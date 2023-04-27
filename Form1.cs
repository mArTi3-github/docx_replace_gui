using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace docx_replace_GUI
{
    public partial class Form1 : Form
    {
        string ResultsPathString = "results";


        public Form1()
        {
            InitializeComponent();
        }

        private void InputDirPathFindButton_Click(object sender, EventArgs e)
        {
            if (InputDirFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                InputDirPathTextBox.Text = InputDirFolderBrowserDialog.SelectedPath;
                WorklogTextBox.Text += "Выбрана входная папка \"" + InputDirFolderBrowserDialog.SelectedPath + "\"\r\n";
            }
        }

        private void MarkersDocFindButton_Click(object sender, EventArgs e)
        {
            if (MarkersDocOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MarkersDocPathTextBox.Text = MarkersDocOpenFileDialog.FileName;
                WorklogTextBox.Text += "Выбран документ с маркерами \"" + MarkersDocOpenFileDialog.FileName + "\"\r\n";
            }
        }

        [STAThread]//Без этого не получается считывать данные из буфера обмена
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, в которых необходимо делать замену");
                return;
            }

            if (MarkersDocPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите документ с маркерами, описывающими данные для замены");
                return;
            }

            if(!Directory.Exists(ResultsPathString))
                Directory.CreateDirectory(ResultsPathString);

            if (Directory.EnumerateFileSystemEntries(ResultsPathString).Any())
            {
                DialogResult dr = MessageBox.Show("Папка для сохранения результатов не пуста, очистить ее перед запуском?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    Directory.Delete(ResultsPathString, true);
                }
                else if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            string inputDir = "";

            if (ReplaceInCopiesCheckBox.Checked)
            {
                DirectoryInfo srcDI = new DirectoryInfo(InputDirPathTextBox.Text);
                DirectoryInfo destDI = new DirectoryInfo(ResultsPathString);
                CopyAll(srcDI, destDI);
                WorklogTextBox.Text += "Входные файлы скопированы в  \"" + destDI.FullName + "\"\r\n";
                inputDir = destDI.FullName;
            }
            else
            {
                inputDir = InputDirPathTextBox.Text;
            }

            string markersFilePath = MarkersDocPathTextBox.Text;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;//!потом можно отключить видимость

            Document markersDocument = word.Documents.Open(markersFilePath);

            Regex excludeTmpDocxFilesReg = new Regex(@"\\~\$");//Regex для исключения из списка временных docx-файлов, имена которых начинаются с "~$"
            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => excludeTmpDocxFilesReg.IsMatch(path) == false)
                                                      .ToArray<string>();
            
            string replacementText;
            string markerText;

            List<string> markersList = new List<string>();
            string curMarkerLabelText = "";
            string curCommentInCurDocText = "";
            Regex markerRegex = new Regex(@"\{\{ \w* \}\}");
            Match match;

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);

                    WorklogTextBox.Text +=  "Обрабатываемый файл:" + curFilePath + "\"\r\n";



                    //Обработка замен по таблице
                    Table markersTable = markersDocument.Tables[1];//!Добавить обработку случая, когда в доке с маркерами нет таблицы
                    foreach (Row row in markersTable.Rows)
                    {
                        markerText = row.Cells[1].Range.Text.TrimEnd('\r', '\a', '\n');

                        //if (useCopyPasteMethodForReplace == true)
                        //{
                        //    row.Cells[2].Range.Select();
                        //    word.Selection.End = word.Selection.End - 1;//Это нужно, чтобы при вставке кусок не вставлялся как ячейка таблицы
                        //    word.Selection.Copy();
                        //    replacementText = "^c";
                        //}
                        //else
                        //{
                        //    replacementText = row.Cells[2].Range.Text.TrimEnd('\r', '\a', '\n');
                        //}

                        replacementText = row.Cells[2].Range.Text.TrimEnd('\r', '\a', '\n');

                        //Замены в теле документа и в колонтитулах
                        foreach (Range rng in curDocument.StoryRanges)
                        {
                            //!Блок кода для составления списка маркеров во всех документах
                            //match = markerRegex.Match(rng.Text);
                            //if (match.Success)
                            //{
                            //    foreach (Capture cap in match.Captures)
                            //    {
                            //        //MessageBox.Show(cap.Value);
                            //        if(!markersList.Contains(cap.Value))
                            //        {
                            //            markersList.Add(cap.Value);
                            //        }
                            //    }
                            //}

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

                        //Замены в теле документа
                        //curDocument.Content.Find.Execute(FindText: markerText,
                        //         ReplaceWith: replacementText,
                        //         MatchCase: false,
                        //         MatchWholeWord: false,
                        //         MatchWildcards: false,
                        //         MatchSoundsLike: false,
                        //         MatchAllWordForms: false,
                        //         //Forward: true,
                        //         //Wrap: WdFindWrap.wdFindContinue,
                        //         //Format: false,
                        //         Replace: WdReplace.wdReplaceAll);  //При вставке происходит применение стиля,
                        //                                            //использованного в документе с маркерами
                        //                                            //(сам стиль берется из документа, в который вставляется текст)

                        //// Замены во всех колонтитулах
                        //// Пройти по всем разделам документа
                        //foreach (Section section in curDocument.Sections)
                        //{
                        //    //Заменить текст в основном тексте документа
                        //    //curDocument.Range(section.Range.Start, section.Range.End).Find.Execute(FindText: markerText, ReplaceWith: replacementText, Replace: WdReplace.wdReplaceAll);

                        //    //Заменить текст в колонтитулах каждого типа
                        //    foreach (HeaderFooter header in section.Headers)
                        //    {
                        //        //Верхний
                        //        header.Range.Find.Execute(FindText: markerText,
                        //                                  ReplaceWith: replacementText,
                        //                                  MatchCase: false,
                        //                                  MatchWholeWord: false,
                        //                                  MatchWildcards: false,
                        //                                  MatchSoundsLike: false,
                        //                                  MatchAllWordForms: false,
                        //                                  //Forward: true,
                        //                                  //Wrap: WdFindWrap.wdFindContinue,
                        //                                  //Format: false,
                        //                                  Replace: WdReplace.wdReplaceAll);
                        //    }

                        //    foreach (HeaderFooter footer in section.Footers)
                        //    {
                        //        //Нижний
                        //        footer.Range.Find.Execute(FindText: markerText,
                        //                                  ReplaceWith: replacementText,
                        //                                  MatchCase: false,
                        //                                  MatchWholeWord: false,
                        //                                  MatchWildcards: false,
                        //                                  MatchSoundsLike: false,
                        //                                  MatchAllWordForms: false,
                        //                                  //Forward: true,
                        //                                  //Wrap: WdFindWrap.wdFindContinue,
                        //                                  //Format: false,
                        //                                  Replace: WdReplace.wdReplaceAll);
                        //    }
                        //}
                    }

                    //обработка замен по комментам

                    foreach (Comment commentInMarkersDoc in markersDocument.Comments)
                    {
                        //таким способом выделяется коммент вместе с текстом
                        //commentInMarkersDoc.Scope.Copy();
                        commentInMarkersDoc.Scope.Select();
                        word.Selection.End += 1;
                        word.Selection.Copy();

                        //commentInMarkersDoc.Scope.Copy();
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

                        for(int i = 1; i <= curDocument.Comments.Count; ++i)
                        {
                            if (curDocument.Comments[i].Range.Text == null)
                                continue;
                            match = markerRegex.Match(curDocument.Comments[i].Range.Text);

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
                                curDocument.Comments[i].Scope.Select();
                                word.Selection.End += 1;
                                word.Selection.Paste();
                                //commentInCurDocument.Scope.Paste();
                                //commentInCurDocument.Scope.Select();
                                //commentInCurDocument.Scope.Start = 0;
                                //commentInCurDocument.Scope.End = 0;
                                //commentInCurDocument.DeleteRecursively();
                                //curDocument.Comments.Add(word.Selection.Range, curMarkerLabelText);
                            }


                        }
                        //foreach (Comment commentInCurDocument in curDocument.Comments)
                        //{
                        //    if(commentInCurDocument.Range.Text.Contains(curMarkerLabelText))//Если коммент в документе для замен содержит маркер из документа с маркерами
                        //    {
                        //        commentInCurDocument.Scope.Select();
                        //        word.Selection.End += 1;
                        //        word.Selection.Paste();
                        //        //commentInCurDocument.Scope.Paste();
                        //        //commentInCurDocument.Scope.Select();
                        //        //commentInCurDocument.Scope.Start = 0;
                        //        //commentInCurDocument.Scope.End = 0;
                        //        //commentInCurDocument.DeleteRecursively();
                        //        //curDocument.Comments.Add(word.Selection.Range, curMarkerLabelText);
                        //    }
                        //}
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
            }
            markersDocument.Close();
            word.Quit();
            MessageBox.Show("Обработка завершена");
            WorklogTextBox.Text += "Обработка завершена" + "\r\n";
        }









        //Static functions:
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
