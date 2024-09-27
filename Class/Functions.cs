using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; //su dung doi tuong messagebox 
using System.Drawing;

namespace sieu_thi_go.Class
{
    internal class Functions
    {

        public static SqlConnection con;


        //tao phuong thuc connect
        public static void Connect()
        {
            con = new SqlConnection();
            //Data Source=TRANGTM;Initial Catalog=sieu_thi_go;Integrated Security=True
            con.ConnectionString = "Data Source=TRANGTM;Initial Catalog=sieu_thi_go;Integrated Security=True";

            if(con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Da ket noi db !");
            }
            else
            {
                MessageBox.Show("ket noi that bai !!!");
            }
        }

        // tao phuong thuc disconnect
        public static void Disconnect()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();//giai phong bo tai nguyen
                con = null;

            }
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }


        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }


        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);//Đổ kết quả từ câu lệnh sql vào table
            
            return table;
        }

        //lay du lieu chuoi
        public static int GetDataString(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int value;
            value = reader.GetInt32(0);

            return value;
        }

        public static long layGiaTuString(string s)
        {
            
            try
            {
                int gia = 0;
                var charsToRemove = new string[] { "@", ",", ".", ";", "'", "vnđ","vnd" };
                foreach (var c in charsToRemove)
                {
                    s = s.Replace(c, string.Empty);
                }
                gia = (int)Convert.ToInt64(s.ToString());
                return gia;
            }
            catch(Exception err)
            {

            }
            return 0;
        }

     

    }
}
