namespace sieu_thi_go
{
    partial class Form_nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.BackgroundWorker backgroundWorker1;
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_nhanvienxoa = new System.Windows.Forms.Button();
            this.bnt_nhanvienthem = new System.Windows.Forms.Button();
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ma_nhan_vien = new System.Windows.Forms.TextBox();
            this.txt_ten_nhan_vien = new System.Windows.Forms.TextBox();
            this.txt_Dia_chi = new System.Windows.Forms.TextBox();
            this.txt_tim_kiem_nhan_vien = new System.Windows.Forms.TextBox();
            this.btn_tim_kiem_nhan_vien = new System.Windows.Forms.Button();
            this.ccb_loc = new System.Windows.Forms.ComboBox();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.maskedTextBox_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_nhanvienxoa);
            this.panel2.Controls.Add(this.bnt_nhanvienthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 83);
            this.panel2.TabIndex = 3;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(396, 21);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "&Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(261, 21);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "&Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_nhanvienxoa
            // 
            this.btn_nhanvienxoa.Location = new System.Drawing.Point(132, 21);
            this.btn_nhanvienxoa.Name = "btn_nhanvienxoa";
            this.btn_nhanvienxoa.Size = new System.Drawing.Size(75, 23);
            this.btn_nhanvienxoa.TabIndex = 1;
            this.btn_nhanvienxoa.Text = "&Xóa";
            this.btn_nhanvienxoa.UseVisualStyleBackColor = true;
            this.btn_nhanvienxoa.Click += new System.EventHandler(this.btn_nhanvienxoa_Click);
            // 
            // bnt_nhanvienthem
            // 
            this.bnt_nhanvienthem.Location = new System.Drawing.Point(12, 21);
            this.bnt_nhanvienthem.Name = "bnt_nhanvienthem";
            this.bnt_nhanvienthem.Size = new System.Drawing.Size(75, 23);
            this.bnt_nhanvienthem.TabIndex = 0;
            this.bnt_nhanvienthem.Text = "&Thêm";
            this.bnt_nhanvienthem.UseVisualStyleBackColor = true;
            this.bnt_nhanvienthem.Click += new System.EventHandler(this.bnt_nhanvienthem_Click);
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(15, 197);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.ReadOnly = true;
            this.dataGridView_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(1080, 155);
            this.dataGridView_nhanvien.TabIndex = 2;
            this.dataGridView_nhanvien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhanvien_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(513, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày sinh";
            // 
            // txt_ma_nhan_vien
            // 
            this.txt_ma_nhan_vien.Location = new System.Drawing.Point(223, 56);
            this.txt_ma_nhan_vien.Multiline = true;
            this.txt_ma_nhan_vien.Name = "txt_ma_nhan_vien";
            this.txt_ma_nhan_vien.Size = new System.Drawing.Size(169, 28);
            this.txt_ma_nhan_vien.TabIndex = 7;
            // 
            // txt_ten_nhan_vien
            // 
            this.txt_ten_nhan_vien.Location = new System.Drawing.Point(223, 103);
            this.txt_ten_nhan_vien.Multiline = true;
            this.txt_ten_nhan_vien.Name = "txt_ten_nhan_vien";
            this.txt_ten_nhan_vien.Size = new System.Drawing.Size(169, 28);
            this.txt_ten_nhan_vien.TabIndex = 8;
            // 
            // txt_Dia_chi
            // 
            this.txt_Dia_chi.Location = new System.Drawing.Point(543, 56);
            this.txt_Dia_chi.Multiline = true;
            this.txt_Dia_chi.Name = "txt_Dia_chi";
            this.txt_Dia_chi.Size = new System.Drawing.Size(169, 28);
            this.txt_Dia_chi.TabIndex = 10;
            // 
            // txt_tim_kiem_nhan_vien
            // 
            this.txt_tim_kiem_nhan_vien.Location = new System.Drawing.Point(781, 52);
            this.txt_tim_kiem_nhan_vien.Multiline = true;
            this.txt_tim_kiem_nhan_vien.Name = "txt_tim_kiem_nhan_vien";
            this.txt_tim_kiem_nhan_vien.Size = new System.Drawing.Size(123, 28);
            this.txt_tim_kiem_nhan_vien.TabIndex = 13;
            // 
            // btn_tim_kiem_nhan_vien
            // 
            this.btn_tim_kiem_nhan_vien.Location = new System.Drawing.Point(926, 52);
            this.btn_tim_kiem_nhan_vien.Name = "btn_tim_kiem_nhan_vien";
            this.btn_tim_kiem_nhan_vien.Size = new System.Drawing.Size(75, 27);
            this.btn_tim_kiem_nhan_vien.TabIndex = 14;
            this.btn_tim_kiem_nhan_vien.Text = "Tìm kiếm";
            this.btn_tim_kiem_nhan_vien.UseVisualStyleBackColor = true;
            this.btn_tim_kiem_nhan_vien.Click += new System.EventHandler(this.btn_tim_kiem_nhan_vien_Click);
            // 
            // ccb_loc
            // 
            this.ccb_loc.FormattingEnabled = true;
            this.ccb_loc.Location = new System.Drawing.Point(781, 107);
            this.ccb_loc.Name = "ccb_loc";
            this.ccb_loc.Size = new System.Drawing.Size(123, 21);
            this.ccb_loc.TabIndex = 15;
            this.ccb_loc.Text = "Lọc";
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(223, 151);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(169, 21);
            this.comboBox_gioitinh.TabIndex = 15;
            this.comboBox_gioitinh.Text = "Giới tính";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(926, 108);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 16;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_ngaysinh
            // 
            this.maskedTextBox_ngaysinh.Location = new System.Drawing.Point(543, 149);
            this.maskedTextBox_ngaysinh.Mask = "00/00/0000";
            this.maskedTextBox_ngaysinh.Name = "maskedTextBox_ngaysinh";
            this.maskedTextBox_ngaysinh.Size = new System.Drawing.Size(169, 20);
            this.maskedTextBox_ngaysinh.TabIndex = 17;
            this.maskedTextBox_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            //
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.maskedTextBox_ngaysinh);
            this.panel1.Controls.Add(this.btn_loc);
            this.panel1.Controls.Add(this.comboBox_gioitinh);
            this.panel1.Controls.Add(this.ccb_loc);
            this.panel1.Controls.Add(this.btn_tim_kiem_nhan_vien);
            this.panel1.Controls.Add(this.txt_tim_kiem_nhan_vien);
            this.panel1.Controls.Add(this.textBox_phone_number);
            this.panel1.Controls.Add(this.txt_Dia_chi);
            this.panel1.Controls.Add(this.txt_ten_nhan_vien);
            this.panel1.Controls.Add(this.txt_ma_nhan_vien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 182);
            this.panel1.TabIndex = 0;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(537, 103);
            this.textBox_phone_number.Multiline = true;
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(169, 28);
            this.textBox_phone_number.TabIndex = 10;
            // 
            // Form_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.dataGridView_nhanvien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_nhanvien";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Form_nhanvien";
            this.Load += new System.EventHandler(this.Form_nhanvien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_nhanvienxoa;
        private System.Windows.Forms.Button bnt_nhanvienthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ma_nhan_vien;
        private System.Windows.Forms.TextBox txt_ten_nhan_vien;
        private System.Windows.Forms.TextBox txt_Dia_chi;
        private System.Windows.Forms.TextBox txt_tim_kiem_nhan_vien;
        private System.Windows.Forms.Button btn_tim_kiem_nhan_vien;
        private System.Windows.Forms.ComboBox ccb_loc;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ngaysinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_phone_number;
    }
}