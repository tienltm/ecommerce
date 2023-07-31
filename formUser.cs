using Library.BussinessObject;
using Library.Repository;

namespace E_Commerce
{
    public partial class formUser : Form
    {
        IUserRepository userRepository = new UserRepository();
        BindingSource source;
        User nd;
        public formUser()
        {
            InitializeComponent();
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            var users = userRepository.GetUserByKeyword(txtKeyWord.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                dgvUser.DataSource = null;
                dgvUser.DataSource = source;
                if (users.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvUser.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                var nguoiDung = userRepository.GetUserByUserName(row.Cells[0].Value.ToString());
                nd = new User()
                {
                    UserName = nguoiDung.UserName,
                    UserPassword = nguoiDung.UserPassword,
                    UserType = nguoiDung.UserType,
                    UserID = nguoiDung.UserID
                };
            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formUserUpdate formUserUpdate = new formUserUpdate()
            {
                Text = "Update User",
                InsertOrUpdate = false,
                UserInfo = nd,
                UserRepository = userRepository
            };
            formUserUpdate.Owner = this;
            if (formUserUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadUserList();
                source.Position = source.Count - 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formUserUpdate formUserUpdate = new formUserUpdate()
            {
                Text = "Update User",
                InsertOrUpdate = true,
                UserInfo = nd,
                UserRepository = userRepository
            };
            formUserUpdate.Owner = this;
            if (formUserUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadUserList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                userRepository.DeleteUser(nd.UserName);
                LoadUserList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        public void LoadUserList()
        {
            var users = userRepository.GetUserList();
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                dgvUser.DataSource = null;
                dgvUser.DataSource = source;
                if (users.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
