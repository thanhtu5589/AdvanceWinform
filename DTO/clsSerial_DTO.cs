using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSerial_DTO
    {
        private string _MaSanPham;

        public string MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }
        private decimal _SerialNumber;

        public decimal SerialNumber
        {
            get { return _SerialNumber; }
            set { _SerialNumber = value; }
        }

    }
}
