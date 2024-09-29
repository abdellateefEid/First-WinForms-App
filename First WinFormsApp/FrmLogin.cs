namespace First_WinFormsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        Home_page homePage = new Home_page();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //if (txtUserName.Text.Length > 0 && txtUserName.Text == "aa")
            {
                //if (txtPassword.Text.Length >= 3 && txtPassword.Text == "123")
                {
                    this.Hide();
                    homePage.ShowDialog();
                }

            }
        }
    }
}
