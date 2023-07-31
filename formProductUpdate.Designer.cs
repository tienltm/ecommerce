namespace E_Commerce
{
    partial class formProductUpdate
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
            label7 = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            label4 = new Label();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPriceBuy = new TextBox();
            txtPriceSale = new TextBox();
            picAvatar = new PictureBox();
            btnUpload = new Button();
            label6 = new Label();
            txtNote = new TextBox();
            txtUnit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnit).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(504, 304);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 48;
            label7.Text = "Price Sale";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 192);
            btnExit.Location = new Point(781, 439);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 51);
            btnExit.TabIndex = 45;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(192, 0, 192);
            btnUpdate.Location = new Point(640, 439);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 51);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 299);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 41;
            label5.Text = "Price Buy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 241);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 40;
            label4.Text = "Unit";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(201, 184);
            txtProductName.Margin = new Padding(4, 4, 4, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(258, 31);
            txtProductName.TabIndex = 39;
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(201, 121);
            txtProductID.Margin = new Padding(4, 4, 4, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(258, 31);
            txtProductID.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 182);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 37;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 36;
            label2.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(321, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 35;
            label1.Text = "Update Product";
            // 
            // txtPriceBuy
            // 
            txtPriceBuy.Location = new Point(201, 300);
            txtPriceBuy.Margin = new Padding(4, 4, 4, 4);
            txtPriceBuy.Name = "txtPriceBuy";
            txtPriceBuy.Size = new Size(258, 31);
            txtPriceBuy.TabIndex = 49;
            // 
            // txtPriceSale
            // 
            txtPriceSale.Location = new Point(640, 300);
            txtPriceSale.Margin = new Padding(4, 4, 4, 4);
            txtPriceSale.Name = "txtPriceSale";
            txtPriceSale.Size = new Size(258, 31);
            txtPriceSale.TabIndex = 50;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(505, 116);
            picAvatar.Margin = new Padding(4, 4, 4, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(249, 159);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 51;
            picAvatar.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpload.ForeColor = Color.Purple;
            btnUpload.Location = new Point(781, 114);
            btnUpload.Margin = new Padding(4, 4, 4, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(118, 36);
            btnUpload.TabIndex = 52;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 374);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 53;
            label6.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(201, 374);
            txtNote.Margin = new Padding(4, 4, 4, 4);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(415, 115);
            txtNote.TabIndex = 54;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(201, 239);
            txtUnit.Margin = new Padding(4, 4, 4, 4);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(259, 31);
            txtUnit.TabIndex = 55;
            // 
            // formProductUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(950, 516);
            Controls.Add(txtUnit);
            Controls.Add(txtNote);
            Controls.Add(label6);
            Controls.Add(btnUpload);
            Controls.Add(picAvatar);
            Controls.Add(txtPriceSale);
            Controls.Add(txtPriceBuy);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formProductUpdate";
            Text = "formProductUpdate";
            Load += formProductUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.TextBox txtPriceSale;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.NumericUpDown txtUnit;
    }
}