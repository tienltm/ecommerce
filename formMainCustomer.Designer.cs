namespace E_Commerce
{
    partial class formMainCustomer
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
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuProduct = new ToolStripMenuItem();
            menuHi = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, menuProduct, menuHi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuExit });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(52, 27);
            filesToolStripMenuItem.Text = "Files";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(224, 26);
            menuExit.Text = "Exit";
            menuExit.Click += mnu_Thoat_Click;
            // 
            // menuProduct
            // 
            menuProduct.Name = "menuProduct";
            menuProduct.Size = new Size(74, 27);
            menuProduct.Text = "Product";
            menuProduct.Click += mnu_SanPham_Click;
            // 
            // menuHi
            // 
            menuHi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menuHi.ForeColor = Color.FromArgb(192, 0, 192);
            menuHi.Name = "menuHi";
            menuHi.Size = new Size(42, 27);
            menuHi.Text = "Hi";
            // 
            // formMainCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "formMainCustomer";
            Text = "formMainCustomer";
            Load += formMainCustomer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuProduct;
        private System.Windows.Forms.ToolStripMenuItem menuHi;
    }
}