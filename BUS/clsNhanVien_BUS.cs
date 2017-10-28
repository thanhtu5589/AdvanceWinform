using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAO;
namespace BUS
{
    public class clsNhanVien_BUS
    {
        public static bool KiemTraDangNhap(string MaTaiKhoan, string MatKhauDaMaHoa)
        {
            return clsNhanVien_DAO.KiemTraDangNhap(MaTaiKhoan, MatKhauDaMaHoa);
        }
    }
}
