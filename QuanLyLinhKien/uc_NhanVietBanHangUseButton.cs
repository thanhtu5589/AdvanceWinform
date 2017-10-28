using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLinhKien
{
    public partial class uc_NhanVietBanHangUseButton : UserControl
    {
        public uc_NhanVietBanHangUseButton()
        {
            InitializeComponent();
            marginRight = 100;
        }

        private void uc_NhanVietBanHangUseButton_SizeChanged(object sender, EventArgs e)
        {
            btnMenu4.Location = new Point(this.Width - btnMenu4.Width - 100, btnMenu4.Location.Y);
            var width = btnMenu4.Location.X;


            var space = (width - (btnMenu1.Width * 3)) / 5;

            btnMenu1.Location = new Point(space, btnMenu4.Location.Y);
            btnMenu2.Location = new Point(space * 2 + btnMenu2.Width, btnMenu4.Location.Y);
            btnMenu3.Location = new Point(space * 3 + btnMenu3.Width * 2, btnMenu4.Location.Y);
            // cái này thường tui dùng mảng
        }

        public int marginRight { get; set; }
    }
}
