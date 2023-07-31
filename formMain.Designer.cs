namespace E_Commerce
{
    partial class formMain
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ManagementToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1067, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ManagementToolStripMenuItem, billToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(1067, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ManagementToolStripMenuItem
            // 
            ManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { staffToolStripMenuItem, customerToolStripMenuItem, productToolStripMenuItem, userToolStripMenuItem });
            ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem";
            ManagementToolStripMenuItem.Size = new Size(111, 24);
            ManagementToolStripMenuItem.Text = "Management";
            ManagementToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(155, 26);
            staffToolStripMenuItem.Text = "Staff";
            staffToolStripMenuItem.Click += staffToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(155, 26);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(155, 26);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(155, 26);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(44, 24);
            billToolStripMenuItem.Text = "Bill";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 533);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "formMain";
            Text = "MainForm";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ManagementToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
    }
}