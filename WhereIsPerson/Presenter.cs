using System.Data;
using System.Drawing;

namespace WhereIsPerson
{
    class Presenter
    {
        private MainForm mainForm;
        public Model model = null;

        public Presenter(MainForm mainForm)
        {
            this.mainForm = mainForm;
            model = new Model();
            this.mainForm.loadMainForm += MainForm_loadMainForm;
            this.mainForm.activeMainForm += MainForm_activeMainForm;
            this.mainForm.pressSearchBtn += MainForm_pressSearchBtn;
            this.mainForm.selectListWorkersRow += MainForm_selectListWorkersRow;
        }

        private void MainForm_pressSearchBtn(object sender, System.EventArgs e)
        {
            if (model.GetConnectionState())
            {
                //если заполнен хотя бы один параметр поиска
                if (mainForm.NameTxt.Text != "" || mainForm.SurnameTxt.Text != "" || mainForm.PatronymicTxt.Text != "" ||
                    (mainForm.ProfCmbBox.Text != "" && mainForm.ProfCmbBox.SelectedValue != null) || (mainForm.OrgCmbBox.Text != "" && mainForm.OrgCmbBox.SelectedValue != null))
                {
                    string queryString, addToQuery = "";
                    bool firstCondition = true;

                    if (mainForm.SurnameTxt.Text != "")
                    {
                        addToQuery = "F_NAME = '" + mainForm.SurnameTxt.Text.Trim() + "' ";
                        firstCondition = false;
                    }

                    if (mainForm.NameTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "S_NAME = '" + mainForm.NameTxt.Text.Trim() + "' ";
                    }

                    if (mainForm.PatronymicTxt.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "M_NAME = '" + mainForm.PatronymicTxt.Text.Trim() + "' ";
                    }
                    if (mainForm.ProfCmbBox.Text != "" && mainForm.ProfCmbBox.SelectedValue != null)
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "PROFESSION_ID = " + mainForm.ProfCmbBox.SelectedValue + " ";
                    }
                    if (mainForm.OrgCmbBox.Text != "" && mainForm.OrgCmbBox.SelectedValue != null)
                    {
                        if (!firstCondition) { addToQuery += " AND "; }

                        addToQuery += "DEPARTMENT_ID = " + mainForm.OrgCmbBox.SelectedValue;
                    }

                    string profSubQuery = "(SELECT NAME FROM PROFESSION WHERE PROFESSION_ID = PERSONNEL.PROFESSION_ID) AS PROFESSION";

                    queryString = "SELECT CLI_N, F_NAME, S_NAME, M_NAME, " + profSubQuery + "  FROM PERSONNEL WHERE " + addToQuery + " ORDER BY F_NAME";

                    mainForm.ListWorkersDataGrid.DataSource = model.GetData(queryString); //запрашиваем данные из базы данных

                    mainForm.ListWorkersDataGrid.Columns[0].Visible = false; //скрываем колонку с данными по номерам пропусков
                    mainForm.ListWorkersDataGrid.Columns[1].HeaderText = "Фамилия";
                    mainForm.ListWorkersDataGrid.Columns[2].HeaderText = "Имя";
                    mainForm.ListWorkersDataGrid.Columns[3].HeaderText = "Отчество";
                    mainForm.ListWorkersDataGrid.Columns[4].HeaderText = "Профессия";

                    mainForm.ListWorkersDataGrid.Columns[1].Width = 80;
                    mainForm.ListWorkersDataGrid.Columns[2].Width = 80;
                    mainForm.ListWorkersDataGrid.Columns[3].Width = 90;
                    mainForm.ListWorkersDataGrid.Columns[4].Width = 156;
                }
            }
        }

        private void TestConnection()
        {
            if (model.GetConnectionState())
            {
                mainForm.MessageLbl.ForeColor = Color.Green;
                mainForm.MessageLbl.Text = "Соединение с БД успешно установлено";
            }
            else
            {
                mainForm.MessageLbl.ForeColor = Color.Red;
                mainForm.MessageLbl.Text = "Не удалось установить соединение с БД. Проверьте настройки подключения";
            }
        }

