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
    }
}
