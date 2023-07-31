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
    public partial class formProduct : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        Product hh;
        public formProduct()
        {
            InitializeComponent();
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            var products = productRepository.GetProductByKeyword(txtKeyWord.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
                if (products.Count() == 0)
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtKeyWord_TextChanged(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formProductUpdate formProductUpdate = new formProductUpdate()
            {
                Text = "Update Product",
                InsertOrUpdate = false,
                ProductInfo = hh,
                ProductRepository = productRepository
            };
            formProductUpdate.Owner = this;
            if (formProductUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formProductUpdate formProductUpdate = new formProductUpdate()
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = hh,
                ProductRepository = productRepository
            };
            formProductUpdate.Owner = this;
            if (formProductUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productRepository.DeleteProduct(hh.ProductID);
                LoadProductList();
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

        private void formProduct_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        public void LoadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                dgvProduct.DataSource = null;
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.Columns.Clear();  // Xóa tất cả các cột hiện có trên DataGridView
                // Thêm cột ID và Tên vào DataGridView
                var maProduct = new DataGridViewTextBoxColumn();
                maProduct.DataPropertyName = "ProductID";
                maProduct.HeaderText = "Mã Hàng hoá";
                dgvProduct.Columns.Add(maProduct);

                var tenProduct = new DataGridViewTextBoxColumn();
                tenProduct.DataPropertyName = "ProductName";
                tenProduct.HeaderText = "Tên Hàng hoá";
                dgvProduct.Columns.Add(tenProduct);

                var soLuong = new DataGridViewTextBoxColumn();
                soLuong.DataPropertyName = "Unit";
                soLuong.HeaderText = "Số lượng";
                dgvProduct.Columns.Add(soLuong);

                var donGiaNhap = new DataGridViewTextBoxColumn();
                donGiaNhap.DataPropertyName = "PriceBuy";
                donGiaNhap.HeaderText = "Đơn giá nhập";
                dgvProduct.Columns.Add(donGiaNhap);

                var donGiaBan = new DataGridViewTextBoxColumn();
                donGiaBan.DataPropertyName = "PriceSale";
                donGiaBan.HeaderText = "Đơn giá bán";
                dgvProduct.Columns.Add(donGiaBan);
                // Ẩn cột Ảnh
                //dgvProduct.Columns[5].Visible = false;
                dgvProduct.DataSource = source;


                if (products.Count() == 0)
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                var product = productRepository.GetProductByID(Convert.ToInt32(row.Cells[0].Value));
                hh = new Product()
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Unit = product.Unit,
                    PriceBuy = product.PriceBuy,
                    PriceSale = product.PriceSale,
                    Picture = product.Picture,
                    Note = product.Note
                };
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
