namespace MyUserManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseLabel1 = new MyUserManagement.Infrastructure.BaseLabel();
            this.baseLabel2 = new MyUserManagement.Infrastructure.BaseLabel();
            this.usernameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.passwordTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.registerButton = new MyUserManagement.Infrastructure.BaseButton();
            this.resetButton = new MyUserManagement.Infrastructure.BaseButton();
            this.loginButton = new MyUserManagement.Infrastructure.BaseButton();
            this.exitButton = new MyUserManagement.Infrastructure.BaseButton();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // baseLabel1
            // 
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.Location = new System.Drawing.Point(15, 15);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(70, 13);
            this.baseLabel1.TabIndex = 0;
            this.baseLabel1.Text = "&Username:";
            // 
            // baseLabel2
            // 
            this.baseLabel2.AutoSize = true;
            this.baseLabel2.Location = new System.Drawing.Point(15, 50);
            this.baseLabel2.Name = "baseLabel2";
            this.baseLabel2.Size = new System.Drawing.Size(66, 13);
            this.baseLabel2.TabIndex = 2;
            this.baseLabel2.Text = "&Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(92, 12);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(244, 21);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.usernameTextBox.WaterMarkText = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(92, 47);
            this.passwordTextBox.MaxLength = 64;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(244, 21);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.passwordTextBox.WaterMarkText = "Password";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(181, 84);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 25);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Re&gister";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(99, 84);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(17, 84);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 25);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(262, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 25);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showPictureBox
            // 
            this.showPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.showPictureBox.Image = global::MyUserManagement.Properties.Resources.eye;
            this.showPictureBox.Location = new System.Drawing.Point(316, 49);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(18, 18);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPictureBox.TabIndex = 8;
            this.showPictureBox.TabStop = false;
            this.showPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPictureBox_Down);
            this.showPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPictureBox_Up);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(354, 122);
            this.ControlBox = false;
            this.Controls.Add(this.showPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.baseLabel2);
            this.Controls.Add(this.baseLabel1);
            this.MaximumSize = new System.Drawing.Size(470, 160);
            this.MinimumSize = new System.Drawing.Size(370, 160);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel baseLabel1;
        private Infrastructure.BaseLabel baseLabel2;
        private Infrastructure.BaseTextBox usernameTextBox;
        private Infrastructure.BaseTextBox passwordTextBox;
        private Infrastructure.BaseButton registerButton;
        private Infrastructure.BaseButton resetButton;
        private Infrastructure.BaseButton loginButton;
        private Infrastructure.BaseButton exitButton;
        private System.Windows.Forms.PictureBox showPictureBox;
    }
}