        private void MainForm_activeMainForm(object sender, System.EventArgs e)
        {
            if (model.OpenConfigFile())
            {
                model.OpenDBConnection(model.ip_addr, model.pathDB, model.user, model.pass, model.codepage);

                TestConnection();
            }
            else
            {
                mainForm.MessageLbl.ForeColor = Color.Red;
                mainForm.MessageLbl.Text = "Не удалось найти настройки подключения к БД";
            }
        }


        //устанавливаем соединение с бд при загрузке формы
        private void MainForm_loadMainForm(object sender, System.EventArgs e)
        {
            if (model.OpenConfigFile())
            {
                model.OpenDBConnection(model.ip_addr, model.pathDB, model.user, model.pass, model.codepage);

                TestConnection();
            }
            else
            {
                mainForm.MessageLbl.ForeColor = Color.Red;
                mainForm.MessageLbl.Text = "Не удалось найти настройки подключения к БД";
            }

            mainForm.ProfCmbBox.DataSource = model.GetData("SELECT PROFESSION_ID, NAME FROM PROFESSION ORDER BY NAME");
            mainForm.ProfCmbBox.DisplayMember = "Name";
            mainForm.ProfCmbBox.ValueMember = "Profession_id";
            mainForm.ProfCmbBox.Text = "";

            mainForm.OrgCmbBox.DataSource = model.GetData("SELECT CODE, NAME FROM DEPARTMENT ORDER BY NAME");
            mainForm.OrgCmbBox.DisplayMember = "Name";
            mainForm.OrgCmbBox.ValueMember = "Code";
            mainForm.OrgCmbBox.Text = "";

        }

        private void MainForm_selectListWorkersRow(object sender, System.EventArgs e)
        {
            if (model.GetConnectionState())
            {
                string id_worker = mainForm.ListWorkersDataGrid.CurrentRow.Cells[0].Value.ToString();

                //делаем выборку событий по сотруднику
                string logtabQuery = "SELECT DT, CLI_TEXT, EV_TEXT, OBJ_TEXT FROM LOGTAB WHERE DT >= '01.06.2019' AND CLI_N = " + id_worker + " AND (EV_N = 7 or EV_N = 8) ORDER BY DT DESC";

                DataTable resultTable = model.GetData(logtabQuery);

                if (resultTable.Rows.Count > 0)
                {
                    resultTable = model.CutData(resultTable, 1, "/"); //обрезаем строку "Сотрудник" оставляя только ФИО
                    resultTable = model.CutData(resultTable, 2, " "); //обрезаем строку "Событие" удаляя ненужные слова после пробела
                }

                mainForm.EventsDataGrid.DataSource = resultTable;

                if (resultTable.Rows.Count > 0)
                {
                    mainForm.EventsDataGrid.Columns[0].HeaderText = "Дата / время";
                    mainForm.EventsDataGrid.Columns[1].HeaderText = "Сотрудник";
                    mainForm.EventsDataGrid.Columns[2].HeaderText = "Событие";
                    mainForm.EventsDataGrid.Columns[3].HeaderText = "Пост";

                    mainForm.EventsDataGrid.Columns[0].Width = 100;
                    mainForm.EventsDataGrid.Columns[1].Width = 210;
                    mainForm.EventsDataGrid.Columns[2].Width = 70;
                    mainForm.EventsDataGrid.Columns[3].Width = 70;
                }

                

                //получаем фото из базы
                if (model.GetPhoto("SELECT PHOTO FROM PHOTOS WHERE CLI_N = " + id_worker, id_worker, "photo"))
                {
                    

                    mainForm.PhotoPicBox.Image = model.OpenPhoto(id_worker);
                }
            }
        }
    }
}