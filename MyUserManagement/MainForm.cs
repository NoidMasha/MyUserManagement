using System.Linq;
namespace MyUserManagement
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();

        }

        public void InitializeMainForm()
        {
            adminToolStripMenuItem.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }";
            }
            else
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure to exit?"
                , "Exit Warning"
                , System.Windows.Forms.MessageBoxButtons.YesNo
                , System.Windows.Forms.MessageBoxIcon.Warning
                , System.Windows.Forms.MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.AuthenticatedUser = null;
            Close();
            Infrastructure.Utility.LoginForm.Show();
        }

        private UpdateProfileForm updateForm;
        private void updateProfileToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (updateForm == null || updateForm.IsDisposed)
            {
                updateForm = new UpdateProfileForm();
                updateForm.MdiParent = this;
            }
            updateForm.Show();
        }

        private ChangePasswordForm changePassForm;
        private void changePasswordToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (changePassForm == null || changePassForm.IsDisposed)
            {
                changePassForm = new ChangePasswordForm();
                changePassForm.MdiParent = this;
            }
            changePassForm.Show();
        }

        private Admin.UsersListForm userListForm;
        private void userListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (userListForm == null || userListForm.IsDisposed)
            {
                userListForm = new Admin.UsersListForm();
                userListForm.MdiParent = this;
            }
            userListForm.Show();
        }

        private void newUserRegToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.AdminRegisterForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            {
                Models.DatabaseContext databaseContext = null;

                try
                {
                    databaseContext = new Models.DatabaseContext();

                    int notActiveUsers = 0;
                    notActiveUsers = databaseContext.Users.Where(current => !current.IsActive).Count();
                        
                    if (notActiveUsers != 0)
                    {
                        if (notActiveUsers == 1)
                        {
                            System.Windows.Forms.MessageBox.Show($"{notActiveUsers} user is waiting for activation!");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"{notActiveUsers} users are waiting for activation!");
                        }
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
        }

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
