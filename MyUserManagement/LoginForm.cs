using System.Linq;
namespace MyUserManagement
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            usernameTextbox.WaterMarkText = "Username";
            passwordTextbox.WaterMarkText = "Password";
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextbox.Text = string.Empty;
            passwordTextbox.Text = string.Empty;

            usernameTextbox.Focus();
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

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(usernameTextbox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextbox.Text)))
            {
                //usernameTextBox.Text =
                //	usernameTextBox.Text.Trim();

                //passwordTextBox.Text =
                //	passwordTextBox.Text.Trim();

                usernameTextbox.Text =
                    usernameTextbox.Text.Replace(" ", string.Empty);

                passwordTextbox.Text =
                    passwordTextbox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show("Username and Password are requied!");

                if (usernameTextbox.Text == string.Empty)
                {
                    usernameTextbox.Focus();
                }
                else
                {
                    passwordTextbox.Focus();
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
                    .Where(current => string.Compare(current.Username, usernameTextbox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox
                        .Show("Username or Password is not correct!");

                    usernameTextbox.Focus();

                    return;
                }

                if (string.Compare(foundedUser.Password, Infrastructure.Utility.getHashSha256(passwordTextbox.Text), ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox
                        .Show("Username or Password is not correct!");

                    usernameTextbox.Focus();

                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox
                        .Show("You can not login to this application! Please contact support team.");

                    usernameTextbox.Focus();

                    return;
                }

                resetButton_Click(null, null);
                Hide();
                // **************************************************
                System.Windows.Forms.MessageBox.Show("Welcome "+foundedUser.FullName);
                // **************************************************

                Infrastructure.Utility.AuthenticatedUser = foundedUser;

                

                // **************************************************
                //MainForm mainForm = new MainForm();

                //mainForm.Show();

                //Infrastructure.Utility.MainForm.Show();
                // **************************************************
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
