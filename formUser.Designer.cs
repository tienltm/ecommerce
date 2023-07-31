namespace E_Commerce
{
    partial class formUser
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvUser = new DataGridView();
            label2 = new Label();
            txtKeyWord = new TextBox();
            txtSearch = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Purple;
            btnExit.Location = new Point(806, 485);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 50);
            btnExit.TabIndex = 32;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Purple;
            btnDelete.Location = new Point(552, 485);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 50);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Purple;
            btnEdit.Location = new Point(295, 485);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 50);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Modify";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Purple;
            btnAdd.Location = new Point(52, 485);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 50);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(52, 168);
            dgvUser.Margin = new Padding(4, 4, 4, 4);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(895, 288);
            dgvUser.TabIndex = 28;
            dgvUser.CellClick += dgvUser_CellClick;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 27;
            label2.Text = "Search Keyword:";
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(295, 108);
            txtKeyWord.Margin = new Padding(4, 4, 4, 4);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(459, 31);
            txtKeyWord.TabIndex = 26;
            txtKeyWord.TextChanged += txtKeyWord_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Purple;
            txtSearch.Location = new Point(801, 104);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 36);
            txtSearch.TabIndex = 25;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(422, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 24;
            label1.Text = "User Manage";
            // 
            // formUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 562);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvUser);
            Controls.Add(label2);
            Controls.Add(txtKeyWord);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formUser";
            Text = "formUser";
            Load += formUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Label label1;
    }
}