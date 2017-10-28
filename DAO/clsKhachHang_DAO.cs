using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class clsKhachHang_DAO
    {
        public clsKhachHang_DTO getKhachHangByChungMinhNhanDan(string str)
        {
            DataProvider.Open();
            SqlCommand cmd = DataProvider.query(string.Format("select * from KhachHang where ChungMinhNhanDan = '{0}' and TrangThai = 1", str));
            SqlDataReader dr = cmd.ExecuteReader();
            clsKhachHang_DTO kh = new clsKhachHang_DTO();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                    kh.MaKhachHang = dr["MaKhachHang"].ToString();
                if (!dr.IsDBNull(1))
                    kh.HoTen = dr["HoTen"].ToString();
                if (!dr.IsDBNull(2))
                    kh.ChungMinhNhanDan = dr["ChungMinhNhanDan"].ToString();
                if (!dr.IsDBNull(3))
                    kh.SoDienThoai = dr["SoDienThoai"].ToString();
                if (!dr.IsDBNull(4))
                    kh.Email = dr["Email"].ToString();
                if (!dr.IsDBNull(5))
                    kh.DiaChi = dr["DiaChi"].ToString();
            }
            DataProvider.Close();
            return kh;
        }
        public bool updateKhachHang(string ma, string HoTen, string CMND, string SDT, string email, string diachi)
        {
            DataProvider.Open();
            SqlCommand cmd = DataProvider.query(string.Format("update KhachHang set HoTen = '{0}', ChungMinhNhanDan = '{1}', SoDienThoai = '{2}', Email = '{3}', DiaChi = '{4}' where MaKhachHang = '{5}'", HoTen, CMND, SDT, email, diachi, ma));
            bool kq = DataProvider.checkQuery(cmd);
            DataProvider.Close();
            return kq;
        }

        public bool insertKhachHang(string HoTen, string CMND, string SDT, string email, string diachi)
        {
            DataProvider.Open();
            SqlCommand cmd = DataProvider.query(string.Format("select * from KhachHang"));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string maKh = string.Format("KH{0}", dt.Rows.Count + 1);
            SqlCommand insert = DataProvider.query(string.Format("insert into KhachHang values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})", maKh, HoTen, CMND, SDT, email, diachi, 1));
            bool kq = DataProvider.checkQuery(insert);
            DataProvider.Close();
            return kq;
        }
    }
}
