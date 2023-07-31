using E_Commerce.App_Code;
using Library.BussinessObject;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace E_Commerce
{
    public partial class formUserUpdate : Form
    {
        public IUserRepository UserRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public User UserInfo { get; set; }

        List<UserType> userType;
        public formUserUpdate()
        {
            InitializeComponent();

            userType = new List<UserType>()
            {
                new UserType(){Id= 1 ,Name = "Quản trị"},
                new UserType(){Id= 2 ,Name = "Khách hàng"},
                new UserType(){Id= 3 ,Name = "Nhân viên"}
            };
            cboUserType.DataSource = userType;
            cboUserType.DisplayMember = "Name";
            cboUserType.ValueMember = "Id";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new User
                {
                    UserName = txtUserName.Text,
                    UserPassword = string.IsNullOrEmpty(txtUserPassword.Text) ? UserInfo.UserPassword : Common.EncryptMD5(txtUserPassword.Text),
                    UserType = Convert.ToInt32(cboUserType.SelectedValue),
                    UserID = Convert.ToInt32(txtUserID.Text)
                };
                if (InsertOrUpdate == false)
                {
                    UserRepository.AddNewUser(kh);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formUser)this.Owner).LoadUserList();
                    }
                }
                else
                {
                    UserRepository.UpdateUser(kh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formUser)this.Owner).LoadUserList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void formUserUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtUserName.Text = UserInfo.UserName.ToString();
                //txtUserPassword.Text = UserInfo.UserPassword.ToString();
                txtUserID.Text = UserInfo.UserID.ToString();
                cboUserType.SelectedValue = UserInfo.UserType;
            }
        }
    }
}
