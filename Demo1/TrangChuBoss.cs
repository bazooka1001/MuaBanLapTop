using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class frm_Boss_Home : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private int MaNV;

        User_DonHang user_DonHang;
        public frm_Boss_Home(int id)
        {
            MaNV = id;
            InitializeComponent();
        }

        private void frm_Boss_Home_Load(object sender, EventArgs e)
        {
            user_DonHang = new User_DonHang(MaNV);
            panel_TrangChucNang.Controls.Add(user_DonHang);
            user_DonHang.Dock = DockStyle.Fill;

            user_DonHang.BringToFront();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            user_DonHang.BringToFront();
            panel_side.Top = btn_DonHang.Top;
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_KhuyenMai.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_khuyenMai.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_khuyenMai.Instance);
                User_khuyenMai.Instance.Dock = DockStyle.Fill;
                User_khuyenMai.Instance.BringToFront();
            }
            else
                User_khuyenMai.Instance.BringToFront();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_KhachHang.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_KhachHang.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_KhachHang.Instance);
                User_KhachHang.Instance.Dock = DockStyle.Fill;
                User_KhachHang.Instance.BringToFront();
            }
            else
                User_KhachHang.Instance.BringToFront();
        }

        private void pic_exit_Click(object sender, EventArgs e)
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

        private void panel_tieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pic_exit_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pic_exit_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel_tieuDe_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel_tieuDe_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_SanPham.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_SanPham.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_SanPham.Instance);
                User_SanPham.Instance.Dock = DockStyle.Fill;
                User_SanPham.Instance.BringToFront();
            }
            else
                User_SanPham.Instance.BringToFront();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_NhaCungCap.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_NhaCungCap.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_NhaCungCap.Instance);
                User_NhaCungCap.Instance.Dock = DockStyle.Fill;
                User_NhaCungCap.Instance.BringToFront();
            }
            else
                User_NhaCungCap.Instance.BringToFront();
        }

        private void bnt_NhapHang_Click(object sender, EventArgs e)
        {
            panel_side.Top = bnt_NhapHang.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_HoaDonNhap.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_HoaDonNhap.Instance);
                User_HoaDonNhap.Instance.Dock = DockStyle.Fill;
                User_HoaDonNhap.Instance.BringToFront();
            }
            else
                User_HoaDonNhap.Instance.BringToFront();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_NhanVien.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_Boss.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_Boss.Instance);
                User_Boss.Instance.Dock = DockStyle.Fill;
                User_Boss.Instance.BringToFront();
            }
            else
                User_Boss.Instance.BringToFront();
        }

        private void btn_ThongTinCH_Click(object sender, EventArgs e)
        {
            panel_side.Top = btn_ThongTinCH.Top;
            if (!panel_TrangChucNang.Controls.Contains(User_ThongTinCuaHang.Instance))
            {
                panel_TrangChucNang.Controls.Add(User_ThongTinCuaHang.Instance);
                User_ThongTinCuaHang.Instance.Dock = DockStyle.Fill;
                User_ThongTinCuaHang.Instance.BringToFront();
            }
            else
                User_ThongTinCuaHang.Instance.BringToFront();
        }

        private void btn_ThayDoiMK_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau(MaNV);
            frm.ShowDialog();
        }
    }
}
