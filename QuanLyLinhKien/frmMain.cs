using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLinhKien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
            //    e.Cancel = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        //    uc_DangNhap ucfrm = new uc_DangNhap();
        //    this.Controls.Add(ucfrm);
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
