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
            this.ReplaceButton = new System.Windows.Forms.Button();
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
            this.CheckRevisionsCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckMarkersCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckHighlightsCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckCorruptedLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.tabPageFinalization = new System.Windows.Forms.TabPage();
            this.AcceptRevisionsCheckBox = new System.Windows.Forms.CheckBox();
            this.FinalizeButton = new System.Windows.Forms.Button();
            this.RemoveCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveHighLightsCheckBox = new System.Windows.Forms.CheckBox();
            this.MarkersFormatLabel = new System.Windows.Forms.Label();
            this.MarkersFormatTextBox = new System.Windows.Forms.TextBox();
            this.UpdateMarkerFormatRegexButton = new System.Windows.Forms.Button();
            this.UpdateFieldsCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.tabPageCheck.SuspendLayout();
            this.tabPageFinalization.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputDirLabel
            // 
            this.InputDirLabel.AutoSize = true;
            this.InputDirLabel.Location = new System.Drawing.Point(16, 11);
            this.InputDirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputDirLabel.Name = "InputDirLabel";
            this.InputDirLabel.Size = new System.Drawing.Size(248, 16);
            this.InputDirLabel.TabIndex = 0;
            this.InputDirLabel.Text = "Папка с документами для обработки";
            // 
            // MarkersDocPathLabel
            // 
            this.MarkersDocPathLabel.AutoSize = true;
            this.MarkersDocPathLabel.Location = new System.Drawing.Point(29, 23);
            this.MarkersDocPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarkersDocPathLabel.Name = "MarkersDocPathLabel";
            this.MarkersDocPathLabel.Size = new System.Drawing.Size(209, 16);
            this.MarkersDocPathLabel.TabIndex = 1;
            this.MarkersDocPathLabel.Text = "Путь к документу с маркерами";
            // 
            // InputDirPathTextBox
            // 
            this.InputDirPathTextBox.Location = new System.Drawing.Point(285, 7);
            this.InputDirPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputDirPathTextBox.Name = "InputDirPathTextBox";
            this.InputDirPathTextBox.Size = new System.Drawing.Size(605, 22);
            this.InputDirPathTextBox.TabIndex = 2;
            // 
            // MarkersDocPathTextBox
            // 
            this.MarkersDocPathTextBox.Location = new System.Drawing.Point(299, 20);
            this.MarkersDocPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MarkersDocPathTextBox.Name = "MarkersDocPathTextBox";
            this.MarkersDocPathTextBox.Size = new System.Drawing.Size(605, 22);
            this.MarkersDocPathTextBox.TabIndex = 3;
            // 
            // InputDirPathFindButton
            // 
            this.InputDirPathFindButton.Location = new System.Drawing.Point(900, 5);
            this.InputDirPathFindButton.Margin = new System.Windows.Forms.Padding(4);
            this.InputDirPathFindButton.Name = "InputDirPathFindButton";
            this.InputDirPathFindButton.Size = new System.Drawing.Size(100, 28);
            this.InputDirPathFindButton.TabIndex = 4;
            this.InputDirPathFindButton.Text = "...";
            this.InputDirPathFindButton.UseVisualStyleBackColor = true;
            this.InputDirPathFindButton.Click += new System.EventHandler(this.InputDirPathFindButton_Click);
            // 
            // MarkersDocFindButton
            // 
            this.MarkersDocFindButton.Location = new System.Drawing.Point(913, 17);
            this.MarkersDocFindButton.Margin = new System.Windows.Forms.Padding(4);
            this.MarkersDocFindButton.Name = "MarkersDocFindButton";
            this.MarkersDocFindButton.Size = new System.Drawing.Size(100, 28);
            this.MarkersDocFindButton.TabIndex = 5;
            this.MarkersDocFindButton.Text = "...";
            this.MarkersDocFindButton.UseVisualStyleBackColor = true;
            this.MarkersDocFindButton.Click += new System.EventHandler(this.MarkersDocFindButton_Click);
            // 
            // WorklogTextBox
            // 
            this.WorklogTextBox.Location = new System.Drawing.Point(16, 416);
            this.WorklogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WorklogTextBox.Multiline = true;
            this.WorklogTextBox.Name = "WorklogTextBox";
            this.WorklogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorklogTextBox.Size = new System.Drawing.Size(1049, 271);
            this.WorklogTextBox.TabIndex = 6;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(463, 197);
            this.ReplaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(100, 28);
            this.ReplaceButton.TabIndex = 7;
            this.ReplaceButton.Text = "Заменить";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // WorklogLabel
            // 
            this.WorklogLabel.AutoSize = true;
            this.WorklogLabel.Location = new System.Drawing.Point(17, 396);
            this.WorklogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorklogLabel.Name = "WorklogLabel";
            this.WorklogLabel.Size = new System.Drawing.Size(84, 16);
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
            this.MakeBackupCheckBox.Location = new System.Drawing.Point(33, 112);
            this.MakeBackupCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MakeBackupCheckBox.Name = "MakeBackupCheckBox";
            this.MakeBackupCheckBox.Size = new System.Drawing.Size(174, 20);
            this.MakeBackupCheckBox.TabIndex = 9;
            this.MakeBackupCheckBox.Text = "Backup входной папки";
            this.MakeBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // TextBlocksPathLabel
            // 
            this.TextBlocksPathLabel.AutoSize = true;
            this.TextBlocksPathLabel.Location = new System.Drawing.Point(29, 71);
            this.TextBlocksPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBlocksPathLabel.Name = "TextBlocksPathLabel";
            this.TextBlocksPathLabel.Size = new System.Drawing.Size(239, 16);
            this.TextBlocksPathLabel.TabIndex = 10;
            this.TextBlocksPathLabel.Text = "Путь к документу с блоками текста";
            // 
            // TextBlocksDocPathTextBox
            // 
            this.TextBlocksDocPathTextBox.Location = new System.Drawing.Point(299, 71);
            this.TextBlocksDocPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextBlocksDocPathTextBox.Name = "TextBlocksDocPathTextBox";
            this.TextBlocksDocPathTextBox.Size = new System.Drawing.Size(605, 22);
            this.TextBlocksDocPathTextBox.TabIndex = 11;
            // 
            // TextBlocksDocFindButton
            // 
            this.TextBlocksDocFindButton.Location = new System.Drawing.Point(913, 71);
            this.TextBlocksDocFindButton.Margin = new System.Windows.Forms.Padding(4);
            this.TextBlocksDocFindButton.Name = "TextBlocksDocFindButton";
            this.TextBlocksDocFindButton.Size = new System.Drawing.Size(100, 28);
            this.TextBlocksDocFindButton.TabIndex = 12;
            this.TextBlocksDocFindButton.Text = "...";
            this.TextBlocksDocFindButton.UseVisualStyleBackColor = true;
            this.TextBlocksDocFindButton.Click += new System.EventHandler(this.TextBlocksDocFindButton_Click);
            // 
            // GetAllMarkersButton
            // 
            this.GetAllMarkersButton.Location = new System.Drawing.Point(767, 197);
            this.GetAllMarkersButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetAllMarkersButton.Name = "GetAllMarkersButton";
            this.GetAllMarkersButton.Size = new System.Drawing.Size(265, 28);
            this.GetAllMarkersButton.TabIndex = 13;
            this.GetAllMarkersButton.Text = "Найти все маркеры в документах";
            this.GetAllMarkersButton.UseVisualStyleBackColor = true;
            this.GetAllMarkersButton.Click += new System.EventHandler(this.GetAllMarkersButton_Click);
            // 
            // ReplaceInTrackRevisionsModeChechBox
            // 
            this.ReplaceInTrackRevisionsModeChechBox.AutoSize = true;
            this.ReplaceInTrackRevisionsModeChechBox.Location = new System.Drawing.Point(33, 140);
            this.ReplaceInTrackRevisionsModeChechBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReplaceInTrackRevisionsModeChechBox.Name = "ReplaceInTrackRevisionsModeChechBox";
            this.ReplaceInTrackRevisionsModeChechBox.Size = new System.Drawing.Size(464, 20);
            this.ReplaceInTrackRevisionsModeChechBox.TabIndex = 14;
            this.ReplaceInTrackRevisionsModeChechBox.Text = "Заменять в режиме исправлений (только для маркеров в таблице)";
            this.ReplaceInTrackRevisionsModeChechBox.UseVisualStyleBackColor = true;
            // 
            // ShowWordWindowsCheckBox
            // 
            this.ShowWordWindowsCheckBox.AutoSize = true;
            this.ShowWordWindowsCheckBox.Checked = true;
            this.ShowWordWindowsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowWordWindowsCheckBox.Location = new System.Drawing.Point(20, 96);
            this.ShowWordWindowsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowWordWindowsCheckBox.Name = "ShowWordWindowsCheckBox";
            this.ShowWordWindowsCheckBox.Size = new System.Drawing.Size(179, 20);
            this.ShowWordWindowsCheckBox.TabIndex = 15;
            this.ShowWordWindowsCheckBox.Text = "Отображать окна Word";
            this.ShowWordWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageReplace);
            this.tabControl1.Controls.Add(this.tabPageCheck);
            this.tabControl1.Controls.Add(this.tabPageFinalization);
            this.tabControl1.Location = new System.Drawing.Point(16, 124);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 268);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.MarkersDocPathTextBox);
            this.tabPageReplace.Controls.Add(this.MarkersDocPathLabel);
            this.tabPageReplace.Controls.Add(this.ReplaceInTrackRevisionsModeChechBox);
            this.tabPageReplace.Controls.Add(this.MarkersDocFindButton);
            this.tabPageReplace.Controls.Add(this.GetAllMarkersButton);
            this.tabPageReplace.Controls.Add(this.ReplaceButton);
            this.tabPageReplace.Controls.Add(this.TextBlocksDocFindButton);
            this.tabPageReplace.Controls.Add(this.MakeBackupCheckBox);
            this.tabPageReplace.Controls.Add(this.TextBlocksDocPathTextBox);
            this.tabPageReplace.Controls.Add(this.TextBlocksPathLabel);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 25);
            this.tabPageReplace.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageReplace.Size = new System.Drawing.Size(1043, 239);
            this.tabPageReplace.TabIndex = 0;
            this.tabPageReplace.Text = "Замена";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.Controls.Add(this.CheckRevisionsCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckMarkersCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckHighlightsCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckCommentsCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckCorruptedLinksCheckBox);
            this.tabPageCheck.Controls.Add(this.CheckButton);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 25);
            this.tabPageCheck.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCheck.Size = new System.Drawing.Size(1043, 239);
            this.tabPageCheck.TabIndex = 1;
            this.tabPageCheck.Text = "Проверка";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // CheckRevisionsCheckBox
            // 
            this.CheckRevisionsCheckBox.AutoSize = true;
            this.CheckRevisionsCheckBox.Checked = true;
            this.CheckRevisionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRevisionsCheckBox.Location = new System.Drawing.Point(8, 120);
            this.CheckRevisionsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckRevisionsCheckBox.Name = "CheckRevisionsCheckBox";
            this.CheckRevisionsCheckBox.Size = new System.Drawing.Size(117, 20);
            this.CheckRevisionsCheckBox.TabIndex = 5;
            this.CheckRevisionsCheckBox.Text = "Исправления";
            this.CheckRevisionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckMarkersCheckBox
            // 
            this.CheckMarkersCheckBox.AutoSize = true;
            this.CheckMarkersCheckBox.Checked = true;
            this.CheckMarkersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckMarkersCheckBox.Location = new System.Drawing.Point(8, 92);
            this.CheckMarkersCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckMarkersCheckBox.Name = "CheckMarkersCheckBox";
            this.CheckMarkersCheckBox.Size = new System.Drawing.Size(88, 20);
            this.CheckMarkersCheckBox.TabIndex = 4;
            this.CheckMarkersCheckBox.Text = "Маркеры";
            this.CheckMarkersCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckHighlightsCheckBox
            // 
            this.CheckHighlightsCheckBox.AutoSize = true;
            this.CheckHighlightsCheckBox.Checked = true;
            this.CheckHighlightsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckHighlightsCheckBox.Location = new System.Drawing.Point(8, 64);
            this.CheckHighlightsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckHighlightsCheckBox.Name = "CheckHighlightsCheckBox";
            this.CheckHighlightsCheckBox.Size = new System.Drawing.Size(153, 20);
            this.CheckHighlightsCheckBox.TabIndex = 3;
            this.CheckHighlightsCheckBox.Text = "Выделения цветом";
            this.CheckHighlightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckCommentsCheckBox
            // 
            this.CheckCommentsCheckBox.AutoSize = true;
            this.CheckCommentsCheckBox.Checked = true;
            this.CheckCommentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCommentsCheckBox.Location = new System.Drawing.Point(8, 36);
            this.CheckCommentsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckCommentsCheckBox.Name = "CheckCommentsCheckBox";
            this.CheckCommentsCheckBox.Size = new System.Drawing.Size(118, 20);
            this.CheckCommentsCheckBox.TabIndex = 2;
            this.CheckCommentsCheckBox.Text = "Комментарии";
            this.CheckCommentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckCorruptedLinksCheckBox
            // 
            this.CheckCorruptedLinksCheckBox.AutoSize = true;
            this.CheckCorruptedLinksCheckBox.Checked = true;
            this.CheckCorruptedLinksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCorruptedLinksCheckBox.Location = new System.Drawing.Point(8, 7);
            this.CheckCorruptedLinksCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckCorruptedLinksCheckBox.Name = "CheckCorruptedLinksCheckBox";
            this.CheckCorruptedLinksCheckBox.Size = new System.Drawing.Size(145, 20);
            this.CheckCorruptedLinksCheckBox.TabIndex = 1;
            this.CheckCorruptedLinksCheckBox.Text = "Ошибки в ссылках";
            this.CheckCorruptedLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(469, 201);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(100, 28);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // tabPageFinalization
            // 
            this.tabPageFinalization.Controls.Add(this.UpdateFieldsCheckBox);
            this.tabPageFinalization.Controls.Add(this.AcceptRevisionsCheckBox);
            this.tabPageFinalization.Controls.Add(this.FinalizeButton);
            this.tabPageFinalization.Controls.Add(this.RemoveCommentsCheckBox);
            this.tabPageFinalization.Controls.Add(this.RemoveHighLightsCheckBox);
            this.tabPageFinalization.Location = new System.Drawing.Point(4, 25);
            this.tabPageFinalization.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFinalization.Name = "tabPageFinalization";
            this.tabPageFinalization.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageFinalization.Size = new System.Drawing.Size(1043, 239);
            this.tabPageFinalization.TabIndex = 2;
            this.tabPageFinalization.Text = "Финализация";
            this.tabPageFinalization.UseVisualStyleBackColor = true;
            // 
            // AcceptRevisionsCheckBox
            // 
            this.AcceptRevisionsCheckBox.AutoSize = true;
            this.AcceptRevisionsCheckBox.Location = new System.Drawing.Point(9, 65);
            this.AcceptRevisionsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptRevisionsCheckBox.Name = "AcceptRevisionsCheckBox";
            this.AcceptRevisionsCheckBox.Size = new System.Drawing.Size(173, 20);
            this.AcceptRevisionsCheckBox.TabIndex = 3;
            this.AcceptRevisionsCheckBox.Text = "Принять исправления";
            this.AcceptRevisionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FinalizeButton
            // 
            this.FinalizeButton.Location = new System.Drawing.Point(445, 201);
            this.FinalizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinalizeButton.Name = "FinalizeButton";
            this.FinalizeButton.Size = new System.Drawing.Size(145, 28);
            this.FinalizeButton.TabIndex = 2;
            this.FinalizeButton.Text = "Финализировать";
            this.FinalizeButton.UseVisualStyleBackColor = true;
            this.FinalizeButton.Click += new System.EventHandler(this.FinalizeButton_Click);
            // 
            // RemoveCommentsCheckBox
            // 
            this.RemoveCommentsCheckBox.AutoSize = true;
            this.RemoveCommentsCheckBox.Location = new System.Drawing.Point(9, 37);
            this.RemoveCommentsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCommentsCheckBox.Name = "RemoveCommentsCheckBox";
            this.RemoveCommentsCheckBox.Size = new System.Drawing.Size(175, 20);
            this.RemoveCommentsCheckBox.TabIndex = 1;
            this.RemoveCommentsCheckBox.Text = "Удалить комментарии";
            this.RemoveCommentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveHighLightsCheckBox
            // 
            this.RemoveHighLightsCheckBox.AutoSize = true;
            this.RemoveHighLightsCheckBox.Location = new System.Drawing.Point(9, 9);
            this.RemoveHighLightsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveHighLightsCheckBox.Name = "RemoveHighLightsCheckBox";
            this.RemoveHighLightsCheckBox.Size = new System.Drawing.Size(202, 20);
            this.RemoveHighLightsCheckBox.TabIndex = 0;
            this.RemoveHighLightsCheckBox.Text = "Убрать выделения цветом";
            this.RemoveHighLightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MarkersFormatLabel
            // 
            this.MarkersFormatLabel.AutoSize = true;
            this.MarkersFormatLabel.Location = new System.Drawing.Point(17, 49);
            this.MarkersFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarkersFormatLabel.Name = "MarkersFormatLabel";
            this.MarkersFormatLabel.Size = new System.Drawing.Size(128, 16);
            this.MarkersFormatLabel.TabIndex = 17;
            this.MarkersFormatLabel.Text = "Формат маркеров:";
            // 
            // MarkersFormatTextBox
            // 
            this.MarkersFormatTextBox.Location = new System.Drawing.Point(285, 49);
            this.MarkersFormatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MarkersFormatTextBox.Name = "MarkersFormatTextBox";
            this.MarkersFormatTextBox.Size = new System.Drawing.Size(605, 22);
            this.MarkersFormatTextBox.TabIndex = 18;
            this.MarkersFormatTextBox.Text = "\\{\\{ \\w* \\}\\}";
            // 
            // UpdateMarkerFormatRegexButton
            // 
            this.UpdateMarkerFormatRegexButton.Location = new System.Drawing.Point(900, 49);
            this.UpdateMarkerFormatRegexButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateMarkerFormatRegexButton.Name = "UpdateMarkerFormatRegexButton";
            this.UpdateMarkerFormatRegexButton.Size = new System.Drawing.Size(100, 28);
            this.UpdateMarkerFormatRegexButton.TabIndex = 19;
            this.UpdateMarkerFormatRegexButton.Text = "Обновить";
            this.UpdateMarkerFormatRegexButton.UseVisualStyleBackColor = true;
            this.UpdateMarkerFormatRegexButton.Click += new System.EventHandler(this.UpdateMarkerFormatRegexButton_Click);
            // 
            // UpdateFieldsCheckBox
            // 
            this.UpdateFieldsCheckBox.AutoSize = true;
            this.UpdateFieldsCheckBox.Location = new System.Drawing.Point(8, 93);
            this.UpdateFieldsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateFieldsCheckBox.Name = "UpdateFieldsCheckBox";
            this.UpdateFieldsCheckBox.Size = new System.Drawing.Size(127, 20);
            this.UpdateFieldsCheckBox.TabIndex = 4;
            this.UpdateFieldsCheckBox.Text = "Обновить поля";
            this.UpdateFieldsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 703);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button ReplaceButton;
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
        private System.Windows.Forms.Button CheckButton;
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
        private System.Windows.Forms.CheckBox CheckRevisionsCheckBox;
        private System.Windows.Forms.CheckBox AcceptRevisionsCheckBox;
        private System.Windows.Forms.CheckBox UpdateFieldsCheckBox;
    }
}

