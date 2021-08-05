namespace Demo1
{
    partial class frm_ThemSanPhamKhuyenMai
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TuKhoaSpDcKM = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachSPKM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TenKM = new System.Windows.Forms.Label();
            this.label_MaKM = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachSP = new System.Windows.Forms.DataGridView();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.date_BatDau = new System.Windows.Forms.DateTimePicker();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPKM)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_TuKhoaSpDcKM);
            this.groupBox3.Controls.Add(this.dgv_DanhSachSPKM);
            this.groupBox3.Location = new System.Drawing.Point(629, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 307);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Khuyến Mãi";
            // 
            // txt_TuKhoaSpDcKM
            // 
            this.txt_TuKhoaSpDcKM.Location = new System.Drawing.Point(128, 30);
            this.txt_TuKhoaSpDcKM.Name = "txt_TuKhoaSpDcKM";
            this.txt_TuKhoaSpDcKM.Size = new System.Drawing.Size(260, 22);
            this.txt_TuKhoaSpDcKM.TabIndex = 44;
            this.txt_TuKhoaSpDcKM.TextChanged += new System.EventHandler(this.txt_TuKhoaSpDcKM_TextChanged);
            // 
            // dgv_DanhSachSPKM
            // 
            this.dgv_DanhSachSPKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSPKM.Location = new System.Drawing.Point(23, 73);
            this.dgv_DanhSachSPKM.Name = "dgv_DanhSachSPKM";
            this.dgv_DanhSachSPKM.RowHeadersWidth = 51;
            this.dgv_DanhSachSPKM.RowTemplate.Height = 24;
            this.dgv_DanhSachSPKM.Size = new System.Drawing.Size(409, 213);
            this.dgv_DanhSachSPKM.TabIndex = 42;
            this.dgv_DanhSachSPKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSPKM_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "#";
            // 
            // label_TenKM
            // 
            this.label_TenKM.AutoSize = true;
            this.label_TenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKM.Location = new System.Drawing.Point(235, 70);
            this.label_TenKM.Name = "label_TenKM";
            this.label_TenKM.Size = new System.Drawing.Size(143, 20);
            this.label_TenKM.TabIndex = 56;
            this.label_TenKM.Text = "Tên Khuyến Mãi";
            // 
            // label_MaKM
            // 
            this.label_MaKM.AutoSize = true;
            this.label_MaKM.Location = new System.Drawing.Point(145, 73);
            this.label_MaKM.Name = "label_MaKM";
            this.label_MaKM.Size = new System.Drawing.Size(47, 17);
            this.label_MaKM.TabIndex = 55;
            this.label_MaKM.Text = "MãKM";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(430, 615);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(114, 35);
            this.btn_Huy.TabIndex = 54;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(247, 615);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(114, 35);
            this.btn_Luu.TabIndex = 53;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgv_DanhSachSP);
            this.groupBox2.Controls.Add(this.txt_TuKhoa);
            this.groupBox2.Location = new System.Drawing.Point(629, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 294);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // dgv_DanhSachSP
            // 
            this.dgv_DanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSP.Location = new System.Drawing.Point(23, 84);
            this.dgv_DanhSachSP.Name = "dgv_DanhSachSP";
            this.dgv_DanhSachSP.RowHeadersWidth = 51;
            this.dgv_DanhSachSP.RowTemplate.Height = 24;
            this.dgv_DanhSachSP.Size = new System.Drawing.Size(409, 195);
            this.dgv_DanhSachSP.TabIndex = 19;
            this.dgv_DanhSachSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSP_CellClick);
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(128, 37);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(260, 22);
            this.txt_TuKhoa.TabIndex = 33;
            this.txt_TuKhoa.TextChanged += new System.EventHandler(this.txt_TuKhoa_TextChanged);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Location = new System.Drawing.Point(430, 546);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(114, 35);
            this.btn_ChinhSua.TabIndex = 51;
            this.btn_ChinhSua.Text = "Chỉnh Sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = true;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(247, 546);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(114, 35);
            this.btn_Xoa.TabIndex = 50;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(65, 546);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(114, 35);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sản Phẩm Khuyến Mãi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_KetThuc);
            this.groupBox1.Controls.Add(this.date_BatDau);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.txt_TenSanPham);
            this.groupBox1.Controls.Add(this.txt_MaSanPham);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(65, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 370);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // date_KetThuc
            // 
            this.date_KetThuc.Location = new System.Drawing.Point(171, 303);
            this.date_KetThuc.Name = "date_KetThuc";
            this.date_KetThuc.Size = new System.Drawing.Size(200, 22);
            this.date_KetThuc.TabIndex = 14;
            // 
            // date_BatDau
            // 
            this.date_BatDau.Location = new System.Drawing.Point(171, 239);
            this.date_BatDau.Name = "date_BatDau";
            this.date_BatDau.Size = new System.Drawing.Size(200, 22);
            this.date_BatDau.TabIndex = 13;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(171, 175);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(100, 22);
            this.txt_GiaBan.TabIndex = 12;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Location = new System.Drawing.Point(171, 111);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(267, 22);
            this.txt_TenSanPham.TabIndex = 8;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(171, 49);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(100, 22);
            this.txt_MaSanPham.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ngày Kết Thúc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày Bắt Đầu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giá Bán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên Sản Phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Sản Phẩm:";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(12, 29);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(88, 33);
            this.btn_QuayLai.TabIndex = 58;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(47)))), ((int)(((byte)(143)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 16);
            this.panel1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tìm Kiếm:";
            // 
            // frm_ThemSanPhamKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TenKM);
            this.Controls.Add(this.label_MaKM);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemSanPhamKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_ThemSanPhamKhuyenMai";
            this.Load += new System.EventHandler(this.frm_ThemSanPhamKhuyenMai_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPKM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_TuKhoaSpDcKM;
        private System.Windows.Forms.DataGridView dgv_DanhSachSPKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_TenKM;
        private System.Windows.Forms.Label label_MaKM;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachSP;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_KetThuc;
        private System.Windows.Forms.DateTimePicker date_BatDau;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}