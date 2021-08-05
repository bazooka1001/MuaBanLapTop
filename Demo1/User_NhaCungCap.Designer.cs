namespace Demo1
{
    partial class User_NhaCungCap
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_TrangthaiNcc = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TimNcc = new System.Windows.Forms.TextBox();
            this.dgv_Ncc = new System.Windows.Forms.DataGridView();
            this.txt_MailNcc = new System.Windows.Forms.TextBox();
            this.txt_TenNcc = new System.Windows.Forms.TextBox();
            this.txt_SdtNcc = new System.Windows.Forms.TextBox();
            this.txt_DiaChiNcc = new System.Windows.Forms.TextBox();
            this.txt_MaNcc = new System.Windows.Forms.TextBox();
            this.btn_LuuNcc = new System.Windows.Forms.Button();
            this.btn_SuaNcc = new System.Windows.Forms.Button();
            this.btn_XoaNcc = new System.Windows.Forms.Button();
            this.btn_ThemNcc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChitietNcc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ncc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(951, 558);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(160, 49);
            this.btn_Huy.TabIndex = 13;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tìm kiếm: ";
            // 
            // cb_TrangthaiNcc
            // 
            this.cb_TrangthaiNcc.AutoSize = true;
            this.cb_TrangthaiNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangthaiNcc.Location = new System.Drawing.Point(532, 249);
            this.cb_TrangthaiNcc.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TrangthaiNcc.Name = "cb_TrangthaiNcc";
            this.cb_TrangthaiNcc.Size = new System.Drawing.Size(121, 24);
            this.cb_TrangthaiNcc.TabIndex = 16;
            this.cb_TrangthaiNcc.Text = "Còn hợp tác";
            this.cb_TrangthaiNcc.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trạng thái: ";
            // 
            // txt_TimNcc
            // 
            this.txt_TimNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimNcc.Location = new System.Drawing.Point(212, 287);
            this.txt_TimNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimNcc.Name = "txt_TimNcc";
            this.txt_TimNcc.Size = new System.Drawing.Size(311, 26);
            this.txt_TimNcc.TabIndex = 12;
            this.txt_TimNcc.TextChanged += new System.EventHandler(this.txt_TimNcc_TextChanged);
            // 
            // dgv_Ncc
            // 
            this.dgv_Ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ncc.Location = new System.Drawing.Point(49, 335);
            this.dgv_Ncc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ncc.Name = "dgv_Ncc";
            this.dgv_Ncc.RowHeadersWidth = 51;
            this.dgv_Ncc.Size = new System.Drawing.Size(799, 267);
            this.dgv_Ncc.TabIndex = 11;
            this.dgv_Ncc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Ncc_CellMouseClick);
            // 
            // txt_MailNcc
            // 
            this.txt_MailNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MailNcc.Location = new System.Drawing.Point(531, 186);
            this.txt_MailNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MailNcc.Name = "txt_MailNcc";
            this.txt_MailNcc.Size = new System.Drawing.Size(333, 26);
            this.txt_MailNcc.TabIndex = 10;
            // 
            // txt_TenNcc
            // 
            this.txt_TenNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNcc.Location = new System.Drawing.Point(504, 54);
            this.txt_TenNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNcc.Name = "txt_TenNcc";
            this.txt_TenNcc.Size = new System.Drawing.Size(360, 26);
            this.txt_TenNcc.TabIndex = 9;
            // 
            // txt_SdtNcc
            // 
            this.txt_SdtNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SdtNcc.Location = new System.Drawing.Point(176, 182);
            this.txt_SdtNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SdtNcc.Name = "txt_SdtNcc";
            this.txt_SdtNcc.Size = new System.Drawing.Size(272, 26);
            this.txt_SdtNcc.TabIndex = 8;
            this.txt_SdtNcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SdtNcc_KeyPress);
            // 
            // txt_DiaChiNcc
            // 
            this.txt_DiaChiNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChiNcc.Location = new System.Drawing.Point(176, 118);
            this.txt_DiaChiNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChiNcc.Name = "txt_DiaChiNcc";
            this.txt_DiaChiNcc.Size = new System.Drawing.Size(688, 26);
            this.txt_DiaChiNcc.TabIndex = 7;
            // 
            // txt_MaNcc
            // 
            this.txt_MaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNcc.Location = new System.Drawing.Point(176, 54);
            this.txt_MaNcc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNcc.Name = "txt_MaNcc";
            this.txt_MaNcc.Size = new System.Drawing.Size(141, 26);
            this.txt_MaNcc.TabIndex = 6;
            // 
            // btn_LuuNcc
            // 
            this.btn_LuuNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuNcc.Location = new System.Drawing.Point(951, 340);
            this.btn_LuuNcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuNcc.Name = "btn_LuuNcc";
            this.btn_LuuNcc.Size = new System.Drawing.Size(160, 49);
            this.btn_LuuNcc.TabIndex = 11;
            this.btn_LuuNcc.Text = "Lưu";
            this.btn_LuuNcc.UseVisualStyleBackColor = true;
            this.btn_LuuNcc.Click += new System.EventHandler(this.btn_LuuNcc_Click);
            // 
            // btn_SuaNcc
            // 
            this.btn_SuaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNcc.Location = new System.Drawing.Point(951, 250);
            this.btn_SuaNcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaNcc.Name = "btn_SuaNcc";
            this.btn_SuaNcc.Size = new System.Drawing.Size(160, 49);
            this.btn_SuaNcc.TabIndex = 10;
            this.btn_SuaNcc.Text = "Sửa";
            this.btn_SuaNcc.UseVisualStyleBackColor = true;
            this.btn_SuaNcc.Click += new System.EventHandler(this.btn_SuaNcc_Click);
            // 
            // btn_XoaNcc
            // 
            this.btn_XoaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNcc.Location = new System.Drawing.Point(951, 440);
            this.btn_XoaNcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaNcc.Name = "btn_XoaNcc";
            this.btn_XoaNcc.Size = new System.Drawing.Size(160, 49);
            this.btn_XoaNcc.TabIndex = 9;
            this.btn_XoaNcc.Text = "Xóa";
            this.btn_XoaNcc.UseVisualStyleBackColor = true;
            this.btn_XoaNcc.Click += new System.EventHandler(this.btn_XoaNcc_Click);
            // 
            // btn_ThemNcc
            // 
            this.btn_ThemNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNcc.Location = new System.Drawing.Point(951, 169);
            this.btn_ThemNcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNcc.Name = "btn_ThemNcc";
            this.btn_ThemNcc.Size = new System.Drawing.Size(160, 49);
            this.btn_ThemNcc.TabIndex = 8;
            this.btn_ThemNcc.Text = "Thêm mới";
            this.btn_ThemNcc.UseVisualStyleBackColor = true;
            this.btn_ThemNcc.Click += new System.EventHandler(this.btn_ThemNcc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách Nhà cung cấp: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp: ";
            // 
            // btn_ChitietNcc
            // 
            this.btn_ChitietNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChitietNcc.Location = new System.Drawing.Point(951, 89);
            this.btn_ChitietNcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChitietNcc.Name = "btn_ChitietNcc";
            this.btn_ChitietNcc.Size = new System.Drawing.Size(160, 49);
            this.btn_ChitietNcc.TabIndex = 12;
            this.btn_ChitietNcc.Text = "Chi tiết";
            this.btn_ChitietNcc.UseVisualStyleBackColor = true;
            this.btn_ChitietNcc.Click += new System.EventHandler(this.btn_ChitietNcc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_TrangthaiNcc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TimNcc);
            this.groupBox1.Controls.Add(this.dgv_Ncc);
            this.groupBox1.Controls.Add(this.txt_MailNcc);
            this.groupBox1.Controls.Add(this.txt_TenNcc);
            this.groupBox1.Controls.Add(this.txt_SdtNcc);
            this.groupBox1.Controls.Add(this.txt_DiaChiNcc);
            this.groupBox1.Controls.Add(this.txt_MaNcc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 634);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà Cung Cấp";
            // 
            // User_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_LuuNcc);
            this.Controls.Add(this.btn_SuaNcc);
            this.Controls.Add(this.btn_XoaNcc);
            this.Controls.Add(this.btn_ThemNcc);
            this.Controls.Add(this.btn_ChitietNcc);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_NhaCungCap";
            this.Size = new System.Drawing.Size(1147, 720);
            this.Load += new System.EventHandler(this.User_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ncc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_TrangthaiNcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TimNcc;
        private System.Windows.Forms.DataGridView dgv_Ncc;
        private System.Windows.Forms.TextBox txt_MailNcc;
        private System.Windows.Forms.TextBox txt_TenNcc;
        private System.Windows.Forms.TextBox txt_SdtNcc;
        private System.Windows.Forms.TextBox txt_DiaChiNcc;
        private System.Windows.Forms.TextBox txt_MaNcc;
        private System.Windows.Forms.Button btn_LuuNcc;
        private System.Windows.Forms.Button btn_SuaNcc;
        private System.Windows.Forms.Button btn_XoaNcc;
        private System.Windows.Forms.Button btn_ThemNcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChitietNcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
