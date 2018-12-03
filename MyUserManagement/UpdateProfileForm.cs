using System.Linq;
namespace MyUserManagement
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
            descriptionTextBox.WaterMarkText = string.Empty;
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User currentUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                fullNameTextBox.Text = currentUser.FullName;
                descriptionTextBox.Text = currentUser.Description;
                saveButton.Focus();
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
                Models.User currentUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                currentUser.FullName = fullNameTextBox.Text;
                currentUser.Description = descriptionTextBox.Text;
                databaseContext.SaveChanges();

                Infrastructure.Utility.AuthenticatedUser = currentUser;

                MainForm mainForm = this.MdiParent as MainForm;
                if (mainForm != null)
                {
                    mainForm.InitializeMainForm();
                }

                System.Windows.Forms.MessageBox.Show("Update Successful.");
                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error:\n" + ex.Message);
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

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }


    }
}