using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietPhieuXuatHang_DTO
    {
        private string _MaPhieuXuat;

        public string MaPhieuXuat
        {
            get { return _MaPhieuXuat; }
            set { _MaPhieuXuat = value; }
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
        private decimal _DonGia;

        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
    }
}
