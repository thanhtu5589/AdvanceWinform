using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLinhKien
{
    public class Check
    {
        public static bool StringIsNullOrWhiteSpace(string[] str)
        {
            foreach (string i in str)
            {
                if (string.IsNullOrWhiteSpace(i))
                    return true;
            }
            return false;
        }
    }
}
