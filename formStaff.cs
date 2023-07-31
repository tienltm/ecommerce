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
    public partial class formStaff : Form
    {
        IStaffRepository staffRepository = new StaffRepository();
        BindingSource source;
        Staff nv;

        public formStaff()
        {
            InitializeComponent();
        }

        private void formStaff_Load(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        public void LoadStaffList()
        {
            var nhanViens = staffRepository.GetStaffs();
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvStaff.DataSource = null;
                dgvStaff.DataSource = source;
                if (nhanViens.Count() == 0)
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

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            var nhanViens = staffRepository.GetStaffByKeyword(txtKeyWord.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvStaff.DataSource = null;
                dgvStaff.DataSource = source;
                if (nhanViens.Count() == 0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formStaffUpdate formStaffUpdate = new formStaffUpdate()
            {
                Text = "Update Staff",
                InsertOrUpdate = false,
                StaffInfo = nv,
                StaffRepository = staffRepository
            };
            formStaffUpdate.Owner = this;
            if (formStaffUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadStaffList();
                source.Position = source.Count - 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formStaffUpdate formStaffUpdate = new formStaffUpdate()
            {
                Text = "Update Staff",
                InsertOrUpdate = true,
                StaffInfo = nv,
                StaffRepository = staffRepository
            };
            formStaffUpdate.Owner = this;
            if (formStaffUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadStaffList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                staffRepository.DeleteStaff(nv.StaffID);
                LoadStaffList();
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


        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvStaff.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                nv = new Staff()
                {
                    StaffID = Convert.ToInt32(row.Cells[0].Value),
                    StaffName = row.Cells[1].Value.ToString(),
                    StaffAdd = row.Cells[2].Value.ToString(),
                    StaffPhone = row.Cells[3].Value.ToString(),
                    StaffGender = Convert.ToBoolean(row.Cells[4].Value.ToString()),
                    StaffDOB = Convert.ToDateTime(row.Cells[5].Value.ToString())
                };
            }
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
