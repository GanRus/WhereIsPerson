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
            new SettingsPresenter(this);
            
        }

        public event EventHandler loadSettingsForm = null; // событие загрузки формы настроек
        public event EventHandler pressOKBtn = null; // нажатие кнопки ОК

        private void openFileDialogBtn_Click(object sender, EventArgs e)
        {
            openFileDBDialog.ShowDialog();
            pathToDBtxt.Text = Path.GetFullPath(openFileDBDialog.FileName);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            pressOKBtn.Invoke(sender, e);

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            loadSettingsForm.Invoke(sender, e);
        }
    }
}
