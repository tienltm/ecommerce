namespace E_Commerce
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(133, 38);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 0;
            label1.Text = "E-COMMERCE LOGIN";
            
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 174);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(219, 126);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(271, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(219, 174);
            txtUserPassword.Margin = new Padding(3, 2, 3, 2);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.Size = new Size(271, 27);
            txtUserPassword.TabIndex = 4;
            txtUserPassword.KeyDown += txtUserPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Purple;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(219, 230);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Purple;
            btnExit.Location = new Point(367, 230);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 42);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(536, 310);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}