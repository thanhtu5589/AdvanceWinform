using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsPhieuXuatHang_DTO
    {
        private string _MaPhieuXuat;

        public string MaPhieuXuat
        {
            get { return _MaPhieuXuat; }
            set { _MaPhieuXuat = value; }
        }
        private string _NhanVienLap;

        public string NhanVienLap
        {
            get { return _NhanVienLap; }
            set { _NhanVienLap = value; }
        }
        private string _NgayXuat;

        public string NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }
        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
    }
}
