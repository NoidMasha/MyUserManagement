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
            RegisterForm r1 = new RegisterForm();
            r1.ShowDialog();
        }
    }
}
