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
        public event EventHandler loadMainForm = null; // событие загрузки главной формы
        public event EventHandler activeMainForm = null; //событие активации формы
        public event EventHandler pressSearchBtn = null; //нажатие кнопки поиска

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
            pressSearchBtn.Invoke(sender, e);
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
            activeMainForm.Invoke(sender, e);
        }

        private void ProfCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProf = ProfCmbBox.SelectedItem.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadMainForm.Invoke(sender, e);
        }
    }
}
