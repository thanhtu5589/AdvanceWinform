using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyLinhKien
{
    public partial class uc_DangNhap : UserControl
    {
        public uc_DangNhap()
        {
            InitializeComponent();
            this.Location = new Point(280, 220);
            this.Size = new Size(600, 200);
            this.Anchor = AnchorStyles.None;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Chưa điền tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (clsNhanVien_BUS.KiemTraDangNhap(txtMaNhanVien.Text, txtMatKhau.Text))
            {
                this.Hide();
                txtMaNhanVien.Text = txtMatKhau.Text = "";
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }

    }
}