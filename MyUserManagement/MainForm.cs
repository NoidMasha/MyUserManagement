namespace MyUserManagement
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, System.EventArgs e)
        {
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.RegisterForm.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.RegisterForm.MdiParent = this;
            Infrastructure.Utility.RegisterForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Infrastructure.Utility.RegisterForm.Location = new System.Drawing.Point((this.ClientSize.Width - Infrastructure.Utility.RegisterForm.Width) / 2,
                (this.ClientSize.Height - Infrastructure.Utility.RegisterForm.Height) / 3);
            Infrastructure.Utility.RegisterForm.Show();
            Infrastructure.Utility.LoginForm.Hide();
            //Infrastructure.Utility.RegisterForm.Focus();
        }

        private void loginToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.LoginForm.MdiParent = this;
            Infrastructure.Utility.LoginForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Infrastructure.Utility.LoginForm.Location = new System.Drawing.Point((this.ClientSize.Width - Infrastructure.Utility.LoginForm.Width) / 2,
                (this.ClientSize.Height - Infrastructure.Utility.LoginForm.Height) / 3);
            Infrastructure.Utility.LoginForm.Show();
            Infrastructure.Utility.RegisterForm.Hide();
            //Infrastructure.Utility.LoginForm.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.AuthenticatedUser = null;
        }
    }
}
