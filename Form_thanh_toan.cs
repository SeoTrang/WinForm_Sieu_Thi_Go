using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sieu_thi_go
{
    public partial class Form_thanh_toan : Form
    {

        private int masp;
        private string tensp;
        private string gia;
        private int soluong;
        private long thanhtien;

        private List<Form_thanh_toan> list_form_thanh_toan = new List<Form_thanh_toan>();

        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public long Thanhtien { get => thanhtien; set => thanhtien = value; }
        public List<Form_thanh_toan> List_form_thanh_toan { get => list_form_thanh_toan; set => list_form_thanh_toan = value; }
        public string Gia { get => gia; set => gia = value; }

        private Form_thanh_toan(int masqp,string tensp,string gia,int soluong,long thanhtien)
        {
            this.masp = masqp;
            this.tensp = tensp;
            this.gia = gia;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }

        public Form_thanh_toan()
        {
            InitializeComponent();
        }

        private bool validateForm()
        {
            if(textBox_TT_ma_sp.Text.Trim().ToString().Length == 0)
            {
                MessageBox.Show("Vui long nhập mã sản phẩm");
                return false;

            }
            if (textBox_TT_so_luong.Text.Trim().ToString().Length == 0)
            {
                MessageBox.Show("Vui long nhập số lượng sản phẩm");
                return false;

            }

            return true;
        }

        private void resetForm()
        {
            textBox_TT_ma_sp.Text = "";
            textBox_TT_so_luong.Text = "";
            textBox_TT_khach_tra_tien_mat.Text = "";
           
        }

       /* private DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }*/

        
        private void loadDataGridView()
        {
            dataGridView_TT.DataSource = this.list_form_thanh_toan.ToList();
            /*DataTable data1 = new DataTable();
            data1.Rows.Add(this.list_form_thanh_toan.ElementAt(0));*/

            /*     DataTable data1 = ToDataTable(this.list_form_thanh_toan);


                 dataGridView_TT.DataSource = data1;*/

            /* data.Rows = this.list_form_thanh_toan.ElementAt(0);*/




            dataGridView_TT.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView_TT.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView_TT.Columns[2].HeaderText = "Số Lượng";
            dataGridView_TT.Columns[3].HeaderText = "Thành tiền";
            dataGridView_TT.Columns[4].HeaderText = "Giá";

            dataGridView_TT.Columns[0].Width = 100;
            dataGridView_TT.Columns[1].Width = 500;
            dataGridView_TT.Columns[2].Width = 100;
            dataGridView_TT.Columns[3].Width = 100;
            dataGridView_TT.Columns[4].Width = 500;

            /*string[] row = new string[] {masp.ToString(),tensp,gia1.ToString(),soluong.ToString(),tt.ToString() };
            dataGridView_TT.Rows.Add(row);*/
        }

        private void btn_TT_them_Click(object sender, EventArgs e)
        {
            if(validateForm()){
                try
                {
                    int msp = Convert.ToInt32(textBox_TT_ma_sp.Text.Trim());
                    int sl = Convert.ToInt32(textBox_TT_so_luong.Text.Trim()); //so luong nhap vao




                    string sql = "select MaSanPham,TenSanPham,DonGiaBan from SanPham_Go where MaSanPham = " + msp;
                    DataTable data = Class.Functions.GetDataToTable(sql);

                    string tsp = data.Rows[0][1].ToString();

                    string gia1 = data.Rows[0][2].ToString();
                    long gia_int = Class.Functions.layGiaTuString(gia1);

                    /*MessageBox.Show(gia_int + "");*/


                    long tt = (long)gia_int * (long)sl;
                    string test1 = tt.ToString();
                    /* string format = test1.replace(/\B(?= (\d{ 3})+(? !\d))/g, ',');
                     MessageBox.Show(DateTime.Now+"");

                     var text = XTL.Utils.NumberToText(number);
                     var ntext = number.ToString("###,###,###,###,###");*/








                    this.list_form_thanh_toan.Add(new Form_thanh_toan(msp, tsp, gia1, sl, tt));
                    /*MessageBox.Show(this.list_form_thanh_toan.ElementAt(0).Masp + " heelo");*/


                    loadDataGridView();
                }
                catch(Exception err)
                {
                    MessageBox.Show("Mã sản phẩm không đúng");
                    textBox_TT_ma_sp.Focus();
                }


            }
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            /*var row = dataGridView_TT.CurrentCell.RowIndex;
            MessageBox.Show(this.list_form_thanh_toan.Count + " ");*/
            /*var len = dataGridView_TT.Rows.Count;
            MessageBox.Show(this.list_form_thanh_toan.Count + " ");*/
            DateTime dt = DateTime.Now;
            string timeNow = dt.ToString();
            string thuNgan = "Nguyễn văn a";
            string khach_tra_tien_mat = textBox_TT_khach_tra_tien_mat.Text.Trim().ToString();
            //hoa don

            string sql_hoa_don = "insert into HoaDon_Go values ('" + dt + "',N'" + thuNgan + "','" + 200.000 + "vnd','"+khach_tra_tien_mat+"','200.000vnd')";

            Class.Functions.RunSQL(sql_hoa_don);


            //chi tiet hoa don
            string sql_lay_id = "select MaHoaDon from HoaDon_Go where NgayTao = '" + timeNow + "' and ThuNgan = N'" + thuNgan + "'";
            DataTable data = Class.Functions.GetDataToTable(sql_lay_id);
            string id_hoa_don = data.Rows[0][0].ToString();

            var len = dataGridView_TT.Rows.Count;
            /*MessageBox.Show(dataGridView_TT.Rows[0][1] + "");*/
            /*MessageBox.Show(list_form_thanh_toan.ElementAt(0).tensp);*/



            string sql_chen_chi_tiet_hoa_don ;
            for (int i = 0; i < len; i++)
            {
                sql_chen_chi_tiet_hoa_don = "insert into ChiTieHoaDon_Go values ("+this.list_form_thanh_toan.ElementAt(i).masp+","+this.list_form_thanh_toan.ElementAt(i).soluong+","+id_hoa_don+",N'"+this.list_form_thanh_toan.ElementAt(i).tensp+"','"+this.list_form_thanh_toan.ElementAt(i).gia+"vnd','900.000vnd')";

                Class.Functions.RunSQL(sql_chen_chi_tiet_hoa_don);

            }

            this.list_form_thanh_toan = new List<Form_thanh_toan>();
            loadDataGridView();
            resetForm();
        }
    }
}
