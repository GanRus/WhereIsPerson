using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsPerson
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
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
        public static string codepage;
    }

    public static class DataBase //класс для работы с базой данных
    {
        public static FbConnection dbConnect;
        //метод подключения к базе данных
        public static void OpenDBConnection(string source, string db, string user, string pass, string codepage)
        {
            try
            {
                FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

                cs.DataSource = source;
                cs.Database = db;
                cs.UserID = user;
                cs.Password = pass;
                cs.Dialect = 3;
                cs.Charset = codepage;

                string dbsource = cs.ToString();

                dbConnect = new FbConnection(dbsource);
                dbConnect.Open();
            }
            catch (Exception ex)
            {
                dbConnect = null;
                //MessageBox.Show(ex.Message + " " + GlobalVariable.ip_addr + " " + GlobalVariable.pathDB + " " + GlobalVariable.user + " " + GlobalVariable.pass);
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
            catch (Exception)
            {
                //Log(ex);
            }

            return GlobalVariable.connection_on;
        }

    }

    public static class ConfigFile //класс работы с конфигурационным файлом
    {
        //метод считывания настроек с конфигурационного файла
        public static bool OpenConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";

            if (File.Exists(path))
            {
                //string[] settings = File.ReadAllLines(path);

                GlobalVariable.ip_addr = GetString(path, "IPADDR");
                GlobalVariable.user = GetString(path, "USER");
                GlobalVariable.pass = GetString(path, "PASS");
                GlobalVariable.pathDB = GetString(path, "PATH");
                GlobalVariable.codepage = GetString(path, "CODE");

                if (GlobalVariable.ip_addr != "" && GlobalVariable.user != "" && GlobalVariable.pass != "" && GlobalVariable.pathDB != "" && GlobalVariable.codepage != "")
                {
                    return true;
                }
            }

            return false;
        }

        private static string GetString(string fileName, string keyWord)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(keyWord))
                    {
                        line = line.Substring(line.IndexOf('=') + 1);
                        return line; //поиск до первого найденного совпадения
                    }
                }
            }
            return null; //если слово не нашли вернем null
        }


        //метод сохранения настроек в конфигурационном файле
        public static void SaveConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            //MessageBox.Show(path);

            //массив настроек
            string[] settings = new String[5];

            settings[0] = "IPADDR=" + GlobalVariable.ip_addr;
            settings[1] = "USER=" + GlobalVariable.user;
            settings[2] = "PASS=" + GlobalVariable.pass;
            settings[3] = "PATH=" + GlobalVariable.pathDB;
            settings[4] = "CODE=" + GlobalVariable.codepage;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, settings);
        }
    }
}
