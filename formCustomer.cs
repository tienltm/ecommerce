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
    public partial class formCustomer : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        BindingSource source;
        Customer kh;
        public formCustomer()
        {
            InitializeComponent();
        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        public void LoadCustomerList()
        {
            var khachHangs = customerRepository.GetCustomers();
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = source;
                if (khachHangs.Count() == 0)
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
        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
            //formCustomerUpdate formCustomerUpdate = new formCustomerUpdate()
            //{
            //    Text = "Update Customer",
            //    InsertOrUpdate = true,
            //    CustomerInfo = kh,
            //    CustomerRepository = customerRepository
            //};
            //formCustomerUpdate.Owner = this;
            //if (formCustomerUpdate.ShowDialog() == DialogResult.OK)
            //{
            //    LoadCustomerList();
            //    source.Position = source.Count - 1;
            //}
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            var khachHangs = customerRepository.GetCustomerByKeyword(txtKeyWord.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = source;
                if (khachHangs.Count() == 0)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formCustomerUpdate formCustomerUpdate = new formCustomerUpdate()
            {
                Text = "Update Customer",
                InsertOrUpdate = true,
                CustomerInfo = kh,
                CustomerRepository = customerRepository
            };
            formCustomerUpdate.Owner = this;
            if (formCustomerUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                customerRepository.DeleteCustomer(kh.CustomerID);
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvCustomer.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                kh = new Customer()
                {
                    CustomerID = Convert.ToInt32(row.Cells[0].Value),
                    CustomerName = row.Cells[1].Value.ToString(),
                    CustomerAdd = row.Cells[2].Value.ToString(),
                    CustomerPhone = row.Cells[3].Value.ToString()
                };
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formCustomerUpdate formCustomerUpdate = new formCustomerUpdate()
            {
                Text = "Update Customer",
                InsertOrUpdate = false,
                CustomerInfo = kh,
                CustomerRepository = customerRepository
            };
            formCustomerUpdate.Owner = this;
            if (formCustomerUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerList();
                source.Position = source.Count - 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
