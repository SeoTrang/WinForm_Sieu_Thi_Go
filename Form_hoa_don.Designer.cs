namespace sieu_thi_go
{
    partial class Form_hoa_don
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
            this.dataGridView_hd = new System.Windows.Forms.DataGridView();
            this.textBox_TT_so_luong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_hd
            // 
            this.dataGridView_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_hd.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_hd.Name = "dataGridView_hd";
            this.dataGridView_hd.ReadOnly = true;
            this.dataGridView_hd.RowHeadersWidth = 51;
            this.dataGridView_hd.RowTemplate.Height = 24;
            this.dataGridView_hd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hd.Size = new System.Drawing.Size(1884, 408);
            this.dataGridView_hd.TabIndex = 0;
            this.dataGridView_hd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hd_CellDoubleClick);
            // 
            // textBox_TT_so_luong
            // 
            this.textBox_TT_so_luong.Location = new System.Drawing.Point(32, 72);
            this.textBox_TT_so_luong.Multiline = true;
            this.textBox_TT_so_luong.Name = "textBox_TT_so_luong";
            this.textBox_TT_so_luong.Size = new System.Drawing.Size(426, 40);
            this.textBox_TT_so_luong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 72);
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
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(20, 563);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1884, 10);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_hd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1884, 408);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox_loc);
            this.panel1.Controls.Add(this.btn_loc);
            this.panel1.Controls.Add(this.btn_tim_kiem);
            this.panel1.Controls.Add(this.textBox_TT_so_luong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1884, 145);
            this.panel1.TabIndex = 3;
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(1085, 84);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(275, 28);
            this.comboBox_loc.TabIndex = 5;
            this.comboBox_loc.Text = "Chọn ngày";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(1389, 73);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(109, 39);
            this.btn_loc.TabIndex = 4;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Image = global::sieu_thi_go.Properties.Resources.icons8_search_25;
            this.btn_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim_kiem.Location = new System.Drawing.Point(499, 72);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tim_kiem.Size = new System.Drawing.Size(155, 40);
            this.btn_tim_kiem.TabIndex = 4;
            this.btn_tim_kiem.Text = "Tìm kiếm";
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
            // 
            // Form_hoa_don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_hoa_don";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form_thanh_toan";
            this.Load += new System.EventHandler(this.Form_hoa_don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_hd;
        private System.Windows.Forms.TextBox textBox_TT_so_luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.Button btn_loc;
    }
}