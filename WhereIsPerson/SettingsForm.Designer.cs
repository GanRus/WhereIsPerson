using System.Windows.Forms;

namespace WhereIsPerson
{
    partial class SettingsForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDBDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathToDBtxt = new System.Windows.Forms.TextBox();
            this.pathToDBlbl = new System.Windows.Forms.Label();
            this.openFileDialogBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.ipLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.codeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDBDialog
            // 
            this.openFileDBDialog.FileName = "openFileDBDialog";
            // 
            // pathToDBtxt
            // 
            this.pathToDBtxt.Location = new System.Drawing.Point(14, 75);
            this.pathToDBtxt.Name = "pathToDBtxt";
            this.pathToDBtxt.Size = new System.Drawing.Size(487, 20);
            this.pathToDBtxt.TabIndex = 0;
            // 
            // pathToDBlbl
            // 
            this.pathToDBlbl.AutoSize = true;
            this.pathToDBlbl.Location = new System.Drawing.Point(17, 59);
            this.pathToDBlbl.Name = "pathToDBlbl";
            this.pathToDBlbl.Size = new System.Drawing.Size(115, 13);
            this.pathToDBlbl.TabIndex = 1;
            this.pathToDBlbl.Text = "Путь до базы данных";
            // 
            // openFileDialogBtn
            // 
            this.openFileDialogBtn.Location = new System.Drawing.Point(505, 75);
            this.openFileDialogBtn.Name = "openFileDialogBtn";
            this.openFileDialogBtn.Size = new System.Drawing.Size(24, 20);
            this.openFileDialogBtn.TabIndex = 2;
            this.openFileDialogBtn.Text = "...";
            this.openFileDialogBtn.UseVisualStyleBackColor = true;
            this.openFileDialogBtn.Click += new System.EventHandler(this.openFileDialogBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(14, 111);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(111, 111);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(14, 30);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(116, 20);
            this.ipTxt.TabIndex = 5;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(137, 30);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(116, 20);
            this.userTxt.TabIndex = 6;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(260, 30);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(116, 20);
            this.passTxt.TabIndex = 7;
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(17, 14);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(95, 13);
            this.ipLbl.TabIndex = 8;
            this.ipLbl.Text = "IP адрес сервера";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(140, 14);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(103, 13);
            this.loginLbl.TabIndex = 9;
            this.loginLbl.Text = "Имя пользователя";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(263, 14);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(45, 13);
            this.passLbl.TabIndex = 10;
            this.passLbl.Text = "Пароль";
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(383, 30);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(116, 20);
            this.codeTxt.TabIndex = 11;
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(386, 14);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(62, 13);
            this.codeLbl.TabIndex = 12;
            this.codeLbl.Text = "Кодировка";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 147);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.ipLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.openFileDialogBtn);
            this.Controls.Add(this.pathToDBlbl);
            this.Controls.Add(this.pathToDBtxt);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDBDialog;
        private TextBox pathToDBtxt;
        private Label pathToDBlbl;
        private Button openFileDialogBtn;
        private Button okBtn;
        private Button cancelBtn;
        private TextBox ipTxt;
        private TextBox userTxt;
        private TextBox passTxt;
        private Label ipLbl;
        private Label loginLbl;
        private Label passLbl;
        private TextBox codeTxt;
        private Label codeLbl;
    }
}