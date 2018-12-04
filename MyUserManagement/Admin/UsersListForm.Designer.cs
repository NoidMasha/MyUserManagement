namespace MyUserManagement.Admin
{
    partial class UsersListForm
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
            this.fullNameLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.fullNameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.usersListBox = new MyUserManagement.Infrastructure.BaseListBox();
            this.searchButton = new MyUserManagement.Infrastructure.BaseButton();
            this.deleteUserButton = new MyUserManagement.Infrastructure.BaseButton();
            this.resetPassButton = new MyUserManagement.Infrastructure.BaseButton();
            this.adminComboBox = new System.Windows.Forms.ComboBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.activeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(10, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "&Full Name";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(79, 12);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(240, 21);
            this.fullNameTextBox.TabIndex = 1;
            this.fullNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.fullNameTextBox.WaterMarkText = "Part of Username Or fullname";
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(13, 88);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(387, 238);
            this.usersListBox.TabIndex = 2;
            this.usersListBox.DoubleClick += new System.EventHandler(this.usersListBox_DoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(325, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(13, 338);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "&Delete Users";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // resetPassButton
            // 
            this.resetPassButton.Location = new System.Drawing.Point(94, 338);
            this.resetPassButton.Name = "resetPassButton";
            this.resetPassButton.Size = new System.Drawing.Size(115, 23);
            this.resetPassButton.TabIndex = 4;
            this.resetPassButton.Text = "&Reset Password";
            this.resetPassButton.UseVisualStyleBackColor = true;
            this.resetPassButton.Click += new System.EventHandler(this.resetPassButton_Click);
            // 
            // adminComboBox
            // 
            this.adminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminComboBox.FormattingEnabled = true;
            this.adminComboBox.Items.AddRange(new object[] {
            "All",
            "Admins",
            "Not Admins"});
            this.adminComboBox.Location = new System.Drawing.Point(299, 52);
            this.adminComboBox.Name = "adminComboBox";
            this.adminComboBox.Size = new System.Drawing.Size(101, 21);
            this.adminComboBox.TabIndex = 5;
            this.adminComboBox.SelectedIndexChanged += new System.EventHandler(this.adminComboBox_SelectedIndexChanged);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(250, 55);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(43, 13);
            this.adminLabel.TabIndex = 6;
            this.adminLabel.Text = "Admin";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(77, 55);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(42, 13);
            this.activeLabel.TabIndex = 7;
            this.activeLabel.Text = "Active";
            // 
            // activeComboBox
            // 
            this.activeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeComboBox.FormattingEnabled = true;
            this.activeComboBox.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.activeComboBox.Location = new System.Drawing.Point(125, 52);
            this.activeComboBox.Name = "activeComboBox";
            this.activeComboBox.Size = new System.Drawing.Size(101, 21);
            this.activeComboBox.TabIndex = 8;
            this.activeComboBox.SelectedIndexChanged += new System.EventHandler(this.activeComboBox_SelectedIndexChanged);
            // 
            // UsersListForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(412, 374);
            this.Controls.Add(this.activeComboBox);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.adminComboBox);
            this.Controls.Add(this.resetPassButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(428, 412);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 412);
            this.Name = "UsersListForm";
            this.ShowIcon = false;
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel fullNameLabel;
        private Infrastructure.BaseTextBox fullNameTextBox;
        private Infrastructure.BaseListBox usersListBox;
        private Infrastructure.BaseButton searchButton;
        private Infrastructure.BaseButton deleteUserButton;
        private Infrastructure.BaseButton resetPassButton;
        private System.Windows.Forms.ComboBox adminComboBox;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.ComboBox activeComboBox;
    }
}
