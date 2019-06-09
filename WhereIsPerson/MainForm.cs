using FirebirdSql.Data.FirebirdClient;
using System;
using System.Drawing;
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
                //заполняем данными комбобоксы "Специальность" и "Организация"

                FbCommand query = new FbCommand("SELECT NAME FROM PROFESSION ORDER BY NAME", DataBase.dbConnect);
                FbDataReader reader = query.ExecuteReader();//для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

                while (reader.Read())
                {
                    ProfCmbBox.Items.Add(reader.GetString(0).ToString());
                }

                query.Dispose(); //нужно ли?

                query = new FbCommand("SELECT NAME FROM DEPARTMENT ORDER BY NAME", DataBase.dbConnect);
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    OrgCmbBox.Items.Add(reader.GetString(0).ToString());
                }

                query.Dispose();
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
            if (DataBase.GetConnectionState())
            {
                //если заполнен хотя бы один параметр поиска
                if (NameTxt.Text != "" || SurnameTxt.Text != "" || PatronymicTxt.Text != "" || ProfCmbBox.Text != "" || OrgCmbBox.Text != "")
                {
                    string query, addToQuery="";
                    bool firstCondition=true;

                    if (NameTxt.Text != "")
                    {
                        addToQuery = "F_NAME=" + NameTxt.Text.Trim();
                        firstCondition = false;
                    }

                    if (SurnameTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND ";}
                        else { firstCondition = true; }

                        addToQuery = "S_NAME=" + SurnameTxt.Text.Trim();
                    }

                    if (PatronymicTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = true; }

                        addToQuery = "M_NAME=" + PatronymicTxt.Text.Trim();
                    }
                    if (ProfCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = true; }

                        //addToQuery = "F_NAME=" + NameTxt.Text.Trim();
                    }
                    if (OrgCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = true; }

                        //addToQuery = "F_NAME=" + NameTxt.Text.Trim();
                    }

                    query = "SELECT F_NAME, S_NAME, M_NAME, DEPARTMENT_ID, PROFESSION_ID WHERE " + addToQuery;
                }
            }
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

        private void ProfCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProf = ProfCmbBox.SelectedItem.ToString();
        }

       
    }
}
