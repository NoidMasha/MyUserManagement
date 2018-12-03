using System.Linq;

namespace MyUserManagement
{
    public partial class AdminRegisterForm : Infrastructure.BaseForm
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
            //usernameTextBox.WaterMarkText = "6-20 Letters Or/And Numbers Or/And _";
            //fullnameTextBox.WaterMarkText = "Maximum 50 Letters";
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Clear();
            fullnameTextBox.Clear();
            adminCheckBox.Checked = false;
            usernameTextBox.Focus();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
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
                        registerButton.Enabled = true;
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
                registerButton.Enabled = false;
            }
        }
        

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (fullnameTextBox.Text.Length>50)
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
                    Password = Infrastructure.Utility.getHashSha256("12345678"),
                    Username = usernameTextBox.Text,

                    NeedPassChange = true,
                    IsActive = activeCheckBox.Checked,
                    IsAdmin = adminCheckBox.Checked
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registration Done! \nDefault password is: 12345678");

                usernameTextBox.Clear();
                fullnameTextBox.Clear();
                adminCheckBox.Checked = false;
                usernameTextBox.Focus();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

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
