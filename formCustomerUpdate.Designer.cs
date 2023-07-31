namespace E_Commerce
{
    partial class formCustomerUpdate
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
            label1 = new Label();
            txtPhone = new MaskedTextBox();
            txtAdd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCustomerName = new TextBox();
            txtMaKhach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(116, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 2;
            label1.Text = "Customer Update";
            label1.Click += label1_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(228, 289);
            txtPhone.Margin = new Padding(4, 4, 4, 4);
            txtPhone.Mask = "(00)000.000.000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 31);
            txtPhone.TabIndex = 17;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(228, 226);
            txtAdd.Margin = new Padding(4, 4, 4, 4);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(258, 31);
            txtAdd.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 15;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 14;
            label4.Text = "Address";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(228, 172);
            txtCustomerName.Margin = new Padding(4, 4, 4, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(258, 31);
            txtCustomerName.TabIndex = 13;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Enabled = false;
            txtMaKhach.Location = new Point(228, 110);
            txtMaKhach.Margin = new Padding(4, 4, 4, 4);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.ReadOnly = true;
            txtMaKhach.Size = new Size(258, 31);
            txtMaKhach.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 11;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 10;
            label2.Text = "Customer ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(192, 0, 192);
            btnUpdate.Location = new Point(228, 374);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 51);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 192);
            btnExit.Location = new Point(369, 374);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 51);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // formCustomerUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(545, 451);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(txtAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCustomerName);
            Controls.Add(txtMaKhach);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formCustomerUpdate";
            Text = "formCustomerUpdate";
            Load += formCustomerUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}