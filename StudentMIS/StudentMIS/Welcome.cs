namespace StudentMIS
{
    public partial class Welcome : Form
    {
        public static Login loginForm;
        public static Update updateForm;
        public static Browser browserForm;
        public Welcome()
        {
            InitializeComponent();
            loginForm = new Login();
            browserForm = new Browser();
            updateForm = new Update();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            loginForm.Show();
            this.Hide();
        }
    }
}