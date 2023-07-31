using Library.BussinessObject;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class formStaffUpdate : Form
    {
        public IStaffRepository StaffRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public Staff StaffInfo { get; set; }
        public formStaffUpdate()
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
                var nv = new Staff
                {
                    StaffID = Convert.ToInt32(txtStaffID.Text == "" ? 0 : txtStaffID.Text),
                    StaffName = txtStaffName.Text,
                    StaffAdd = txtAdd.Text,
                    StaffPhone = txtPhone.Text,
                    StaffGender = chkGender.Checked,
                    StaffDOB = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)

                };
                if (InsertOrUpdate == false)
                {
                    StaffRepository.InsertStaff(nv);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formStaff)this.Owner).LoadStaffList();
                    }
                }
                else
                {
                    StaffRepository.UpdateStaff(nv);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((formStaff)this.Owner).LoadStaffList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void formStaffUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtStaffID.Text = StaffInfo.StaffID.ToString();
                txtStaffName.Text = StaffInfo.StaffName.ToString();
                txtAdd.Text = StaffInfo.StaffAdd.ToString();
                txtPhone.Text = StaffInfo.StaffPhone.ToString();
                txtDOB.Text = StaffInfo.StaffDOB.ToString("dd/MM/yyyy");
                chkGender.Checked = StaffInfo.StaffGender;
            }
        }
    }
}
