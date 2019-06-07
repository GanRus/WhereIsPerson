using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsPerson
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            ConfigFile.OpenConfigFile();

            //соединяем с базой данных
            DataBase.OpenDBConnection(GlobalVariable.ip_addr, GlobalVariable.pathDB, GlobalVariable.user, GlobalVariable.pass);

            //если соединение установлено
            if (DataBase.GetConnectionState())
            {
                FbCommand profQuery = new FbCommand("SELECT NAME FROM PROFESSION ORDER BY NAME", DataBase.dbConnect);

                MessageBox.Show("test");

                if (GlobalVariable.connection_on)
                {
                    FbTransaction fbt = DataBase.dbConnect.BeginTransaction();
                    //profQuery.Dispose();
                    profQuery.Transaction = fbt;
                    FbDataReader reader = profQuery.ExecuteReader();//для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

                    //for (int i = 0; i < reader.GetString(0).Length; i++)
                    //{
                    //    ProfCmbBox.Items.Add()
                    //}

                    while (reader.Read())
                    {
                        ProfCmbBox.Items.Add(reader.GetString(0).ToString());
                    }


                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (DataBase.GetConnectionState())
            {
                MessageLbl.ForeColor = Color.Green;
                MessageLbl.Text = "Соединение с БД успешно установлено!";
            }
            else
            {
                MessageLbl.ForeColor = Color.Red;
                MessageLbl.Text = "Не удалось соединиться с указанной базой данных! Проверьте настройки подключения!";
            }
        }
    }
}
