namespace sieu_thi_go
{
    partial class Form_dangnhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.linkLabel_dang_ký = new System.Windows.Forms.LinkLabel();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.txt_ten_dang_nhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_dang_nhap);
            this.groupBox1.Controls.Add(this.linkLabel_dang_ký);
            this.groupBox1.Controls.Add(this.txt_mat_khau);
            this.groupBox1.Controls.Add(this.txt_ten_dang_nhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(524, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.BackColor = System.Drawing.Color.Firebrick;
            this.btn_dang_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_nhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dang_nhap.Location = new System.Drawing.Point(191, 222);
            this.btn_dang_nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(167, 43);
            this.btn_dang_nhap.TabIndex = 6;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = false;
            // 
            // linkLabel_dang_ký
            // 
            this.linkLabel_dang_ký.AutoSize = true;
            this.linkLabel_dang_ký.Location = new System.Drawing.Point(261, 327);
            this.linkLabel_dang_ký.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_dang_ký.Name = "linkLabel_dang_ký";
            this.linkLabel_dang_ký.Size = new System.Drawing.Size(76, 20);
            this.linkLabel_dang_ký.TabIndex = 5;
            this.linkLabel_dang_ký.TabStop = true;
            this.linkLabel_dang_ký.Text = "Đăng ký";
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Location = new System.Drawing.Point(213, 130);
            this.txt_mat_khau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Size = new System.Drawing.Size(244, 26);
            this.txt_mat_khau.TabIndex = 4;
            // 
            // txt_ten_dang_nhap
            // 
            this.txt_ten_dang_nhap.Location = new System.Drawing.Point(213, 48);
            this.txt_ten_dang_nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ten_dang_nhap.Name = "txt_ten_dang_nhap";
            this.txt_ten_dang_nhap.Size = new System.Drawing.Size(244, 26);
            this.txt_ten_dang_nhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bạn chưa có tài khoản ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // Form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 486);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_dangnhap";
            this.Text = "Đăng nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.LinkLabel linkLabel_dang_ký;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.TextBox txt_ten_dang_nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}