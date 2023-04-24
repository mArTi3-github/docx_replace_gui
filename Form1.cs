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
        public Form1()
        {
            InitializeComponent();
            ReplaceMethodComboBox.SelectedIndex = 0;
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

            //Планы:
            //1) Сделать readme (указать, что перед запуском лучше закрыть все окна Word)
            //2) перенести в GUI (inputDir и markersFilePath - в OpenFileDialog)
            //3) добавить составление списка всех маркеров (или проще через Searcher?)
            //4) Делать замены на копии (копировать папку inputDir в "results")
            string inputDir = "";

            if (ReplaceInCopiesCheckBox.Checked)
            {
                DirectoryInfo srcDI = new DirectoryInfo(InputDirPathTextBox.Text);
                DirectoryInfo destDI = new DirectoryInfo("results");
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
            Table markersTable = markersDocument.Tables[1];

            Regex excludeTmpDocxFilesReg = new Regex(@"\\~\$");//Regex для исключения из списка временных docx-файлов, имена которых начинаются с "~$"
            string[] pathsToInputDocuments = Directory.GetFiles(inputDir, "*.docx", SearchOption.AllDirectories)
                                                      .Where(path => excludeTmpDocxFilesReg.IsMatch(path) == false)
                                                      .ToArray<string>();
            
            string replacementText;
            string markerText;

            bool useCopyPasteMethodForReplace = false;
            if(ReplaceMethodComboBox.SelectedIndex == 1)
            {
                useCopyPasteMethodForReplace = true;
            }

            foreach (string curFilePath in pathsToInputDocuments)
            {
                try
                {
                    Document curDocument = word.Documents.Open(curFilePath);

                    WorklogTextBox.Text +=  "Обрабатываемый файл:" + curFilePath + "\"\r\n";
                    foreach (Row row in markersTable.Rows)
                    {
                        markerText = row.Cells[1].Range.Text.TrimEnd('\r', '\a', '\n');

                        if (useCopyPasteMethodForReplace == true)
                        {
                            row.Cells[2].Range.Select();
                            word.Selection.End = word.Selection.End - 1;//Это нужно, чтобы при вставке кусок не вставлялся как ячейка таблицы
                            word.Selection.Copy();
                            replacementText = "^c";
                        }
                        else
                        {
                            replacementText = row.Cells[2].Range.Text.TrimEnd('\r', '\a', '\n');
                        }

                        curDocument.Content.Find.Execute(FindText: markerText,
                                                         ReplaceWith: replacementText,
                                                         MatchCase: false,
                                                         MatchWholeWord: false,
                                                         MatchWildcards: false,
                                                         MatchSoundsLike: false,
                                                         MatchAllWordForms: false,
                                                         //Forward: true,
                                                         //Wrap: WdFindWrap.wdFindContinue,
                                                         //Format: false,
                                                         Replace: WdReplace.wdReplaceAll); ;//При вставке происходит применение стиля,
                                                                                            //использованного в документе с маркерами
                                                                                            //(сам стиль берется из документа, в который вставляется текст)
                    }
                    curDocument.Save();
                    curDocument.Close();
                }
                catch (System.Runtime.InteropServices.COMException ex)//исключение происходит, когда файл поврежден либо когда файл является временным, начинающимся с "~$",
                                                                      //такие файлы исключаются через regex, но на всякий случай проверку оставил
                {
                    WorklogTextBox.Text += "" + ex.Message;
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
