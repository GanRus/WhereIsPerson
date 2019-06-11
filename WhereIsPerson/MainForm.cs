using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WhereIsPerson
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //соединяем с базой данных
            if (ConfigFile.OpenConfigFile())
            {
                DataBase.OpenDBConnection(GlobalVariable.ip_addr, GlobalVariable.pathDB, GlobalVariable.user, GlobalVariable.pass, GlobalVariable.codepage);
            }
            else
            {
                MessageLbl.ForeColor = Color.Red;
                MessageLbl.Text = "Ошибка подключения к БД! Не указаны все нужные данные для подключения!";
            }

            //если соединение установлено
            if (DataBase.GetConnectionState())
            {
                //заполняем данными комбобоксы "Специальность" и "Организация"

                //using (DataBase.dbConnect)
                //{
                FbCommand query = new FbCommand("SELECT NAME FROM PROFESSION ORDER BY NAME", DataBase.dbConnect);
                FbDataReader reader = query.ExecuteReader();//для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()

                while (reader.Read())
                {
                    ProfCmbBox.Items.Add(reader.GetString(0).ToString());
                }

                query = new FbCommand("SELECT NAME FROM DEPARTMENT ORDER BY NAME", DataBase.dbConnect);
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    OrgCmbBox.Items.Add(reader.GetString(0).ToString());
                }
                //}
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
                    string queryString, addToQuery = "";
                    bool firstCondition = true;

                    //ListWorkersDataGrid.Rows.Clear();
                    //ListWorkersDataGrid.Columns.Clear();

                    if (SurnameTxt.Text != "")
                    {
                        addToQuery = "F_NAME = '" + SurnameTxt.Text.Trim() + "' ";
                        firstCondition = false;
                    }

                    if (NameTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "S_NAME = '" + NameTxt.Text.Trim() + "' ";
                    }

                    if (PatronymicTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "M_NAME = '" + PatronymicTxt.Text.Trim() + "' ";
                    }
                    if (ProfCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        //addToQuery = "F_NAME=" + NameTxt.Text.Trim();
                    }
                    if (OrgCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        //addToQuery = "F_NAME=" + NameTxt.Text.Trim();
                    }

                    queryString = "SELECT F_NAME, S_NAME, M_NAME, PROFESSION_ID, DEPARTMENT_ID FROM PERSONNEL WHERE " + addToQuery;

                    var column1 = new DataGridViewColumn();
                    column1.HeaderText = "Фамилия";
                    column1.Width = 100;
                    column1.ReadOnly = true;
                    column1.Name = "surname";
                    column1.CellTemplate = new DataGridViewTextBoxCell();

                    var column2 = new DataGridViewColumn();
                    column2.HeaderText = "Имя";
                    column2.Width = 100;
                    column2.ReadOnly = true;
                    column2.Name = "name";
                    column2.CellTemplate = new DataGridViewTextBoxCell();

                    //ListWorkersDataGrid.Columns.Add(column1);
                    //ListWorkersDataGrid.Columns.Add(column2);

                    ListWorkersDataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

                    //using (DataBase.dbConnect)
                    //{
                    FbCommand query = new FbCommand(queryString, DataBase.dbConnect);
                    FbDataAdapter da = new FbDataAdapter(queryString, DataBase.dbConnect);

                    DataTable resultTable = new DataTable();

                    da.Fill(resultTable);

                    ListWorkersDataGrid.DataSource = resultTable;

                    ListWorkersDataGrid.Columns[0].HeaderText = "Фамилия";
                    ListWorkersDataGrid.Columns[1].HeaderText = "Имя";
                    ListWorkersDataGrid.Columns[2].HeaderText = "Отчество";
                    ListWorkersDataGrid.Columns[3].HeaderText = "Профессия";
                    ListWorkersDataGrid.Columns[4].HeaderText = "Организация";
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SurnameTxt.Clear();
            NameTxt.Clear();
            PatronymicTxt.Clear();
            ProfCmbBox.Text = "";
            OrgCmbBox.Text = "";
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
