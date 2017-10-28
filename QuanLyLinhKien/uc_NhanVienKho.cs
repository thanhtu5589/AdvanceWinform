using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLinhKien
{
    public partial class uc_NhanVienKho : UserControl
    {

        uc_SanPham ufrmSanPham = null;
        //uc_LoaiSanPham
        //uc_PhieuNhapHang
        //uc_PhieuXuatHang
        public uc_NhanVienKho()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.Size = new Size(1614, 813);
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PhieuXuatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
