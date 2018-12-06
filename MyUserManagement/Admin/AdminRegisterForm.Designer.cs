namespace MyUserManagement
{
    partial class AdminRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegisterForm));
            this.baseLabel1 = new MyUserManagement.Infrastructure.BaseLabel();
            this.baseLabel3 = new MyUserManagement.Infrastructure.BaseLabel();
            this.usernameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.fullnameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.registerButton = new MyUserManagement.Infrastructure.BaseButton();
            this.resetButton = new MyUserManagement.Infrastructure.BaseButton();
            this.cancelButton = new MyUserManagement.Infrastructure.BaseButton();
            this.baseLabel4 = new MyUserManagement.Infrastructure.BaseLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminCheckBox = new MyUserManagement.Infrastructure.BaseCheckBox();
            this.activeCheckBox = new MyUserManagement.Infrastructure.BaseCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // baseLabel3
            // 
            this.baseLabel3.AutoSize = true;
            this.baseLabel3.Location = new System.Drawing.Point(22, 57);
            this.baseLabel3.Name = "baseLabel3";
            this.baseLabel3.Size = new System.Drawing.Size(64, 13);
            this.baseLabel3.TabIndex = 2;
            this.baseLabel3.Text = "&FullName:";
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
            this.usernameTextBox.WaterMarkText = "6-20 Letters Or/And Numbers Or/And _";
            this.usernameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameTextbox_KeyUp);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameTextBox.Location = new System.Drawing.Point(92, 54);
            this.fullnameTextBox.MaxLength = 50;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(244, 21);
            this.fullnameTextBox.TabIndex = 3;
            this.fullnameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.fullnameTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(17, 151);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 25);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Re&gister";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(181, 151);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(262, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // baseLabel4
            // 
            this.baseLabel4.AutoSize = true;
            this.baseLabel4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            this.baseLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.baseLabel4.Location = new System.Drawing.Point(89, 33);
            this.baseLabel4.Name = "baseLabel4";
            this.baseLabel4.Size = new System.Drawing.Size(185, 13);
            this.baseLabel4.TabIndex = 9;
            this.baseLabel4.Text = "This Username already exist!!!";
            this.baseLabel4.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(92, 116);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(62, 17);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "&Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckBox.Location = new System.Drawing.Point(92, 92);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.activeCheckBox.TabIndex = 4;
            this.activeCheckBox.Text = "Ac&tive";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminRegisterForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(354, 189);
            this.ControlBox = false;
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.baseLabel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.baseLabel3);
            this.Controls.Add(this.baseLabel1);
            this.MaximumSize = new System.Drawing.Size(470, 228);
            this.MinimumSize = new System.Drawing.Size(370, 228);
            this.Name = "AdminRegisterForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel baseLabel1;
        private Infrastructure.BaseLabel baseLabel3;
        private Infrastructure.BaseTextBox usernameTextBox;
        private Infrastructure.BaseTextBox fullnameTextBox;
        private Infrastructure.BaseButton registerButton;
        private Infrastructure.BaseButton resetButton;
        private Infrastructure.BaseButton cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Infrastructure.BaseLabel baseLabel4;
        private Infrastructure.BaseCheckBox adminCheckBox;
        private Infrastructure.BaseCheckBox activeCheckBox;
    }
}
