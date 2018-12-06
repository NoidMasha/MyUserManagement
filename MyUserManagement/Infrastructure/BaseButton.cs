namespace MyUserManagement.Infrastructure
{
    class BaseButton:System.Windows.Forms.Button
    {
        public BaseButton():base()
        {
            Size = new System.Drawing.Size(75, 25);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseButton
            // 
            this.ResumeLayout(false);

        }
    }
}
