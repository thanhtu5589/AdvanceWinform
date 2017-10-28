using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHoaDon_DTO
    {
        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        private string _MaKhachHang;

        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }
        private string _NhanVienLap;

        public string NhanVienLap
        {
            get { return _NhanVienLap; }
            set { _NhanVienLap = value; }
        }
        private string _NgayLap;

        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private decimal _TongTien;

        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
       
    }
}
