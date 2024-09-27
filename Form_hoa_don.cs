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
    public partial class Form_hoa_don : Form
    {

        private DataTable tblCL;
        public Form_hoa_don()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "select * from HoaDon_Go";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView_hd.DataSource = tblCL; //Nguồn dữ liệu

            dataGridView_hd.Dock = DockStyle.Fill;

            dataGridView_hd.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView_hd.Columns[1].HeaderText = "Tên ngày tạo";
            dataGridView_hd.Columns[2].HeaderText = "Thu ngân";
            dataGridView_hd.Columns[3].HeaderText = "Thành tiền";
            dataGridView_hd.Columns[4].HeaderText = "Khách trả tiền mặt";
            dataGridView_hd.Columns[5].HeaderText = "Trả lại";

            dataGridView_hd.Columns[0].Width = 320;
            dataGridView_hd.Columns[1].Width = 200;
            dataGridView_hd.Columns[2].Width = 200;
            dataGridView_hd.Columns[3].Width = 200;
            dataGridView_hd.Columns[4].Width = 200;
            dataGridView_hd.Columns[5].Width = 200;

            dataGridView_hd.RowTemplate.Height = 50;
            dataGridView_hd.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_hd.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp


        }

        private void Form_hoa_don_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dataGridView_hd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* textBox_DM_ma_dm.Text = dataGridView_DM.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
             textBox_DM_ten_dm.Text = dataGridView_DM.CurrentRow.Cells["TenDanhMuc"].Value.ToString();*/


            string ma_hoa_don = dataGridView_hd.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            string ngay_tao = dataGridView_hd.CurrentRow.Cells["NgayTao"].Value.ToString();
            string thu_nggan = dataGridView_hd.CurrentRow.Cells["ThuNgan"].Value.ToString();
            string thanh_tien = dataGridView_hd.CurrentRow.Cells["ThanhTien"].Value.ToString();
            string khach_tra_tien_mat = dataGridView_hd.CurrentRow.Cells["KhachTraTienMat"].Value.ToString();
            string tra_lai = dataGridView_hd.CurrentRow.Cells["TraLai"].Value.ToString();
            Form_chi_tiet_hoa_don f = new Form_chi_tiet_hoa_don(ngay_tao, ma_hoa_don, thu_nggan, thanh_tien, khach_tra_tien_mat, tra_lai);
            f.Show();
        }
    }
}