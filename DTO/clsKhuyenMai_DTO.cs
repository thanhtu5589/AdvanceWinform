using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsKhuyenMai_DTO
    {
        private string _MaChuongTrinh;

        public string MaChuongTrinh
        {
            get { return _MaChuongTrinh; }
            set { _MaChuongTrinh = value; }
        }
        private string _TenChuongTrinh;

        public string TenChuongTrinh
        {
            get { return _TenChuongTrinh; }
            set { _TenChuongTrinh = value; }
        }
        private string _ThoiGianBatDau;

        public string ThoiGianBatDau
        {
            get { return _ThoiGianBatDau; }
            set { _ThoiGianBatDau = value; }
        }
        private string _ThoiGianKetThuc;

        public string ThoiGianKetThuc
        {
            get { return _ThoiGianKetThuc; }
            set { _ThoiGianKetThuc = value; }
        }
    }
}
