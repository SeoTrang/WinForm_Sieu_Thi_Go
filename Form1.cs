using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sieu_thi_go.Class;

namespace sieu_thi_go
{
    public partial class Form1 : Form
    {
        private Form CurreentFromChild;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int i)
        {
            InitializeComponent();
            OpenChildFrom(new Form_trang_chu());
        }
        

        private void OpenChildFrom(Form chiLdFrom)
        {
            if (CurreentFromChild != null)
            {
                CurreentFromChild.Close();

            }
            CurreentFromChild = chiLdFrom;
            chiLdFrom.TopLevel = false;
            chiLdFrom.FormBorderStyle = FormBorderStyle.None;
            chiLdFrom.Dock = DockStyle.Fill;
            panel_fill.Controls.Add(chiLdFrom);
            panel_fill.Tag = chiLdFrom;
            chiLdFrom.BringToFront();
            chiLdFrom.Show();
                    
        }

     

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_trang_chu());
           

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_sanpham());

        }

      

       

        private void btn_danhmuc_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_danh_muc());
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_thanh_toan());
        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_sanpham());
        }

        private void btn_hoa_don_Click(object sender,EventArgs e)
        {
            OpenChildFrom(new Form_hoa_don());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Class.Functions.Connect();
            Functions.Connect();
        }

        private void btn_nhan_vien_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Form_nhanvien());
        }
    }
}
