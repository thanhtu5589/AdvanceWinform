using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiSanPham_DTO
    {
        private string _MaLoai;

        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }
        private string _TenLoai;

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }
    }
}
