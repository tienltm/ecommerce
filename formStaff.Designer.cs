namespace E_Commerce
{
    partial class formStaff
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
            label2 = new Label();
            txtKeyWord = new TextBox();
            txtSearch = new Button();
            label1 = new Label();
            dgvStaff = new DataGridView();
            btnExit = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 17;
            label2.Text = "Search Keyword";
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(304, 120);
            txtKeyWord.Margin = new Padding(4, 4, 4, 4);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(459, 31);
            txtKeyWord.TabIndex = 16;
            txtKeyWord.TextChanged += txtKeyWord_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Purple;
            txtSearch.Location = new Point(810, 116);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 36);
            txtSearch.TabIndex = 15;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(304, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 38);
            label1.TabIndex = 14;
            label1.Text = "STAFF MANAGE";
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(61, 180);
            dgvStaff.Margin = new Padding(4, 4, 4, 4);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.Size = new Size(895, 288);
            dgvStaff.TabIndex = 19;
            dgvStaff.CellClick += dgvStaff_CellClick;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Purple;
            btnExit.Location = new Point(815, 498);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 50);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Purple;
            btnDelete.Location = new Point(561, 498);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 50);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Purple;
            btnEdit.Location = new Point(304, 498);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 50);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Purple;
            btnAdd.Location = new Point(61, 498);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 50);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // formStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 562);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvStaff);
            Controls.Add(label2);
            Controls.Add(txtKeyWord);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formStaff";
            Text = "formStaff";
            Load += formStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}