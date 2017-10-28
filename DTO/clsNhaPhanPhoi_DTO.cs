using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhaPhanPhoi_DTO
    {
        private string _MaNhaPhanPhoi;

        public string MaNhaPhanPhoi
        {
            get { return _MaNhaPhanPhoi; }
            set { _MaNhaPhanPhoi = value; }
        }
        private string _TenNhaPhanPhoi;

        public string TenNhaPhanPhoi
        {
            get { return _TenNhaPhanPhoi; }
            set { _TenNhaPhanPhoi = value; }
        }
    }
}
