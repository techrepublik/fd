using FD.dal.man;
using System;
using FD.dal.data;
using System.Windows.Forms;

namespace FD.forms
{
    public partial class UserManagemrnForm : Form
    {
        public UserManagemrnForm()
        {
            InitializeComponent();
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (userBindingSource == null) return;
            userBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }

        private void UserManagemrnForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            userLevelBindingSource.DataSource = UserLevelManager.GetAll();
            userBindingSource.DataSource = UserManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (userLevelIdComboBox.SelectedIndex <= 0) return;
            if (userBindingSource == null) return;
            Validate();
            userBindingSource.EndEdit();
            var iResult = UserManager.Save((User)userBindingSource.Current);
            if (iResult > 0)
            {
                MessageBox.Show(@"Record was successfully saved.", @"Save.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userNameTextBox.Focus();
            }
            else
            {
                MessageBox.Show(@"Error occurred in saving.", @"Save.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userNameTextBox.Focus();
            }
        }

        private void DeleteUser()
        {
            if (userBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (UserManager.Delete(((User)userBindingSource.Current)))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        userBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        userDataGridView.Focus();
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}
