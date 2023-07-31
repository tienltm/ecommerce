using Library.BussinessObject;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class formProductUpdate : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public Product ProductInfo { get; set; }
        public string pathName;
        private OpenFileDialog openFileDialog;
        public formProductUpdate()
        {
            InitializeComponent();

            // Khởi tạo đối tượng OpenFileDialog
            openFileDialog = new OpenFileDialog();

            // Cấu hình các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var hh = new Product
                {
                    ProductID = Convert.ToInt32(txtProductID.Text == "" ? 0 : txtProductID.Text),
                    ProductName = txtProductName.Text,
                    Unit = Convert.ToInt32(txtUnit.Text),
                    PriceBuy = Convert.ToDecimal(txtPriceBuy.Text),
                    PriceSale = Convert.ToDecimal(txtPriceSale.Text),
                    Picture = pathName,
                    Note = txtNote.Text
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(hh);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formProduct)this.Owner).LoadProductList();
                    }
                }
                else
                {
                    ProductRepository.UpdateProduct(hh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formProduct)this.Owner).LoadProductList();
                    }
                }

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp ảnh đã chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh lên PictureBox
                picAvatar.Image = Image.FromFile(imagePath);
                // Lấy đường dẫn thư mục để lưu tệp ảnh
                string directoryPath = Application.StartupPath + "/Avatar";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                pathName = Path.GetFileName(imagePath);
                File.Copy(openFileDialog.FileName, Path.Combine(directoryPath, Path.GetFileName(openFileDialog.FileName)));

            }

        }

        private void formProductUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = ProductInfo.ProductID.ToString();
                txtProductName.Text = ProductInfo.ProductName.ToString();
                txtUnit.Text = ProductInfo.Unit.ToString();
                txtPriceBuy.Text = ProductInfo.PriceBuy.ToString();
                txtPriceSale.Text = ProductInfo.PriceSale.ToString();
                picAvatar.Image = Image.FromFile(Application.StartupPath + "/Avatar/" + ProductInfo.Picture);
                pathName = Path.GetFileName(Application.StartupPath + "/Avatar/" + ProductInfo.Picture);
                txtNote.Text = ProductInfo.Note.ToString();
            }
        }
    }
}
