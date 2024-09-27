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
    public partial class Form_chi_tiet_hoa_don : Form
    {
        private DataTable tblCL;
        public Form_chi_tiet_hoa_don()
        {
            InitializeComponent();
        }

        public Form_chi_tiet_hoa_don(string txt_ngay, string ma_hoa_don, string txt_thu_ngan, string txt_tong_tien, string txt_khach_tra_tien_mat, string txt_tra_lai)
        {


            InitializeComponent();

            this.txt_ma_chi_tiet_hoa_don.Text = ma_hoa_don;



            this.txt_thu_ngan.Text = txt_thu_ngan;

            this.txt_tong_tien.Text = txt_tong_tien;

            this.txt_khach_tra_tien_mat.Text = txt_khach_tra_tien_mat;

            this.txt_tra_lai.Text = txt_tra_lai;

            try
            {
                int ma_hoa_don_int = Convert.ToInt32(ma_hoa_don);
                LoadDataGridView(ma_hoa_don_int);
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " ");
            }

        }



        private void LoadDataGridView(int maHoaDon)
        {
            ;
            string sql;
            sql = "select TenSanPham,GiaBan,SoLuongBan,ThanhTien from ChiTieHoaDon_Go where MaHoaDon = " + maHoaDon;
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView_chi_tiet_hoa_don.DataSource = tblCL; //Nguồn dữ liệu

            /*       dataGridView_chi_tiet_hoa_don.Dock = DockStyle.Fill;*/

            dataGridView_chi_tiet_hoa_don.Columns[0].HeaderText = "Tên mặt hàng";
            dataGridView_chi_tiet_hoa_don.Columns[1].HeaderText = "Giá bán";
            dataGridView_chi_tiet_hoa_don.Columns[2].HeaderText = "Số lượng";
            dataGridView_chi_tiet_hoa_don.Columns[3].HeaderText = "Thành tiền";


            dataGridView_chi_tiet_hoa_don.Columns[0].Width = 250;
            dataGridView_chi_tiet_hoa_don.Columns[1].Width = 100;
            dataGridView_chi_tiet_hoa_don.Columns[2].Width = 100;
            dataGridView_chi_tiet_hoa_don.Columns[3].Width = 100;


            dataGridView_chi_tiet_hoa_don.RowTemplate.Height = 50;
            dataGridView_chi_tiet_hoa_don.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_chi_tiet_hoa_don.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp


        }

        private void Form_chi_tiet_hoa_don_Load(object sender, EventArgs e)
        {

        }
    }
}