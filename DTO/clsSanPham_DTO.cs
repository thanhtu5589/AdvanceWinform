using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSanPham_DTO
    {
        private string _MaSanPham;

        public string MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }
        private string _TenSanPham;

        public string TenSanPham
        {
            get { return _TenSanPham; }
            set { _TenSanPham = value; }
        }
        private string _HinhAnh;

        public string HinhAnh
        {
            get { return _HinhAnh; }
            set { _HinhAnh = value; }
        }
        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        private string _NhaSanXuat;

        public string NhaSanXuat
        {
            get { return _NhaSanXuat; }
            set { _NhaSanXuat = value; }
        }
        private int _GiaSanPham;

        public int GiaSanPham
        {
            get { return _GiaSanPham; }
            set { _GiaSanPham = value; }
        }
        private string _LoaiSanPham;

        public string LoaiSanPham
        {
            get { return _LoaiSanPham; }
            set { _LoaiSanPham = value; }
        }
        private int _BaoHanh;

        public int BaoHanh
        {
            get { return _BaoHanh; }
            set { _BaoHanh = value; }
        }
    }
}
