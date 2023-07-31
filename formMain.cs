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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStaff f_NV = new formStaff();
            f_NV.MdiParent = this;
            f_NV.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCustomer f_KH = new formCustomer();
            f_KH.MdiParent = this;
            f_KH.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUser f_Nd = new formUser();
            f_Nd.MdiParent = this;
            f_Nd.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProduct f_HH = new formProduct();
            f_HH.MdiParent = this;
            f_HH.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
