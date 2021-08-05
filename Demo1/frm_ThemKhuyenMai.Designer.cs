namespace Demo1
{
    partial class frm_ThemKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox_ThongTin = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbt_ApDung = new System.Windows.Forms.RadioButton();
            this.rbt_Khoa = new System.Windows.Forms.RadioButton();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.dgv_DanhSachSP = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenKM = new System.Windows.Forms.TextBox();
            this.txt_Giam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.groupBox_ThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(1006, 581);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(90, 32);
            this.btn_Luu.TabIndex = 22;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // groupBox_ThongTin
            // 
            this.groupBox_ThongTin.Controls.Add(this.panel2);
            this.groupBox_ThongTin.Controls.Add(this.txt_NoiDung);
            this.groupBox_ThongTin.Controls.Add(this.btn_ThemSanPham);
            this.groupBox_ThongTin.Controls.Add(this.dgv_DanhSachSP);
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
            this.groupBox_ThongTin.Location = new System.Drawing.Point(96, 92);
            this.groupBox_ThongTin.Name = "groupBox_ThongTin";
            this.groupBox_ThongTin.Size = new System.Drawing.Size(888, 593);
            this.groupBox_ThongTin.TabIndex = 21;
            this.groupBox_ThongTin.TabStop = false;
            this.groupBox_ThongTin.Text = "Thông Tin Khuyến Mãi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbt_ApDung);
            this.panel2.Controls.Add(this.rbt_Khoa);
            this.panel2.Location = new System.Drawing.Point(532, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 35);
            this.panel2.TabIndex = 18;
            // 
            // rbt_ApDung
            // 
            this.rbt_ApDung.AutoSize = true;
            this.rbt_ApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ApDung.Location = new System.Drawing.Point(12, 8);
            this.rbt_ApDung.Name = "rbt_ApDung";
            this.rbt_ApDung.Size = new System.Drawing.Size(122, 21);
            this.rbt_ApDung.TabIndex = 16;
            this.rbt_ApDung.TabStop = true;
            this.rbt_ApDung.Text = "Đang Áp Dụng";
            this.rbt_ApDung.UseVisualStyleBackColor = true;
            this.rbt_ApDung.CheckedChanged += new System.EventHandler(this.rbt_ApDung_CheckedChanged);
            // 
            // rbt_Khoa
            // 
            this.rbt_Khoa.AutoSize = true;
            this.rbt_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Khoa.Location = new System.Drawing.Point(176, 8);
            this.rbt_Khoa.Name = "rbt_Khoa";
            this.rbt_Khoa.Size = new System.Drawing.Size(62, 21);
            this.rbt_Khoa.TabIndex = 17;
            this.rbt_Khoa.TabStop = true;
            this.rbt_Khoa.Text = "Khóa";
            this.rbt_Khoa.UseVisualStyleBackColor = true;
            this.rbt_Khoa.CheckedChanged += new System.EventHandler(this.rbt_Khoa_CheckedChanged);
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDung.Location = new System.Drawing.Point(127, 86);
            this.txt_NoiDung.Multiline = true;
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(546, 74);
            this.txt_NoiDung.TabIndex = 13;
            this.txt_NoiDung.TextChanged += new System.EventHandler(this.txt_NoiDung_TextChanged);
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.Location = new System.Drawing.Point(499, 537);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(237, 35);
            this.btn_ThemSanPham.TabIndex = 17;
            this.btn_ThemSanPham.Text = "Thêm Sản Phẩm Được Khuyến Mãi";
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // dgv_DanhSachSP
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachSP.Location = new System.Drawing.Point(104, 312);
            this.dgv_DanhSachSP.Name = "dgv_DanhSachSP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSachSP.RowHeadersWidth = 51;
            this.dgv_DanhSachSP.RowTemplate.Height = 24;
            this.dgv_DanhSachSP.Size = new System.Drawing.Size(632, 219);
            this.dgv_DanhSachSP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội Dung :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Danh Sách Các Sản Phẩm Được Áp Dụng";
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKM.Location = new System.Drawing.Point(444, 35);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(326, 22);
            this.txt_TenKM.TabIndex = 9;
            this.txt_TenKM.TextChanged += new System.EventHandler(this.txt_TenKM_TextChanged);
            // 
            // txt_Giam
            // 
            this.txt_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Giam.Location = new System.Drawing.Point(127, 189);
            this.txt_Giam.Name = "txt_Giam";
            this.txt_Giam.Size = new System.Drawing.Size(214, 22);
            this.txt_Giam.TabIndex = 10;
            this.txt_Giam.TextChanged += new System.EventHandler(this.txt_Giam_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giảm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khuyến Mãi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Tạo:";
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKM.Location = new System.Drawing.Point(157, 38);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(100, 22);
            this.txt_MaKM.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayTao.Location = new System.Drawing.Point(136, 241);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Size = new System.Drawing.Size(200, 22);
            this.date_NgayTao.TabIndex = 12;
            this.date_NgayTao.Value = new System.DateTime(2019, 11, 27, 9, 49, 19, 0);
            this.date_NgayTao.ValueChanged += new System.EventHandler(this.date_NgayTao_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình Trạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thêm Khuyến Mãi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(47)))), ((int)(((byte)(143)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 16);
            this.panel1.TabIndex = 24;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(12, 40);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(77, 32);
            this.btn_QuayLai.TabIndex = 25;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // frm_ThemKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 720);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.groupBox_ThongTin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_ThemKhuyenMai";
            this.Load += new System.EventHandler(this.frm_ThemKhuyenMai_Load);
            this.groupBox_ThongTin.ResumeLayout(false);
            this.groupBox_ThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox_ThongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbt_ApDung;
        private System.Windows.Forms.RadioButton rbt_Khoa;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.DataGridView dgv_DanhSachSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenKM;
        private System.Windows.Forms.TextBox txt_Giam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_NgayTao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_QuayLai;
    }
}