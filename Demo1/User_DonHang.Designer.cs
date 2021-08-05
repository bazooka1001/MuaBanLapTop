namespace Demo1
{
    partial class User_DonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ThemDonHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_DanhSachDonHang = new System.Windows.Forms.DataGridView();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.txt_MaDH = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_TraTruoc = new System.Windows.Forms.TextBox();
            this.date_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.btn_editDonHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_Chua = new System.Windows.Forms.RadioButton();
            this.rbt_DaThanhToan = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Huy = new System.Windows.Forms.CheckBox();
            this.cbx_GiaoHang = new System.Windows.Forms.CheckBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDonHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trả Trước:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // btn_ThemDonHang
            // 
            this.btn_ThemDonHang.Location = new System.Drawing.Point(747, 633);
            this.btn_ThemDonHang.Name = "btn_ThemDonHang";
            this.btn_ThemDonHang.Size = new System.Drawing.Size(172, 45);
            this.btn_ThemDonHang.TabIndex = 7;
            this.btn_ThemDonHang.Text = "Thêm Đơn Hàng";
            this.btn_ThemDonHang.UseVisualStyleBackColor = true;
            this.btn_ThemDonHang.Click += new System.EventHandler(this.btn_themDonHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trạng Thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quản Lý Đơn Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Danh Sách Đơn Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày Tạo:";
            // 
            // dgv_DanhSachDonHang
            // 
            this.dgv_DanhSachDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDonHang.Location = new System.Drawing.Point(570, 150);
            this.dgv_DanhSachDonHang.Name = "dgv_DanhSachDonHang";
            this.dgv_DanhSachDonHang.RowHeadersWidth = 51;
            this.dgv_DanhSachDonHang.RowTemplate.Height = 24;
            this.dgv_DanhSachDonHang.Size = new System.Drawing.Size(514, 444);
            this.dgv_DanhSachDonHang.TabIndex = 13;
            this.dgv_DanhSachDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDonHang_CellClick);
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Location = new System.Drawing.Point(558, 631);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(172, 47);
            this.btn_XemChiTiet.TabIndex = 15;
            this.btn_XemChiTiet.Text = "Xem Chi Tiết Đơn Hàng";
            this.btn_XemChiTiet.UseVisualStyleBackColor = true;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // txt_MaDH
            // 
            this.txt_MaDH.Location = new System.Drawing.Point(165, 55);
            this.txt_MaDH.Name = "txt_MaDH";
            this.txt_MaDH.Size = new System.Drawing.Size(148, 22);
            this.txt_MaDH.TabIndex = 16;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(165, 112);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(225, 22);
            this.txt_TenKhachHang.TabIndex = 17;
            // 
            // txt_maKH
            // 
            this.txt_maKH.AutoSize = true;
            this.txt_maKH.Location = new System.Drawing.Point(396, 115);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(46, 17);
            this.txt_maKH.TabIndex = 18;
            this.txt_maKH.Text = "maKH";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(164, 170);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(155, 22);
            this.txt_TongTien.TabIndex = 19;
            // 
            // txt_TraTruoc
            // 
            this.txt_TraTruoc.Location = new System.Drawing.Point(165, 230);
            this.txt_TraTruoc.Name = "txt_TraTruoc";
            this.txt_TraTruoc.Size = new System.Drawing.Size(155, 22);
            this.txt_TraTruoc.TabIndex = 20;
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayTao.Location = new System.Drawing.Point(165, 355);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Size = new System.Drawing.Size(191, 22);
            this.date_NgayTao.TabIndex = 22;
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(851, 65);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(260, 22);
            this.txt_TuKhoa.TabIndex = 24;
            this.txt_TuKhoa.TextChanged += new System.EventHandler(this.txt_TuKhoa_TextChanged);
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(851, 110);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(156, 24);
            this.cmb_Loc.TabIndex = 26;
            this.cmb_Loc.SelectedIndexChanged += new System.EventHandler(this.cmb_Loc_SelectedIndexChanged);
            // 
            // btn_editDonHang
            // 
            this.btn_editDonHang.Location = new System.Drawing.Point(936, 633);
            this.btn_editDonHang.Name = "btn_editDonHang";
            this.btn_editDonHang.Size = new System.Drawing.Size(172, 45);
            this.btn_editDonHang.TabIndex = 28;
            this.btn_editDonHang.Text = "Chỉnh Sửa Thông Tin";
            this.btn_editDonHang.UseVisualStyleBackColor = true;
            this.btn_editDonHang.Click += new System.EventHandler(this.btn_editDonHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_Chua);
            this.panel1.Controls.Add(this.rbt_DaThanhToan);
            this.panel1.Location = new System.Drawing.Point(164, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 47);
            this.panel1.TabIndex = 29;
            // 
            // rbt_Chua
            // 
            this.rbt_Chua.AutoSize = true;
            this.rbt_Chua.Location = new System.Drawing.Point(190, 13);
            this.rbt_Chua.Name = "rbt_Chua";
            this.rbt_Chua.Size = new System.Drawing.Size(62, 21);
            this.rbt_Chua.TabIndex = 2;
            this.rbt_Chua.TabStop = true;
            this.rbt_Chua.Text = "Chưa";
            this.rbt_Chua.UseVisualStyleBackColor = true;
            // 
            // rbt_DaThanhToan
            // 
            this.rbt_DaThanhToan.Location = new System.Drawing.Point(21, 11);
            this.rbt_DaThanhToan.Name = "rbt_DaThanhToan";
            this.rbt_DaThanhToan.Size = new System.Drawing.Size(146, 24);
            this.rbt_DaThanhToan.TabIndex = 1;
            this.rbt_DaThanhToan.TabStop = true;
            this.rbt_DaThanhToan.Text = "Đã Thanh Toán";
            this.rbt_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nhân Viên:";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(165, 412);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(225, 22);
            this.txt_NhanVien.TabIndex = 31;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.AutoSize = true;
            this.txt_MaNV.Location = new System.Drawing.Point(396, 415);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(46, 17);
            this.txt_MaNV.TabIndex = 32;
            this.txt_MaNV.Text = "maNV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Huy);
            this.groupBox1.Controls.Add(this.cbx_GiaoHang);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.date_NgayTao);
            this.groupBox1.Controls.Add(this.txt_MaDH);
            this.groupBox1.Controls.Add(this.txt_TenKhachHang);
            this.groupBox1.Controls.Add(this.txt_TraTruoc);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Location = new System.Drawing.Point(27, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 625);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // cbx_Huy
            // 
            this.cbx_Huy.AutoSize = true;
            this.cbx_Huy.Location = new System.Drawing.Point(374, 57);
            this.cbx_Huy.Name = "cbx_Huy";
            this.cbx_Huy.Size = new System.Drawing.Size(55, 21);
            this.cbx_Huy.TabIndex = 35;
            this.cbx_Huy.Text = "Hủy";
            this.cbx_Huy.UseVisualStyleBackColor = true;
            // 
            // cbx_GiaoHang
            // 
            this.cbx_GiaoHang.AutoSize = true;
            this.cbx_GiaoHang.Location = new System.Drawing.Point(374, 234);
            this.cbx_GiaoHang.Name = "cbx_GiaoHang";
            this.cbx_GiaoHang.Size = new System.Drawing.Size(98, 21);
            this.cbx_GiaoHang.TabIndex = 34;
            this.cbx_GiaoHang.Text = "Giao Hàng";
            this.cbx_GiaoHang.UseVisualStyleBackColor = true;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(167, 481);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(289, 126);
            this.txt_GhiChu.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tìm Kiếm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(757, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Bộ Lọc:";
            // 
            // User_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_editDonHang);
            this.Controls.Add(this.cmb_Loc);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.btn_XemChiTiet);
            this.Controls.Add(this.dgv_DanhSachDonHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ThemDonHang);
            this.Name = "User_DonHang";
            this.Size = new System.Drawing.Size(1141, 720);
            this.Load += new System.EventHandler(this.User_DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDonHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ThemDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_DanhSachDonHang;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.TextBox txt_MaDH;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label txt_maKH;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_TraTruoc;
        private System.Windows.Forms.DateTimePicker date_NgayTao;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Button btn_editDonHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_DaThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label txt_MaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.RadioButton rbt_Chua;
        private System.Windows.Forms.CheckBox cbx_Huy;
        private System.Windows.Forms.CheckBox cbx_GiaoHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}
