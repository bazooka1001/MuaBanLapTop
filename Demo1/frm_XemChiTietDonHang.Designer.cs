namespace Demo1
{
    partial class frm_XemChiTietDonHang
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
            this.btn_XemSanPhamMua = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.dgv_DanhSachSPMua = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_GiaoHang = new System.Windows.Forms.CheckBox();
            this.cbx_Huy = new System.Windows.Forms.CheckBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbt_Chua = new System.Windows.Forms.RadioButton();
            this.rbt_DaThanhToan = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.date_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.txt_MaDH = new System.Windows.Forms.TextBox();
            this.txt_TraTruoc = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPMua)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 16);
            this.panel1.TabIndex = 0;
            // 
            // btn_XemSanPhamMua
            // 
            this.btn_XemSanPhamMua.Location = new System.Drawing.Point(898, 350);
            this.btn_XemSanPhamMua.Name = "btn_XemSanPhamMua";
            this.btn_XemSanPhamMua.Size = new System.Drawing.Size(209, 38);
            this.btn_XemSanPhamMua.TabIndex = 50;
            this.btn_XemSanPhamMua.Text = "Xem Chi Tiết Sản Phẩm Mua";
            this.btn_XemSanPhamMua.UseVisualStyleBackColor = true;
            this.btn_XemSanPhamMua.Click += new System.EventHandler(this.btn_XemSanPhamMua_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(999, 664);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(107, 36);
            this.btn_QuayLai.TabIndex = 48;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // dgv_DanhSachSPMua
            // 
            this.dgv_DanhSachSPMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSPMua.Location = new System.Drawing.Point(621, 393);
            this.dgv_DanhSachSPMua.Name = "dgv_DanhSachSPMua";
            this.dgv_DanhSachSPMua.RowHeadersWidth = 51;
            this.dgv_DanhSachSPMua.RowTemplate.Height = 24;
            this.dgv_DanhSachSPMua.Size = new System.Drawing.Size(486, 265);
            this.dgv_DanhSachSPMua.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(618, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "Danh Sách Sản Phẩm Mua";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Email);
            this.groupBox2.Controls.Add(this.txt_DiaChi);
            this.groupBox2.Controls.Add(this.txt_Sdt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_TenKhachHang);
            this.groupBox2.Controls.Add(this.txt_maKH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(616, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 242);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(134, 119);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(225, 22);
            this.txt_Email.TabIndex = 24;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(134, 168);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(255, 55);
            this.txt_DiaChi.TabIndex = 23;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(134, 74);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(225, 22);
            this.txt_Sdt.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Số Điện Thoại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Địa Chỉ:";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(134, 34);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(225, 22);
            this.txt_TenKhachHang.TabIndex = 17;
            // 
            // txt_maKH
            // 
            this.txt_maKH.AutoSize = true;
            this.txt_maKH.Location = new System.Drawing.Point(380, 39);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(46, 17);
            this.txt_maKH.TabIndex = 18;
            this.txt_maKH.Text = "maKH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khách Hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(37, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 32);
            this.label8.TabIndex = 44;
            this.label8.Text = "Xem Chi Tiết Đơn Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_GiaoHang);
            this.groupBox1.Controls.Add(this.cbx_Huy);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.date_NgayTao);
            this.groupBox1.Controls.Add(this.txt_MaDH);
            this.groupBox1.Controls.Add(this.txt_TraTruoc);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Location = new System.Drawing.Point(34, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 625);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // cbx_GiaoHang
            // 
            this.cbx_GiaoHang.AutoSize = true;
            this.cbx_GiaoHang.Location = new System.Drawing.Point(412, 189);
            this.cbx_GiaoHang.Name = "cbx_GiaoHang";
            this.cbx_GiaoHang.Size = new System.Drawing.Size(98, 21);
            this.cbx_GiaoHang.TabIndex = 37;
            this.cbx_GiaoHang.Text = "Giao Hàng";
            this.cbx_GiaoHang.UseVisualStyleBackColor = true;
            // 
            // cbx_Huy
            // 
            this.cbx_Huy.AutoSize = true;
            this.cbx_Huy.Location = new System.Drawing.Point(412, 57);
            this.cbx_Huy.Name = "cbx_Huy";
            this.cbx_Huy.Size = new System.Drawing.Size(55, 21);
            this.cbx_Huy.TabIndex = 36;
            this.cbx_Huy.Text = "Hủy";
            this.cbx_Huy.UseVisualStyleBackColor = true;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(160, 464);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(289, 126);
            this.txt_GhiChu.TabIndex = 33;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.AutoSize = true;
            this.txt_MaNV.Location = new System.Drawing.Point(404, 390);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(46, 17);
            this.txt_MaNV.TabIndex = 32;
            this.txt_MaNV.Text = "maNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn Hàng:";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(158, 385);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(225, 22);
            this.txt_NhanVien.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Tiền:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trả Trước:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbt_Chua);
            this.panel2.Controls.Add(this.rbt_DaThanhToan);
            this.panel2.Location = new System.Drawing.Point(157, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 47);
            this.panel2.TabIndex = 29;
            // 
            // rbt_Chua
            // 
            this.rbt_Chua.AutoSize = true;
            this.rbt_Chua.Location = new System.Drawing.Point(187, 14);
            this.rbt_Chua.Name = "rbt_Chua";
            this.rbt_Chua.Size = new System.Drawing.Size(62, 21);
            this.rbt_Chua.TabIndex = 38;
            this.rbt_Chua.TabStop = true;
            this.rbt_Chua.Text = "Chưa";
            this.rbt_Chua.UseVisualStyleBackColor = true;
            // 
            // rbt_DaThanhToan
            // 
            this.rbt_DaThanhToan.Location = new System.Drawing.Point(33, 12);
            this.rbt_DaThanhToan.Name = "rbt_DaThanhToan";
            this.rbt_DaThanhToan.Size = new System.Drawing.Size(146, 24);
            this.rbt_DaThanhToan.TabIndex = 1;
            this.rbt_DaThanhToan.TabStop = true;
            this.rbt_DaThanhToan.Text = "Đã Thanh Toán";
            this.rbt_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trạng Thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày Tạo:";
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayTao.Location = new System.Drawing.Point(158, 318);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Size = new System.Drawing.Size(191, 22);
            this.date_NgayTao.TabIndex = 22;
            // 
            // txt_MaDH
            // 
            this.txt_MaDH.Location = new System.Drawing.Point(158, 55);
            this.txt_MaDH.Name = "txt_MaDH";
            this.txt_MaDH.Size = new System.Drawing.Size(148, 22);
            this.txt_MaDH.TabIndex = 16;
            // 
            // txt_TraTruoc
            // 
            this.txt_TraTruoc.Location = new System.Drawing.Point(158, 184);
            this.txt_TraTruoc.Name = "txt_TraTruoc";
            this.txt_TraTruoc.Size = new System.Drawing.Size(155, 22);
            this.txt_TraTruoc.TabIndex = 20;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(157, 117);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(155, 22);
            this.txt_TongTien.TabIndex = 19;
            // 
            // frm_XemChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 720);
            this.Controls.Add(this.btn_XemSanPhamMua);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.dgv_DanhSachSPMua);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_XemChiTietDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_XemChiTietDonHang";
            this.Load += new System.EventHandler(this.frm_XemChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPMua)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XemSanPhamMua;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.DataGridView dgv_DanhSachSPMua;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label txt_maKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label txt_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbt_DaThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_NgayTao;
        private System.Windows.Forms.TextBox txt_MaDH;
        private System.Windows.Forms.TextBox txt_TraTruoc;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.CheckBox cbx_Huy;
        private System.Windows.Forms.CheckBox cbx_GiaoHang;
        private System.Windows.Forms.RadioButton rbt_Chua;
    }
}