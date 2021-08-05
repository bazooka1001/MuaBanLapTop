namespace Demo1
{
    partial class User_khuyenMai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_DanhSachSanPhamKM = new System.Windows.Forms.DataGridView();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.txt_TenKM = new System.Windows.Forms.TextBox();
            this.txt_Giam = new System.Windows.Forms.TextBox();
            this.date_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.groupBox_ThongTin = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.rbt_ApDung = new System.Windows.Forms.RadioButton();
            this.rbt_Khoa = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_DanhSachKM = new System.Windows.Forms.DataGridView();
            this.btn_ThemKhuyenMai = new System.Windows.Forms.Button();
            this.btn_ChinhSuaKM = new System.Windows.Forms.Button();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPhamKM)).BeginInit();
            this.groupBox_ThongTin.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khuyến Mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khuyến Mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội Dung :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giảm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Tạo:";
            // 
            // dgv_DanhSachSanPhamKM
            // 
            this.dgv_DanhSachSanPhamKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPhamKM.Location = new System.Drawing.Point(45, 358);
            this.dgv_DanhSachSanPhamKM.Name = "dgv_DanhSachSanPhamKM";
            this.dgv_DanhSachSanPhamKM.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPhamKM.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPhamKM.Size = new System.Drawing.Size(632, 219);
            this.dgv_DanhSachSanPhamKM.TabIndex = 7;
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKM.Location = new System.Drawing.Point(158, 49);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(100, 22);
            this.txt_MaKM.TabIndex = 8;
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKM.Location = new System.Drawing.Point(427, 49);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(247, 22);
            this.txt_TenKM.TabIndex = 9;
            // 
            // txt_Giam
            // 
            this.txt_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Giam.Location = new System.Drawing.Point(128, 190);
            this.txt_Giam.Name = "txt_Giam";
            this.txt_Giam.Size = new System.Drawing.Size(214, 22);
            this.txt_Giam.TabIndex = 10;
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayTao.Location = new System.Drawing.Point(133, 288);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Size = new System.Drawing.Size(200, 22);
            this.date_NgayTao.TabIndex = 12;
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDung.Location = new System.Drawing.Point(128, 97);
            this.txt_NoiDung.Multiline = true;
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(546, 74);
            this.txt_NoiDung.TabIndex = 13;
            // 
            // groupBox_ThongTin
            // 
            this.groupBox_ThongTin.Controls.Add(this.panel);
            this.groupBox_ThongTin.Controls.Add(this.txt_NoiDung);
            this.groupBox_ThongTin.Controls.Add(this.dgv_DanhSachSanPhamKM);
            this.groupBox_ThongTin.Controls.Add(this.label4);
            this.groupBox_ThongTin.Controls.Add(this.label8);
            this.groupBox_ThongTin.Controls.Add(this.txt_TenKM);
            this.groupBox_ThongTin.Controls.Add(this.txt_Giam);
            this.groupBox_ThongTin.Controls.Add(this.label5);
            this.groupBox_ThongTin.Controls.Add(this.label3);
            this.groupBox_ThongTin.Controls.Add(this.label7);
            this.groupBox_ThongTin.Controls.Add(this.txt_MaKM);
            this.groupBox_ThongTin.Controls.Add(this.label2);
            this.groupBox_ThongTin.Controls.Add(this.date_NgayTao);
            this.groupBox_ThongTin.Controls.Add(this.label6);
            this.groupBox_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ThongTin.Location = new System.Drawing.Point(22, 87);
            this.groupBox_ThongTin.Name = "groupBox_ThongTin";
            this.groupBox_ThongTin.Size = new System.Drawing.Size(717, 605);
            this.groupBox_ThongTin.TabIndex = 14;
            this.groupBox_ThongTin.TabStop = false;
            this.groupBox_ThongTin.Text = "Thông Tin Khuyến Mãi";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rbt_ApDung);
            this.panel.Controls.Add(this.rbt_Khoa);
            this.panel.Location = new System.Drawing.Point(133, 231);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(257, 35);
            this.panel.TabIndex = 18;
            // 
            // rbt_ApDung
            // 
            this.rbt_ApDung.AutoSize = true;
            this.rbt_ApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ApDung.Location = new System.Drawing.Point(12, 8);
            this.rbt_ApDung.Name = "rbt_ApDung";
            this.rbt_ApDung.Size = new System.Drawing.Size(122, 21);
            this.rbt_ApDung.TabIndex = 16;
            this.rbt_ApDung.Text = "Đang Áp Dụng";
            this.rbt_ApDung.UseVisualStyleBackColor = true;
            // 
            // rbt_Khoa
            // 
            this.rbt_Khoa.AutoSize = true;
            this.rbt_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Khoa.Location = new System.Drawing.Point(176, 8);
            this.rbt_Khoa.Name = "rbt_Khoa";
            this.rbt_Khoa.Size = new System.Drawing.Size(62, 21);
            this.rbt_Khoa.TabIndex = 17;
            this.rbt_Khoa.Text = "Khóa";
            this.rbt_Khoa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Danh Sách Các Sản Phẩm Được Áp Dụng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Danh Sách Khuyến Mãi";
            // 
            // dgv_DanhSachKM
            // 
            this.dgv_DanhSachKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKM.Location = new System.Drawing.Point(771, 175);
            this.dgv_DanhSachKM.Name = "dgv_DanhSachKM";
            this.dgv_DanhSachKM.RowHeadersWidth = 51;
            this.dgv_DanhSachKM.RowTemplate.Height = 24;
            this.dgv_DanhSachKM.Size = new System.Drawing.Size(332, 423);
            this.dgv_DanhSachKM.TabIndex = 16;
            this.dgv_DanhSachKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKM_CellClick);
            // 
            // btn_ThemKhuyenMai
            // 
            this.btn_ThemKhuyenMai.Location = new System.Drawing.Point(771, 629);
            this.btn_ThemKhuyenMai.Name = "btn_ThemKhuyenMai";
            this.btn_ThemKhuyenMai.Size = new System.Drawing.Size(162, 48);
            this.btn_ThemKhuyenMai.TabIndex = 17;
            this.btn_ThemKhuyenMai.Text = "Thêm Khuyến Mãi";
            this.btn_ThemKhuyenMai.UseVisualStyleBackColor = true;
            this.btn_ThemKhuyenMai.Click += new System.EventHandler(this.btn_ThemKhuyenMai_Click);
            // 
            // btn_ChinhSuaKM
            // 
            this.btn_ChinhSuaKM.Location = new System.Drawing.Point(941, 629);
            this.btn_ChinhSuaKM.Name = "btn_ChinhSuaKM";
            this.btn_ChinhSuaKM.Size = new System.Drawing.Size(162, 48);
            this.btn_ChinhSuaKM.TabIndex = 18;
            this.btn_ChinhSuaKM.Text = "Chỉnh Sửa Khuyến Mãi";
            this.btn_ChinhSuaKM.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaKM.Click += new System.EventHandler(this.btn_ChinhSuaKM_Click);
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(853, 81);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(156, 24);
            this.cmb_Loc.TabIndex = 30;
            this.cmb_Loc.SelectedIndexChanged += new System.EventHandler(this.cmb_Loc_SelectedIndexChanged);
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(853, 36);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(260, 22);
            this.txt_TuKhoa.TabIndex = 29;
            this.txt_TuKhoa.TextChanged += new System.EventHandler(this.txt_TuKhoa_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(770, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tìm Kiếm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Bộ Lọc:";
            // 
            // User_khuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_Loc);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.btn_ChinhSuaKM);
            this.Controls.Add(this.btn_ThemKhuyenMai);
            this.Controls.Add(this.dgv_DanhSachKM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox_ThongTin);
            this.Controls.Add(this.label1);
            this.Name = "User_khuyenMai";
            this.Size = new System.Drawing.Size(1141, 720);
            this.Load += new System.EventHandler(this.User_khuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPhamKM)).EndInit();
            this.groupBox_ThongTin.ResumeLayout(false);
            this.groupBox_ThongTin.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPhamKM;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.TextBox txt_TenKM;
        private System.Windows.Forms.TextBox txt_Giam;
        private System.Windows.Forms.DateTimePicker date_NgayTao;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.GroupBox groupBox_ThongTin;
        private System.Windows.Forms.RadioButton rbt_ApDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbt_Khoa;
        private System.Windows.Forms.DataGridView dgv_DanhSachKM;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_ThemKhuyenMai;
        private System.Windows.Forms.Button btn_ChinhSuaKM;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
