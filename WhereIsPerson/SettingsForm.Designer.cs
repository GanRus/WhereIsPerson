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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.userTxt.Location = new System.Drawing.Point(144, 30);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(116, 20);
            this.userTxt.TabIndex = 6;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(275, 30);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 147);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label label3;
    }
}