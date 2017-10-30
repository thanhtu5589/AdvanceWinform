using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsPhieuGiaoHang_DTO
    {
        private string _MaPhieuGiao;

        public string MaPhieuGiao
        {
            get { return _MaPhieuGiao; }
            set { _MaPhieuGiao = value; }
        }
        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        private string _NhanVienGiao;

        public string NhanVienGiao
        {
            get { return _NhanVienGiao; }
            set { _NhanVienGiao = value; }
        }
        private string _DiaChiGiao;

        public string DiaChiGiao
        {
            get { return _DiaChiGiao; }
            set { _DiaChiGiao = value; }
        }
        private int _PhiGiaoHang;

        public int PhiGiaoHang
        {
            get { return _PhiGiaoHang; }
            set { _PhiGiaoHang = value; }
        }
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
    }
}
