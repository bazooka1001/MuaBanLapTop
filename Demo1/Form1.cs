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
    public partial class frm_Login : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        string err;
        
        public frm_Login()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pic_exit_Click_1(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Bạn muốn thoát?", "Trả Lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trl == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pic_exit_MouseHover(object sender, EventArgs e)
        {
            pic_exit.Image = Properties.Resources.exit2;
        }

        private void pic_exit_MouseLeave(object sender, EventArgs e)
        {
            pic_exit.Image = Properties.Resources.exit1;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                BLDangNhap blDn = new BLDangNhap();
                if(blDn.KiemTraMaNV(Convert.ToInt32(txt_id.Text),ref err) != 0)
                {
                    if (blDn.KiemTraMK(Convert.ToInt32(txt_id.Text), txt_pass.Text.Trim(), ref err) != 0)
                    {
                        int kq = blDn.KiemTraViTri(Convert.ToInt32(txt_id.Text), ref err);
                        if (kq == 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            frm_Boss_Home frm = new frm_Boss_Home(Convert.ToInt32(txt_id.Text));
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else if(kq == 1)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            frm_Emp_Home frm = new frm_Emp_Home(Convert.ToInt32(txt_id.Text));
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else if(kq == 3)
                        {
                            MessageBox.Show("Tai khoan dang bi khoa");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Nhập sai mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại mã nhân viên!", "Nhập sai mã nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại mã nhân viên!", "Nhập sai mã nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
