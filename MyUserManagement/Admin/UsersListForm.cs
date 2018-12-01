﻿using System.Linq;

namespace MyUserManagement.Admin
{
    public partial class UsersListForm : Infrastructure.BaseForm
    {
        public UsersListForm()
        {
            InitializeComponent();
            fullNameTextBox.WaterMarkText = "Part of Username Or fullname";
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            search();
        }


        private void search()
        {
            System.Collections.Generic.List<Models.User> users = null;

            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();

                fullNameTextBox.Text = fullNameTextBox.Text.Trim();

                while (fullNameTextBox.Text.Contains("  "))
                {
                    fullNameTextBox.Text = fullNameTextBox.Text.Replace("  ", " ");
                }

                if (fullNameTextBox.Text == string.Empty)
                {
                    users = databaseContext.Users.OrderBy(current => current.FullName).ToList();
                }
                else
                {
                    users = databaseContext.Users.Where(current =>
                    current.FullName.Contains(fullNameTextBox.Text)
                    || current.Username.Contains(fullNameTextBox.Text))
                    .ToList();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!\n" + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }

            usersListBox.ValueMember = "Id";
            usersListBox.DisplayMember = "DisplayName";
            usersListBox.DataSource = users;
        }

        private void usersListBox_DoubleClick(object sender, System.EventArgs e)
        {
            Models.User selectedUser = usersListBox.SelectedItem as Models.User;

            if (selectedUser != null)
            {
                UpdateUserForm updateUserForm = new UpdateUserForm
                {
                    SelectedUser = selectedUser
                };

                updateUserForm.ShowDialog();

                search();
            }
        }


        private void deleteUserButton_Click(object sender, System.EventArgs e)
        {
            if (usersListBox.SelectedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No user is selected!");

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                foreach (var selectedItem in usersListBox.SelectedItems)
                {
                    Models.User selectedUser = selectedItem as Models.User;

                    if (selectedUser != null)
                    {
                        if (selectedUser.IsAdmin == false)
                        {
                            if (selectedUser.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                            {
                                System.Windows.Forms.MessageBox.Show($"For safty reasons you are not\nallowed to delete your own account!\nAsk another admin to do so.");
                                return;
                            }
                            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show($"Are you sure to delete [{selectedUser.Username}] ?"
                                , "Delete user", System.Windows.Forms.MessageBoxButtons.YesNo
                                , System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                databaseContext.Entry(selectedUser).State = System.Data.Entity.EntityState.Deleted;
                                databaseContext.SaveChanges();
                                System.Windows.Forms.MessageBox.Show($"[{selectedUser.Username}] deleted!");
                            }

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"[{selectedUser.Username}] is an Admin!\nFirst change it to normal user!");
                        }
                    }
                }

                search();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        private void resetPassButton_Click(object sender, System.EventArgs e)
        {
            if (usersListBox.SelectedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No user is selected!");

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                foreach (var selectedItem in usersListBox.SelectedItems)
                {
                    Models.User selectedUser = selectedItem as Models.User;

                    if (selectedUser != null)
                    {
                        if (selectedUser.IsAdmin == false)
                        {
                            if (selectedUser.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                            {
                                System.Windows.Forms.MessageBox.Show($"For safty reasons you are not\nallowed to reset your own Password!\nAsk another admin to do so.");
                                return;
                            }
                            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show($"Are you sure to reset [{selectedUser.Username}] Password?"
                                , "Reset Password", System.Windows.Forms.MessageBoxButtons.YesNo
                                , System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Models.User toResetUser = databaseContext.Users
                                    .Where(current => current.Id == selectedUser.Id).FirstOrDefault();
                                toResetUser.Password = Infrastructure.Utility.getHashSha256("12345678");
                                toResetUser.NeedPassChange = true;
                                databaseContext.SaveChanges();
                                System.Windows.Forms.MessageBox.Show($"[{selectedUser.Username}] password reset to 12345678");
                            }
                            
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"[{selectedUser.Username}] is an Admin!\nFirst change it to normal user!");
                        }
                    }
                }

                search();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

    }
}
