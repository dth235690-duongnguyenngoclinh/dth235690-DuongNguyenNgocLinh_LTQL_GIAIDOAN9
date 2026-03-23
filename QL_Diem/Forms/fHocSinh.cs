using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Diem.Forms
{
    public partial class fHocSinh : Form
    {
        public fHocSinh()
        {
            InitializeComponent();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLop f = new fLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMonHoc f = new fMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void qUaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBangDiem f = new fBangDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
