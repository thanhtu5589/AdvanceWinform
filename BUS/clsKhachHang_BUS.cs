using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsKhachHang_BUS
    {
        public clsKhachHang_DTO getKhachHangByChungMinhNhanDan(string str)
        {
            clsKhachHang_DAO kh_dao = new clsKhachHang_DAO();
            return kh_dao.getKhachHangByChungMinhNhanDan(str);
        }
        public bool updateKhachHang(string ma, string HoTen, string CMND, string SDT, string email, string diachi)
        {
            clsKhachHang_DAO kh_dao = new clsKhachHang_DAO();
            return kh_dao.updateKhachHang(ma, HoTen, CMND, SDT, email, diachi);
        }
        public bool insertKhachHang(string HoTen, string CMND, string SDT, string email, string diachi)
        {
            clsKhachHang_DAO kh_dao = new clsKhachHang_DAO();
            return kh_dao.insertKhachHang(HoTen, CMND, SDT, email, diachi);
        }
    }
}
