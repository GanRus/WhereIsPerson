using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsPerson
{
    class SettingsPresenter
    {
        private SettingsForm setForm;
      
        Model model = null;

        public SettingsPresenter(SettingsForm setForm)
        {
            this.setForm = setForm;
            
            model = new Model();

            this.setForm.loadSettingsForm += SetForm_loadSettingsForm;
            this.setForm.pressOKBtn += SetForm_pressOKBtn;
        }

        private void SetForm_pressOKBtn(object sender, EventArgs e)
        {
            model.ip_addr = setForm.ipTxt.Text;
            model.user = setForm.userTxt.Text;
            model.pass = setForm.passTxt.Text;
            model.pathDB = setForm.pathToDBtxt.Text;
            model.codepage = setForm.codeTxt.Text;

            model.SaveConfigFile();

            //model.OpenDBConnection(model.ip_addr, model.pathDB, model.user, model.pass, model.codepage);

            //if (model.GetConnectionState())
            //{
            //    mainForm.MessageLbl.ForeColor = Color.Green;
            //    mainForm.MessageLbl.Text = "Соединение с БД успешно установлено";
            //}
            //else
            //{
            //    mainForm.MessageLbl.ForeColor = Color.Red;
            //    mainForm.MessageLbl.Text = "Не удалось установить соединение с БД. Проверьте настройки подключения";
            //}
        }

        private void SetForm_loadSettingsForm(object sender, EventArgs e)
        {

            model.OpenConfigFile();

            setForm.ipTxt.Text = model.ip_addr;
            setForm.userTxt.Text = model.user;
            setForm.passTxt.Text = model.pass;
            setForm.pathToDBtxt.Text = model.pathDB;
            setForm.codeTxt.Text = model.codepage;
        }
    }
}
