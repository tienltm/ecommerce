namespace E_Commerce
{
    partial class formStaffUpdate
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
            txtPhone = new MaskedTextBox();
            txtAdd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtStaffName = new TextBox();
            txtStaffID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            chkGender = new CheckBox();
            label7 = new Label();
            txtDOB = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 192);
            btnExit.Location = new Point(461, 402);
            btnExit.Margin = new Padding(4);
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
            btnUpdate.Location = new Point(320, 402);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 51);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(320, 291);
            txtPhone.Margin = new Padding(4);
            txtPhone.Mask = "(00)000.000.000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 31);
            txtPhone.TabIndex = 28;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(320, 229);
            txtAdd.Margin = new Padding(4);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(258, 31);
            txtAdd.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 26;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 238);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 25;
            label4.Text = "Adress";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(320, 175);
            txtStaffName.Margin = new Padding(4);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(258, 31);
            txtStaffName.TabIndex = 24;
            // 
            // txtStaffID
            // 
            txtStaffID.Enabled = false;
            txtStaffID.Location = new Point(320, 112);
            txtStaffID.Margin = new Padding(4);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(258, 31);
            txtStaffID.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 22;
            label3.Text = "Staff Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "Staff ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(243, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 20;
            label1.Text = "Staff Update";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 416);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 31;
            label6.Text = "Gender";
            // 
            // chkGender
            // 
            chkGender.AutoSize = true;
            chkGender.Location = new Point(160, 411);
            chkGender.Margin = new Padding(4);
            chkGender.Name = "chkGender";
            chkGender.Size = new Size(76, 29);
            chkGender.TabIndex = 32;
            chkGender.Text = "Male";
            chkGender.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 355);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 33;
            label7.Text = "DOB";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(320, 346);
            txtDOB.Margin = new Padding(4);
            txtDOB.Mask = "00/00/0000";
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(258, 31);
            txtDOB.TabIndex = 34;
            txtDOB.ValidatingType = typeof(DateTime);
            // 
            // formStaffUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(620, 490);
            Controls.Add(txtDOB);
            Controls.Add(label7);
            Controls.Add(chkGender);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(txtAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "formStaffUpdate";
            Text = "formStaffUpdate";
            Load += formStaffUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDOB;
    }
}