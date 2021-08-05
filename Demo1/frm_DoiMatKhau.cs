using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Demo1.BS_Layer;

namespace Demo1
{
    public partial class frm_DoiMatKhau : Form
    {
        BLDangNhap dlDN = new BLDangNhap();

        string err;

        private int MaNV;
        public frm_DoiMatKhau(int id)
        {
            MaNV = id;
            InitializeComponent();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MKcu.Text.Equals("") ||
                txt_MKmoi.Text.Equals("") ||
                txt_XacMinh.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                if (dlDN.KiemTraMK(MaNV, txt_MKcu.Text.Trim(), ref err) != 0)
                {
                    if (txt_MKmoi.Text.Equals(txt_XacMinh.Text))
                    {
                        bool kp = dlDN.DoiMatKhau(MaNV, txt_MKmoi.Text.Trim(), ref err);
                        if (kp)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Không đổi được mật khẩu");
                    }
                    else
                        MessageBox.Show("Mật khẩu mới và Nhập lại mật khẩu không giống nhau!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Nhập sai mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
