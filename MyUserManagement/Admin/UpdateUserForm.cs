using System.Linq;


namespace MyUserManagement.Admin
{
    public partial class UpdateUserForm : Infrastructure.BaseForm
    {
        public UpdateUserForm()
        {
            InitializeComponent();
            descriptionTextBox.WaterMarkText = string.Empty;
        }

        public Models.User SelectedUser { get; set; }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void UpdateUserForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User foundedUser = databaseContext.Users.Where(current => current.Id == SelectedUser.Id).FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such user anymore!");
                    Close();
                }
                else
                {
                    fullNameTextBox.Text = foundedUser.FullName;
                    descriptionTextBox.Text = foundedUser.Description;
                    this.Text = this.Text + "  !!! " + foundedUser.Username + " !!!   info";
                    activeCheckBox.Checked = foundedUser.IsActive;
                    adminCheckBox.Checked = foundedUser.IsAdmin;
                }
                if (foundedUser.IsAdmin && foundedUser.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                {
                    adminCheckBox.Enabled = false;
                    activeCheckBox.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!\n" + ex.Message);
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

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (fullNameTextBox.Text.Length > 50)
            {
                errorMessages = "FullName can be maximum 50 characters!";
            }

            if (descriptionTextBox.Text.Length > 200)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Description can be maximum 200 characters!";
            }

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);
                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User foundedUser = databaseContext.Users.Where(current => current.Id == SelectedUser.Id).FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such user anymore!");
                    Close();
                }
                else
                {
                    foundedUser.FullName = fullNameTextBox.Text;
                    foundedUser.Description = descriptionTextBox.Text;
                    foundedUser.IsActive = activeCheckBox.Checked;
                    foundedUser.IsAdmin = adminCheckBox.Checked;

                    databaseContext.SaveChanges();
                    System.Windows.Forms.MessageBox.Show("Update succesful!");
                    Close();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!\n" + ex.Message);
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
