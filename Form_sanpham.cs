using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sieu_thi_go
{
    public partial class Form_sanpham : Form
    {
        public DataTable tblCL;
        public Form_sanpham()
        {
            InitializeComponent();
        }

        private bool validateForm()
        {
            if (textBox_SP_ten_sp.Text.Trim().Length == 0) //Nếu chưa nhập ten san pham
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_SP_ten_sp.Focus();
                return false;
            }
            if (textBox_SP_so_luong_sp.Text.Trim().Length == 0) //Nếu chưa nhập tên danh muc
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_SP_so_luong_sp.Focus();
                return false;
            }

            if (textBox_SP_don_gia_nhap.Text.Trim().Length == 0) // neu chua nhap don gia nhap 
            {
                MessageBox.Show("Vui lòng nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_SP_don_gia_nhap.Focus();
                return false;
            }

            if (textBox_SP_don_gia_ban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_SP_don_gia_ban.Focus();
                return false;
            }

            if (comboBox_SP_danh_muc.Text == "Chọn danh mục")
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;

            }

            return true;

        }
        

        private void Form_sanpham_Load(object sender, EventArgs e)
        {

            loadDataGridView();

        }

        private void loadDataGridView()
        {
            string sql = "SELECT * FROM SanPham_Go";
            tblCL = Class.Functions.GetDataToTable(sql);
            dataGridView_SP_san_pham.DataSource = tblCL; //do du lieu vao datagridview

            dataGridView_SP_san_pham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView_SP_san_pham.Columns[1].HeaderText = "Mã Danh Mục";
            dataGridView_SP_san_pham.Columns[2].HeaderText = "Tên Sản Phẩm";
            dataGridView_SP_san_pham.Columns[3].HeaderText = "Số Lượng Sản Phẩm";
            dataGridView_SP_san_pham.Columns[4].HeaderText = "Đơn Giá Nhập";
            dataGridView_SP_san_pham.Columns[5].HeaderText = "Đơn Giá Bán";
            dataGridView_SP_san_pham.Columns[6].HeaderText = "Link Hình Ảnh";
            dataGridView_SP_san_pham.Columns[7].HeaderText = "Ghi Chú";


            dataGridView_SP_san_pham.Columns[0].Width = 100;
            dataGridView_SP_san_pham.Columns[1].Width = 100;
            dataGridView_SP_san_pham.Columns[2].Width = 400;
            dataGridView_SP_san_pham.Columns[3].Width = 100;
            dataGridView_SP_san_pham.Columns[4].Width = 200;
            dataGridView_SP_san_pham.Columns[5].Width = 200;
            dataGridView_SP_san_pham.Columns[6].Width = 100;
            dataGridView_SP_san_pham.Columns[7].Width = 100;

            dataGridView_SP_san_pham.RowTemplate.Height = 50;

            dataGridView_SP_san_pham.AllowUserToAddRows = false; //khong cho nguoi dung them du lieu truc tiep
            dataGridView_SP_san_pham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp


            btn_SP_sua.Enabled = false;
            btn_SP_xoa.Enabled = false;
            textBox_SP_ma_sp.Enabled = false;

            getdataDanhMuc();
        }

        private void getdataDanhMuc()
        {
            string sql = "SELECT TenDanhMuc FROM DanhMuc_Go";
            tblCL = Class.Functions.GetDataToTable(sql);
            /*MessageBox.Show(tblCL.Rows[1][0]+"");*/
            /* var cell = tblCL.Rows[0][0];
             MessageBox.Show(tblCL.Rows.Count+"");*/
            int len = tblCL.Rows.Count;

            for (int i = 0; i < len; i++)
            {
                comboBox_SP_danh_muc.Items.Add(tblCL.Rows[i][0]);
            }

        }

        private void dataGridView_SP_san_pham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_SP_ma_sp.Text = dataGridView_SP_san_pham.CurrentRow.Cells["MaSanPham"].Value.ToString();
            textBox_SP_ten_sp.Text = dataGridView_SP_san_pham.CurrentRow.Cells["TenSanPham"].Value.ToString();
            textBox_SP_so_luong_sp.Text = dataGridView_SP_san_pham.CurrentRow.Cells["SoLuongSP"].Value.ToString();
            textBox_SP_don_gia_nhap.Text = dataGridView_SP_san_pham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            textBox_SP_don_gia_ban.Text = dataGridView_SP_san_pham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            textBox_SP_hinh_anh_sp.Text = dataGridView_SP_san_pham.CurrentRow.Cells["Img"].Value.ToString();
            textBox_SP_gi_chu.Text = dataGridView_SP_san_pham.CurrentRow.Cells["GhiChu"].Value.ToString();


            btn_SP_them.Enabled = false;
            btn_SP_sua.Enabled = true;
            btn_SP_xoa.Enabled = true; 
        }

        private void reset()
        {
            textBox_SP_ma_sp.Text = "";
            textBox_SP_ten_sp.Text = "";
            textBox_SP_so_luong_sp.Text = "";
            textBox_SP_don_gia_nhap.Text = "";
            textBox_SP_don_gia_ban.Text = "";
            textBox_SP_hinh_anh_sp.Text = "";
            textBox_SP_gi_chu.Text = "";

            btn_SP_them.Enabled = true;
            btn_SP_sua.Enabled = false;
            btn_SP_xoa.Enabled = false;

           
        }

        private void btn_SP_refresh_Click(object sender, EventArgs e)
        {
            reset();
            loadDataGridView();
        }


        private void btn_SP_them_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql



            if (validateForm())
            {
                try
                {
                    string danhmuc = comboBox_SP_danh_muc.Text.ToString();
                    sql = "SELECT MaDanhMuc FROM DanhMuc_Go WHERE TenDanhMuc=N'" + danhmuc + "'";

                    //SqlDataReader data = Class.Functions.GetDataString(sql);

                    /*MessageBox.Show("" + comboBox_SP_danh_muc.Text);*/
                    DataTable value = Class.Functions.GetDataToTable(sql);
                    var cell = value.Rows[0][0];


                    /*   MessageBox.Show(cell + "");*/
                    string sql2;

                    int madanhmuc = Convert.ToInt32(cell.ToString());
                    int soluong = Convert.ToInt32(textBox_SP_so_luong_sp.Text.Trim().ToString());


                    sql2 = "insert into SanPham_Go(MaDanhMuc, TenSanPham, SoLuongSP, DonGiaNhap, DonGiaBan,Img,GhiChu)" +
                    "values" +
                    "(" + madanhmuc + ",N'" + textBox_SP_ten_sp.Text.Trim().ToString() + "'," + soluong + ",N'" + textBox_SP_don_gia_nhap.Text.Trim().ToString() + "vnđ',N'" + textBox_SP_don_gia_ban.Text.Trim().ToString() + "vnđ',N'" + textBox_SP_hinh_anh_sp.Text.Trim().ToString() + "',N'" + textBox_SP_gi_chu.Text.Trim().ToString() + "')";

                    Class.Functions.RunSQL(sql2);
                    /*MessageBox.Show(sql2);*/
                    loadDataGridView();



                }
                catch (Exception err)
                {
                    MessageBox.Show(err + "");
                }
            }
        }

        private void btn_SP_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int mahang = Convert.ToInt32(textBox_SP_ma_sp.Text.Trim().ToString());
                string sql = "delete from SanPham_Go where MaSanPham="+mahang;
                Class.Functions.RunSQL(sql);   
                reset();
                loadDataGridView();

            }
            catch(Exception err)
            {

            }
        }

        private void btn_SP_sua_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                try
                {
                    string danhmuc = comboBox_SP_danh_muc.Text.ToString();
                    string sql = "SELECT MaDanhMuc FROM DanhMuc_Go WHERE TenDanhMuc=N'" + danhmuc + "'";

                    //SqlDataReader data = Class.Functions.GetDataString(sql);

                    /*MessageBox.Show("" + comboBox_SP_danh_muc.Text);*/
                    DataTable value = Class.Functions.GetDataToTable(sql);
                    var cell = value.Rows[0][0];


                    /*   MessageBox.Show(cell + "");*/


                    int madanhmuc = Convert.ToInt32(cell.ToString());
                    int soluong = Convert.ToInt32(textBox_SP_so_luong_sp.Text.Trim().ToString());

                    int masanpham = Convert.ToInt32(textBox_SP_ma_sp.Text.Trim().ToString());
                    string sql2 = "UPDATE SanPham_Go SET MaDanhMuc = " +
                        madanhmuc +
                        ",TenSanPham = N'" +
                        textBox_SP_ten_sp.Text.Trim().ToString() +
                        "'," +
                        "SoLuongSp = " +
                        soluong +
                        ",DonGiaNhap = N'" +
                        textBox_SP_don_gia_nhap.Text.Trim().ToString() +
                        "vnđ',DonGiaBan = N'" +
                        textBox_SP_don_gia_ban.Text.Trim().ToString() +
                        "vnđ',Img = N'" +
                        textBox_SP_hinh_anh_sp.Text.Trim().ToString() +
                        "',GhiChu = N'" +
                        textBox_SP_gi_chu.Text.Trim().ToString() +
                        "' WHERE MaSanPham =" + masanpham;

                    Class.Functions.RunSQL(sql2);

                    loadDataGridView();
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err + "");
                }
            }
        }

        private void btn_SP_tim_kiem_Click(object sender, EventArgs e)
        {
            string search = textBox_SP_tim_kiem.Text.Trim().ToString();
            string sql = "select * from SanPham_Go where TenSanPham = '"+search+"'";
            tblCL = Class.Functions.GetDataToTable(sql);
            dataGridView_SP_san_pham.DataSource = tblCL; //do du lieu vao datagridview

            dataGridView_SP_san_pham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView_SP_san_pham.Columns[1].HeaderText = "Mã Danh Mục";
            dataGridView_SP_san_pham.Columns[2].HeaderText = "Tên Sản Phẩm";
            dataGridView_SP_san_pham.Columns[3].HeaderText = "Số Lượng Sản Phẩm";
            dataGridView_SP_san_pham.Columns[4].HeaderText = "Đơn Giá Nhập";
            dataGridView_SP_san_pham.Columns[5].HeaderText = "Đơn Giá Bán";
            dataGridView_SP_san_pham.Columns[6].HeaderText = "Link Hình Ảnh";
            dataGridView_SP_san_pham.Columns[7].HeaderText = "Ghi Chú";


            dataGridView_SP_san_pham.Columns[0].Width = 100;
            dataGridView_SP_san_pham.Columns[1].Width = 100;
            dataGridView_SP_san_pham.Columns[2].Width = 400;
            dataGridView_SP_san_pham.Columns[3].Width = 100;
            dataGridView_SP_san_pham.Columns[4].Width = 200;
            dataGridView_SP_san_pham.Columns[5].Width = 200;
            dataGridView_SP_san_pham.Columns[6].Width = 100;
            dataGridView_SP_san_pham.Columns[7].Width = 100;

            dataGridView_SP_san_pham.RowTemplate.Height = 50;

            dataGridView_SP_san_pham.AllowUserToAddRows = false; //khong cho nguoi dung them du lieu truc tiep
            dataGridView_SP_san_pham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp


            btn_SP_sua.Enabled = false;
            btn_SP_xoa.Enabled = false;
            textBox_SP_ma_sp.Enabled = false;

            getdataDanhMuc();
        }
    }
}
