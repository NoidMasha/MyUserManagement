using System.Linq;

namespace MyUserManagement
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            usernameTextbox.WaterMarkText = "6-20 Letters Or/And Numbers Or/And _";
            passwordTextbox.WaterMarkText = "8-40 Letters & Numbers & UpperCase";
            fullnameTextbox.WaterMarkText = "Maximum 50 Letters";
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextbox.Text = string.Empty;
            passwordTextbox.Text = string.Empty;
            fullnameTextbox.Text = string.Empty;

            usernameTextbox.Focus();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            Infrastructure.Utility.LoginForm.Show();
        }

        private void usernameTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.validUsername(usernameTextbox.Text, 6, 20))
            {
                Models.DatabaseContext databaseContext = null;
                try
                {
                    databaseContext =
                    new Models.DatabaseContext();
                    Models.User user =
                        databaseContext.Users
                        .Where(current => string.Compare(current.Username, usernameTextbox.Text, true) == 0)
                        .FirstOrDefault();

                    if (user == null)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        if (pictureBox3.Visible && !string.IsNullOrWhiteSpace(fullnameTextbox.Text))
                        {
                            registerButton.Enabled = true;
                        }
                        return;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
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
        }

        private void passwordTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.validPassword(passwordTextbox.Text, 8, 40))
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                if (pictureBox1.Visible && !string.IsNullOrWhiteSpace(fullnameTextbox.Text))
                {
                    registerButton.Enabled = true;
                }
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void fullnameTextbox_KeyUp(object sender, System.EventArgs e)
        {
            if (pictureBox1.Visible && pictureBox3.Visible && !string.IsNullOrWhiteSpace(fullnameTextbox.Text))
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                fullnameTextbox.Text = fullnameTextbox.Text.Trim();
                while (fullnameTextbox.Text.Contains("  "))
                {
                    fullnameTextbox.Text = fullnameTextbox.Text.Replace("  ", " ");
                }
                fullnameTextbox.Invalidate();

                databaseContext = new Models.DatabaseContext();

                Models.User user = new Models.User
                {
                    FullName = fullnameTextbox.Text,
                    Password = passwordTextbox.Text,
                    Username = usernameTextbox.Text,

                    IsActive = true
                };

                databaseContext.Users.Add(user);

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registration Done!");

                resetButton_Click(null, null);
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
