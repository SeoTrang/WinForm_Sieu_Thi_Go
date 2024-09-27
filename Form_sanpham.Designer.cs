namespace sieu_thi_go
{
    partial class Form_sanpham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_SP_danh_muc = new System.Windows.Forms.ComboBox();
            this.btn_SP_tim_kiem = new System.Windows.Forms.Button();
            this.textBox_SP_tim_kiem = new System.Windows.Forms.TextBox();
            this.textBox_SP_gi_chu = new System.Windows.Forms.TextBox();
            this.textBox_SP_don_gia_ban = new System.Windows.Forms.TextBox();
            this.textBox_SP_don_gia_nhap = new System.Windows.Forms.TextBox();
            this.textBox_SP_so_luong_sp = new System.Windows.Forms.TextBox();
            this.textBox_SP_ten_sp = new System.Windows.Forms.TextBox();
            this.textBox_SP_ma_sp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_SP_hinh_anh_sp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SP_refresh = new System.Windows.Forms.Button();
            this.btn_SP_sua = new System.Windows.Forms.Button();
            this.btn_SP_xoa = new System.Windows.Forms.Button();
            this.btn_SP_them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_SP_san_pham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP_san_pham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.comboBox_SP_danh_muc);
            this.panel1.Controls.Add(this.btn_SP_tim_kiem);
            this.panel1.Controls.Add(this.textBox_SP_tim_kiem);
            this.panel1.Controls.Add(this.textBox_SP_gi_chu);
            this.panel1.Controls.Add(this.textBox_SP_don_gia_ban);
            this.panel1.Controls.Add(this.textBox_SP_don_gia_nhap);
            this.panel1.Controls.Add(this.textBox_SP_so_luong_sp);
            this.panel1.Controls.Add(this.textBox_SP_ten_sp);
            this.panel1.Controls.Add(this.textBox_SP_ma_sp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_SP_hinh_anh_sp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 309);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_SP_danh_muc
            // 
            this.comboBox_SP_danh_muc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_SP_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SP_danh_muc.FormattingEnabled = true;
            this.comboBox_SP_danh_muc.Location = new System.Drawing.Point(1084, 157);
            this.comboBox_SP_danh_muc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SP_danh_muc.Name = "comboBox_SP_danh_muc";
            this.comboBox_SP_danh_muc.Size = new System.Drawing.Size(305, 28);
            this.comboBox_SP_danh_muc.TabIndex = 19;
            this.comboBox_SP_danh_muc.Text = "Chọn danh mục";
            // 
            // btn_SP_tim_kiem
            // 
            this.btn_SP_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SP_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP_tim_kiem.Image = global::sieu_thi_go.Properties.Resources.icons8_search_25__2___1_;
            this.btn_SP_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SP_tim_kiem.Location = new System.Drawing.Point(917, 242);
            this.btn_SP_tim_kiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SP_tim_kiem.Name = "btn_SP_tim_kiem";
            this.btn_SP_tim_kiem.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_SP_tim_kiem.Size = new System.Drawing.Size(150, 50);
            this.btn_SP_tim_kiem.TabIndex = 18;
            this.btn_SP_tim_kiem.Text = "Tìm kiếm";
            this.btn_SP_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_SP_tim_kiem.Click += new System.EventHandler(this.btn_SP_tim_kiem_Click);
            // 
            // textBox_SP_tim_kiem
            // 
            this.textBox_SP_tim_kiem.Location = new System.Drawing.Point(1084, 258);
            this.textBox_SP_tim_kiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_tim_kiem.Multiline = true;
            this.textBox_SP_tim_kiem.Name = "textBox_SP_tim_kiem";
            this.textBox_SP_tim_kiem.Size = new System.Drawing.Size(595, 34);
            this.textBox_SP_tim_kiem.TabIndex = 17;
            // 
            // textBox_SP_gi_chu
            // 
            this.textBox_SP_gi_chu.Location = new System.Drawing.Point(1084, 102);
            this.textBox_SP_gi_chu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_gi_chu.Multiline = true;
            this.textBox_SP_gi_chu.Name = "textBox_SP_gi_chu";
            this.textBox_SP_gi_chu.Size = new System.Drawing.Size(595, 34);
            this.textBox_SP_gi_chu.TabIndex = 14;
            // 
            // textBox_SP_don_gia_ban
            // 
            this.textBox_SP_don_gia_ban.Location = new System.Drawing.Point(160, 258);
            this.textBox_SP_don_gia_ban.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_don_gia_ban.Multiline = true;
            this.textBox_SP_don_gia_ban.Name = "textBox_SP_don_gia_ban";
            this.textBox_SP_don_gia_ban.Size = new System.Drawing.Size(464, 34);
            this.textBox_SP_don_gia_ban.TabIndex = 13;
            // 
            // textBox_SP_don_gia_nhap
            // 
            this.textBox_SP_don_gia_nhap.Location = new System.Drawing.Point(160, 212);
            this.textBox_SP_don_gia_nhap.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_don_gia_nhap.Multiline = true;
            this.textBox_SP_don_gia_nhap.Name = "textBox_SP_don_gia_nhap";
            this.textBox_SP_don_gia_nhap.Size = new System.Drawing.Size(464, 34);
            this.textBox_SP_don_gia_nhap.TabIndex = 12;
            // 
            // textBox_SP_so_luong_sp
            // 
            this.textBox_SP_so_luong_sp.Location = new System.Drawing.Point(160, 161);
            this.textBox_SP_so_luong_sp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_so_luong_sp.Multiline = true;
            this.textBox_SP_so_luong_sp.Name = "textBox_SP_so_luong_sp";
            this.textBox_SP_so_luong_sp.Size = new System.Drawing.Size(464, 34);
            this.textBox_SP_so_luong_sp.TabIndex = 11;
            // 
            // textBox_SP_ten_sp
            // 
            this.textBox_SP_ten_sp.Location = new System.Drawing.Point(160, 114);
            this.textBox_SP_ten_sp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_ten_sp.Multiline = true;
            this.textBox_SP_ten_sp.Name = "textBox_SP_ten_sp";
            this.textBox_SP_ten_sp.Size = new System.Drawing.Size(464, 34);
            this.textBox_SP_ten_sp.TabIndex = 10;
            // 
            // textBox_SP_ma_sp
            // 
            this.textBox_SP_ma_sp.Location = new System.Drawing.Point(160, 66);
            this.textBox_SP_ma_sp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_ma_sp.Multiline = true;
            this.textBox_SP_ma_sp.Name = "textBox_SP_ma_sp";
            this.textBox_SP_ma_sp.Size = new System.Drawing.Size(464, 34);
            this.textBox_SP_ma_sp.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(981, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Danh mục";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(981, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ghi chú";
            // 
            // textBox_SP_hinh_anh_sp
            // 
            this.textBox_SP_hinh_anh_sp.Location = new System.Drawing.Point(1084, 54);
            this.textBox_SP_hinh_anh_sp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SP_hinh_anh_sp.Multiline = true;
            this.textBox_SP_hinh_anh_sp.Name = "textBox_SP_hinh_anh_sp";
            this.textBox_SP_hinh_anh_sp.Size = new System.Drawing.Size(595, 34);
            this.textBox_SP_hinh_anh_sp.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(981, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hình ảnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(734, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng hóa";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btn_SP_refresh);
            this.panel2.Controls.Add(this.btn_SP_sua);
            this.panel2.Controls.Add(this.btn_SP_xoa);
            this.panel2.Controls.Add(this.btn_SP_them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 476);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1499, 60);
            this.panel2.TabIndex = 2;
            // 
            // btn_SP_refresh
            // 
            this.btn_SP_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SP_refresh.Image = global::sieu_thi_go.Properties.Resources.icons8_available_updates_16;
            this.btn_SP_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SP_refresh.Location = new System.Drawing.Point(1190, 8);
            this.btn_SP_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SP_refresh.Name = "btn_SP_refresh";
            this.btn_SP_refresh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_SP_refresh.Size = new System.Drawing.Size(149, 48);
            this.btn_SP_refresh.TabIndex = 7;
            this.btn_SP_refresh.Text = "Refresh";
            this.btn_SP_refresh.UseVisualStyleBackColor = true;
            this.btn_SP_refresh.Click += new System.EventHandler(this.btn_SP_refresh_Click);
            // 
            // btn_SP_sua
            // 
            this.btn_SP_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SP_sua.Image = global::sieu_thi_go.Properties.Resources.icons8_advanced_search_16__2_;
            this.btn_SP_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SP_sua.Location = new System.Drawing.Point(325, 8);
            this.btn_SP_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SP_sua.Name = "btn_SP_sua";
            this.btn_SP_sua.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_SP_sua.Size = new System.Drawing.Size(150, 48);
            this.btn_SP_sua.TabIndex = 6;
            this.btn_SP_sua.Text = "&Sửa";
            this.btn_SP_sua.UseVisualStyleBackColor = true;
            this.btn_SP_sua.Click += new System.EventHandler(this.btn_SP_sua_Click);
            // 
            // btn_SP_xoa
            // 
            this.btn_SP_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SP_xoa.Image = global::sieu_thi_go.Properties.Resources.icons8_close_16;
            this.btn_SP_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SP_xoa.Location = new System.Drawing.Point(576, 8);
            this.btn_SP_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SP_xoa.Name = "btn_SP_xoa";
            this.btn_SP_xoa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_SP_xoa.Size = new System.Drawing.Size(145, 48);
            this.btn_SP_xoa.TabIndex = 5;
            this.btn_SP_xoa.Text = "&Xóa";
            this.btn_SP_xoa.UseVisualStyleBackColor = true;
            this.btn_SP_xoa.Click += new System.EventHandler(this.btn_SP_xoa_Click);
            // 
            // btn_SP_them
            // 
            this.btn_SP_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SP_them.Image = global::sieu_thi_go.Properties.Resources.icons8_plus_16;
            this.btn_SP_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SP_them.Location = new System.Drawing.Point(122, 8);
            this.btn_SP_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SP_them.Name = "btn_SP_them";
            this.btn_SP_them.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_SP_them.Size = new System.Drawing.Size(145, 48);
            this.btn_SP_them.TabIndex = 4;
            this.btn_SP_them.Text = "&Thêm";
            this.btn_SP_them.UseVisualStyleBackColor = true;
            this.btn_SP_them.Click += new System.EventHandler(this.btn_SP_them_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_SP_san_pham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 327);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1499, 149);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView_SP_san_pham
            // 
            this.dataGridView_SP_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SP_san_pham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SP_san_pham.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_SP_san_pham.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_SP_san_pham.Name = "dataGridView_SP_san_pham";
            this.dataGridView_SP_san_pham.RowHeadersWidth = 51;
            this.dataGridView_SP_san_pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SP_san_pham.Size = new System.Drawing.Size(1499, 149);
            this.dataGridView_SP_san_pham.TabIndex = 0;
            this.dataGridView_SP_san_pham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SP_san_pham_CellDoubleClick);
            // 
            // Form_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1539, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_sanpham";
            this.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Text = "Form_sanpham";
            this.Load += new System.EventHandler(this.Form_sanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP_san_pham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SP_gi_chu;
        private System.Windows.Forms.TextBox textBox_SP_don_gia_ban;
        private System.Windows.Forms.TextBox textBox_SP_don_gia_nhap;
        private System.Windows.Forms.TextBox textBox_SP_so_luong_sp;
        private System.Windows.Forms.TextBox textBox_SP_ten_sp;
        private System.Windows.Forms.TextBox textBox_SP_ma_sp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_SP_hinh_anh_sp;
        private System.Windows.Forms.Button btn_SP_tim_kiem;
        private System.Windows.Forms.TextBox textBox_SP_tim_kiem;
        private System.Windows.Forms.Button btn_SP_refresh;
        private System.Windows.Forms.Button btn_SP_sua;
        private System.Windows.Forms.Button btn_SP_xoa;
        private System.Windows.Forms.Button btn_SP_them;
        private System.Windows.Forms.DataGridView dataGridView_SP_san_pham;
        private System.Windows.Forms.ComboBox comboBox_SP_danh_muc;
        private System.Windows.Forms.Label label9;
    }
}