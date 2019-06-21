using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace WhereIsPerson
{
    class Model
    {
        #region Соединение с базой данных

        public bool connection_on;
        public string ip_addr;
        public string user;
        public string pass;
        public string pathDB;
        public string codepage;
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

                if (GetConnectionState()) //если уже было подключение, закрываем его
                {
                    dbConnect.Close();
                }

                dbConnect = new FbConnection(dbsource);
                dbConnect.Open();
            }
            catch (Exception ex)
            {
                dbConnect = null;
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

        #region Работа с базой данных

        public DataTable GetData(string query)
        {
            using (FbDataAdapter da = new FbDataAdapter(query, dbConnect))
            {
                DataTable resultTable = new DataTable();

                da.Fill(resultTable);

                return resultTable;
            }
        }

        //обрезает строку в DataTable в указанном столбце по указанному делителю
        public DataTable CutData(DataTable source, int numColumn, string delimeter)
        {
            string tempStr;

            for (int i = 0; i < source.Rows.Count; i++)
            {
                tempStr = source.Rows[i].Field<string>(numColumn);
                tempStr = tempStr.Substring(0, tempStr.IndexOf(delimeter));
                source.Rows[i].SetField(numColumn, tempStr);
            }

            return source;
        }

        public bool GetPhoto(string query, string id, string namecolumn)
        {
            string path = Directory.GetCurrentDirectory() + "\\config.cfg";

            using (FbDataAdapter da = new FbDataAdapter(query, dbConnect))
            {
                FbCommand command = new FbCommand(query, dbConnect);
                FbDataReader rdr = command.ExecuteReader();

                if (rdr.Read())
                {
                    using (MemoryStream ms = new MemoryStream((byte[])rdr[namecolumn]))
                    {
                        File.WriteAllBytes("c:\\temp\\" + id + ".jpg", (byte[])rdr[namecolumn]);
                    }
                    
                    return true;
                }

                return false;
            }
        }

        public Image OpenPhoto(string id)
        {
            FileStream fs = new System.IO.FileStream(@"c:\\temp\\" + id + ".jpg", FileMode.Open, FileAccess.Read);
            Image img = Image.FromStream(fs);
            fs.Close();
            return img;
        }

        #endregion
    }
}
