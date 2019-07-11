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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListWorkersDataGrid = new System.Windows.Forms.DataGridView();
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
            this.DescPanel = new System.Windows.Forms.Panel();
            this.FIOTxtBox = new System.Windows.Forms.TextBox();
            this.RealTimeChkBox = new System.Windows.Forms.CheckBox();
            this.LogQueryTimer = new System.Windows.Forms.Timer(this.components);
            this.BeepChkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListWorkersDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPicBox)).BeginInit();
            this.DescPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListWorkersDataGrid
            // 
            this.ListWorkersDataGrid.AllowUserToAddRows = false;
            this.ListWorkersDataGrid.AllowUserToDeleteRows = false;
            this.ListWorkersDataGrid.AllowUserToResizeColumns = false;
            this.ListWorkersDataGrid.AllowUserToResizeRows = false;
            this.ListWorkersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListWorkersDataGrid.Location = new System.Drawing.Point(16, 29);
            this.ListWorkersDataGrid.MultiSelect = false;
            this.ListWorkersDataGrid.Name = "ListWorkersDataGrid";
            this.ListWorkersDataGrid.ReadOnly = true;
            this.ListWorkersDataGrid.RowHeadersVisible = false;
            this.ListWorkersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListWorkersDataGrid.Size = new System.Drawing.Size(426, 243);
            this.ListWorkersDataGrid.TabIndex = 0;
            this.ListWorkersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListWorkersDataGrid_CellClick);
            this.ListWorkersDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListWorkersDataGrid_KeyPress);
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTxt.Location = new System.Drawing.Point(160, 28);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(250, 26);
            this.SurnameTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.Location = new System.Drawing.Point(160, 65);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(250, 26);
            this.NameTxt.TabIndex = 2;
            // 
            // PatronymicTxt
            // 
            this.PatronymicTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTxt.Location = new System.Drawing.Point(160, 102);
            this.PatronymicTxt.Name = "PatronymicTxt";
            this.PatronymicTxt.Size = new System.Drawing.Size(250, 26);
            this.PatronymicTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(13, 34);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(70, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Фамилия";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLbl.Location = new System.Drawing.Point(13, 70);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(35, 17);
            this.SurnameLbl.TabIndex = 5;
            this.SurnameLbl.Text = "Имя";
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLbl.Location = new System.Drawing.Point(13, 106);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(71, 17);
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
            this.menuStrip1.Location = new System.Drawing.Point(2, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(61, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
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
            this.SearchGroupBox.Location = new System.Drawing.Point(16, 277);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(426, 262);
            this.SearchGroupBox.TabIndex = 8;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Параметры поиска";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(122, 220);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 30);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.Location = new System.Drawing.Point(14, 220);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 30);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // OrgranisationLbl
            // 
            this.OrgranisationLbl.AutoSize = true;
            this.OrgranisationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgranisationLbl.Location = new System.Drawing.Point(13, 184);
            this.OrgranisationLbl.Name = "OrgranisationLbl";
            this.OrgranisationLbl.Size = new System.Drawing.Size(95, 17);
            this.OrgranisationLbl.TabIndex = 10;
            this.OrgranisationLbl.Text = "Организация";
            // 
            // ProfessionLbl
            // 
            this.ProfessionLbl.AutoSize = true;
            this.ProfessionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionLbl.Location = new System.Drawing.Point(12, 145);
            this.ProfessionLbl.Name = "ProfessionLbl";
            this.ProfessionLbl.Size = new System.Drawing.Size(109, 17);
            this.ProfessionLbl.TabIndex = 9;
            this.ProfessionLbl.Text = "Специальность";
            // 
            // OrgCmbBox
            // 
            this.OrgCmbBox.DropDownHeight = 300;
            this.OrgCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgCmbBox.FormattingEnabled = true;
            this.OrgCmbBox.IntegralHeight = false;
            this.OrgCmbBox.Location = new System.Drawing.Point(160, 178);
            this.OrgCmbBox.Name = "OrgCmbBox";
            this.OrgCmbBox.Size = new System.Drawing.Size(250, 28);
            this.OrgCmbBox.TabIndex = 8;
            // 
            // ProfCmbBox
            // 
            this.ProfCmbBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProfCmbBox.DropDownHeight = 300;
            this.ProfCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfCmbBox.FormattingEnabled = true;
            this.ProfCmbBox.IntegralHeight = false;
            this.ProfCmbBox.Location = new System.Drawing.Point(160, 139);
            this.ProfCmbBox.Name = "ProfCmbBox";
            this.ProfCmbBox.Size = new System.Drawing.Size(250, 28);
            this.ProfCmbBox.TabIndex = 7;
            this.ProfCmbBox.SelectedIndexChanged += new System.EventHandler(this.ProfCmbBox_SelectedIndexChanged);
            // 
            // MessageLbl
            // 
            this.MessageLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(76, 542);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(0, 13);
            this.MessageLbl.TabIndex = 9;
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Location = new System.Drawing.Point(14, 542);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(64, 13);
            this.StateLbl.TabIndex = 10;
            this.StateLbl.Text = "Состояние:";
            // 
            // EventsDataGrid
            // 
            this.EventsDataGrid.AllowUserToAddRows = false;
            this.EventsDataGrid.AllowUserToDeleteRows = false;
            this.EventsDataGrid.AllowUserToResizeColumns = false;
            this.EventsDataGrid.AllowUserToResizeRows = false;
            this.EventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGrid.Location = new System.Drawing.Point(457, 283);
            this.EventsDataGrid.Name = "EventsDataGrid";
            this.EventsDataGrid.RowHeadersVisible = false;
            this.EventsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventsDataGrid.Size = new System.Drawing.Size(484, 221);
            this.EventsDataGrid.TabIndex = 11;
            // 
            // PhotoPicBox
            // 
            this.PhotoPicBox.Image = global::WhereIsPerson.Properties.Resources.empty;
            this.PhotoPicBox.Location = new System.Drawing.Point(457, 30);
            this.PhotoPicBox.Name = "PhotoPicBox";
            this.PhotoPicBox.Size = new System.Drawing.Size(207, 242);
            this.PhotoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPicBox.TabIndex = 12;
            this.PhotoPicBox.TabStop = false;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTxtBox.Location = new System.Drawing.Point(6, 28);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.ReadOnly = true;
            this.DescriptionTxtBox.Size = new System.Drawing.Size(258, 157);
            this.DescriptionTxtBox.TabIndex = 13;
            // 
            // DescPanel
            // 
            this.DescPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescPanel.Controls.Add(this.FIOTxtBox);
            this.DescPanel.Controls.Add(this.DescriptionTxtBox);
            this.DescPanel.Location = new System.Drawing.Point(671, 30);
            this.DescPanel.Name = "DescPanel";
            this.DescPanel.Size = new System.Drawing.Size(270, 242);
            this.DescPanel.TabIndex = 14;
            // 
            // FIOTxtBox
            // 
            this.FIOTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FIOTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FIOTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOTxtBox.Location = new System.Drawing.Point(6, 2);
            this.FIOTxtBox.Multiline = true;
            this.FIOTxtBox.Name = "FIOTxtBox";
            this.FIOTxtBox.ReadOnly = true;
            this.FIOTxtBox.Size = new System.Drawing.Size(258, 26);
            this.FIOTxtBox.TabIndex = 14;
            // 
            // RealTimeChkBox
            // 
            this.RealTimeChkBox.AutoSize = true;
            this.RealTimeChkBox.Location = new System.Drawing.Point(460, 507);
            this.RealTimeChkBox.Name = "RealTimeChkBox";
            this.RealTimeChkBox.Size = new System.Drawing.Size(289, 17);
            this.RealTimeChkBox.TabIndex = 15;
            this.RealTimeChkBox.Text = "Отображать проходы в режиме реального времени";
            this.RealTimeChkBox.UseVisualStyleBackColor = true;
            this.RealTimeChkBox.CheckedChanged += new System.EventHandler(this.RealTimeChkBox_CheckedChanged);
            // 
            // LogQueryTimer
            // 
            this.LogQueryTimer.Interval = 5000;
            // 
            // BeepChkBox
            // 
            this.BeepChkBox.AutoSize = true;
            this.BeepChkBox.Location = new System.Drawing.Point(460, 524);
            this.BeepChkBox.Name = "BeepChkBox";
            this.BeepChkBox.Size = new System.Drawing.Size(216, 17);
            this.BeepChkBox.TabIndex = 16;
            this.BeepChkBox.Text = "Оповещать звуком о новых проходах";
            this.BeepChkBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.SearchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(957, 560);
            this.Controls.Add(this.BeepChkBox);
            this.Controls.Add(this.RealTimeChkBox);
            this.Controls.Add(this.DescPanel);
            this.Controls.Add(this.PhotoPicBox);
            this.Controls.Add(this.EventsDataGrid);
            this.Controls.Add(this.StateLbl);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ListWorkersDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Поиск работника на строительной площадке";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListWorkersDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPicBox)).EndInit();
            this.DescPanel.ResumeLayout(false);
            this.DescPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ListWorkersDataGrid;
        public System.Windows.Forms.TextBox SurnameTxt;
        public System.Windows.Forms.TextBox NameTxt;
        public System.Windows.Forms.TextBox PatronymicTxt;
        public System.Windows.Forms.Label NameLbl;
        public System.Windows.Forms.Label SurnameLbl;
        public System.Windows.Forms.Label PatronymicLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label OrgranisationLbl;
        private System.Windows.Forms.Label ProfessionLbl;
        public System.Windows.Forms.ComboBox OrgCmbBox;
        public System.Windows.Forms.ComboBox ProfCmbBox;
        public System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Label StateLbl;
        public System.Windows.Forms.DataGridView EventsDataGrid;
        public System.Windows.Forms.PictureBox PhotoPicBox;
        public System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Panel DescPanel;
        public System.Windows.Forms.TextBox FIOTxtBox;
        public System.Windows.Forms.CheckBox RealTimeChkBox;
        public System.Windows.Forms.Timer LogQueryTimer;
        public System.Windows.Forms.CheckBox BeepChkBox;
    }
}

