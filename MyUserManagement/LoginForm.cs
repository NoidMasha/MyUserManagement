using System.Linq;
namespace MyUserManagement
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            usernameTextBox.WaterMarkText = "Username";
            passwordTextBox.WaterMarkText = "Password";
        }

        public string usernameText
        {
            set
            {
                usernameTextBox.Text = value;
            }
        }
        public void clearPassword()
        {
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            Infrastructure.Utility.RegisterForm.Show();
        }

        private void showPictureBox_Down(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }
        private void showPictureBox_Up(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {

                System.Windows.Forms.MessageBox.Show("Username and Password are required!");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Clear();
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundedUser =
                    databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Username or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(foundedUser.Password, Infrastructure.Utility.getHashSha256(passwordTextBox.Text), ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Username or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox.Show("You can not login to this application! Please contact administrator!");

                    usernameTextBox.Focus();

                    return;
                }

                passwordTextBox.Clear();
                Hide();

                Infrastructure.Utility.AuthenticatedUser = foundedUser;

                if (foundedUser.NeedPassChange)
                {
                    ChangePasswordForm changePass = new ChangePasswordForm();
                    changePass.ShowDialog();
                }

                
                Infrastructure.Utility.MainForm.InitializeMainForm();
                Infrastructure.Utility.MainForm.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
