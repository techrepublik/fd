using FD.dal.data;
using FD.dal.man;
using System;
using System.Windows.Forms;

namespace FD.forms
{
    public partial class PreferencesForm : Form
    {

        enum Tab
        {
            TransactionType,
            UserLeve
        };

        Tab _tabChoice;
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void transactionTypeDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (transactionTypeBindingSource == null) return;
            if (transactionTypeDataGridView.Rows.Count <= 1) return;
            if (!transactionTypeDataGridView.IsCurrentRowDirty) return;
            Validate();
            transactionTypeBindingSource.EndEdit();
            var iResult = TransactionTypeManager.Save((TransactionType)transactionTypeBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Transation Type was saved successfully." : @"Error occurred when saving Transaction Type.";
        }

        private void DeleteTransactionType()
        {
            if (transactionTypeBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (TransactionTypeManager.Delete(((TransactionType)transactionTypeBindingSource.Current)))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        transactionTypeBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        transactionTypeDataGridView.Focus();
                    }
                }
            }
        }

        private void DeleteUserLevel()
        {
            if (userLevelBindingSource != null)
            {
                var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (UserLevelManager.Delete(((UserLevel)userLevelBindingSource.Current)))
                    {
                        MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        userLevelBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        userLevelDataGridView.Focus();
                    }
                }
            }
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            transactionTypeBindingSource.DataSource = TransactionTypeManager.GetAll();
            userLevelBindingSource.DataSource = UserLevelManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void userLevelDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (userLevelBindingSource == null) return;
            if (userLevelDataGridView.Rows.Count <= 1) return;
            if (!userLevelDataGridView.IsCurrentRowDirty) return;
            Validate();
            userLevelBindingSource .EndEdit();
            var iResult = UserLevelManager.Save((UserLevel)userLevelBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"User Level Type was saved successfully." : @"Error occurred when saving User Level.";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _tabChoice = Tab.TransactionType;
                    transactionTypeBindingNavigator.BindingSource = transactionTypeBindingSource;
                    break;
                case 1:
                    _tabChoice = Tab.UserLeve;
                    transactionTypeBindingNavigator.BindingSource = userLevelBindingSource;
                    break;
                default:
                    break;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            switch (_tabChoice)
            {
                case Tab.TransactionType:
                    DeleteTransactionType();
                    break;
                case Tab.UserLeve:
                    DeleteUserLevel();
                    break;
                default:
                    break;
            }
        }
    }
}
