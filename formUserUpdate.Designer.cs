namespace E_Commerce
{
    partial class formUserUpdate
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
            btnExit = new Button();
            btnUpdate = new Button();
            txtUserID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtUserPassword = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboUserType = new ComboBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 192);
            btnExit.Location = new Point(391, 399);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 51);
            btnExit.TabIndex = 30;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(192, 0, 192);
            btnUpdate.Location = new Point(250, 399);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 51);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(250, 251);
            txtUserID.Margin = new Padding(4, 4, 4, 4);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(258, 31);
            txtUserID.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 318);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 26;
            label5.Text = "User Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 25;
            label4.Text = "User ID";
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(250, 198);
            txtUserPassword.Margin = new Padding(4, 4, 4, 4);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.Size = new Size(258, 31);
            txtUserPassword.TabIndex = 24;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(250, 135);
            txtUserName.Margin = new Padding(4, 4, 4, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(258, 31);
            txtUserName.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 201);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 21;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(106, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 20;
            label1.Text = "User Update";
            // 
            // cboUserType
            // 
            cboUserType.FormattingEnabled = true;
            cboUserType.Location = new Point(250, 314);
            cboUserType.Margin = new Padding(4, 4, 4, 4);
            cboUserType.Name = "cboUserType";
            cboUserType.Size = new Size(258, 33);
            cboUserType.TabIndex = 31;
            // 
            // formUserUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(590, 488);
            Controls.Add(cboUserType);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtUserID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formUserUpdate";
            Text = "formUserUpdate";
            Load += formUserUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUserType;
    }
}