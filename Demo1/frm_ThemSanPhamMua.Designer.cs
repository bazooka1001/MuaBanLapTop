namespace Demo1
{
    partial class frm_ThemSanPhamMua
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
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiemSpDaKM = new System.Windows.Forms.Button();
            this.txt_TuKhoaSpDcMua = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachSPMua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.txt_TuKhoaSanPham = new System.Windows.Forms.TextBox();
            this.txt_ncc = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.Label();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_KhuyenMai = new System.Windows.Forms.ComboBox();
            this.txt_Giam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.txt_SoLuongTon = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.cmb_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPMua)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Location = new System.Drawing.Point(28, 14);
            this.btn_quayLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(64, 29);
            this.btn_quayLai.TabIndex = 70;
            this.btn_quayLai.Text = "Quay Lại";
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TimKiemSpDaKM);
            this.groupBox3.Controls.Add(this.txt_TuKhoaSpDcMua);
            this.groupBox3.Controls.Add(this.dgv_DanhSachSPMua);
            this.groupBox3.Location = new System.Drawing.Point(488, 323);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(340, 249);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Mua";
            // 
            // btn_TimKiemSpDaKM
            // 
            this.btn_TimKiemSpDaKM.Location = new System.Drawing.Point(17, 23);
            this.btn_TimKiemSpDaKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiemSpDaKM.Name = "btn_TimKiemSpDaKM";
            this.btn_TimKiemSpDaKM.Size = new System.Drawing.Size(74, 21);
            this.btn_TimKiemSpDaKM.TabIndex = 43;
            this.btn_TimKiemSpDaKM.Text = "Tìm Kiếm:";
            this.btn_TimKiemSpDaKM.UseVisualStyleBackColor = true;
            // 
            // txt_TuKhoaSpDcMua
            // 
            this.txt_TuKhoaSpDcMua.Location = new System.Drawing.Point(96, 24);
            this.txt_TuKhoaSpDcMua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TuKhoaSpDcMua.Name = "txt_TuKhoaSpDcMua";
            this.txt_TuKhoaSpDcMua.Size = new System.Drawing.Size(196, 20);
            this.txt_TuKhoaSpDcMua.TabIndex = 44;
            this.txt_TuKhoaSpDcMua.TextChanged += new System.EventHandler(this.txt_TuKhoaSpDcMua_TextChanged);
            // 
            // dgv_DanhSachSPMua
            // 
            this.dgv_DanhSachSPMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSPMua.Location = new System.Drawing.Point(17, 59);
            this.dgv_DanhSachSPMua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSachSPMua.Name = "dgv_DanhSachSPMua";
            this.dgv_DanhSachSPMua.RowHeadersWidth = 51;
            this.dgv_DanhSachSPMua.RowTemplate.Height = 24;
            this.dgv_DanhSachSPMua.Size = new System.Drawing.Size(307, 173);
            this.dgv_DanhSachSPMua.TabIndex = 42;
            this.dgv_DanhSachSPMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanPham_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "#";
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Location = new System.Drawing.Point(340, 28);
            this.lbl_MaDH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(38, 13);
            this.lbl_MaDH.TabIndex = 68;
            this.lbl_MaDH.Text = "MãĐH";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(332, 526);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(86, 28);
            this.btn_Huy.TabIndex = 67;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(195, 526);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(86, 28);
            this.btn_Luu.TabIndex = 66;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.dgv_DanhSachSanPham);
            this.groupBox2.Controls.Add(this.txt_TuKhoaSanPham);
            this.groupBox2.Controls.Add(this.txt_ncc);
            this.groupBox2.Controls.Add(this.txt_km);
            this.groupBox2.Location = new System.Drawing.Point(488, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(340, 239);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(17, 28);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(74, 21);
            this.btn_TimKiem.TabIndex = 32;
            this.btn_TimKiem.Text = "Tìm Kiếm:";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(17, 68);
            this.dgv_DanhSachSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(307, 158);
            this.dgv_DanhSachSanPham.TabIndex = 19;
            this.dgv_DanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanPham_CellClick);
            // 
            // txt_TuKhoaSanPham
            // 
            this.txt_TuKhoaSanPham.Location = new System.Drawing.Point(96, 30);
            this.txt_TuKhoaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TuKhoaSanPham.Name = "txt_TuKhoaSanPham";
            this.txt_TuKhoaSanPham.Size = new System.Drawing.Size(196, 20);
            this.txt_TuKhoaSanPham.TabIndex = 33;
            this.txt_TuKhoaSanPham.TextChanged += new System.EventHandler(this.txt_TuKhoaSanPham_TextChanged);
            // 
            // txt_ncc
            // 
            this.txt_ncc.AutoSize = true;
            this.txt_ncc.Location = new System.Drawing.Point(40, 93);
            this.txt_ncc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_ncc.Name = "txt_ncc";
            this.txt_ncc.Size = new System.Drawing.Size(41, 13);
            this.txt_ncc.TabIndex = 72;
            this.txt_ncc.Text = "label12";
            // 
            // txt_km
            // 
            this.txt_km.AutoSize = true;
            this.txt_km.Location = new System.Drawing.Point(40, 131);
            this.txt_km.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(35, 13);
            this.txt_km.TabIndex = 71;
            this.txt_km.Text = "label7";
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Location = new System.Drawing.Point(332, 462);
            this.btn_ChinhSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(86, 28);
            this.btn_ChinhSua.TabIndex = 64;
            this.btn_ChinhSua.Text = "Chỉnh Sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = true;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(195, 462);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(86, 28);
            this.btn_Xoa.TabIndex = 63;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(58, 462);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(86, 28);
            this.btn_Them.TabIndex = 62;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "Sản Phẩm Mua";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_KhuyenMai);
            this.groupBox1.Controls.Add(this.txt_Giam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.txt_SoLuongTon);
            this.groupBox1.Controls.Add(this.txt_ThanhTien);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.cmb_NhaCungCap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenSanPham);
            this.groupBox1.Controls.Add(this.txt_MaSanPham);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(55, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 361);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // cmb_KhuyenMai
            // 
            this.cmb_KhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KhuyenMai.FormattingEnabled = true;
            this.cmb_KhuyenMai.Location = new System.Drawing.Point(122, 154);
            this.cmb_KhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_KhuyenMai.Name = "cmb_KhuyenMai";
            this.cmb_KhuyenMai.Size = new System.Drawing.Size(144, 21);
            this.cmb_KhuyenMai.TabIndex = 25;
            this.cmb_KhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cmb_KhuyenMai_SelectedIndexChanged);
            // 
            // txt_Giam
            // 
            this.txt_Giam.Location = new System.Drawing.Point(122, 194);
            this.txt_Giam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Giam.Name = "txt_Giam";
            this.txt_Giam.Size = new System.Drawing.Size(116, 20);
            this.txt_Giam.TabIndex = 24;
            this.txt_Giam.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Giảm:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(122, 277);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(90, 20);
            this.txt_SoLuong.TabIndex = 22;
            this.txt_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_SoLuong.ValueChanged += new System.EventHandler(this.txt_SoLuong_ValueChanged);
            // 
            // txt_SoLuongTon
            // 
            this.txt_SoLuongTon.AutoSize = true;
            this.txt_SoLuongTon.Location = new System.Drawing.Point(296, 120);
            this.txt_SoLuongTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_SoLuongTon.Name = "txt_SoLuongTon";
            this.txt_SoLuongTon.Size = new System.Drawing.Size(52, 13);
            this.txt_SoLuongTon.TabIndex = 21;
            this.txt_SoLuongTon.Text = "trangThai";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(122, 318);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(123, 20);
            this.txt_ThanhTien.TabIndex = 20;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(122, 233);
            this.txt_GiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(123, 20);
            this.txt_GiaBan.TabIndex = 19;
            // 
            // cmb_NhaCungCap
            // 
            this.cmb_NhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NhaCungCap.FormattingEnabled = true;
            this.cmb_NhaCungCap.Location = new System.Drawing.Point(122, 115);
            this.cmb_NhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_NhaCungCap.Name = "cmb_NhaCungCap";
            this.cmb_NhaCungCap.Size = new System.Drawing.Size(158, 21);
            this.cmb_NhaCungCap.TabIndex = 17;
            this.cmb_NhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cmb_NhaCungCap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thành Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Khuyến Mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhà Cung Cấp:";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Location = new System.Drawing.Point(122, 77);
            this.txt_TenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(201, 20);
            this.txt_TenSanPham.TabIndex = 8;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(122, 38);
            this.txt_MaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(76, 20);
            this.txt_MaSanPham.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giá Bán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên Sản Phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Sản Phẩm:";
            // 
            // frm_ThemSanPhamMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.btn_quayLai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MaDH);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ThemSanPhamMua";
            this.Text = "frm_ThemSanPhamMua";
            this.Load += new System.EventHandler(this.frm_ThemSanPhamMua_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPMua)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_TimKiemSpDaKM;
        private System.Windows.Forms.TextBox txt_TuKhoaSpDcMua;
        private System.Windows.Forms.DataGridView dgv_DanhSachSPMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.TextBox txt_TuKhoaSanPham;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txt_SoLuong;
        private System.Windows.Forms.Label txt_SoLuongTon;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.ComboBox cmb_NhaCungCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Giam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_KhuyenMai;
        private System.Windows.Forms.Label txt_ncc;
        private System.Windows.Forms.Label txt_km;
    }
}