using System;
using System.Data;
using System.Drawing;

namespace WhereIsPerson
{
    class Presenter
    {
        private MainForm mainForm;
        public Model model = null;
        string id_worker_glob; //идентификатор текущего выбранного работника
        int count_events = 0; //количество проходов текущего работника
        bool first_show = true; //используется чтобы при первом получении выборки в реальном времени не использовался звуковой сигнал

        public Presenter(MainForm mainForm)
        {
            this.mainForm = mainForm;
            model = new Model();
            this.mainForm.loadMainForm += MainForm_loadMainForm;
            this.mainForm.activeMainForm += MainForm_activeMainForm;
            this.mainForm.pressSearchBtn += MainForm_pressSearchBtn;
            this.mainForm.selectListWorkersRow += MainForm_selectListWorkersRow;
            this.mainForm.enableRealTime += MainForm_enableRealTime;
        }

        private void MainForm_enableRealTime(object sender, EventArgs e)
        {
            if (mainForm.RealTimeChkBox.Checked)
            {
                if (model.GetConnectionState() && mainForm.ListWorkersDataGrid.RowCount > 0)
                {
                    string id_worker = mainForm.ListWorkersDataGrid.CurrentRow.Cells[0].Value.ToString(); //номер пропуска
                    id_worker_glob = id_worker; //сохраняем в глобальной переменной, для последующей передачи в метод обработчик события tick

                    if (id_worker != "")
                    {
                        mainForm.LogQueryTimer.Tick += GetLogTab;
                        mainForm.LogQueryTimer.Start();
                    }
                }
            }
            else
            {
                mainForm.LogQueryTimer.Stop();
                mainForm.LogQueryTimer.Tick -= GetLogTab;
                count_events = 0;
                first_show = true;
            }
        }

