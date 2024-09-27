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
    public partial class Form_danh_muc : Form
    {
        DataTable tblCL; //Chứa dữ liệu bảng Chất liệu
        public Form_danh_muc()
        {
            InitializeComponent();
        }

        private bool validateForm()
        {
          
            if (textBox_DM_ten_dm.Text.Trim().Length == 0) //Nếu chưa nhập tên danh muc
            {
                MessageBox.Show("Vui lòng nhập tên danh muc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_DM_ten_dm.Focus();
                return false;
            }

            return true;
        }

        private void Form_danh_muc_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            btn_DM_them.Enabled = true;
            btn_DM_sua.Enabled = false;
            btn_DM_xoa.Enabled = false;
            
            textBox_DM_ma_dm.Enabled = false;
        }

        private void ResetValue()
        {
            textBox_DM_ma_dm.Text = "";
            textBox_DM_ten_dm.Text = "";
           
        }




        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM DanhMuc_Go";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView_DM.DataSource = tblCL; //Nguồn dữ liệu

            dataGridView_DM.Dock = DockStyle.Fill;
            
            dataGridView_DM.Columns[0].HeaderText = "Mã danh mục";
            dataGridView_DM.Columns[1].HeaderText = "Tên danh mục";
            dataGridView_DM.Columns[2].HeaderText = "Số lượng sản phẩm";
            dataGridView_DM.Columns[0].Width = 320;
            dataGridView_DM.Columns[1].Width = 500;
            dataGridView_DM.Columns[2].Width = 500;

            dataGridView_DM.RowTemplate.Height = 50;
            dataGridView_DM.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DM.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp



        }

   /*     private void dataGridView_DM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_DM_ma_dm.Text = dataGridView_DM.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            textBox_DM_ten_dm.Text = dataGridView_DM.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
        }*/

        private void dataGridView_DM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_DM_ma_dm.Text = dataGridView_DM.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            textBox_DM_ten_dm.Text = dataGridView_DM.CurrentRow.Cells["TenDanhMuc"].Value.ToString();

            btn_DM_them.Enabled = false;
            btn_DM_sua.Enabled = true;
            btn_DM_xoa.Enabled = true;
     
        }

        private void btn_DM_them_Click(object sender, EventArgs e)
        {
        /*    MessageBox.Show("click them");*/
            string sql; //Lưu lệnh sql

            if (validateForm())
            {
                try
                {
                    

                    sql = "INSERT INTO DanhMuc_Go VALUES(N'" + textBox_DM_ten_dm.Text + "'" + ','+0+")";

                    
                    Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                                                 // LoadDataGridView(); //Nạp lại DataGridView
                    ResetValue();
                    LoadDataGridView();
                    /* btnXoa.Enabled = true;
                     btnThem.Enabled = true;
                     btnSua.Enabled = true;
                     btnBoQua.Enabled = false;
                     btnLuu.Enabled = false;
                     txtMaChatLieu.Enabled = false;*/
                }
                catch (Exception err)
                {
                    MessageBox.Show(err + " ");

                }
            }
        }

        private void btn_DM_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            textBox_DM_ma_dm.Text = "";
            textBox_DM_ten_dm.Text = "";
            btn_DM_them.Enabled = true;
            btn_DM_sua.Enabled = false;
            btn_DM_xoa.Enabled = false;


        
        }

        private void btn_DM_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (validateForm())
            {
                try
                {
                    int madanhmuc = Convert.ToInt32(textBox_DM_ma_dm.Text.Trim().ToString());

                    sql = "UPDATE DanhMuc_Go SET  TenDanhmuc = N'"+textBox_DM_ten_dm.Text.Trim().ToString()+"' WHERE MaDanhMuc ="+madanhmuc;
                    Class.Functions.RunSQL(sql);
                    LoadDataGridView();
                }
                catch(Exception err)
                {

                }
            }
        }

        private void btn_DM_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int madanhmuc = Convert.ToInt32(textBox_DM_ma_dm.Text.Trim().ToString());
                string sql = "delete from DanhMuc_Go where MaDanhmuc = " + madanhmuc;
                Class.Functions.RunSQL(sql);

                LoadDataGridView();
                
            }catch(Exception err)
            {
                MessageBox.Show(err+" ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
