using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietKhuyenMai_DTO
    {
        private string _MaChuongTrinh;

        public string MaChuongTrinh
        {
            get { return _MaChuongTrinh; }
            set { _MaChuongTrinh = value; }
        }
        private string _MaSanPham;

        public string MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }
        private int _GiamGia;

        public int GiamGia
        {
            get { return _GiamGia; }
            set { _GiamGia = value; }
        }
        private int _SoLuongKhuyenMai;

        public int SoLuongKhuyenMai
        {
            get { return _SoLuongKhuyenMai; }
            set { _SoLuongKhuyenMai = value; }
        }
    }
}