        private void GetLogTab(object sender, EventArgs e)
        {
            if (mainForm.RealTimeChkBox.Checked && id_worker_glob != "")
            {
                string logtabQuery = "SELECT DT, CLI_TEXT, EV_TEXT, OBJ_TEXT FROM LOGTAB WHERE DT >= '" + DateTime.Today + "' AND CLI_N = " + id_worker_glob + " AND (EV_N = 7 or EV_N = 8) ORDER BY DT DESC";

                DataTable resultTable = model.GetData(logtabQuery);

                if (resultTable.Rows.Count > 0)
                {
                    resultTable = model.CutData(resultTable, 1, "/"); //обрезаем строку "Сотрудник" оставляя только ФИО
                    resultTable = model.CutData(resultTable, 2, " "); //обрезаем строку "Событие" удаляя ненужные слова после пробела
                }

                mainForm.EventsDataGrid.DataSource = resultTable;

                if (count_events < resultTable.Rows.Count) //если добавилось новое событие, выводим окно на передний план
                {
                    count_events = resultTable.Rows.Count;
                    if (!first_show)
                    {
                        mainForm.Activate();
                        if (mainForm.BeepChkBox.Checked)
                        {
                            Console.Beep(1000, 1000);
                        }
                    }
                    if (first_show) { first_show = false; }
                }
            }
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

                    queryString = "SELECT CLI_N, F_NAME, S_NAME, M_NAME, " + profSubQuery + " FROM PERSONNEL WHERE " + addToQuery + " AND CLI_N IS NOT NULL ORDER BY F_NAME";

                    mainForm.ListWorkersDataGrid.DataSource = model.GetData(queryString); //запрашиваем данные из базы данных

                    mainForm.ListWorkersDataGrid.Columns[0].Visible = false; //скрываем колонку с данными по номерам пропусков
                    mainForm.ListWorkersDataGrid.Columns[1].HeaderText = "Фамилия";
                    mainForm.ListWorkersDataGrid.Columns[2].HeaderText = "Имя";
                    mainForm.ListWorkersDataGrid.Columns[3].HeaderText = "Отчество";
                    mainForm.ListWorkersDataGrid.Columns[4].HeaderText = "Должность";

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

            if (model.GetConnectionState())
            {
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

        private void MainForm_selectListWorkersRow(object sender, System.EventArgs e)
        {
            if (mainForm.RealTimeChkBox.Checked) //если включен режим слежения в реальном времени, то выключаем его
            {
                mainForm.RealTimeChkBox.Checked = false;
                mainForm.BeepChkBox.Checked = false;
                mainForm.LogQueryTimer.Stop();
                mainForm.LogQueryTimer.Tick -= GetLogTab;
                id_worker_glob = "";
                count_events = 0;
                first_show = true;
            }

            if (model.GetConnectionState())
            {
                string id_worker = mainForm.ListWorkersDataGrid.CurrentRow.Cells[0].Value.ToString(); //номер пропуска

                //делаем выборку событий по сотруднику
                string logtabQuery = "SELECT DT, CLI_TEXT, EV_TEXT, OBJ_TEXT FROM LOGTAB WHERE DT >= '" + DateTime.Today + "' AND CLI_N = " + id_worker + " AND (EV_N = 7 or EV_N = 8) ORDER BY DT DESC";

                DataTable resultTable = model.GetData(logtabQuery);

                if (resultTable.Rows.Count > 0)
                {
                    resultTable = model.CutData(resultTable, 1, "/"); //обрезаем строку "Сотрудник" оставляя только ФИО
                    resultTable = model.CutData(resultTable, 2, " "); //обрезаем строку "Событие" удаляя ненужные слова после пробела
                }

                mainForm.EventsDataGrid.DataSource = resultTable;

                mainForm.EventsDataGrid.Columns[0].HeaderText = "Дата / время";
                mainForm.EventsDataGrid.Columns[1].HeaderText = "Сотрудник";
                mainForm.EventsDataGrid.Columns[2].HeaderText = "Событие";
                mainForm.EventsDataGrid.Columns[3].HeaderText = "Пост";

                mainForm.EventsDataGrid.Columns[0].Width = 100;
                mainForm.EventsDataGrid.Columns[1].Width = 210;
                mainForm.EventsDataGrid.Columns[2].Width = 75;
                mainForm.EventsDataGrid.Columns[3].Width = 75;

                //получаем фото из базы
                if (model.GetPhoto("SELECT PHOTO FROM PHOTOS WHERE CLI_N = " + id_worker, id_worker, "photo"))
                {
                    mainForm.PhotoPicBox.Image = model.OpenPhoto(id_worker);
                }

                //получаем информацию по сотруднику
                string profSubQuery = "(SELECT NAME FROM PROFESSION WHERE PROFESSION_ID = PERSONNEL.PROFESSION_ID) AS PROFESSION";
                string departSubQuery = "(SELECT NAME FROM DEPARTMENT WHERE CODE = PERSONNEL.DEPARTMENT_ID) AS DEPARTMENT";

                string workerQuery = "SELECT USER_ID, CLI_N, F_NAME, S_NAME, M_NAME, " + profSubQuery + ", " + departSubQuery + ", " +
                                     "PROFESSION_ID, TABN, DATE_BRS, H_ADDR, H_PHONE, M_PHONE, P_NUM, P_ISSUED, P_ISSUEDAY, REGISTRATION, GETTINGDATE, DECISION " +
                                     "FROM PERSONNEL WHERE CLI_N = " + id_worker;

                resultTable = model.GetData(workerQuery);

                if (mainForm.FIOTxtBox.Text.Length > 0)
                {
                    mainForm.FIOTxtBox.Clear();
                    mainForm.DescriptionTxtBox.Clear();
                }

                if (resultTable.Rows.Count > 0)
                {
                    mainForm.FIOTxtBox.AppendText(resultTable.Rows[0]["F_NAME"].ToString() + " " + resultTable.Rows[0]["S_NAME"].ToString() + " " + resultTable.Rows[0]["M_NAME"].ToString());

                    string date_brs = resultTable.Rows[0]["DATE_BRS"].ToString();
                    string mphone = resultTable.Rows[0]["M_PHONE"].ToString();

                    if (date_brs != "")
                    {
                        date_brs = "Дата рождения: " + date_brs.Substring(0, date_brs.IndexOf(" ")) + Environment.NewLine;
                    }
                    if (mphone != "")
                    {
                        mphone = "Контактный телефон: " + mphone + Environment.NewLine;
                    }

                    string profession = "Должность: " + resultTable.Rows[0]["PROFESSION"].ToString() + Environment.NewLine;
                    string department = "Организация: " + resultTable.Rows[0]["DEPARTMENT"].ToString() + Environment.NewLine;
                    string cli_n = "Пропуск: № " + resultTable.Rows[0]["CLI_N"].ToString();

                    string gettingdate = resultTable.Rows[0]["GETTINGDATE"].ToString();
                    gettingdate = " выдан " + gettingdate.Substring(0, 10) + Environment.NewLine; //убираем лишние нули с даты выдачи пропуска

                    string passport = "Паспорт: " + resultTable.Rows[0]["P_NUM"].ToString() + " выдан " + resultTable.Rows[0]["P_ISSUED"].ToString() + ", " +
                                      resultTable.Rows[0]["P_ISSUEDAY"].ToString().Substring(0, 10) + Environment.NewLine;

                    string address = resultTable.Rows[0]["H_ADDR"].ToString();

                    if (address != "")
                    {
                        address = "Адрес прописки: " + address;
                    }
                    mainForm.DescriptionTxtBox.AppendText(date_brs + profession + department + cli_n + gettingdate + mphone + passport + address);
                }
            }
        }
    }
}