using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        public event EventHandler selectListWorkersRow = null; //выбор работника в списке найденных
        public event EventHandler enableRealTime = null; //включение режима наблюдения за проходами в режиме реального времени

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

        private void RealTimeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            enableRealTime.Invoke(sender, e);
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, UInt32 wParam, UInt32 Param); //непонятная для меня функция для отлова количества строк текста в текстбоксе при wordwrap
        const int EM_GETLINECOUNT = 0x00BA;

        private void ListWorkersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FIOTxtBox.Height == 47) //если менялась высота текстбокса, то устанавливаем значения по умолчанию
            {
                FIOTxtBox.Height = 26;
                DescriptionTxtBox.Location = new Point(6, 28);
            }

            selectListWorkersRow.Invoke(sender, e);

            int LineCount;
            LineCount = SendMessage(FIOTxtBox.Handle, EM_GETLINECOUNT, 0, 0);

            //расширяем высоту текстбокса, если ФИО не влазит и переносится на вторую строку
            if (LineCount == 2)
            {
                FIOTxtBox.Height = 47;
                DescriptionTxtBox.Location = new Point(6, 49); //смещаем нижний текстбокс чуть пониже
            }
        }

        private void ListWorkersDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (FIOTxtBox.Height == 47)
                {
                    FIOTxtBox.Height = 26;
                    DescriptionTxtBox.Location = new Point(6, 28);
                }

                selectListWorkersRow.Invoke(sender, e);

                int LineCount;
                LineCount = SendMessage(FIOTxtBox.Handle, EM_GETLINECOUNT, 0, 0);

                if (LineCount == 2)
                {
                    FIOTxtBox.Height = 47;
                    DescriptionTxtBox.Location = new Point(6, 49);
                }
            }
        }
    }
}
