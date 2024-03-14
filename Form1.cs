using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace docx_replace_GUI
{
    public partial class Form1 : Form
    {
        //Путь для сохранения резульатов задается жестко, чтобы случайно не удалить ничего лишнего
        string BackupPathString = "backup";
        Regex markerRegex;
        string TmpDocxFileMarker = @"\~$";
        int TooManyInputFilesThreshold = 30;
        //Regex excludeTmpDocxFilesReg = new Regex(@"\~$");//Regex для исключения из списка временных docx-файлов, имена которых начинаются с "~$"

        public Form1()
        {
            InitializeComponent();
            markerRegex = new Regex(MarkersFormatTextBox.Text);
        }

        private void InputDirPathFindButton_Click(object sender, EventArgs e)
        {
            var dlg = new FolderPicker();
            if (dlg.ShowDialog(this.Handle) == true && !string.IsNullOrWhiteSpace(dlg.ResultPath))
            {
                InputDirPathTextBox.Text = dlg.ResultPath;
                WorklogTextBox.Text += "Выбрана входная папка \"" + dlg.ResultPath + "\"\r\n";
            }
        }

        private void MarkersDocFindButton_Click(object sender, EventArgs e)
        {
            if (DocOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MarkersDocPathTextBox.Text = DocOpenFileDialog.FileName;
                WorklogTextBox.Text += "Выбран документ с маркерами \"" + DocOpenFileDialog.FileName + "\"\r\n";
            }
        }

        private void TextBlocksDocFindButton_Click(object sender, EventArgs e)
        {
            if (DocOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBlocksDocPathTextBox.Text = DocOpenFileDialog.FileName;
                WorklogTextBox.Text += "Выбран документ с текстовыми блоками \"" + DocOpenFileDialog.FileName + "\"\r\n";
            }
        }

        [STAThread]//Без этого не получается считывать данные из буфера обмена
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if(WordProcessIsRunning())
            {
                DialogResult dr = MessageBox.Show("Программа MS Word запущена, рекомендуется закрыть все документы перед запуском, т.к. программа не сможет выполнить замены" +
                    " в открытых документах. Нажмите \"Отмена\", чтобы отменить запуск программы и закрыть окна Word вручную, или нажмите \"ОК\", чтобы продолжить, " +
                    "несмотря на открытые документы",
                    "Предупреждение", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
                MessageBox.Show(DialogResult.Cancel.ToString());
            }

            //Блок проверки корректности входных данных
            if (InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, в которых необходимо делать замену");
                return;
            }

            if (MarkersDocPathTextBox.Text == "" && TextBlocksDocPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите хотя бы один документ с данными для замены");
                return;
            }
            else if (MarkersDocPathTextBox.Text != "" && !File.Exists(MarkersDocPathTextBox.Text))
            {
                MessageBox.Show("Документ с маркерами не найден");
                return;
            }
            else if (TextBlocksDocPathTextBox.Text != "" && !File.Exists(TextBlocksDocPathTextBox.Text))
            {
                MessageBox.Show("Документ с текстовыми блоками не найден");
                return;
            }

            string inputDir = InputDirPathTextBox.Text;

            if (MakeBackupCheckBox.Checked)
            {
                try
                {
                    if (!Directory.Exists(BackupPathString))
                        Directory.CreateDirectory(BackupPathString);

                    if (Directory.EnumerateFileSystemEntries(BackupPathString).Any())
                    {
                        DialogResult dr = MessageBox.Show("Папка с резервными копиями не пуста, файлы с одинаковыми именами в папке для бекапа при копировании будут заменены, продолжить?", "Предупреждение", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            try
                            {
                                Directory.Delete(BackupPathString, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Не удалось очистить папку с резервными копиями");
                                WorklogLabel.Text += "Не удалось очистить папку с резервными копиями, возникло следующее исключение:\r\n" + ex.Message;
                                return;
                            }

                        }
                        else if (dr == DialogResult.Cancel)
                        {
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось создать папку для резервных копий документов");
                    WorklogTextBox.Text += ex.Message;
                    return;
                }
                DirectoryInfo srcDI = new DirectoryInfo(InputDirPathTextBox.Text);
                DirectoryInfo destDI = new DirectoryInfo(BackupPathString);
                CopyAllDocx(srcDI, destDI);
                WorklogTextBox.Text += "Входные файлы скопированы в  \"" + destDI.FullName + "\"\r\n";
            }

            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => path.Contains(TmpDocxFileMarker) == false)
                                                      .ToArray<string>();

            if (pathsToInputDocuments.Count() > TooManyInputFilesThreshold)
            {
                if (MessageBox.Show($"Во входной папке обнаружено {pathsToInputDocuments.Count()} документов. " +
                    $"Возможно, выбрана неверная входная папка. " +
                    $"Продолжить?", "Внимание", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    WorklogTextBox.Text += "Запуск процесса отменен\r\n";
                    return;
                }
            }
            string markersFilePath = MarkersDocPathTextBox.Text;
            string textBlocksFilePath = TextBlocksDocPathTextBox.Text;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            word.Visible = ShowWordWindowsCheckBox.Checked;

            Document markersDocument = word.Documents.Open(markersFilePath);
            Document textBlocksDocument = word.Documents.Open(textBlocksFilePath);

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);

                    //Включение режима отслеживания изменений в Word перед началом обработки документа по маркерам в таблице
                    if (ReplaceInTrackRevisionsModeChechBox.Checked)
                    {
                        curDocument.TrackRevisions = true;
                    }

                    WorklogTextBox.Text += "Обрабатываемый файл:" + curFilePath + "\"\r\n";

                    //Обработка замен по таблице
                    if (MarkersDocPathTextBox.Text != "")
                    {
                        ReplaceMarkers(curDocument, markersDocument);
                    }
                    //Отключение режима отслеживания изменений в Word после завершения обработки документа
                    if (ReplaceInTrackRevisionsModeChechBox.Checked)
                    {
                        curDocument.TrackRevisions = false;
                    }

                    //обработка замен по комментам
                    if (TextBlocksDocPathTextBox.Text != "")
                    {
                        ReplaceTextBlocks(curDocument, textBlocksDocument, word, markerRegex);
                    }

                    curDocument.Save();
                    curDocument.Close();
                }
                catch (System.Runtime.InteropServices.COMException ex)//исключение происходит, когда файл поврежден либо когда файл является временным, начинающимся с "~$",
                                                                      //такие файлы исключаются через regex, но на всякий случай проверку оставил
                {
                    WorklogTextBox.Text += ex.Message + "\r\n";
                    continue;
                }
                catch (Exception ex)
                {
                    WorklogTextBox.Text += ex.Message + "\r\n";
                    continue;
                }
            }
            if (markersDocument != null)
                markersDocument.Close();
            if (textBlocksDocument != null)
                textBlocksDocument.Close();
            word.Quit();
            WorklogTextBox.Text += "Обработка завершена" + "\r\n";
        }

        private void GetAllMarkersButton_Click(object sender, EventArgs e)
        {
            if (InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, в которых необходимо найти маркеры");
                return;
            }

            string Resultspath = "all_markers.txt";
            if (File.Exists(Resultspath))
            {
                File.Delete(Resultspath);
            }
            List<string> markers = GetAllMarkersInInputDocs(InputDirPathTextBox.Text, markerRegex);
            if (markers.Count > 0)
            {
                File.WriteAllLines(Resultspath, markers.ToArray());
                WorklogTextBox.Text += "Список маркеров сохранен в \"" + Resultspath + "\r\n";
            }
            else
                WorklogTextBox.Text += "В документах не найдено ни одного маркера походящего формата";
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (WordProcessIsRunning())
            {
                DialogResult dr = MessageBox.Show("Программа MS Word запущена, рекомендуется закрыть все документы перед запуском, т.к. программа не сможет выполнить замены" +
                    " в открытых документах. Нажмите \"Отмена\", чтобы отменить запуск программы и закрыть окна Word вручную, или нажмите \"ОК\", чтобы продолжить, " +
                    "несмотря на открытые документы",
                    "Предупреждение", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
                MessageBox.Show(DialogResult.Cancel.ToString());
            }

            if (InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, которые необходимо проверить");
                return;
            }
            if (!Directory.Exists(InputDirPathTextBox.Text))
            {
                MessageBox.Show("Не удалось найти указанную входную папку");
                return;
            }

            string InputDir = InputDirPathTextBox.Text;

            string[] PathsToInputDocuments = Directory.GetFiles(InputDir, "*.docx", SearchOption.AllDirectories)
                                          .Where(path => path.Contains(TmpDocxFileMarker) == false)
                                          .ToArray<string>();

            if (PathsToInputDocuments.Count() > TooManyInputFilesThreshold)
            {
                if (MessageBox.Show($"Во входной папке обнаружено {PathsToInputDocuments.Count()} документов. " +
                    $"Возможно, выбрана неверная входная папка. " +
                    $"Продолжить?", "Внимание", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    WorklogTextBox.Text += "Запуск процесса отменен\r\n";
                    return;
                }
            }

            WorklogTextBox.Text += $"Проверка начата" + "\r\n";

            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();
            Word.Visible = ShowWordWindowsCheckBox.Checked;
            Document CurDoc;

            int CommentsCount, MarkersCount, RevisionsCount;
            bool CorruptedLinksFound, HighlightsFound;


            DirectoryInfo DI = new DirectoryInfo(InputDirPathTextBox.Text);
            foreach (string CurFilePath in PathsToInputDocuments)
            {
                try
                {
                    CurDoc = Word.Documents.Open(CurFilePath);

                    CorruptedLinksFound = false;
                    HighlightsFound = false;

                    CommentsCount = 0;
                    MarkersCount = 0;
                    RevisionsCount = 0;

                    if (CheckCorruptedLinksCheckBox.Checked)
                        CurDoc.Fields.Update();
                    foreach (Range rng in CurDoc.StoryRanges)
                    {
                        if (CheckCorruptedLinksCheckBox.Checked && !CorruptedLinksFound)
                        {
                            CorruptedLinksFound = rng.Find.Execute(FindText: "Ошибка! Источник ссылки не найден",
                            MatchCase: true,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: false,
                            MatchAllWordForms: false
                            //Forward: true,
                            //Wrap: WdFindWrap.wdFindContinue,
                            //Format: false,
                            //Replace: WdReplace.wdReplaceAll
                            );
                        }
                        if (CheckHighlightsCheckBox.Checked && !HighlightsFound)
                        {
                            rng.Find.ClearFormatting();
                            rng.Find.Highlight = 1;
                            HighlightsFound = rng.Find.Execute(FindText: "",
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: false,
                            MatchAllWordForms: false,
                            Format: true
                            //Replace: WdReplace.wdReplaceAll,
                            //ReplaceWith: "ZAZAZAZAZAZAZAZ121212"
                            //Forward: true,
                            //Wrap: WdFindWrap.wdFindContinue,
                            //Format: false,
                            //Replace: WdReplace.wdReplaceAll
                            );

                            //Debug
                            //if(HighlightsFound)
                            //{
                            //    MessageBox.Show(rng.Text);
                            //}
                        }
                        if (CheckMarkersCheckBox.Checked)
                        {
                            foreach (Match match in markerRegex.Matches(rng.Text))
                            {
                                ++MarkersCount;
                            }
                        }
                    }

                    if (CheckCommentsCheckBox.Checked)
                    {
                        CommentsCount = CurDoc.Comments.Count;
                    }

                    if (CheckRevisionsCheckBox.Checked)
                    {
                        RevisionsCount = CurDoc.Revisions.Count;
                    }



                    if (CorruptedLinksFound || CommentsCount > 0 || HighlightsFound || MarkersCount > 0 || RevisionsCount > 0)
                    {
                        WorklogTextBox.Text += $"В файле \"{CurFilePath}\" обнаружены следующие проблемы:\r\n";

                        if (CorruptedLinksFound)
                        {
                            WorklogTextBox.Text += $"- ошибки в ссылках (1 или больше)\r\n";
                        }

                        if (CommentsCount > 0)
                        {
                            WorklogTextBox.Text += $"- комментарии: {CommentsCount}\r\n";
                        }

                        if (HighlightsFound)
                        {
                            WorklogTextBox.Text += $"- выделения цветом (1 или больше)\r\n";
                        }

                        if (MarkersCount > 0)
                        {
                            WorklogTextBox.Text += $"- маркеры в тексте: {MarkersCount}\r\n";
                        }

                        if (RevisionsCount > 0)
                        {
                            WorklogTextBox.Text += $"- исправления в тексте: {RevisionsCount}\r\n";
                        }

                    }
                    else
                    {
                        WorklogTextBox.Text += $"В файле \"{CurFilePath}\" проблем не обнаружено.\r\n";
                    }

                    CurDoc.Close(SaveChanges: false);
                }
                catch (Exception ex)
                {
                    WorklogTextBox.Text += CurFilePath + "\r\n" + ex.Message + "\r\n";
                    continue;
                }
            }
            Word.Quit();
            WorklogTextBox.Text += $"Проверка завершена" + "\r\n";
        }
        private void UpdateMarkerFormatRegexButton_Click(object sender, EventArgs e)
        {
            try
            {
                markerRegex = new Regex(MarkersFormatTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FinalizeButton_Click(object sender, EventArgs e)
        {
            if (!RemoveHighLightsCheckBox.Checked && !RemoveCommentsCheckBox.Checked && !AcceptRevisionsCheckBox.Checked)
            {
                MessageBox.Show("Выберите хотя бы одну процедуру для финализации");
                return;
            }

            if (InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, которые необходимо финализировать");
                return;
            }
            if (!Directory.Exists(InputDirPathTextBox.Text))
            {
                MessageBox.Show("Не удалось найти указанную входную папку");
                return;
            }

            string InputDir = InputDirPathTextBox.Text;

            int CommentsCounter = 0;
            int RevisionsCounter = 0;

            string[] PathsToInputDocuments = Directory.GetFiles(InputDir, "*.docx", SearchOption.AllDirectories)
                                          .Where(path => path.Contains(TmpDocxFileMarker) == false)
                                          .ToArray<string>();

            if (PathsToInputDocuments.Count() > TooManyInputFilesThreshold)
            {
                if (MessageBox.Show($"Во входной папке обнаружено {PathsToInputDocuments.Count()} документов. " +
                    $"Возможно, выбрана неверная входная папка. " +
                    $"Продолжить?", "Внимание", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    WorklogTextBox.Text += "Запуск процесса отменен\r\n";
                    return;
                }
            }

            WorklogTextBox.Text += $"Финализация начата" + "\r\n";

            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();
            Word.Visible = ShowWordWindowsCheckBox.Checked;
            Document CurDoc;

            foreach (string CurFilePath in PathsToInputDocuments)
            {
                try
                {
                    CurDoc = Word.Documents.Open(CurFilePath);

                    WorklogTextBox.Text += $"В документе {CurFilePath} проведены следующие операции:\r\n";
                    if (RemoveHighLightsCheckBox.Checked)
                    {
                        foreach (Range rng in CurDoc.StoryRanges)
                        {
                            rng.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                        }
                        WorklogTextBox.Text += $"- удалены все выделения цветом (если они были в документе)\r\n";
                    }

                    if (RemoveCommentsCheckBox.Checked)
                    {
                        if (CurDoc.Comments.Count > 0)
                        {
                            CommentsCounter = CurDoc.Comments.Count;
                            foreach (Comment comment in CurDoc.Comments)
                            {
                                comment.DeleteRecursively();
                            }
                            WorklogTextBox.Text += $"- удалены все комментарии ({CommentsCounter} шт.)\r\n";
                        }
                        else
                        {
                            WorklogTextBox.Text += $"- комментарии не обнаружены\r\n";
                        }
                    }

                    if (AcceptRevisionsCheckBox.Checked)
                    {
                        RevisionsCounter = CurDoc.Revisions.Count;
                        
                        if (RevisionsCounter > 0)
                        {
                            CurDoc.AcceptAllRevisions();
                            WorklogTextBox.Text += $"- приняты все исправления ({RevisionsCounter} шт.)\r\n";
                        }
                        CurDoc.TrackRevisions = false;
                    }

                    CurDoc.Close(SaveChanges: true);
                }
                catch (Exception ex)
                {
                    WorklogTextBox.Text += CurFilePath + "\r\n" + ex.Message + "\r\n";
                    continue;
                }
            }
            Word.Quit();
            WorklogTextBox.Text += $"Финализация завершена" + "\r\n";
        }














        //Функции обработки документов
        public void ReplaceMarkers(Document inputDoc, Document markersDoc)
        {
            string replacementText;
            string markerText;
            Table markersTable = markersDoc.Tables[1];//!Добавить обработку ошибки, когда в доке с маркерами нет таблицы

            foreach (Row row in markersTable.Rows)
            {
                markerText = row.Cells[1].Range.Text.TrimEnd('\r', '\a', '\n');

                replacementText = row.Cells[2].Range.Text.TrimEnd('\r', '\a', '\n');


                //Замены в теле документа и в колонтитулах
                foreach (Range rng in inputDoc.StoryRanges)
                {
                    rng.Find.Execute(FindText: markerText,
                                     ReplaceWith: replacementText,
                                     MatchCase: false,
                                     MatchWholeWord: false,
                                     MatchWildcards: false,
                                     MatchSoundsLike: false,
                                     MatchAllWordForms: false,
                                     //Forward: true,
                                     //Wrap: WdFindWrap.wdFindContinue,
                                     //Format: false,
                                     Replace: WdReplace.wdReplaceAll);
                }

                //inputDoc.Application.Selection.Find.ClearFormatting();

                //inputDoc.Application.Selection.Find.Execute(FindText: markerText,
                //         ReplaceWith: replacementText,
                //         MatchCase: false,
                //         MatchWholeWord: false,
                //         MatchWildcards: false,
                //         MatchSoundsLike: false,
                //         MatchAllWordForms: false,
                //         //Forward: true,
                //         //Wrap: WdFindWrap.wdFindContinue,
                //         //Format: false,
                //         Replace: WdReplace.wdReplaceAll);
            }
        }

        public void ReplaceTextBlocks(Document inputDoc, Document textBlocksDoc, Microsoft.Office.Interop.Word.Application word, Regex markerRegex)
        {
            string curMarkerLabelText;
            string curCommentInCurDocText;
            Match match;

            foreach (Comment commentInMarkersDoc in textBlocksDoc.Comments)
            {
                //таким способом выделяется коммент вместе с текстом
                commentInMarkersDoc.Scope.Select();
                word.Selection.End += 1;
                word.Selection.Copy();

                if (commentInMarkersDoc.Range.Text == null)
                    continue;

                match = markerRegex.Match(commentInMarkersDoc.Range.Text);
                if (match.Success)
                {
                    curMarkerLabelText = match.Value;
                }
                else
                {
                    continue;
                }
                //curMarkerLabelText = commentInMarkersDoc.Range.Text.TrimEnd('\r', '\a', '\n');

                for (int i = 1; i <= inputDoc.Comments.Count; ++i)
                {
                    if (inputDoc.Comments[i].Range.Text == null)
                        continue;
                    match = markerRegex.Match(inputDoc.Comments[i].Range.Text);

                    //MessageBox.Show(curDocument.Comments[i].Range.Text);
                    if (match.Success)
                    {
                        curCommentInCurDocText = match.Value;
                    }
                    else
                    {
                        continue;
                    }


                    //if (curDocument.Comments[i].Range.Text.Contains(curMarkerLabelText))//Если коммент в документе для замен содержит маркер из документа с маркерами
                    if (curMarkerLabelText == curCommentInCurDocText)//Если коммент в документе для замен содержит маркер из документа с маркерами
                    {
                        inputDoc.Comments[i].Scope.Select();
                        word.Selection.End += 1;
                        word.Selection.Paste();
                    }
                }
            }
        }

        public List<string> GetAllMarkersInInputDocs(string inputDir, Regex markerRegex)
        {
            List<string> markersInDocsList = new List<string>();
            //Match match;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            word.Visible = ShowWordWindowsCheckBox.Checked;

            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => path.Contains(TmpDocxFileMarker) == false)
                                                      .ToArray<string>();

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);
                    foreach (Range rng in curDocument.StoryRanges)
                    {
                        string tmp = rng.Text;
                        foreach (Match match in markerRegex.Matches(rng.Text))
                        {
                            if (!markersInDocsList.Contains(match.Value))
                            {
                                markersInDocsList.Add(match.Value);
                            }
                        }
                    }
                    curDocument.Close();
                }
                catch (Exception ex)
                {
                    WorklogTextBox.Text += ex.Message + "\r\n";
                    continue;
                }
            }
            word.Quit();
            return markersInDocsList;
        }

        public void CopyAllDocx(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles("*.docx", SearchOption.AllDirectories)
                                                      .Where(path => path.FullName.Contains(TmpDocxFileMarker) == false))
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAllDocx(diSourceSubDir, nextTargetSubDir);
            }
        }


        //Прочие функции
        public bool WordProcessIsRunning()
        {
            if (Process.GetProcessesByName("WINWORD").Count() > 0)
                return true;
            else
                return false;
        }
    }
}
