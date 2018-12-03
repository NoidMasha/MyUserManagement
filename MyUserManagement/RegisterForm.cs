using System.Linq;

namespace MyUserManagement
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            //usernameTextBox.WaterMarkText = "6-20 Letters Or/And Numbers Or/And _";
            //passwordTextBox.WaterMarkText = "8-40 Letters & Numbers & UpperCase";
            //confirmPassTextBox.WaterMarkText = "Retype Password";
            //fullnameTextBox.WaterMarkText = "Maximum 50 Letters";
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            confirmPassTextBox.Clear();
            fullnameTextBox.Clear();

            usernameTextBox.Focus();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            Close();
            Infrastructure.Utility.LoginForm.Show();
        }

        private void usernameTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.validUsername(usernameTextBox.Text, 6, 20))
            {
                Models.DatabaseContext databaseContext = null;
                try
                {
                    databaseContext =
                    new Models.DatabaseContext();
                    Models.User user =
                        databaseContext.Users
                        .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                        .FirstOrDefault();

                    if (user == null)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        baseLabel4.Visible = false;
                        if (pictureBox3.Visible && !string.IsNullOrWhiteSpace(fullnameTextBox.Text))
                        {
                            registerButton.Enabled = true;
                        }
                        return;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        baseLabel4.Visible = true;
                        registerButton.Enabled = false;
                    }
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
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            enableRegisterButton();
        }

        private void passwordTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.validPassword(passwordTextBox.Text, 8, 40))
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;

                confirmPassTextbox_KeyUp(null, null);
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            enableRegisterButton();
        }

        private void confirmPassTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if ((passwordTextBox.Text.Length == confirmPassTextBox.Text.Length &&
                !string.IsNullOrWhiteSpace(passwordTextBox.Text)) ||
                pictureBox5.Visible || pictureBox6.Visible)
            {
                if (string.Compare(passwordTextBox.Text, confirmPassTextBox.Text, false) == 0)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                }
                else
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                }
            }
            enableRegisterButton();
        }

        private void enableRegisterButton()
        {
            registerButton.Enabled = pictureBox1.Visible && pictureBox3.Visible && pictureBox5.Visible;
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (fullnameTextBox.Text.Length > 50)
            {
                errorMessages = "FullName can be maximum 50 characters!";
            }

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);
                return;
            }

            Models.DatabaseContext databaseContext = null;
            try
            {
                fullnameTextBox.Text = fullnameTextBox.Text.Trim();
                while (fullnameTextBox.Text.Contains("  "))
                {
                    fullnameTextBox.Text = fullnameTextBox.Text.Replace("  ", " ");
                }
                fullnameTextBox.Invalidate();

                databaseContext = new Models.DatabaseContext();

                Models.User user = new Models.User
                {
                    FullName = fullnameTextBox.Text,
                    Password = Infrastructure.Utility.getHashSha256(passwordTextBox.Text),
                    Username = usernameTextBox.Text,

                    NeedPassChange = false,
                    IsActive = false
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registration Done!");

                Close();
                Infrastructure.Utility.LoginForm.usernameText = user.Username;
                Infrastructure.Utility.LoginForm.Show();

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
