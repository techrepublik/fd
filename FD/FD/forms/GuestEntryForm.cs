using System;
using System.Windows.Forms;
using FD.dal.data;
using FD.dal.man;

namespace FD.forms
{
    public partial class GuestEntryForm : Form
    {
        private int _iiResult;
        public GuestEntryForm()
        {
            InitializeComponent();
        }

        private void GuestEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void jTabWizard1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    buttonNext.Enabled = guestNameTextBox.Text.Length > 0;
                    break;
                case 1:
                    label5.Text = guestNameTextBox.Text.ToUpper();
                    break;
                default:
                    break;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (jTabWizard1.SelectedIndex <= 0) return;
            jTabWizard1.SelectTab(jTabWizard1.SelectedIndex - 1);
            selectTab();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (jTabWizard1.SelectedIndex >= jTabWizard1.TabCount - 1) return;
            jTabWizard1.SelectTab(jTabWizard1.SelectedIndex + 1);
            selectTab();
        }

        private void selectTab()
        {
            switch (jTabWizard1.SelectedIndex)
            {
                case 0:
                    label2.BorderStyle = BorderStyle.FixedSingle;
                    label3.BorderStyle = BorderStyle.None;
                    break;
                case 1:
                    label2.BorderStyle = BorderStyle.None;
                    label3.BorderStyle = BorderStyle.FixedSingle;
                    break;
                default:
                    break;
            }
        }

        private void guestNameTextBox_TextChanged(object sender, EventArgs e)
        {
            label5.Text = guestNameTextBox.Text.ToUpper();
        }

        private int SaveGuest()
        {
            var iResult = 0;
            if (guestNameTextBox.Text.Length > 0)
            {
                if (guestBindingSource == null) return iResult;
                Validate();
                guestBindingSource.EndEdit();
                iResult = GuestManager.Save((Guest) guestBindingSource.Current);
            }
            else
            {
                MessageBox.Show(@"Don't leave the Guest Name empty.", @"Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _iiResult = iResult;
            return iResult;
        }

        private bool SaveTransaction()
        {
            var bResult = false;
            if (guestNameTextBox.Text.Length > 0)
            {
                if (transactionBindingSource == null) return false;
                Validate();
                transactionBindingSource.EndEdit();
                var iResult = TransactionManager.Save((Transaction)guestBindingSource.Current);
                if (iResult > 0)
                {
                    bResult = true;
                }
            }
            else
            {
                MessageBox.Show(@"There were no guest record found.", @"Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return bResult;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveGuest() <= 0) return;
            if (SaveTransaction())
            {
                MessageBox.Show(@"Transaction was successfully saved.", @"Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Transaction was not saved. Please verify inputs and try again.", @"Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
