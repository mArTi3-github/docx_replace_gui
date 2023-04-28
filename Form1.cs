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
using Microsoft.Office.Interop.Word;

namespace docx_replace_GUI
{
    public partial class Form1 : Form
    {
        //Путь для сохранения резульатов задается жестко, чтобы случайно не удалить ничего лишнего
        string ResultsPathString = "results";
        Regex markerRegex = new Regex(@"\{\{ \w* \}\}");
        Regex excludeTmpDocxFilesReg = new Regex(@"\\~\$");//Regex для исключения из списка временных docx-файлов, имена которых начинаются с "~$"

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
        private void StartButton_Click(object sender, EventArgs e)
        {

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
            else if (!File.Exists(MarkersDocPathTextBox.Text))
            {
                MessageBox.Show("Документ с маркерами не найден");
                return;
            }
            else if (!File.Exists(TextBlocksDocPathTextBox.Text))
            {
                MessageBox.Show("Документ с текстовыми блоками не найден");
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
            string textBlocksFilePath = TextBlocksDocPathTextBox.Text;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;//!потом можно отключить видимость

            Document markersDocument = word.Documents.Open(markersFilePath);
            Document textBlocksDocument = word.Documents.Open(textBlocksFilePath);

            
            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => excludeTmpDocxFilesReg.IsMatch(path) == false)
                                                      .ToArray<string>();


            //Планы на будущее
            //List<KeyValuePair<string,string>> markers = new List<KeyValuePair<string,string>>();


            

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);

                    WorklogTextBox.Text +=  "Обрабатываемый файл:" + curFilePath + "\"\r\n";

                    //Обработка замен по таблице
                    if (MarkersDocPathTextBox.Text != "")
                    {
                        ReplaceMarkers(curDocument, markersDocument);
                    }

                    //обработка замен по комментам
                    if(TextBlocksDocPathTextBox.Text != "")
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
            markersDocument.Close();
            textBlocksDocument.Close();
            word.Quit();
            WorklogTextBox.Text += "Обработка завершена" + "\r\n";
        }

        private void GetAllMarkersButton_Click(object sender, EventArgs e)
        {
            if(InputDirPathTextBox.Text == "")
            {
                MessageBox.Show("Выберите папку с документами, в которых необходимо найти маркеры");
                return;
            }

            string Resultspath = ResultsPathString + @"\all_markers.txt";
            if (File.Exists(Resultspath))
            {
                File.Delete(Resultspath);
            }
            List<string> markers = GetAllMarkersInInputDocs(InputDirPathTextBox.Text, markerRegex, excludeTmpDocxFilesReg);
            if (markers.Count > 0) 
            {
                File.WriteAllLines(Resultspath, markers.ToArray());
                WorklogTextBox.Text += "Список маркеров сохранен в \"" + Resultspath + "\r\n";
            }
            else
                WorklogTextBox.Text += "В документах не найдено ни одного маркера походящего формата";
        }







        //Static functions:
        public static void ReplaceMarkers(Document inputDoc, Document markersDoc)
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
            }
        }

        public static void ReplaceTextBlocks(Document inputDoc, Document textBlocksDoc, Microsoft.Office.Interop.Word.Application word, Regex markerRegex)
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

        public List<string> GetAllMarkersInInputDocs(string inputDir, Regex markerRegex, Regex excludeTmpDocxFilesReg)
        {
            List<string> markersInDocsList = new List<string>();
            //Match match;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;//!потом можно отключить видимость


            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => excludeTmpDocxFilesReg.IsMatch(path) == false)
                                                      .ToArray<string>();

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);
                    foreach (Range rng in curDocument.StoryRanges)
                    {
                        foreach(Match match in markerRegex.Matches(rng.Text))
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
