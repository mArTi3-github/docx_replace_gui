namespace docx_replace_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputDirLabel = new System.Windows.Forms.Label();
            this.MarkersDocPathLabel = new System.Windows.Forms.Label();
            this.InputDirPathTextBox = new System.Windows.Forms.TextBox();
            this.MarkersDocPathTextBox = new System.Windows.Forms.TextBox();
            this.InputDirPathFindButton = new System.Windows.Forms.Button();
            this.MarkersDocFindButton = new System.Windows.Forms.Button();
            this.WorklogTextBox = new System.Windows.Forms.TextBox();
            this.StratButton = new System.Windows.Forms.Button();
            this.WorklogLabel = new System.Windows.Forms.Label();
            this.DocOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MakeBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.TextBlocksPathLabel = new System.Windows.Forms.Label();
            this.TextBlocksDocPathTextBox = new System.Windows.Forms.TextBox();
            this.TextBlocksDocFindButton = new System.Windows.Forms.Button();
            this.GetAllMarkersButton = new System.Windows.Forms.Button();
            this.ReplaceInTrackRevisionsModeChechBox = new System.Windows.Forms.CheckBox();
            this.ShowWordWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.tabPageCheck = new System.Windows.Forms.TabPage();
            this.CheckMarkersCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckHighlightsCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckCorruptedLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.StartCheckButton = new System.Windows.Forms.Button();
            this.tabPageFinalization = new System.Windows.Forms.TabPage();
            this.MarkersFormatLabel = new System.Windows.Forms.Label();
            this.MarkersFormatTextBox = new System.Windows.Forms.TextBox();
            this.UpdateMarkerFormatRegexButton = new System.Windows.Forms.Button();
            this.RemoveHighLightsCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.FinalizeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.tabPageCheck.SuspendLayout();
            this.tabPageFinalization.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputDirLabel
            // 
            this.InputDirLabel.AutoSize = true;
            this.InputDirLabel.Location = new System.Drawing.Point(12, 9);
            this.InputDirLabel.Name = "InputDirLabel";
            this.InputDirLabel.Size = new System.Drawing.Size(196, 13);
            this.InputDirLabel.TabIndex = 0;
            this.InputDirLabel.Text = "Папка с документами для обработки";
            // 
            // MarkersDocPathLabel
            // 
            this.MarkersDocPathLabel.AutoSize = true;
            this.MarkersDocPathLabel.Location = new System.Drawing.Point(22, 19);
            this.MarkersDocPathLabel.Name = "MarkersDocPathLabel";
            this.MarkersDocPathLabel.Size = new System.Drawing.Size(166, 13);
            this.MarkersDocPathLabel.TabIndex = 1;
            this.MarkersDocPathLabel.Text = "Путь к документу с маркерами";
            // 
            // InputDirPathTextBox
            // 
            this.InputDirPathTextBox.Location = new System.Drawing.Point(214, 6);
            this.InputDirPathTextBox.Name = "InputDirPathTextBox";
            this.InputDirPathTextBox.Size = new System.Drawing.Size(455, 20);
            this.InputDirPathTextBox.TabIndex = 2;
            // 
            // MarkersDocPathTextBox
            // 
            this.MarkersDocPathTextBox.Location = new System.Drawing.Point(224, 16);
            this.MarkersDocPathTextBox.Name = "MarkersDocPathTextBox";
            this.MarkersDocPathTextBox.Size = new System.Drawing.Size(455, 20);
            this.MarkersDocPathTextBox.TabIndex = 3;
            // 
            // InputDirPathFindButton
            // 
            this.InputDirPathFindButton.Location = new System.Drawing.Point(675, 4);
            this.InputDirPathFindButton.Name = "InputDirPathFindButton";
            this.InputDirPathFindButton.Size = new System.Drawing.Size(75, 23);
            this.InputDirPathFindButton.TabIndex = 4;
            this.InputDirPathFindButton.Text = "...";
            this.InputDirPathFindButton.UseVisualStyleBackColor = true;
            this.InputDirPathFindButton.Click += new System.EventHandler(this.InputDirPathFindButton_Click);
            // 
            // MarkersDocFindButton
            // 
            this.MarkersDocFindButton.Location = new System.Drawing.Point(685, 14);
            this.MarkersDocFindButton.Name = "MarkersDocFindButton";
            this.MarkersDocFindButton.Size = new System.Drawing.Size(75, 23);
            this.MarkersDocFindButton.TabIndex = 5;
            this.MarkersDocFindButton.Text = "...";
            this.MarkersDocFindButton.UseVisualStyleBackColor = true;
            this.MarkersDocFindButton.Click += new System.EventHandler(this.MarkersDocFindButton_Click);
            // 
            // WorklogTextBox
            // 
            this.WorklogTextBox.Location = new System.Drawing.Point(12, 338);
            this.WorklogTextBox.Multiline = true;
            this.WorklogTextBox.Name = "WorklogTextBox";
            this.WorklogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorklogTextBox.Size = new System.Drawing.Size(788, 221);
            this.WorklogTextBox.TabIndex = 6;
            // 
            // StratButton
            // 
            this.StratButton.Location = new System.Drawing.Point(347, 160);
            this.StratButton.Name = "StratButton";
            this.StratButton.Size = new System.Drawing.Size(75, 23);
            this.StratButton.TabIndex = 7;
            this.StratButton.Text = "Заменить";
            this.StratButton.UseVisualStyleBackColor = true;
            this.StratButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // WorklogLabel
            // 
            this.WorklogLabel.AutoSize = true;
            this.WorklogLabel.Location = new System.Drawing.Point(13, 322);
            this.WorklogLabel.Name = "WorklogLabel";
            this.WorklogLabel.Size = new System.Drawing.Size(69, 13);
            this.WorklogLabel.TabIndex = 8;
            this.WorklogLabel.Text = "Лог работы:";
            // 
            // DocOpenFileDialog
            // 
            this.DocOpenFileDialog.Filter = "Документы в формате docx|*.docx";
            // 
            // MakeBackupCheckBox
            // 
            this.MakeBackupCheckBox.AutoSize = true;
            this.MakeBackupCheckBox.Checked = true;
            this.MakeBackupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MakeBackupCheckBox.Location = new System.Drawing.Point(25, 91);
            this.MakeBackupCheckBox.Name = "MakeBackupCheckBox";
            this.MakeBackupCheckBox.Size = new System.Drawing.Size(140, 17);
            this.MakeBackupCheckBox.TabIndex = 9;
            this.MakeBackupCheckBox.Text = "Backup входной папки";
            this.MakeBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // TextBlocksPathLabel
            // 
            this.TextBlocksPathLabel.AutoSize = true;
            this.TextBlocksPathLabel.Location = new System.Drawing.Point(22, 58);
            this.TextBlocksPathLabel.Name = "TextBlocksPathLabel";
            this.TextBlocksPathLabel.Size = new System.Drawing.Size(189, 13);
            this.TextBlocksPathLabel.TabIndex = 10;
            this.TextBlocksPathLabel.Text = "Путь к документу с блоками текста";
            // 
            // TextBlocksDocPathTextBox
            // 
            this.TextBlocksDocPathTextBox.Location = new System.Drawing.Point(224, 58);
            this.TextBlocksDocPathTextBox.Name = "TextBlocksDocPathTextBox";
            this.TextBlocksDocPathTextBox.Size = new System.Drawing.Size(455, 20);
            this.TextBlocksDocPathTextBox.TabIndex = 11;
            // 
            // TextBlocksDocFindButton
            // 
            this.TextBlocksDocFindButton.Location = new System.Drawing.Point(685, 58);
            this.TextBlocksDocFindButton.Name = "TextBlocksDocFindButton";
            this.TextBlocksDocFindButton.Size = new System.Drawing.Size(75, 23);
            this.TextBlocksDocFindButton.TabIndex = 12;
            this.TextBlocksDocFindButton.Text = "...";
            this.TextBlocksDocFindButton.UseVisualStyleBackColor = true;
            this.TextBlocksDocFindButton.Click += new System.EventHandler(this.TextBlocksDocFindButton_Click);
            // 
            // GetAllMarkersButton
            // 
            this.GetAllMarkersButton.Location = new System.Drawing.Point(575, 160);
            this.GetAllMarkersButton.Name = "GetAllMarkersButton";
            this.GetAllMarkersButton.Size = new System.Drawing.Size(199, 23);
            this.GetAllMarkersButton.TabIndex = 13;
            this.GetAllMarkersButton.Text = "Найти все маркеры в документах";
            this.GetAllMarkersButton.UseVisualStyleBackColor = true;
            this.GetAllMarkersButton.Click += new System.EventHandler(this.GetAllMarkersButton_Click);
            // 
            // ReplaceInTrackRevisionsModeChechBox
            // 
            this.ReplaceInTrackRevisionsModeChechBox.AutoSize = true;
            this.ReplaceInTrackRevisionsModeChechBox.Location = new System.Drawing.Point(25, 114);
            this.ReplaceInTrackRevisionsModeChechBox.Name = "ReplaceInTrackRevisionsModeChechBox";
            this.ReplaceInTrackRevisionsModeChechBox.Size = new System.Drawing.Size(368, 17);
            this.ReplaceInTrackRevisionsModeChechBox.TabIndex = 14;
            this.ReplaceInTrackRevisionsModeChechBox.Text = "Заменять в режиме исправлений (только для маркеров в таблице)";
            this.ReplaceInTrackRevisionsModeChechBox.UseVisualStyleBackColor = true;
            // 
            // ShowWordWindowsCheckBox
            // 
            this.ShowWordWindowsCheckBox.AutoSize = true;
            this.ShowWordWindowsCheckBox.Checked = true;
            this.ShowWordWindowsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowWordWindowsCheckBox.Location = new System.Drawing.Point(15, 78);
            this.ShowWordWindowsCheckBox.Name = "ShowWordWindowsCheckBox";
            this.ShowWordWindowsCheckBox.Size = new System.Drawing.Size(144, 17);
            this.ShowWordWindowsCheckBox.TabIndex = 15;
            this.ShowWordWindowsCheckBox.Text = "Отображать окна Word";
            this.ShowWordWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageReplace);
            this.tabControl1.Controls.Add(this.tabPageCheck);
            this.tabControl1.Controls.Add(this.tabPageFinalization);
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 218);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.MarkersDocPathTextBox);
            this.tabPageReplace.Controls.Add(this.MarkersDocPathLabel);
            this.tabPageReplace.Controls.Add(this.ReplaceInTrackRevisionsModeChechBox);
            this.tabPageReplace.Controls.Add(this.MarkersDocFindButton);
            this.tabPageReplace.Controls.Add(this.GetAllMarkersButton);
            this.tabPageReplace.Controls.Add(this.StratButton);
            this.tabPageReplace.Controls.Add(this.TextBlocksDocFindButton);
            this.tabPageReplace.Controls.Add(this.MakeBackupCheckBox);
            this.tabPageReplace.Controls.Add(this.TextBlocksDocPathTextBox);
            this.tabPageReplace.Controls.Add(this.TextBlocksPathLabel);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 22);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReplace.Size = new System.Drawing.Size(780, 192);
            this.tabPageReplace.TabIndex = 0;
            this.tabPageReplace.Text = "Замена";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.Controls.Add(this.CheckMarkersCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckHighlightsCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckCommentsCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckCorruptedLinksCheckBox);
            this.tabPageCheck.Controls.Add(this.StartCheckButton);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheck.Size = new System.Drawing.Size(780, 192);
            this.tabPageCheck.TabIndex = 1;
            this.tabPageCheck.Text = "Проверка";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // CheckMarkersCheckBox
            // 
            this.CheckMarkersCheckBox.AutoSize = true;
            this.CheckMarkersCheckBox.Checked = true;
            this.CheckMarkersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckMarkersCheckBox.Location = new System.Drawing.Point(6, 75);
            this.CheckMarkersCheckBox.Name = "CheckMarkersCheckBox";
            this.CheckMarkersCheckBox.Size = new System.Drawing.Size(73, 17);
            this.CheckMarkersCheckBox.TabIndex = 4;
            this.CheckMarkersCheckBox.Text = "Маркеры";
            this.CheckMarkersCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckHighlightsCheckBox
            // 
            this.CheckHighlightsCheckBox.AutoSize = true;
            this.CheckHighlightsCheckBox.Checked = true;
            this.CheckHighlightsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckHighlightsCheckBox.Location = new System.Drawing.Point(6, 52);
            this.CheckHighlightsCheckBox.Name = "CheckHighlightsCheckBox";
            this.CheckHighlightsCheckBox.Size = new System.Drawing.Size(123, 17);
            this.CheckHighlightsCheckBox.TabIndex = 3;
            this.CheckHighlightsCheckBox.Text = "Выделения цветом";
            this.CheckHighlightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckCommentsCheckBox
            // 
            this.CheckCommentsCheckBox.AutoSize = true;
            this.CheckCommentsCheckBox.Checked = true;
            this.CheckCommentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCommentsCheckBox.Location = new System.Drawing.Point(6, 29);
            this.CheckCommentsCheckBox.Name = "CheckCommentsCheckBox";
            this.CheckCommentsCheckBox.Size = new System.Drawing.Size(96, 17);
            this.CheckCommentsCheckBox.TabIndex = 2;
            this.CheckCommentsCheckBox.Text = "Комментарии";
            this.CheckCommentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckCorruptedLinksCheckBox
            // 
            this.CheckCorruptedLinksCheckBox.AutoSize = true;
            this.CheckCorruptedLinksCheckBox.Checked = true;
            this.CheckCorruptedLinksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCorruptedLinksCheckBox.Location = new System.Drawing.Point(6, 6);
            this.CheckCorruptedLinksCheckBox.Name = "CheckCorruptedLinksCheckBox";
            this.CheckCorruptedLinksCheckBox.Size = new System.Drawing.Size(121, 17);
            this.CheckCorruptedLinksCheckBox.TabIndex = 1;
            this.CheckCorruptedLinksCheckBox.Text = "Ошибки в ссылках";
            this.CheckCorruptedLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartCheckButton
            // 
            this.StartCheckButton.Location = new System.Drawing.Point(352, 163);
            this.StartCheckButton.Name = "StartCheckButton";
            this.StartCheckButton.Size = new System.Drawing.Size(75, 23);
            this.StartCheckButton.TabIndex = 0;
            this.StartCheckButton.Text = "Проверить";
            this.StartCheckButton.UseVisualStyleBackColor = true;
            this.StartCheckButton.Click += new System.EventHandler(this.StartCheckButton_Click);
            // 
            // tabPageFinalization
            // 
            this.tabPageFinalization.Controls.Add(this.FinalizeButton);
            this.tabPageFinalization.Controls.Add(this.RemoveCommentsCheckBox);
            this.tabPageFinalization.Controls.Add(this.RemoveHighLightsCheckBox);
            this.tabPageFinalization.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinalization.Name = "tabPageFinalization";
            this.tabPageFinalization.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinalization.Size = new System.Drawing.Size(780, 192);
            this.tabPageFinalization.TabIndex = 2;
            this.tabPageFinalization.Text = "Финализация";
            this.tabPageFinalization.UseVisualStyleBackColor = true;
            // 
            // MarkersFormatLabel
            // 
            this.MarkersFormatLabel.AutoSize = true;
            this.MarkersFormatLabel.Location = new System.Drawing.Point(13, 40);
            this.MarkersFormatLabel.Name = "MarkersFormatLabel";
            this.MarkersFormatLabel.Size = new System.Drawing.Size(105, 13);
            this.MarkersFormatLabel.TabIndex = 17;
            this.MarkersFormatLabel.Text = "Формат маркеров:";
            // 
            // MarkersFormatTextBox
            // 
            this.MarkersFormatTextBox.Location = new System.Drawing.Point(214, 40);
            this.MarkersFormatTextBox.Name = "MarkersFormatTextBox";
            this.MarkersFormatTextBox.Size = new System.Drawing.Size(455, 20);
            this.MarkersFormatTextBox.TabIndex = 18;
            this.MarkersFormatTextBox.Text = "\\{\\{ \\w* \\}\\}";
            // 
            // UpdateMarkerFormatRegexButton
            // 
            this.UpdateMarkerFormatRegexButton.Location = new System.Drawing.Point(675, 40);
            this.UpdateMarkerFormatRegexButton.Name = "UpdateMarkerFormatRegexButton";
            this.UpdateMarkerFormatRegexButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateMarkerFormatRegexButton.TabIndex = 19;
            this.UpdateMarkerFormatRegexButton.Text = "Обновить";
            this.UpdateMarkerFormatRegexButton.UseVisualStyleBackColor = true;
            this.UpdateMarkerFormatRegexButton.Click += new System.EventHandler(this.UpdateMarkerFormatRegexButton_Click);
            // 
            // RemoveHighLightsCheckBox
            // 
            this.RemoveHighLightsCheckBox.AutoSize = true;
            this.RemoveHighLightsCheckBox.Location = new System.Drawing.Point(7, 7);
            this.RemoveHighLightsCheckBox.Name = "RemoveHighLightsCheckBox";
            this.RemoveHighLightsCheckBox.Size = new System.Drawing.Size(162, 17);
            this.RemoveHighLightsCheckBox.TabIndex = 0;
            this.RemoveHighLightsCheckBox.Text = "Убрать выделения цветом";
            this.RemoveHighLightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveCommentsCheckBox
            // 
            this.RemoveCommentsCheckBox.AutoSize = true;
            this.RemoveCommentsCheckBox.Location = new System.Drawing.Point(7, 30);
            this.RemoveCommentsCheckBox.Name = "RemoveCommentsCheckBox";
            this.RemoveCommentsCheckBox.Size = new System.Drawing.Size(141, 17);
            this.RemoveCommentsCheckBox.TabIndex = 1;
            this.RemoveCommentsCheckBox.Text = "Удалить комментарии";
            this.RemoveCommentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FinalizeButton
            // 
            this.FinalizeButton.Location = new System.Drawing.Point(334, 163);
            this.FinalizeButton.Name = "FinalizeButton";
            this.FinalizeButton.Size = new System.Drawing.Size(109, 23);
            this.FinalizeButton.TabIndex = 2;
            this.FinalizeButton.Text = "Финализировать";
            this.FinalizeButton.UseVisualStyleBackColor = true;
            this.FinalizeButton.Click += new System.EventHandler(this.FinalizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 571);
            this.Controls.Add(this.UpdateMarkerFormatRegexButton);
            this.Controls.Add(this.MarkersFormatTextBox);
            this.Controls.Add(this.MarkersFormatLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ShowWordWindowsCheckBox);
            this.Controls.Add(this.WorklogLabel);
            this.Controls.Add(this.WorklogTextBox);
            this.Controls.Add(this.InputDirPathFindButton);
            this.Controls.Add(this.InputDirPathTextBox);
            this.Controls.Add(this.InputDirLabel);
            this.Name = "Form1";
            this.Text = "Docx-replacer";
            this.tabControl1.ResumeLayout(false);
            this.tabPageReplace.ResumeLayout(false);
            this.tabPageReplace.PerformLayout();
            this.tabPageCheck.ResumeLayout(false);
            this.tabPageCheck.PerformLayout();
            this.tabPageFinalization.ResumeLayout(false);
            this.tabPageFinalization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputDirLabel;
        private System.Windows.Forms.Label MarkersDocPathLabel;
        private System.Windows.Forms.TextBox InputDirPathTextBox;
        private System.Windows.Forms.TextBox MarkersDocPathTextBox;
        private System.Windows.Forms.Button InputDirPathFindButton;
        private System.Windows.Forms.Button MarkersDocFindButton;
        private System.Windows.Forms.TextBox WorklogTextBox;
        private System.Windows.Forms.Button StratButton;
        private System.Windows.Forms.Label WorklogLabel;
        private System.Windows.Forms.OpenFileDialog DocOpenFileDialog;
        private System.Windows.Forms.CheckBox MakeBackupCheckBox;
        private System.Windows.Forms.Label TextBlocksPathLabel;
        private System.Windows.Forms.TextBox TextBlocksDocPathTextBox;
        private System.Windows.Forms.Button TextBlocksDocFindButton;
        private System.Windows.Forms.Button GetAllMarkersButton;
        private System.Windows.Forms.CheckBox ReplaceInTrackRevisionsModeChechBox;
        private System.Windows.Forms.CheckBox ShowWordWindowsCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.TabPage tabPageCheck;
        private System.Windows.Forms.TabPage tabPageFinalization;
        private System.Windows.Forms.Button StartCheckButton;
        private System.Windows.Forms.CheckBox CheckMarkersCheckBox;
        private System.Windows.Forms.CheckBox CheckHighlightsCheckBox;
        private System.Windows.Forms.CheckBox CheckCommentsCheckBox;
        private System.Windows.Forms.CheckBox CheckCorruptedLinksCheckBox;
        private System.Windows.Forms.Label MarkersFormatLabel;
        private System.Windows.Forms.TextBox MarkersFormatTextBox;
        private System.Windows.Forms.Button UpdateMarkerFormatRegexButton;
        private System.Windows.Forms.Button FinalizeButton;
        private System.Windows.Forms.CheckBox RemoveCommentsCheckBox;
        private System.Windows.Forms.CheckBox RemoveHighLightsCheckBox;
    }
}

