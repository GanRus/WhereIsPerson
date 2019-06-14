using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.IO;

namespace WhereIsPerson
{
    class Model
    {
        //static FbConnection dbConnect;
        public bool connection_on;
        public string ip_addr;
        public string user;
        public string pass;
        public string pathDB;
        public string codepage;

        #region Соединение с базой данных
        public FbConnection dbConnect;
        //метод подключения к базе данных
        public void OpenDBConnection(string source, string db, string user, string pass, string codepage)
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
                //MessageBox.Show(ex.Message + " " + ip_addr + " " + pathDB + " " + user + " " + pass);
                //тут надо что то придумать     
            }
        }

        // состояние подключения
        public bool GetConnectionState()
        {
            connection_on = false;

            try
            {
                if (dbConnect.State == ConnectionState.Open)
                {
                    connection_on = true;
                    return connection_on;
                }
            }
            catch (Exception)
            {
                //Log(ex);
            }

            return connection_on;
        }
        #endregion

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

        #region Работа с конфигурационным файлом
        //метод считывания настроек с конфигурационного файла
        public bool OpenConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";

            if (File.Exists(path))
            {
                //string[] settings = File.ReadAllLines(path);

                ip_addr = GetString(path, "IPADDR");
                user = GetString(path, "USER");
                pass = GetString(path, "PASS");
                pathDB = GetString(path, "PATH");
                codepage = GetString(path, "CODE");

                if (ip_addr != "" && user != "" && pass != "" && pathDB != "" && codepage != "")
                {
                    return true;
                }
            }

            return false;
        }

        private string GetString(string fileName, string keyWord)
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
        public void SaveConfigFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";
            //MessageBox.Show(path);

            //массив настроек
            string[] settings = new String[5];

            settings[0] = "IPADDR=" + ip_addr;
            settings[1] = "USER=" + user;
            settings[2] = "PASS=" + pass;
            settings[3] = "PATH=" + pathDB;
            settings[4] = "CODE=" + codepage;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, settings);
        }
        #endregion
    }
}
