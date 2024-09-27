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

    public partial class Form_nhanvien : Form
    {
        public DataTable dataTable;
        public Form_nhanvien()
        {
            InitializeComponent();
        }
        private bool validateForm()
        {
            if (txt_ten_nhan_vien.Text.Trim().Length == 0) //Nếu chưa nhập tên nhân viên
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ten_nhan_vien.Focus();
                return false;
            }
            if (comboBox_gioitinh.Text == "Chọn giới tính")
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;

            }


            if (txt_Dia_chi.Text.Trim().Length == 0) // Nếu chưa nhập địa chỉ
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Dia_chi.Focus();
                return false;
            }

            if (textBox_phone_number.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_phone_number.Focus();
                return false;
            }

            if (maskedTextBox_ngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox_ngaysinh.Focus();
                return false;
            }


            return true;

        }
        
        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM  NhanVien_Go";
            dataTable = Class.Functions.GetDataToTable(sql);
            dataGridView_nhanvien.DataSource = dataTable; //do du lieu vao datagridview

            dataGridView_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView_nhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView_nhanvien.Columns[2].HeaderText = "Giới tính";
            dataGridView_nhanvien.Columns[3].HeaderText = "Địa chỉ";
            dataGridView_nhanvien.Columns[4].HeaderText = "Điện thoại";
            dataGridView_nhanvien.Columns[5].HeaderText = "Ngày sinh";

            dataGridView_nhanvien.AllowUserToAddRows = false; //khong cho nguoi dung them du lieu truc tiep

            dataGridView_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
       
        }
        private void Form_nhanvien_Load(object sender, EventArgs e)
        {

            LoadDataGridView();

            bnt_nhanvienthem.Enabled = true;
            btn_nhanvienxoa.Enabled = true;
            txt_ma_nhan_vien.Enabled = false;


        }
        private void reset()
        {
            txt_ma_nhan_vien.Text = "";
            txt_ten_nhan_vien.Text = "";
            comboBox_gioitinh.Text = "";
            txt_Dia_chi.Text = "";
            textBox_phone_number.Text = "";
            maskedTextBox_ngaysinh.Text = "";


            bnt_nhanvienthem.Enabled = true;
            btn_sua.Enabled = true;
            btn_nhanvienxoa.Enabled = true;

            LoadDataGridView();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            reset();
            LoadDataGridView();

        }

        private void bnt_nhanvienthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    string sql;//Lưu câu lệnh sql


                    sql = "insert into NhanVien_Go values (N'" + txt_ten_nhan_vien.Text.Trim().ToString() + "',N'" + txt_Dia_chi.Text.Trim().ToString() + "','" + textBox_phone_number.Text.Trim().ToString() + "',\r\n\tN'" + comboBox_gioitinh.Text.Trim().ToString() + "','" + maskedTextBox_ngaysinh.Text.Trim().ToString() + "',N'Nhân viên')";
                    Class.Functions.RunSQL(sql);
                    reset();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        private void btn_nhanvienxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {
                    int MaNhanVien = Convert.ToInt32(txt_ma_nhan_vien.Text.Trim().ToString());
                   /* MessageBox.Show(MaNhanVien.ToString());*/
                    string sql = "delete from NhanVien_Go where MaNhanVien =" + MaNhanVien;
                    Class.Functions.RunSQL(sql);
                    reset();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err + "");

                }
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                try
                {
                    /*DataTable value = Class.Functions.GetDataToTable(sql);
                    var cell = value.Rows[0][0];*/



                    int MaNhanVien = Convert.ToInt32(txt_ma_nhan_vien.Text.Trim().ToString());

                    /*      MessageBox.Show(MaNhanVien + "");*/
                    //string sql2 = "UPDATE NhanVien_Go SET TenNhanVien = N'" + txt_ten_nhan_vien.Text.Trim().ToString() + "', DiaChi = N'" + txt_Dia_chi.Text.Trim().ToString() + "' WHERE MaNhanVien = " + MaNhanVien;

                   string sql2 = "UPDATE NhanVien_Go SET TenNhanVien = N'"+txt_ten_nhan_vien.Text.Trim().ToString() + "', DiaChi = N'"+txt_Dia_chi.Text.Trim().ToString() + "', SoDienThoai = '"+textBox_phone_number.Text.Trim().ToString() + "', GioiTinh = N'"+comboBox_gioitinh.Text.Trim().ToString() + "', NgaySinh = '"+maskedTextBox_ngaysinh.Text.Trim().ToString() + "' WHERE MaNhanVien = "+ MaNhanVien;


                    Class.Functions.RunSQL(sql2);
                    reset();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err + "");
                }
            }
        }
        // bam click se so lene texboxt
        private void dataGridView_nhanvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            txt_ma_nhan_vien.Text = dataGridView_nhanvien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_ten_nhan_vien.Text = dataGridView_nhanvien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txt_Dia_chi.Text = dataGridView_nhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            textBox_phone_number.Text = dataGridView_nhanvien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            comboBox_gioitinh.Text = dataGridView_nhanvien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            maskedTextBox_ngaysinh.Text = dataGridView_nhanvien.CurrentRow.Cells["NgaySinh"].Value.ToString();

        }

        private void btn_tim_kiem_nhan_vien_Click(object sender, EventArgs e)
        {

            if (txt_tim_kiem_nhan_vien.Text.Trim() == "")
            {
                MessageBox.Show("Không có tên ");
            }
            else
            {

                try
                {
                    string sql2 = "select * from NhanVien_Go WHERE TenNhanVien= N'" + txt_tim_kiem_nhan_vien.Text.Trim().ToString() + "'";
                    /*  Class.Functions.RunSQL(sql2);*/
                    /* validateForm();*/
                    dataTable = Class.Functions.GetDataToTable(sql2);
                    dataGridView_nhanvien.DataSource = dataTable; //do du lieu vao datagridview

                    dataGridView_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
                    dataGridView_nhanvien.Columns[1].HeaderText = "Tên nhân viên";
                    dataGridView_nhanvien.Columns[2].HeaderText = "Giới tính";
                    dataGridView_nhanvien.Columns[3].HeaderText = "Địa chỉ";
                    dataGridView_nhanvien.Columns[4].HeaderText = "Điện thoại";
                    dataGridView_nhanvien.Columns[5].HeaderText = "Ngày sinh";

                    dataGridView_nhanvien.AllowUserToAddRows = false; //khong cho nguoi dung them du lieu truc tiep

                    dataGridView_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

                    reset();


                }
                catch(Exception err)
                {
                    MessageBox.Show(err+"");
                }
            }

        }
    }
}