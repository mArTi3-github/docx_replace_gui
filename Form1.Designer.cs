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
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ReplaceMethodHelpLabel = new System.Windows.Forms.Label();
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
            this.ReplaceInCopiesCheckBox.Location = new System.Drawing.Point(15, 81);
            this.ReplaceInCopiesCheckBox.Name = "ReplaceInCopiesCheckBox";
            this.ReplaceInCopiesCheckBox.Size = new System.Drawing.Size(129, 17);
            this.ReplaceInCopiesCheckBox.TabIndex = 9;
            this.ReplaceInCopiesCheckBox.Text = "Заменять на копиях";
            this.ReplaceInCopiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Метод замены";
            // 
            // ReplaceMethodComboBox
            // 
            this.ReplaceMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReplaceMethodComboBox.Items.AddRange(new object[] {
            "Text",
            "Copy-paste"});
            this.ReplaceMethodComboBox.Location = new System.Drawing.Point(100, 117);
            this.ReplaceMethodComboBox.Name = "ReplaceMethodComboBox";
            this.ReplaceMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.ReplaceMethodComboBox.TabIndex = 12;
            // 
            // ReplaceMethodHelpLabel
            // 
            this.ReplaceMethodHelpLabel.AutoSize = true;
            this.ReplaceMethodHelpLabel.Location = new System.Drawing.Point(228, 120);
            this.ReplaceMethodHelpLabel.Name = "ReplaceMethodHelpLabel";
            this.ReplaceMethodHelpLabel.Size = new System.Drawing.Size(526, 13);
            this.ReplaceMethodHelpLabel.TabIndex = 13;
            this.ReplaceMethodHelpLabel.Text = "Copy-paste - для кусков больше 256 символов либо при сложном форматировании (рису" +
    "нки, таблицы)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.ReplaceMethodHelpLabel);
            this.Controls.Add(this.ReplaceMethodComboBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ReplaceMethodComboBox;
        private System.Windows.Forms.Label ReplaceMethodHelpLabel;
    }
}

