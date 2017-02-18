namespace FD.forms
{
    partial class UserManagemrnForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagemrnForm));
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userFullNameLabel;
            System.Windows.Forms.Label userLevelIdLabel;
            System.Windows.Forms.Label userIsActiveLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userFullNameTextBox = new System.Windows.Forms.TextBox();
            this.userLevelIdComboBox = new System.Windows.Forms.ComboBox();
            this.userIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.userLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            userNameLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userFullNameLabel = new System.Windows.Forms.Label();
            userLevelIdLabel = new System.Windows.Forms.Label();
            userIsActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 40);
            this.panel1.TabIndex = 1;
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = null;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(747, 25);
            this.userBindingNavigator.TabIndex = 2;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(12, 93);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 30;
            this.userDataGridView.Size = new System.Drawing.Size(265, 231);
            this.userDataGridView.TabIndex = 5;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User List";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserIsActive";
            this.dataGridViewTextBoxColumn6.HeaderText = "Active";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FD.dal.data.User);
            this.userBindingSource.CurrentChanged += new System.EventHandler(this.userBindingSource_CurrentChanged);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(308, 121);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(394, 118);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(308, 147);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(56, 13);
            userPasswordLabel.TabIndex = 6;
            userPasswordLabel.Text = "Password:";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Location = new System.Drawing.Point(394, 144);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(195, 20);
            this.userPasswordTextBox.TabIndex = 1;
            this.userPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // userFullNameLabel
            // 
            userFullNameLabel.AutoSize = true;
            userFullNameLabel.Location = new System.Drawing.Point(308, 174);
            userFullNameLabel.Name = "userFullNameLabel";
            userFullNameLabel.Size = new System.Drawing.Size(57, 13);
            userFullNameLabel.TabIndex = 8;
            userFullNameLabel.Text = "Full Name:";
            // 
            // userFullNameTextBox
            // 
            this.userFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserFullName", true));
            this.userFullNameTextBox.Location = new System.Drawing.Point(394, 170);
            this.userFullNameTextBox.Name = "userFullNameTextBox";
            this.userFullNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.userFullNameTextBox.TabIndex = 2;
            // 
            // userLevelIdLabel
            // 
            userLevelIdLabel.AutoSize = true;
            userLevelIdLabel.Location = new System.Drawing.Point(308, 202);
            userLevelIdLabel.Name = "userLevelIdLabel";
            userLevelIdLabel.Size = new System.Drawing.Size(39, 13);
            userLevelIdLabel.TabIndex = 10;
            userLevelIdLabel.Text = "Level :";
            // 
            // userLevelIdComboBox
            // 
            this.userLevelIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserLevelId", true));
            this.userLevelIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "UserLevelId", true));
            this.userLevelIdComboBox.DataSource = this.userLevelBindingSource;
            this.userLevelIdComboBox.DisplayMember = "UserLevel1";
            this.userLevelIdComboBox.FormattingEnabled = true;
            this.userLevelIdComboBox.Location = new System.Drawing.Point(394, 196);
            this.userLevelIdComboBox.Name = "userLevelIdComboBox";
            this.userLevelIdComboBox.Size = new System.Drawing.Size(195, 21);
            this.userLevelIdComboBox.TabIndex = 3;
            this.userLevelIdComboBox.ValueMember = "UserLevelId";
            // 
            // userIsActiveLabel
            // 
            userIsActiveLabel.AutoSize = true;
            userIsActiveLabel.Location = new System.Drawing.Point(308, 228);
            userIsActiveLabel.Name = "userIsActiveLabel";
            userIsActiveLabel.Size = new System.Drawing.Size(43, 13);
            userIsActiveLabel.TabIndex = 12;
            userIsActiveLabel.Text = " Active:";
            // 
            // userIsActiveCheckBox
            // 
            this.userIsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "UserIsActive", true));
            this.userIsActiveCheckBox.Location = new System.Drawing.Point(394, 223);
            this.userIsActiveCheckBox.Name = "userIsActiveCheckBox";
            this.userIsActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.userIsActiveCheckBox.TabIndex = 4;
            this.userIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // userLevelBindingSource
            // 
            this.userLevelBindingSource.DataSource = typeof(FD.dal.data.UserLevel);
            // 
            // UserManagemrnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 347);
            this.Controls.Add(userIsActiveLabel);
            this.Controls.Add(this.userIsActiveCheckBox);
            this.Controls.Add(userLevelIdLabel);
            this.Controls.Add(this.userLevelIdComboBox);
            this.Controls.Add(userFullNameLabel);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "UserManagemrnForm";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagemrnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.ComboBox userLevelIdComboBox;
        private System.Windows.Forms.CheckBox userIsActiveCheckBox;
        private System.Windows.Forms.BindingSource userLevelBindingSource;
    }
}