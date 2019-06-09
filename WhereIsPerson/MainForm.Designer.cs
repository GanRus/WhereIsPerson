namespace WhereIsPerson
{
    partial class MainForm
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
            this.ResultOfSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PatronymicTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.PatronymicLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.OrgranisationLbl = new System.Windows.Forms.Label();
            this.ProfessionLbl = new System.Windows.Forms.Label();
            this.OrgCmbBox = new System.Windows.Forms.ComboBox();
            this.ProfCmbBox = new System.Windows.Forms.ComboBox();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.StateLbl = new System.Windows.Forms.Label();
            this.EventsDataGrid = new System.Windows.Forms.DataGridView();
            this.PhotoPicBox = new System.Windows.Forms.PictureBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultOfSearchDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultOfSearchDataGrid
            // 
            this.ResultOfSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultOfSearchDataGrid.Location = new System.Drawing.Point(21, 37);
            this.ResultOfSearchDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ResultOfSearchDataGrid.Name = "ResultOfSearchDataGrid";
            this.ResultOfSearchDataGrid.Size = new System.Drawing.Size(568, 283);
            this.ResultOfSearchDataGrid.TabIndex = 0;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTxt.Location = new System.Drawing.Point(213, 28);
            this.SurnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(332, 30);
            this.SurnameTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.Location = new System.Drawing.Point(213, 74);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(332, 30);
            this.NameTxt.TabIndex = 2;
            // 
            // PatronymicTxt
            // 
            this.PatronymicTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTxt.Location = new System.Drawing.Point(213, 119);
            this.PatronymicTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PatronymicTxt.Name = "PatronymicTxt";
            this.PatronymicTxt.Size = new System.Drawing.Size(332, 30);
            this.PatronymicTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(17, 36);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(87, 20);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Фамилия";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLbl.Location = new System.Drawing.Point(17, 80);
            this.SurnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(42, 20);
            this.SurnameLbl.TabIndex = 5;
            this.SurnameLbl.Text = "Имя";
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLbl.Location = new System.Drawing.Point(17, 124);
            this.PatronymicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(91, 20);
            this.PatronymicLbl.TabIndex = 6;
            this.PatronymicLbl.Text = "Отчество";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-8, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(73, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.ClearBtn);
            this.SearchGroupBox.Controls.Add(this.SearchBtn);
            this.SearchGroupBox.Controls.Add(this.OrgranisationLbl);
            this.SearchGroupBox.Controls.Add(this.ProfessionLbl);
            this.SearchGroupBox.Controls.Add(this.OrgCmbBox);
            this.SearchGroupBox.Controls.Add(this.ProfCmbBox);
            this.SearchGroupBox.Controls.Add(this.SurnameTxt);
            this.SearchGroupBox.Controls.Add(this.NameTxt);
            this.SearchGroupBox.Controls.Add(this.PatronymicTxt);
            this.SearchGroupBox.Controls.Add(this.NameLbl);
            this.SearchGroupBox.Controls.Add(this.PatronymicLbl);
            this.SearchGroupBox.Controls.Add(this.SurnameLbl);
            this.SearchGroupBox.Location = new System.Drawing.Point(21, 330);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SearchGroupBox.Size = new System.Drawing.Size(568, 315);
            this.SearchGroupBox.TabIndex = 8;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Параметры поиска";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(168, 271);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(120, 37);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.Location = new System.Drawing.Point(24, 271);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(120, 37);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // OrgranisationLbl
            // 
            this.OrgranisationLbl.AutoSize = true;
            this.OrgranisationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgranisationLbl.Location = new System.Drawing.Point(17, 220);
            this.OrgranisationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgranisationLbl.Name = "OrgranisationLbl";
            this.OrgranisationLbl.Size = new System.Drawing.Size(119, 20);
            this.OrgranisationLbl.TabIndex = 10;
            this.OrgranisationLbl.Text = "Организация";
            // 
            // ProfessionLbl
            // 
            this.ProfessionLbl.AutoSize = true;
            this.ProfessionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionLbl.Location = new System.Drawing.Point(16, 172);
            this.ProfessionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfessionLbl.Name = "ProfessionLbl";
            this.ProfessionLbl.Size = new System.Drawing.Size(140, 20);
            this.ProfessionLbl.TabIndex = 9;
            this.ProfessionLbl.Text = "Специальность";
            // 
            // OrgCmbBox
            // 
            this.OrgCmbBox.DropDownHeight = 300;
            this.OrgCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgCmbBox.FormattingEnabled = true;
            this.OrgCmbBox.IntegralHeight = false;
            this.OrgCmbBox.Location = new System.Drawing.Point(213, 213);
            this.OrgCmbBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrgCmbBox.Name = "OrgCmbBox";
            this.OrgCmbBox.Size = new System.Drawing.Size(332, 33);
            this.OrgCmbBox.TabIndex = 8;
            // 
            // ProfCmbBox
            // 
            this.ProfCmbBox.DropDownHeight = 300;
            this.ProfCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfCmbBox.FormattingEnabled = true;
            this.ProfCmbBox.IntegralHeight = false;
            this.ProfCmbBox.Location = new System.Drawing.Point(213, 165);
            this.ProfCmbBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfCmbBox.Name = "ProfCmbBox";
            this.ProfCmbBox.Size = new System.Drawing.Size(332, 33);
            this.ProfCmbBox.TabIndex = 7;
            this.ProfCmbBox.SelectedIndexChanged += new System.EventHandler(this.ProfCmbBox_SelectedIndexChanged);
            // 
            // MessageLbl
            // 
            this.MessageLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(120, 652);
            this.MessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(0, 17);
            this.MessageLbl.TabIndex = 9;
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Location = new System.Drawing.Point(25, 652);
            this.StateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(83, 17);
            this.StateLbl.TabIndex = 10;
            this.StateLbl.Text = "Состояние:";
            // 
            // EventsDataGrid
            // 
            this.EventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGrid.Location = new System.Drawing.Point(611, 340);
            this.EventsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EventsDataGrid.Name = "EventsDataGrid";
            this.EventsDataGrid.Size = new System.Drawing.Size(644, 300);
            this.EventsDataGrid.TabIndex = 11;
            // 
            // PhotoPicBox
            // 
            this.PhotoPicBox.Location = new System.Drawing.Point(611, 37);
            this.PhotoPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoPicBox.Name = "PhotoPicBox";
            this.PhotoPicBox.Size = new System.Drawing.Size(268, 283);
            this.PhotoPicBox.TabIndex = 12;
            this.PhotoPicBox.TabStop = false;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(900, 37);
            this.DescriptionTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(353, 282);
            this.DescriptionTxtBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 673);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.PhotoPicBox);
            this.Controls.Add(this.EventsDataGrid);
            this.Controls.Add(this.StateLbl);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ResultOfSearchDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "WhereIsPerson";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ResultOfSearchDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultOfSearchDataGrid;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PatronymicTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label PatronymicLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label OrgranisationLbl;
        private System.Windows.Forms.Label ProfessionLbl;
        private System.Windows.Forms.ComboBox OrgCmbBox;
        private System.Windows.Forms.ComboBox ProfCmbBox;
        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Label StateLbl;
        private System.Windows.Forms.DataGridView EventsDataGrid;
        private System.Windows.Forms.PictureBox PhotoPicBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
    }
}

