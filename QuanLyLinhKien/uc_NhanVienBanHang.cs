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
using DTO;

namespace QuanLyLinhKien
{
    public partial class uc_NhanVienBanHang : UserControl
    {
        private bool editKhachHang = false;
        private clsKhachHang_DTO kh_dto = null;
        public uc_NhanVienBanHang()
        {
            InitializeComponent();

           // this.AutoSize = true;
           // this.Dock = DockStyle.Fill;
           //// this.Size = new Size(1614, 813);
            this.SizeChanged +=uc_NhanVienBanHang_SizeChanged;
        }

        

        private void uc_NhanVienBanHang_SizeChanged(object sender, EventArgs e)
        {
            //ScaleMenuItem(TaoHoaDonToolStripMenuItem);
            //ScaleMenuItem(LoaiSanPhamToolStripMenuItem);
            //ScaleMenuItem(PhieuNhapHangToolStripMenuItem);
            //ScaleMenuItem(DangXuatToolStripMenuItem);
        }

        private void ScaleMenuItem(ToolStripMenuItem item)
        {
            var ownerForm = this.FindForm();
            if (ownerForm == null) return;
            var itemWidth = ownerForm.Width / 5;
            item.Size = new Size(itemWidth, item.Height);
            //DangXuatToolStripMenuItem.Margin = new Padding(itemWidth - 40, 0, 0, 0);
        }
        private void uc_NhanVienBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_DieuKienTimKiem.Text))
            {
                clsKhachHang_BUS kh_bus = new clsKhachHang_BUS();
                kh_dto = kh_bus.getKhachHangByChungMinhNhanDan(textBox_DieuKienTimKiem.Text);
                textBox_HoTen.Text = kh_dto.HoTen;
                textBox_Email.Text = kh_dto.Email;
                textBox_SDT.Text = kh_dto.SoDienThoai;
                textBox_CMND.Text = kh_dto.ChungMinhNhanDan;
                textBox_DiaChi.Text = kh_dto.DiaChi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng phù hợp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_SuaKH_Click(object sender, EventArgs e)
        {
            if (editKhachHang == false)
            {
                editKhachHang = true;
                textBox_HoTen.ReadOnly = false;
                textBox_Email.ReadOnly = false;
                textBox_SDT.ReadOnly = false;
                textBox_CMND.ReadOnly = false;
                textBox_DiaChi.ReadOnly = false;
                button_SuaKH.Text = "Xong";
            }
            else
            {
                //update KhachHang
                clsKhachHang_BUS kh_bus = new clsKhachHang_BUS();
                try
                {
                    if (kh_bus.updateKhachHang(kh_dto.MaKhachHang, textBox_HoTen.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_Email.Text, textBox_DiaChi.Text))
                    {
                        kh_dto = kh_bus.getKhachHangByChungMinhNhanDan(textBox_CMND.Text);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //
                catch 
                {
                    MessageBox.Show("Không có Khách hàng phù hợp với Chứng minh nhân dân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                editKhachHang = false;
                textBox_HoTen.ReadOnly = true;
                textBox_Email.ReadOnly = true;
                textBox_SDT.ReadOnly = true;
                textBox_CMND.ReadOnly = true;
                textBox_DiaChi.ReadOnly = true;
                button_SuaKH.Text = "Sửa";
            }
        }

        private void button_HuyKH_Click(object sender, EventArgs e)
        {
            if (kh_dto != null)
            {
                textBox_HoTen.Text = kh_dto.HoTen;
                textBox_Email.Text = kh_dto.Email;
                textBox_SDT.Text = kh_dto.SoDienThoai;
                textBox_CMND.Text = kh_dto.ChungMinhNhanDan;
                textBox_DiaChi.Text = kh_dto.DiaChi;
            }
        }

        private void button_ThemKH_Click(object sender, EventArgs e)
        {
            string[] str = {textBox_HoTen.Text, textBox_SDT.Text, textBox_Email.Text, textBox_CMND.Text, textBox_DiaChi.Text};
            if (!Check.StringIsNullOrWhiteSpace(str))
            {
                clsKhachHang_BUS kh_bus = new clsKhachHang_BUS();
                clsKhachHang_DTO khTemp = kh_bus.getKhachHangByChungMinhNhanDan(textBox_DieuKienTimKiem.Text);
                if (khTemp.ChungMinhNhanDan == null)
                {
                    kh_bus.insertKhachHang(textBox_HoTen.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_Email.Text, textBox_DiaChi.Text);
                    kh_dto = kh_bus.getKhachHangByChungMinhNhanDan(textBox_CMND.Text);
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất baị, trùng Chứng minh nhân dân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Có dữ liệu để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
