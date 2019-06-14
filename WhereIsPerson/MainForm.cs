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
            new Presenter(this);
        }
        public event EventHandler loadMainForm = null; // событие нажатия кнопки с цифрой

            //если соединение установлено
            if (GetConnectionState())
            {
                //заполняем данными комбобоксы "Специальность" и "Организация"

                
            }
        

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (GetConnectionState())
            {
                //если заполнен хотя бы один параметр поиска
                if (NameTxt.Text != "" || SurnameTxt.Text != "" || PatronymicTxt.Text != "" || ProfCmbBox.Text != "" || OrgCmbBox.Text != "")
                {
                    string queryString, addToQuery = "";
                    bool firstCondition = true;

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
                    }
                    if (OrgCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                    }

                    queryString = "SELECT F_NAME, S_NAME, M_NAME, PROFESSION_ID, DEPARTMENT_ID FROM PERSONNEL WHERE " + addToQuery;

                    ListWorkersDataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

                    using (FbDataAdapter da = new FbDataAdapter(queryString, dbConnect))
                    {
                        DataTable resultTable = new DataTable();

                        da.Fill(resultTable);

                        ListWorkersDataGrid.DataSource = resultTable;
                    }

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
            if (GetConnectionState())
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
