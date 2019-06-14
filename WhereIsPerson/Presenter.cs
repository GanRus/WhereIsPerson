namespace WhereIsPerson
{
    class Presenter
    {
        private MainForm mainForm;
        Model model = null;

        public Presenter(MainForm mainForm)
        {
            this.mainForm = mainForm;
            model = new Model();
            this.mainForm.loadMainForm += MainForm_loadMainForm;
        }

        private void MainForm_loadMainForm(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}