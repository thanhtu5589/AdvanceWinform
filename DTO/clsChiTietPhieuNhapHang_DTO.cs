using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietPhieuNhapHang_DTO
    {
        private string _MaPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _MaPhieuNhap; }
            set { _MaPhieuNhap = value; }
        }
        private string _MaSanPham;

        public string MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private int _DonGia;

        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private string _NhaPhanPhoi;

        public string NhaPhanPhoi
        {
            get { return _NhaPhanPhoi; }
            set { _NhaPhanPhoi = value; }
        }
    }
}
