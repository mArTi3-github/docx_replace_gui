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
            this.InputDirFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MakeBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TextBlocksPathLabel = new System.Windows.Forms.Label();
            this.TextBlocksDocPathTextBox = new System.Windows.Forms.TextBox();
            this.TextBlocksDocFindButton = new System.Windows.Forms.Button();
            this.GetAllMarkersButton = new System.Windows.Forms.Button();
            this.ReplaceInTrackRevisionsModeChechBox = new System.Windows.Forms.CheckBox();
            this.ShowWordWindowsCheckBox = new System.Windows.Forms.CheckBox();
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
            this.MarkersDocPathLabel.Location = new System.Drawing.Point(12, 49);
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
            this.MarkersDocPathTextBox.Location = new System.Drawing.Point(214, 46);
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
            this.MarkersDocFindButton.Location = new System.Drawing.Point(675, 44);
            this.MarkersDocFindButton.Name = "MarkersDocFindButton";
            this.MarkersDocFindButton.Size = new System.Drawing.Size(75, 23);
            this.MarkersDocFindButton.TabIndex = 5;
            this.MarkersDocFindButton.Text = "...";
            this.MarkersDocFindButton.UseVisualStyleBackColor = true;
            this.MarkersDocFindButton.Click += new System.EventHandler(this.MarkersDocFindButton_Click);
            // 
            // WorklogTextBox
            // 
            this.WorklogTextBox.Location = new System.Drawing.Point(15, 178);
            this.WorklogTextBox.Multiline = true;
            this.WorklogTextBox.Name = "WorklogTextBox";
            this.WorklogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorklogTextBox.Size = new System.Drawing.Size(730, 260);
            this.WorklogTextBox.TabIndex = 6;
            // 
            // StratButton
            // 
            this.StratButton.Location = new System.Drawing.Point(337, 149);
            this.StratButton.Name = "StratButton";
            this.StratButton.Size = new System.Drawing.Size(75, 23);
            this.StratButton.TabIndex = 7;
            this.StratButton.Text = "Замена";
            this.StratButton.UseVisualStyleBackColor = true;
            this.StratButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // WorklogLabel
            // 
            this.WorklogLabel.AutoSize = true;
            this.WorklogLabel.Location = new System.Drawing.Point(12, 162);
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
            this.MakeBackupCheckBox.Location = new System.Drawing.Point(15, 121);
            this.MakeBackupCheckBox.Name = "MakeBackupCheckBox";
            this.MakeBackupCheckBox.Size = new System.Drawing.Size(140, 17);
            this.MakeBackupCheckBox.TabIndex = 9;
            this.MakeBackupCheckBox.Text = "Backup входной папки";
            this.MakeBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // TextBlocksPathLabel
            // 
            this.TextBlocksPathLabel.AutoSize = true;
            this.TextBlocksPathLabel.Location = new System.Drawing.Point(12, 88);
            this.TextBlocksPathLabel.Name = "TextBlocksPathLabel";
            this.TextBlocksPathLabel.Size = new System.Drawing.Size(189, 13);
            this.TextBlocksPathLabel.TabIndex = 10;
            this.TextBlocksPathLabel.Text = "Путь к документу с блоками текста";
            // 
            // TextBlocksDocPathTextBox
            // 
            this.TextBlocksDocPathTextBox.Location = new System.Drawing.Point(214, 88);
            this.TextBlocksDocPathTextBox.Name = "TextBlocksDocPathTextBox";
            this.TextBlocksDocPathTextBox.Size = new System.Drawing.Size(455, 20);
            this.TextBlocksDocPathTextBox.TabIndex = 11;
            // 
            // TextBlocksDocFindButton
            // 
            this.TextBlocksDocFindButton.Location = new System.Drawing.Point(675, 88);
            this.TextBlocksDocFindButton.Name = "TextBlocksDocFindButton";
            this.TextBlocksDocFindButton.Size = new System.Drawing.Size(75, 23);
            this.TextBlocksDocFindButton.TabIndex = 12;
            this.TextBlocksDocFindButton.Text = "...";
            this.TextBlocksDocFindButton.UseVisualStyleBackColor = true;
            this.TextBlocksDocFindButton.Click += new System.EventHandler(this.TextBlocksDocFindButton_Click);
            // 
            // GetAllMarkersButton
            // 
            this.GetAllMarkersButton.Location = new System.Drawing.Point(546, 149);
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
            this.ReplaceInTrackRevisionsModeChechBox.Location = new System.Drawing.Point(170, 121);
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
            this.ShowWordWindowsCheckBox.Location = new System.Drawing.Point(546, 121);
            this.ShowWordWindowsCheckBox.Name = "ShowWordWindowsCheckBox";
            this.ShowWordWindowsCheckBox.Size = new System.Drawing.Size(144, 17);
            this.ShowWordWindowsCheckBox.TabIndex = 15;
            this.ShowWordWindowsCheckBox.Text = "Отображать окна Word";
            this.ShowWordWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.ShowWordWindowsCheckBox);
            this.Controls.Add(this.ReplaceInTrackRevisionsModeChechBox);
            this.Controls.Add(this.GetAllMarkersButton);
            this.Controls.Add(this.TextBlocksDocFindButton);
            this.Controls.Add(this.TextBlocksDocPathTextBox);
            this.Controls.Add(this.TextBlocksPathLabel);
            this.Controls.Add(this.MakeBackupCheckBox);
            this.Controls.Add(this.WorklogLabel);
            this.Controls.Add(this.StratButton);
            this.Controls.Add(this.WorklogTextBox);
            this.Controls.Add(this.MarkersDocFindButton);
            this.Controls.Add(this.InputDirPathFindButton);
            this.Controls.Add(this.MarkersDocPathTextBox);
            this.Controls.Add(this.InputDirPathTextBox);
            this.Controls.Add(this.MarkersDocPathLabel);
            this.Controls.Add(this.InputDirLabel);
            this.Name = "Form1";
            this.Text = "Docx-replacer";
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
        private System.Windows.Forms.FolderBrowserDialog InputDirFolderBrowserDialog;
        private System.Windows.Forms.CheckBox MakeBackupCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label TextBlocksPathLabel;
        private System.Windows.Forms.TextBox TextBlocksDocPathTextBox;
        private System.Windows.Forms.Button TextBlocksDocFindButton;
        private System.Windows.Forms.Button GetAllMarkersButton;
        private System.Windows.Forms.CheckBox ReplaceInTrackRevisionsModeChechBox;
        private System.Windows.Forms.CheckBox ShowWordWindowsCheckBox;
    }
}

