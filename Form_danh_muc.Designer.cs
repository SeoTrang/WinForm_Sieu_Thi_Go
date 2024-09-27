namespace sieu_thi_go
{
    partial class Form_danh_muc
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
            this.btn_DM_loc = new System.Windows.Forms.Button();
            this.comboBox_DM_loc = new System.Windows.Forms.ComboBox();
            this.label_DM_so_luong_sp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DM_tim_kiem = new System.Windows.Forms.TextBox();
            this.textBox_DM_ten_dm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DM_ma_dm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_DM = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DM_refresh = new System.Windows.Forms.Button();
            this.btn_DM_xoa = new System.Windows.Forms.Button();
            this.btn_DM_sua = new System.Windows.Forms.Button();
            this.btn_DM_them = new System.Windows.Forms.Button();
            this.btn_DM_tim_kiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DM)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_DM_tim_kiem);
            this.panel1.Controls.Add(this.btn_DM_loc);
            this.panel1.Controls.Add(this.comboBox_DM_loc);
            this.panel1.Controls.Add(this.label_DM_so_luong_sp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_DM_tim_kiem);
            this.panel1.Controls.Add(this.textBox_DM_ten_dm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_DM_ma_dm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 222);
            this.panel1.TabIndex = 0;
            // 
            // btn_DM_loc
            // 
            this.btn_DM_loc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_loc.Location = new System.Drawing.Point(1421, 172);
            this.btn_DM_loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_loc.Name = "btn_DM_loc";
            this.btn_DM_loc.Size = new System.Drawing.Size(75, 32);
            this.btn_DM_loc.TabIndex = 6;
            this.btn_DM_loc.Text = "Lọc";
            this.btn_DM_loc.UseVisualStyleBackColor = true;
            // 
            // comboBox_DM_loc
            // 
            this.comboBox_DM_loc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_DM_loc.FormattingEnabled = true;
            this.comboBox_DM_loc.Items.AddRange(new object[] {
            "Điện Thoại",
            "Laptop",
            "Giày Dép",
            "Quần Áo"});
            this.comboBox_DM_loc.Location = new System.Drawing.Point(1128, 176);
            this.comboBox_DM_loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_DM_loc.Name = "comboBox_DM_loc";
            this.comboBox_DM_loc.Size = new System.Drawing.Size(261, 28);
            this.comboBox_DM_loc.TabIndex = 5;
            this.comboBox_DM_loc.Text = "Chọn Danh Mục";
            // 
            // label_DM_so_luong_sp
            // 
            this.label_DM_so_luong_sp.AutoSize = true;
            this.label_DM_so_luong_sp.Location = new System.Drawing.Point(1419, 62);
            this.label_DM_so_luong_sp.Name = "label_DM_so_luong_sp";
            this.label_DM_so_luong_sp.Size = new System.Drawing.Size(27, 20);
            this.label_DM_so_luong_sp.TabIndex = 4;
            this.label_DM_so_luong_sp.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1124, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng sản phẩm trong danh mục : ";
            // 
            // textBox_DM_tim_kiem
            // 
            this.textBox_DM_tim_kiem.Location = new System.Drawing.Point(223, 172);
            this.textBox_DM_tim_kiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DM_tim_kiem.Multiline = true;
            this.textBox_DM_tim_kiem.Name = "textBox_DM_tim_kiem";
            this.textBox_DM_tim_kiem.Size = new System.Drawing.Size(425, 32);
            this.textBox_DM_tim_kiem.TabIndex = 3;
            // 
            // textBox_DM_ten_dm
            // 
            this.textBox_DM_ten_dm.Location = new System.Drawing.Point(223, 114);
            this.textBox_DM_ten_dm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DM_ten_dm.Multiline = true;
            this.textBox_DM_ten_dm.Name = "textBox_DM_ten_dm";
            this.textBox_DM_ten_dm.Size = new System.Drawing.Size(425, 32);
            this.textBox_DM_ten_dm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên danh mục";
            // 
            // textBox_DM_ma_dm
            // 
            this.textBox_DM_ma_dm.Location = new System.Drawing.Point(223, 62);
            this.textBox_DM_ma_dm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DM_ma_dm.Multiline = true;
            this.textBox_DM_ma_dm.Name = "textBox_DM_ma_dm";
            this.textBox_DM_ma_dm.Size = new System.Drawing.Size(425, 32);
            this.textBox_DM_ma_dm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã danh mục";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(723, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_DM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 242);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1521, 364);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_DM
            // 
            this.dataGridView_DM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DM.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_DM.Name = "dataGridView_DM";
            this.dataGridView_DM.RowHeadersWidth = 51;
            this.dataGridView_DM.RowTemplate.Height = 24;
            this.dataGridView_DM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DM.Size = new System.Drawing.Size(1521, 364);
            this.dataGridView_DM.TabIndex = 0;
            this.dataGridView_DM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DM_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btn_DM_refresh);
            this.panel3.Controls.Add(this.btn_DM_xoa);
            this.panel3.Controls.Add(this.btn_DM_sua);
            this.panel3.Controls.Add(this.btn_DM_them);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(20, 506);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1521, 100);
            this.panel3.TabIndex = 2;
            // 
            // btn_DM_refresh
            // 
            this.btn_DM_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_refresh.Image = global::sieu_thi_go.Properties.Resources.icons8_available_updates_16;
            this.btn_DM_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DM_refresh.Location = new System.Drawing.Point(897, 26);
            this.btn_DM_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_refresh.Name = "btn_DM_refresh";
            this.btn_DM_refresh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_DM_refresh.Size = new System.Drawing.Size(151, 48);
            this.btn_DM_refresh.TabIndex = 0;
            this.btn_DM_refresh.Text = "Refresh";
            this.btn_DM_refresh.UseVisualStyleBackColor = true;
            this.btn_DM_refresh.Click += new System.EventHandler(this.btn_DM_refresh_Click);
            // 
            // btn_DM_xoa
            // 
            this.btn_DM_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_xoa.Image = global::sieu_thi_go.Properties.Resources.icons8_close_16;
            this.btn_DM_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DM_xoa.Location = new System.Drawing.Point(604, 26);
            this.btn_DM_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_xoa.Name = "btn_DM_xoa";
            this.btn_DM_xoa.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_DM_xoa.Size = new System.Drawing.Size(165, 48);
            this.btn_DM_xoa.TabIndex = 0;
            this.btn_DM_xoa.Text = "Xóa";
            this.btn_DM_xoa.UseVisualStyleBackColor = true;
            this.btn_DM_xoa.Click += new System.EventHandler(this.btn_DM_xoa_Click);
            // 
            // btn_DM_sua
            // 
            this.btn_DM_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_sua.Image = global::sieu_thi_go.Properties.Resources.icons8_advanced_search_16__2_;
            this.btn_DM_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DM_sua.Location = new System.Drawing.Point(320, 26);
            this.btn_DM_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_sua.Name = "btn_DM_sua";
            this.btn_DM_sua.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_DM_sua.Size = new System.Drawing.Size(151, 48);
            this.btn_DM_sua.TabIndex = 0;
            this.btn_DM_sua.Text = "Sửa";
            this.btn_DM_sua.UseVisualStyleBackColor = true;
            this.btn_DM_sua.Click += new System.EventHandler(this.btn_DM_sua_Click);
            // 
            // btn_DM_them
            // 
            this.btn_DM_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_them.Image = global::sieu_thi_go.Properties.Resources.icons8_plus_16;
            this.btn_DM_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DM_them.Location = new System.Drawing.Point(29, 26);
            this.btn_DM_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_them.Name = "btn_DM_them";
            this.btn_DM_them.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_DM_them.Size = new System.Drawing.Size(168, 48);
            this.btn_DM_them.TabIndex = 0;
            this.btn_DM_them.Text = "Thêm";
            this.btn_DM_them.UseVisualStyleBackColor = true;
            this.btn_DM_them.Click += new System.EventHandler(this.btn_DM_them_Click);
            // 
            // btn_DM_tim_kiem
            // 
            this.btn_DM_tim_kiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DM_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DM_tim_kiem.ForeColor = System.Drawing.Color.Black;
            this.btn_DM_tim_kiem.Image = global::sieu_thi_go.Properties.Resources.icons8_search_25__2___1_;
            this.btn_DM_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DM_tim_kiem.Location = new System.Drawing.Point(55, 162);
            this.btn_DM_tim_kiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DM_tim_kiem.Name = "btn_DM_tim_kiem";
            this.btn_DM_tim_kiem.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_DM_tim_kiem.Size = new System.Drawing.Size(147, 42);
            this.btn_DM_tim_kiem.TabIndex = 6;
            this.btn_DM_tim_kiem.Text = "Tìm Kiếm";
            this.btn_DM_tim_kiem.UseVisualStyleBackColor = false;
            // 
            // Form_danh_muc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 626);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_danh_muc";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.Form_danh_muc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DM)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_DM_ma_dm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DM_tim_kiem;
        private System.Windows.Forms.Button btn_DM_loc;
        private System.Windows.Forms.ComboBox comboBox_DM_loc;
        private System.Windows.Forms.Label label_DM_so_luong_sp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DM_tim_kiem;
        private System.Windows.Forms.TextBox textBox_DM_ten_dm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_DM;
        private System.Windows.Forms.Button btn_DM_them;
        private System.Windows.Forms.Button btn_DM_refresh;
        private System.Windows.Forms.Button btn_DM_xoa;
        private System.Windows.Forms.Button btn_DM_sua;
    }
}