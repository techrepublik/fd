namespace FD.forms
{
    partial class GuestEntryForm
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
            System.Windows.Forms.Label guestNameLabel;
            System.Windows.Forms.Label guestAddressLabel;
            System.Windows.Forms.Label guestContactLabel;
            System.Windows.Forms.Label guestEmailLabel;
            System.Windows.Forms.Label transactionIdLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label transactionTypeIdLabel;
            System.Windows.Forms.Label transactionQntyLabel;
            System.Windows.Forms.Label transactionPriceLabel;
            System.Windows.Forms.Label transactionAmountLabel;
            System.Windows.Forms.Label transactionIsActiveLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jTabWizard1 = new UtilityManager.ui.JTabWizard();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guestEmailTextBox = new System.Windows.Forms.TextBox();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestContactTextBox = new System.Windows.Forms.TextBox();
            this.guestAddressTextBox = new System.Windows.Forms.TextBox();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionPriceTextBox = new System.Windows.Forms.TextBox();
            this.transactionQntyTextBox = new System.Windows.Forms.TextBox();
            this.transactionTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.transactionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            guestNameLabel = new System.Windows.Forms.Label();
            guestAddressLabel = new System.Windows.Forms.Label();
            guestContactLabel = new System.Windows.Forms.Label();
            guestEmailLabel = new System.Windows.Forms.Label();
            transactionIdLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            transactionTypeIdLabel = new System.Windows.Forms.Label();
            transactionQntyLabel = new System.Windows.Forms.Label();
            transactionPriceLabel = new System.Windows.Forms.Label();
            transactionAmountLabel = new System.Windows.Forms.Label();
            transactionIsActiveLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.jTabWizard1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new System.Drawing.Point(6, 25);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new System.Drawing.Size(69, 13);
            guestNameLabel.TabIndex = 0;
            guestNameLabel.Text = "Guest Name:";
            // 
            // guestAddressLabel
            // 
            guestAddressLabel.AutoSize = true;
            guestAddressLabel.Location = new System.Drawing.Point(6, 53);
            guestAddressLabel.Name = "guestAddressLabel";
            guestAddressLabel.Size = new System.Drawing.Size(48, 13);
            guestAddressLabel.TabIndex = 2;
            guestAddressLabel.Text = "Address:";
            // 
            // guestContactLabel
            // 
            guestContactLabel.AutoSize = true;
            guestContactLabel.Location = new System.Drawing.Point(6, 104);
            guestContactLabel.Name = "guestContactLabel";
            guestContactLabel.Size = new System.Drawing.Size(67, 13);
            guestContactLabel.TabIndex = 4;
            guestContactLabel.Text = "Contact No.:";
            // 
            // guestEmailLabel
            // 
            guestEmailLabel.AutoSize = true;
            guestEmailLabel.Location = new System.Drawing.Point(6, 131);
            guestEmailLabel.Name = "guestEmailLabel";
            guestEmailLabel.Size = new System.Drawing.Size(35, 13);
            guestEmailLabel.TabIndex = 6;
            guestEmailLabel.Text = "Email:";
            // 
            // transactionIdLabel
            // 
            transactionIdLabel.AutoSize = true;
            transactionIdLabel.Location = new System.Drawing.Point(8, 47);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new System.Drawing.Size(83, 13);
            transactionIdLabel.TabIndex = 0;
            transactionIdLabel.Text = "Transaction No:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new System.Drawing.Point(58, 74);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(33, 13);
            transactionDateLabel.TabIndex = 2;
            transactionDateLabel.Text = "Date:";
            // 
            // transactionTypeIdLabel
            // 
            transactionTypeIdLabel.AutoSize = true;
            transactionTypeIdLabel.Location = new System.Drawing.Point(57, 102);
            transactionTypeIdLabel.Name = "transactionTypeIdLabel";
            transactionTypeIdLabel.Size = new System.Drawing.Size(34, 13);
            transactionTypeIdLabel.TabIndex = 4;
            transactionTypeIdLabel.Text = "Type:";
            // 
            // transactionQntyLabel
            // 
            transactionQntyLabel.AutoSize = true;
            transactionQntyLabel.Location = new System.Drawing.Point(42, 128);
            transactionQntyLabel.Name = "transactionQntyLabel";
            transactionQntyLabel.Size = new System.Drawing.Size(49, 13);
            transactionQntyLabel.TabIndex = 6;
            transactionQntyLabel.Text = "Quantity:";
            // 
            // transactionPriceLabel
            // 
            transactionPriceLabel.AutoSize = true;
            transactionPriceLabel.Location = new System.Drawing.Point(57, 155);
            transactionPriceLabel.Name = "transactionPriceLabel";
            transactionPriceLabel.Size = new System.Drawing.Size(34, 13);
            transactionPriceLabel.TabIndex = 8;
            transactionPriceLabel.Text = "Price:";
            // 
            // transactionAmountLabel
            // 
            transactionAmountLabel.AutoSize = true;
            transactionAmountLabel.Location = new System.Drawing.Point(45, 180);
            transactionAmountLabel.Name = "transactionAmountLabel";
            transactionAmountLabel.Size = new System.Drawing.Size(46, 13);
            transactionAmountLabel.TabIndex = 10;
            transactionAmountLabel.Text = "Amount:";
            // 
            // transactionIsActiveLabel
            // 
            transactionIsActiveLabel.AutoSize = true;
            transactionIsActiveLabel.Location = new System.Drawing.Point(51, 210);
            transactionIsActiveLabel.Name = "transactionIsActiveLabel";
            transactionIsActiveLabel.Size = new System.Drawing.Size(40, 13);
            transactionIsActiveLabel.TabIndex = 12;
            transactionIsActiveLabel.Text = "Active:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 40);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 325);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":: Activity ::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = ":: Entry Form ::";
            // 
            // jTabWizard1
            // 
            this.jTabWizard1.Controls.Add(this.tabPage1);
            this.jTabWizard1.Controls.Add(this.tabPage2);
            this.jTabWizard1.Location = new System.Drawing.Point(163, 62);
            this.jTabWizard1.Name = "jTabWizard1";
            this.jTabWizard1.SelectedIndex = 0;
            this.jTabWizard1.Size = new System.Drawing.Size(499, 266);
            this.jTabWizard1.TabIndex = 0;
            this.jTabWizard1.Selected += new System.Windows.Forms.TabControlEventHandler(this.jTabWizard1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(guestEmailLabel);
            this.tabPage1.Controls.Add(this.guestEmailTextBox);
            this.tabPage1.Controls.Add(guestContactLabel);
            this.tabPage1.Controls.Add(this.guestContactTextBox);
            this.tabPage1.Controls.Add(guestAddressLabel);
            this.tabPage1.Controls.Add(this.guestAddressTextBox);
            this.tabPage1.Controls.Add(guestNameLabel);
            this.tabPage1.Controls.Add(this.guestNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Guest Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guestEmailTextBox
            // 
            this.guestEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GuestEmail", true));
            this.guestEmailTextBox.Location = new System.Drawing.Point(81, 127);
            this.guestEmailTextBox.Name = "guestEmailTextBox";
            this.guestEmailTextBox.Size = new System.Drawing.Size(404, 20);
            this.guestEmailTextBox.TabIndex = 3;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataSource = typeof(FD.dal.data.Guest);
            // 
            // guestContactTextBox
            // 
            this.guestContactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GuestContact", true));
            this.guestContactTextBox.Location = new System.Drawing.Point(81, 100);
            this.guestContactTextBox.Name = "guestContactTextBox";
            this.guestContactTextBox.Size = new System.Drawing.Size(404, 20);
            this.guestContactTextBox.TabIndex = 2;
            // 
            // guestAddressTextBox
            // 
            this.guestAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GuestAddress", true));
            this.guestAddressTextBox.Location = new System.Drawing.Point(81, 48);
            this.guestAddressTextBox.Multiline = true;
            this.guestAddressTextBox.Name = "guestAddressTextBox";
            this.guestAddressTextBox.Size = new System.Drawing.Size(404, 44);
            this.guestAddressTextBox.TabIndex = 1;
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.guestNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GuestName", true));
            this.guestNameTextBox.Location = new System.Drawing.Point(81, 22);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.Size = new System.Drawing.Size(404, 20);
            this.guestNameTextBox.TabIndex = 0;
            this.guestNameTextBox.TextChanged += new System.EventHandler(this.guestNameTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(transactionIsActiveLabel);
            this.tabPage2.Controls.Add(this.transactionIsActiveCheckBox);
            this.tabPage2.Controls.Add(transactionAmountLabel);
            this.tabPage2.Controls.Add(this.transactionAmountTextBox);
            this.tabPage2.Controls.Add(transactionPriceLabel);
            this.tabPage2.Controls.Add(this.transactionPriceTextBox);
            this.tabPage2.Controls.Add(transactionQntyLabel);
            this.tabPage2.Controls.Add(this.transactionQntyTextBox);
            this.tabPage2.Controls.Add(transactionTypeIdLabel);
            this.tabPage2.Controls.Add(this.transactionTypeIdComboBox);
            this.tabPage2.Controls.Add(transactionDateLabel);
            this.tabPage2.Controls.Add(this.transactionDateDateTimePicker);
            this.tabPage2.Controls.Add(transactionIdLabel);
            this.tabPage2.Controls.Add(this.transactionIdTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Guest Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(106, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "...";
            // 
            // transactionIsActiveCheckBox
            // 
            this.transactionIsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.transactionBindingSource, "TransactionIsActive", true));
            this.transactionIsActiveCheckBox.Location = new System.Drawing.Point(109, 205);
            this.transactionIsActiveCheckBox.Name = "transactionIsActiveCheckBox";
            this.transactionIsActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.transactionIsActiveCheckBox.TabIndex = 6;
            this.transactionIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(FD.dal.data.Transaction);
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TransactionAmount", true));
            this.transactionAmountTextBox.Location = new System.Drawing.Point(109, 176);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(134, 20);
            this.transactionAmountTextBox.TabIndex = 5;
            // 
            // transactionPriceTextBox
            // 
            this.transactionPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TransactionPrice", true));
            this.transactionPriceTextBox.Location = new System.Drawing.Point(109, 150);
            this.transactionPriceTextBox.Name = "transactionPriceTextBox";
            this.transactionPriceTextBox.Size = new System.Drawing.Size(134, 20);
            this.transactionPriceTextBox.TabIndex = 4;
            // 
            // transactionQntyTextBox
            // 
            this.transactionQntyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TransactionQnty", true));
            this.transactionQntyTextBox.Location = new System.Drawing.Point(109, 124);
            this.transactionQntyTextBox.Name = "transactionQntyTextBox";
            this.transactionQntyTextBox.Size = new System.Drawing.Size(134, 20);
            this.transactionQntyTextBox.TabIndex = 3;
            // 
            // transactionTypeIdComboBox
            // 
            this.transactionTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transactionBindingSource, "TransactionTypeId", true));
            this.transactionTypeIdComboBox.DataSource = this.transactionTypeBindingSource;
            this.transactionTypeIdComboBox.DisplayMember = "TransactionTypeName";
            this.transactionTypeIdComboBox.FormattingEnabled = true;
            this.transactionTypeIdComboBox.Location = new System.Drawing.Point(109, 97);
            this.transactionTypeIdComboBox.Name = "transactionTypeIdComboBox";
            this.transactionTypeIdComboBox.Size = new System.Drawing.Size(348, 21);
            this.transactionTypeIdComboBox.TabIndex = 2;
            this.transactionTypeIdComboBox.ValueMember = "TransactionTypeId";
            // 
            // transactionTypeBindingSource
            // 
            this.transactionTypeBindingSource.DataSource = typeof(FD.dal.data.TransactionType);
            // 
            // transactionDateDateTimePicker
            // 
            this.transactionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "TransactionDate", true));
            this.transactionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDateDateTimePicker.Location = new System.Drawing.Point(109, 70);
            this.transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            this.transactionDateDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.transactionDateDateTimePicker.TabIndex = 1;
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TransactionId", true));
            this.transactionIdTextBox.Location = new System.Drawing.Point(109, 44);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.Size = new System.Drawing.Size(101, 20);
            this.transactionIdTextBox.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(167, 334);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "<< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(248, 334);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next >>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(583, 334);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(466, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // GuestEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 387);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.jTabWizard1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "GuestEntryForm";
            this.Text = "Guest Entry Form";
            this.Load += new System.EventHandler(this.GuestEntryForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.jTabWizard1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UtilityManager.ui.JTabWizard jTabWizard1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox guestAddressTextBox;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private System.Windows.Forms.TextBox guestNameTextBox;
        private System.Windows.Forms.TextBox guestEmailTextBox;
        private System.Windows.Forms.TextBox guestContactTextBox;
        private System.Windows.Forms.DateTimePicker transactionDateDateTimePicker;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.ComboBox transactionTypeIdComboBox;
        private System.Windows.Forms.TextBox transactionQntyTextBox;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.TextBox transactionPriceTextBox;
        private System.Windows.Forms.CheckBox transactionIsActiveCheckBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource transactionTypeBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}