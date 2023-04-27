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
            this.MarkersFocPathLabel = new System.Windows.Forms.Label();
            this.InputDirPathTextBox = new System.Windows.Forms.TextBox();
            this.MarkersDocPathTextBox = new System.Windows.Forms.TextBox();
            this.InputDirPathFindButton = new System.Windows.Forms.Button();
            this.MarkersDocFindButton = new System.Windows.Forms.Button();
            this.WorklogTextBox = new System.Windows.Forms.TextBox();
            this.StratButton = new System.Windows.Forms.Button();
            this.WorklogLabel = new System.Windows.Forms.Label();
            this.MarkersDocOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputDirFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ReplaceInCopiesCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            // MarkersFocPathLabel
            // 
            this.MarkersFocPathLabel.AutoSize = true;
            this.MarkersFocPathLabel.Location = new System.Drawing.Point(12, 49);
            this.MarkersFocPathLabel.Name = "MarkersFocPathLabel";
            this.MarkersFocPathLabel.Size = new System.Drawing.Size(166, 13);
            this.MarkersFocPathLabel.TabIndex = 1;
            this.MarkersFocPathLabel.Text = "Путь к документу с маркерами";
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
            // MarkersDocOpenFileDialog
            // 
            this.MarkersDocOpenFileDialog.Filter = "Документы в формате docx|*.docx";
            // 
            // ReplaceInCopiesCheckBox
            // 
            this.ReplaceInCopiesCheckBox.AutoSize = true;
            this.ReplaceInCopiesCheckBox.Checked = true;
            this.ReplaceInCopiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceInCopiesCheckBox.Enabled = false;
            this.ReplaceInCopiesCheckBox.Location = new System.Drawing.Point(15, 81);
            this.ReplaceInCopiesCheckBox.Name = "ReplaceInCopiesCheckBox";
            this.ReplaceInCopiesCheckBox.Size = new System.Drawing.Size(129, 17);
            this.ReplaceInCopiesCheckBox.TabIndex = 9;
            this.ReplaceInCopiesCheckBox.Text = "Заменять на копиях";
            this.ReplaceInCopiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.ReplaceInCopiesCheckBox);
            this.Controls.Add(this.WorklogLabel);
            this.Controls.Add(this.StratButton);
            this.Controls.Add(this.WorklogTextBox);
            this.Controls.Add(this.MarkersDocFindButton);
            this.Controls.Add(this.InputDirPathFindButton);
            this.Controls.Add(this.MarkersDocPathTextBox);
            this.Controls.Add(this.InputDirPathTextBox);
            this.Controls.Add(this.MarkersFocPathLabel);
            this.Controls.Add(this.InputDirLabel);
            this.Name = "Form1";
            this.Text = "Docx-replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputDirLabel;
        private System.Windows.Forms.Label MarkersFocPathLabel;
        private System.Windows.Forms.TextBox InputDirPathTextBox;
        private System.Windows.Forms.TextBox MarkersDocPathTextBox;
        private System.Windows.Forms.Button InputDirPathFindButton;
        private System.Windows.Forms.Button MarkersDocFindButton;
        private System.Windows.Forms.TextBox WorklogTextBox;
        private System.Windows.Forms.Button StratButton;
        private System.Windows.Forms.Label WorklogLabel;
        private System.Windows.Forms.OpenFileDialog MarkersDocOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog InputDirFolderBrowserDialog;
        private System.Windows.Forms.CheckBox ReplaceInCopiesCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

