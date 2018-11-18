using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyUserManagement
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTextbox.Text = string.Empty;
            passwordTextbox.Text = string.Empty;

            usernameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Hide();
            Infrastructure.Utility.RegisterForm.Show();
        }
    }
}
