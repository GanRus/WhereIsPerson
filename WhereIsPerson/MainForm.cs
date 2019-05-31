using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsPerson
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();


            //соединяем с базой данных
            DataBase.OpenDBConnection();

            if (DataBase.GetConnectionState())
            {
                MessageLbl.Text = "Соединение с БД успешно установлено!";
            }
            else
            {
                MessageLbl.Text = "Не удалось соединиться с указанной базой данных! Проверьте настройки подключения!";
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

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }
    }

    public static class DataBase //класс для работы с базой данных
    {
        static FbConnection dbConnect;
        //метод подключения к базе данных
        public static void OpenDBConnection()
        // private void OpenDBConnection(string source, string db, string user, string pass)
        {
            try
            {
                FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

                //cs.DataSource = source;
                //cs.Database = db;
                //cs.UserID = user;
                //cs.Dialect = 3;

                cs.DataSource = "localhost";
                cs.Database = "C:\\codos\\WorkDB\\CODOS.GDB";
                cs.UserID = "SYSDBA";
                cs.Password = "masterkey";
                cs.Dialect = 3;

                string dbsource = cs.ToString();

                dbConnect = new FbConnection(dbsource);
                dbConnect.Open();
            }
            catch (Exception)
            {
                dbConnect = null;
                //тут надо что то придумать     
            }
        }

        // состояние подключения
        public static bool GetConnectionState()
        {
            GlobalVariable.connection_on = false;

            try
            {
                if (dbConnect.State == ConnectionState.Open)
                {
                    GlobalVariable.connection_on = true;
                    return GlobalVariable.connection_on;
                }
            }
            catch (Exception ex)
            {
                //Log(ex);
            }

            return GlobalVariable.connection_on;
        }

    }

    public static class ConfigFile //класс работы с конфигурационным файлом
    {
        //метод считывания настроек с конфигурационного файла
        public static void OpenConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            if (File.Exists(path))
            {
                string[] settings = File.ReadAllLines(path);

                for (int i = 0; i < settings.Length; i++)
                {
                    settings[i] = settings[i].Substring(settings[i].IndexOf('=') + 1);
                }
                GlobalVariable.ip_addr = settings[0];
                GlobalVariable.user = settings[1];
                GlobalVariable.pass = settings[2];
                GlobalVariable.pathDB = settings[3];
            }
        }

        //метод сохранения настроек в конфигурационном файле
        public static void SaveConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            //MessageBox.Show(path);

            //массив настроек
            string[] settings = new String[4];

            settings[0] = "IPADDR=" + GlobalVariable.ip_addr;
            settings[1] = "USER=" + GlobalVariable.user;
            settings[2] = "PASS=" + GlobalVariable.pass;
            settings[3] = "PATH=" + GlobalVariable.pathDB;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, settings);
        }
    }

    public static class GlobalVariable //класс для хранения глобальных переменных
    {
        //static FbConnection dbConnect;
        public static bool connection_on;
        public static string ip_addr;
        public static string user;
        public static string pass;
        public static string pathDB;
    }
}
