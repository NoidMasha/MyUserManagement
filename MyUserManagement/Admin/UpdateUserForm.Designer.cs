namespace MyUserManagement.Admin
{
    partial class UpdateUserForm
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
            this.cancelButton = new MyUserManagement.Infrastructure.BaseButton();
            this.saveButton = new MyUserManagement.Infrastructure.BaseButton();
            this.adminCheckBox = new MyUserManagement.Infrastructure.BaseCheckBox();
            this.activeCheckBox = new MyUserManagement.Infrastructure.BaseCheckBox();
            this.descriptionTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.fullNameTextBox = new MyUserManagement.Infrastructure.BaseTextBox();
            this.descriptionLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.fullNameLabel = new MyUserManagement.Infrastructure.BaseLabel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(205, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(297, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(12, 242);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(62, 17);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "&Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(12, 218);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.activeCheckBox.TabIndex = 4;
            this.activeCheckBox.Text = "Ac&tive";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 45);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(283, 214);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.descriptionTextBox.WaterMarkText = "Maximum 200 Letters";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(89, 12);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(283, 21);
            this.fullNameTextBox.TabIndex = 2;
            this.fullNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.fullNameTextBox.WaterMarkText = "Maximum 50 Letters";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 45);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "&Description";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "&Full Name";
            // 
            // UpdateUserForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(387, 326);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.fullNameLabel);
            this.MaximumSize = new System.Drawing.Size(403, 364);
            this.MinimumSize = new System.Drawing.Size(403, 364);
            this.Name = "UpdateUserForm";
            this.Text = "Update ";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infrastructure.BaseLabel fullNameLabel;
        private Infrastructure.BaseLabel descriptionLabel;
        private Infrastructure.BaseTextBox fullNameTextBox;
        private Infrastructure.BaseTextBox descriptionTextBox;
        private Infrastructure.BaseCheckBox activeCheckBox;
        private Infrastructure.BaseCheckBox adminCheckBox;
        private Infrastructure.BaseButton saveButton;
        private Infrastructure.BaseButton cancelButton;
    }
}
