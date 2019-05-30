using System;
using System.Windows.Forms;
using System.IO;

namespace WhereIsPerson
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            OpenConfigFile();

        }

        //метод считывания настроек с конфигурационного файла
        private void OpenConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            if (File.Exists(path))
            {
                string[] settings = File.ReadAllLines(path);

                for (int i = 0; i < settings.Length; i++)
                {
                    settings[i] = settings[i].Substring(settings[i].IndexOf('=') + 1);
                }
                ipTxt.Text = settings[0];
                userTxt.Text = settings[1];
                passTxt.Text = settings[2];
                pathToDBtxt.Text = settings[3];
            }
        }

        //метод сохранения настроек в конфигурационном файле
        private void SaveConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            //MessageBox.Show(path);

            //массив настроек
            string[] settings = new String[4];

            settings[0] = "IPADDR=" + ipTxt.Text;
            settings[1] = "USER=" + userTxt.Text;
            settings[2] = "PASS=" + passTxt.Text;
            settings[3] = "PATH=" + pathToDBtxt.Text;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, settings);
        }

        private void openFileDialogBtn_Click(object sender, EventArgs e)
        {
            openFileDBDialog.ShowDialog();
            pathToDBtxt.Text = Path.GetFullPath(openFileDBDialog.FileName);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            SaveConfigFile();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
