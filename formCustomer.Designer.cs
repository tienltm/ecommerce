namespace E_Commerce
{
    partial class formCustomer
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
            dgvCustomer = new DataGridView();
            txtSearch = new Button();
            txtKeyWord = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(285, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 1;
            label1.Text = "Customer Manage";
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(42, 182);
            dgvCustomer.Margin = new Padding(4, 4, 4, 4);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(895, 288);
            dgvCustomer.TabIndex = 10;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            dgvCustomer.CellDoubleClick += dgvCustomer_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Purple;
            txtSearch.Location = new Point(791, 109);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 48);
            txtSearch.TabIndex = 11;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(285, 112);
            txtKeyWord.Margin = new Padding(4, 4, 4, 4);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(459, 31);
            txtKeyWord.TabIndex = 12;
            txtKeyWord.TextChanged += txtKeyWord_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 13;
            label2.Text = "Search Keyword";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Purple;
            btnAdd.Location = new Point(42, 498);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 50);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Purple;
            btnEdit.Location = new Point(285, 498);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 50);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Purple;
            btnDelete.Location = new Point(542, 498);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 50);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Purple;
            btnExit.Location = new Point(796, 498);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 50);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // formCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(974, 562);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtKeyWord);
            Controls.Add(txtSearch);
            Controls.Add(dgvCustomer);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formCustomer";
            Text = "formCustomer";
            Load += formCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}