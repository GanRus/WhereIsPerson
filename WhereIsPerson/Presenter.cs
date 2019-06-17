using System.Drawing;
using System.Windows.Forms;

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
        }

        private void MainForm_pressSearchBtn(object sender, System.EventArgs e)
        {
            if (model.GetConnectionState())
            {
                //если заполнен хотя бы один параметр поиска
                if (mainForm.NameTxt.Text != "" || mainForm.SurnameTxt.Text != "" || mainForm.PatronymicTxt.Text != "" || mainForm.ProfCmbBox.Text != "" || mainForm.OrgCmbBox.Text != "")
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
                    if (mainForm.ProfCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        else { firstCondition = false; }

                        addToQuery += "PROFESSION_ID = " + mainForm.ProfCmbBox.SelectedValue + " ";
                    }
                    if (mainForm.OrgCmbBox.Text != "")
                    {
                        if (!firstCondition) { addToQuery += " AND "; }
                        addToQuery += "DEPARTMENT_ID = " + mainForm.OrgCmbBox.SelectedValue;
                    }

                    queryString = "SELECT F_NAME, S_NAME, M_NAME, PROFESSION_ID, DEPARTMENT_ID FROM PERSONNEL WHERE " + addToQuery;

                    MessageBox.Show(queryString);

                    mainForm.ListWorkersDataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

                    mainForm.ListWorkersDataGrid.DataSource = model.GetData(queryString); //запрашиваем данные из базы данных

                    mainForm.ListWorkersDataGrid.Columns[0].HeaderText = "Фамилия";
                    mainForm.ListWorkersDataGrid.Columns[1].HeaderText = "Имя";
                    mainForm.ListWorkersDataGrid.Columns[2].HeaderText = "Отчество";
                    mainForm.ListWorkersDataGrid.Columns[3].HeaderText = "Профессия";
                    mainForm.ListWorkersDataGrid.Columns[4].HeaderText = "Организация";
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

            //FbCommand query = new FbCommand("SELECT NAME FROM PROFESSION ORDER BY NAME", dbConnect);
            //FbDataReader reader;

            //        using (reader = query.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                ProfCmbBox.Items.Add(reader.GetString(0).ToString());
            //            }
            //        }

            //        query = new FbCommand("SELECT NAME FROM DEPARTMENT ORDER BY NAME", dbConnect);

            //        using (reader = query.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                OrgCmbBox.Items.Add(reader.GetString(0).ToString());
            //            }
            //        }

            mainForm.ProfCmbBox.DataSource = model.GetData("SELECT PROFESSION_ID, NAME FROM PROFESSION ORDER BY NAME");
            mainForm.ProfCmbBox.DisplayMember = "Name";
            mainForm.ProfCmbBox.ValueMember = "Profession_id";
            mainForm.ProfCmbBox.Text = "";

            mainForm.OrgCmbBox.DataSource = model.GetData("SELECT CODE, NAME FROM DEPARTMENT ORDER BY NAME");
            mainForm.OrgCmbBox.DisplayMember = "Name";
            mainForm.OrgCmbBox.ValueMember = "Code";
            mainForm.OrgCmbBox.Text = "";

        }
    }
}