using System;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class LoginForm : Form
    {
        adminData admin = new adminData();
        public LoginForm()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void loginBtn_Click(object sender, System.EventArgs e)
        {
            bool result = adminData.LoginVerification(usernameTextbox.Text, passwordTextbox.Text);
            if (result)
            {
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.ShowDialog();
            } else
            {
                MessageBox.Show("Please check your username and password");
            }
        }

        public void showForm()
        {
            this.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

    }
}
