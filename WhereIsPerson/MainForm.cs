using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsPerson
{
    public partial class MainForm : Form
    {
        FbConnection dbConnect;

        //метод подключения к базе данных
        private void OpenDBConnection()
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


            }
        }

        public MainForm()
        {
            InitializeComponent();
            OpenDBConnection();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
