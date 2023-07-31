using Library.BussinessObject;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class formCustomerUpdate : Form
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public Customer CustomerInfo { get; set; }
        public formCustomerUpdate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new Customer
                {
                    CustomerID = Convert.ToInt32(txtMaKhach.Text == "" ? 0 : txtMaKhach.Text),
                    CustomerName = txtCustomerName.Text,
                    CustomerAdd = txtAdd.Text,
                    CustomerPhone = txtPhone.Text
                };
                if (InsertOrUpdate == false)
                {
                    CustomerRepository.InsertCustomer(kh);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formCustomer)this.Owner).LoadCustomerList();
                    }
                }
                else
                {
                    CustomerRepository.UpdateCustomer(kh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formCustomer)this.Owner).LoadCustomerList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void formCustomerUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtMaKhach.Text = CustomerInfo.CustomerID.ToString();
                txtCustomerName.Text = CustomerInfo.CustomerName.ToString();
                txtAdd.Text = CustomerInfo.CustomerAdd.ToString();
                txtPhone.Text = CustomerInfo.CustomerPhone.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
