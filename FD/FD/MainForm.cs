using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FD.forms;

namespace FD
{
    public partial class MainForm : Form
    {

        private TransactionListForm _transactionListForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void guestEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _transactionListForm = new TransactionListForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            _transactionListForm.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PreferencesForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            f.ShowDialog();
        }
    }
}
