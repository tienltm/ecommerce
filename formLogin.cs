using Library.Repository;
using Library.BussinessObject;
using E_Commerce.App_Code;

//using static Azure.Core.HttpHeader;



namespace E_Commerce
{
    public partial class formLogin : Form
    {
        public IUserRepository UserRepository { get; set; }
        IUserRepository userRepository = new UserRepository();
        public formLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "Vui lòng nhập tên đăng nhập");
                    return;
                }
                if (string.IsNullOrEmpty(txtUserPassword.Text))
                {
                    errorProvider1.SetError(txtUserPassword, "Vui lòng nhập mật khẩu");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                    // Thực hiện xử lý đăng nhập ở đây
                    var user = GetUserObject();
                    var userTmp = userRepository.GetUserLogin(user.UserName, Common.EncryptMD5(user.UserPassword));
                    if (userTmp != null)
                    {
                        this.Visible = false;
                        if (MessageBox.Show("Login Success", "Messages") == DialogResult.OK)
                        {
                            Common.WriteLog("Login", "btnLogin_Click", user.UserName + " đăng nhập hệ thống");
                            if (userTmp.UserType == 1)
                            {
                                formMain f_main = new formMain()
                                {
                                    Text = "Management System",
                                };
                                f_main.Show();
                            }
                            else
                            {
                                //Customer
                                if (userTmp.UserType == 2)
                                {
                                    formMainCustomer f_main = new formMainCustomer()
                                    {
                                        Text = "Management Customer System",
                                        UserInfo = user
                                    };
                                    f_main.Show();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Messages");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private User GetUserObject()
        {
            User user = null;
            try
            {
                user = new User()
                {
                    UserName = txtUserName.Text,
                    UserPassword = txtUserPassword.Text
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                txtUserName.Focus();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                txtUserPassword.Focus();
            }
        }


    }
}