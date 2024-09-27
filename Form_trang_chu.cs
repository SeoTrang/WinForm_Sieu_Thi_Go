using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sieu_thi_go
{
    public partial class Form_trang_chu : Form
    {
        public Form_trang_chu()
        {
            InitializeComponent();
        }

        private void Form_trang_chu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 1", 1000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 2", 5000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 3", 1500);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 4", 7000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 5", 8000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 6", 7000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 7", 3000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 8", 3500);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 9", 7000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 10", 6000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 11", 9000);
            chart_mien.Series["DoanhThu"].Points.AddXY("Tháng 12", 0);


            chart_tron.Series["TopDanhMuc"].Points.AddXY("Điện thoại", 1000);
            chart_tron.Series["TopDanhMuc"].Points.AddXY("Giày dép", 5000);
            chart_tron.Series["TopDanhMuc"].Points.AddXY("Quần áo", 1500);
            chart_tron.Series["TopDanhMuc"].Points.AddXY("Laptop", 7000);
            chart_tron.Series["TopDanhMuc"].Points.AddXY("Quà cáp", 8000);
            chart_tron.Series["TopDanhMuc"].Points.AddXY("Đồ gia dụng", 7000);
           
        }
    }
}
