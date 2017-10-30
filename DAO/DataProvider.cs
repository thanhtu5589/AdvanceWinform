using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        private static string strCon = @"Data Source=THANHTU6B5C\SQLEXPRESS;Initial Catalog=QuanLyLinhKien;Integrated Security=True";
        private static SqlConnection con = null;

        public static void Open()
        {
            if (con == null)
                con = new SqlConnection(strCon);
            con.Open();
        }
        public static void Close()
        {
            con.Close();
        }
        public static SqlCommand query(string str)
        {
            return (new SqlCommand(str, con));
        }
        public static bool checkQuery(SqlCommand cmd)
        {
            return (cmd.ExecuteNonQuery() != 0);
        }
    }
}
