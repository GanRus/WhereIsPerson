﻿namespace WhereIsPerson
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
            this.ResultOfSearchList = new System.Windows.Forms.DataGridView();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.ResultOfSearchList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultOfSearchList
            // 
            this.ResultOfSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultOfSearchList.Location = new System.Drawing.Point(537, 228);
            this.ResultOfSearchList.Name = "ResultOfSearchList";
            this.ResultOfSearchList.Size = new System.Drawing.Size(426, 256);
            this.ResultOfSearchList.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.Location = new System.Drawing.Point(126, 23);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(200, 26);
            this.NameTxt.TabIndex = 1;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTxt.Location = new System.Drawing.Point(126, 60);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(200, 26);
            this.SurnameTxt.TabIndex = 2;
            // 
            // PatronymicTxt
            // 
            this.PatronymicTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTxt.Location = new System.Drawing.Point(126, 97);
            this.PatronymicTxt.Name = "PatronymicTxt";
            this.PatronymicTxt.Size = new System.Drawing.Size(200, 26);
            this.PatronymicTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(13, 29);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(70, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Фамилия";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLbl.Location = new System.Drawing.Point(13, 65);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(35, 17);
            this.SurnameLbl.TabIndex = 5;
            this.SurnameLbl.Text = "Имя";
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLbl.Location = new System.Drawing.Point(13, 101);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(71, 17);
            this.PatronymicLbl.TabIndex = 6;
            this.PatronymicLbl.Text = "Отчество";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
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
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.SearchGroupBox.Controls.Add(this.NameTxt);
            this.SearchGroupBox.Controls.Add(this.SurnameTxt);
            this.SearchGroupBox.Controls.Add(this.PatronymicTxt);
            this.SearchGroupBox.Controls.Add(this.NameLbl);
            this.SearchGroupBox.Controls.Add(this.PatronymicLbl);
            this.SearchGroupBox.Controls.Add(this.SurnameLbl);
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 228);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(349, 256);
            this.SearchGroupBox.TabIndex = 8;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Параметры поиска";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(126, 220);
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
            this.SearchBtn.Location = new System.Drawing.Point(18, 220);
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
            this.OrgranisationLbl.Location = new System.Drawing.Point(13, 179);
            this.OrgranisationLbl.Name = "OrgranisationLbl";
            this.OrgranisationLbl.Size = new System.Drawing.Size(95, 17);
            this.OrgranisationLbl.TabIndex = 10;
            this.OrgranisationLbl.Text = "Организация";
            // 
            // ProfessionLbl
            // 
            this.ProfessionLbl.AutoSize = true;
            this.ProfessionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionLbl.Location = new System.Drawing.Point(12, 140);
            this.ProfessionLbl.Name = "ProfessionLbl";
            this.ProfessionLbl.Size = new System.Drawing.Size(109, 17);
            this.ProfessionLbl.TabIndex = 9;
            this.ProfessionLbl.Text = "Специальность";
            // 
            // OrgCmbBox
            // 
            this.OrgCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgCmbBox.FormattingEnabled = true;
            this.OrgCmbBox.Location = new System.Drawing.Point(126, 173);
            this.OrgCmbBox.Name = "OrgCmbBox";
            this.OrgCmbBox.Size = new System.Drawing.Size(200, 28);
            this.OrgCmbBox.TabIndex = 8;
            // 
            // ProfCmbBox
            // 
            this.ProfCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfCmbBox.FormattingEnabled = true;
            this.ProfCmbBox.Location = new System.Drawing.Point(126, 134);
            this.ProfCmbBox.Name = "ProfCmbBox";
            this.ProfCmbBox.Size = new System.Drawing.Size(200, 28);
            this.ProfCmbBox.TabIndex = 7;
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(374, 35);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(0, 13);
            this.MessageLbl.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 496);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ResultOfSearchList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WhereIsPerson";
            ((System.ComponentModel.ISupportInitialize)(this.ResultOfSearchList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultOfSearchList;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
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
    }
}

