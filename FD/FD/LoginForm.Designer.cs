namespace FD
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waterMarkTextBoxUserName = new UtilityManager.ui.WaterMarkTextBox();
            this.waterMarkTextBox2 = new UtilityManager.ui.WaterMarkTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 40);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FD.Properties.Resources.login_pic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // waterMarkTextBoxUserName
            // 
            this.waterMarkTextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxUserName.Location = new System.Drawing.Point(268, 92);
            this.waterMarkTextBoxUserName.Name = "waterMarkTextBoxUserName";
            this.waterMarkTextBoxUserName.Size = new System.Drawing.Size(216, 20);
            this.waterMarkTextBoxUserName.TabIndex = 0;
            this.waterMarkTextBoxUserName.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxUserName.WaterMarkText = "<<username>>";
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(268, 120);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.Size = new System.Drawing.Size(216, 20);
            this.waterMarkTextBox2.TabIndex = 1;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "<<password>>";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(409, 155);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMessage.Location = new System.Drawing.Point(206, 225);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(16, 13);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "...";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 273);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.waterMarkTextBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UtilityManager.ui.WaterMarkTextBox waterMarkTextBoxUserName;
        private UtilityManager.ui.WaterMarkTextBox waterMarkTextBox2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMessage;
    }
}