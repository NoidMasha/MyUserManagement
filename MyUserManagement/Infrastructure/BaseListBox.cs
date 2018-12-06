namespace MyUserManagement.Infrastructure
{
    class BaseListBox: System.Windows.Forms.ListBox
    {
        public BaseListBox():base()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseListBox
            // 
            this.ResumeLayout(false);

        }
    }
}
