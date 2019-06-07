﻿using System;
using System.Windows.Forms;
using System.IO;

namespace WhereIsPerson
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ConfigFile.OpenConfigFile();

            ipTxt.Text = GlobalVariable.ip_addr;
            userTxt.Text = GlobalVariable.user;
            passTxt.Text = GlobalVariable.pass;
            pathToDBtxt.Text = GlobalVariable.pathDB;
        }

        private void openFileDialogBtn_Click(object sender, EventArgs e)
        {
            openFileDBDialog.ShowDialog();
            pathToDBtxt.Text = Path.GetFullPath(openFileDBDialog.FileName);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            GlobalVariable.ip_addr = ipTxt.Text;
            GlobalVariable.user = userTxt.Text;
            GlobalVariable.pass = passTxt.Text;
            GlobalVariable.pathDB = pathToDBtxt.Text;

            ConfigFile.SaveConfigFile();
            DataBase.OpenDBConnection(GlobalVariable.ip_addr, GlobalVariable.pathDB, GlobalVariable.user, GlobalVariable.pass);

            //if (DataBase.GetConnectionState())
            //{
            //    MessageLbl.ForeColor = Color.Green;
            //    MessageLbl.Text = "Соединение с БД успешно установлено!";
            //}
            //else
            //{
            //    MessageLbl.ForeColor = Color.Red;
            //    MessageLbl.Text = "Не удалось соединиться с указанной базой данных! Проверьте настройки подключения!";
            //}

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
