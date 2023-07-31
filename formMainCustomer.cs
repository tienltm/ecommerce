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

namespace E_Commerce
{
    public partial class formMainCustomer : Form
    {
        public User UserInfo { get; set; }
        public ICustomerRepository customerRepository = new CustomerRepository();
        public formMainCustomer()
        {
            InitializeComponent();

        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnu_SanPham_Click(object sender, EventArgs e)
        {
            //frmSanPham f_SP = new frmSanPham();
            //f_SP.MdiParent = this;
            //f_SP.Show();
        }

        private void formMainCustomer_Load(object sender, EventArgs e)
        {
            menuHi.Text = "Chào: " + customerRepository.GetCustomerByID(Convert.ToInt32(UserInfo.UserID)).CustomerName;
        }
    }
}
