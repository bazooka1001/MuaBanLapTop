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
    //public delegate void SendMessage(int value);
    public partial class frm_ChinhSuaDonHang : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();

        private int MaKH;
        private int MaNV;
        private int MaDH;
        public frm_ChinhSuaDonHang(int manv, int madh)
        {
            MaNV = manv;
            MaDH = madh;
            InitializeComponent();
        }

        private void frm_ChinhSuaDonHang_Load(object sender, EventArgs e)
        {
            txt_MaDH.Enabled = false;
            txt_MaDH.Text = MaDH.ToString();
            txt_TongTien.Enabled = false;
            txt_NhanVien.Enabled = false;
            txt_TraTruoc.Enabled = false;
            txt_MaNV.Text = "#" + MaNV.ToString();
            layTenNhanVien();

            txt_TenKhachHang.Enabled = false;
            txt_Sdt.Enabled = false;
            txt_Email.Enabled = false;
            txt_DiaChi.Enabled = false;

            date_NgayTao.Enabled = false;
            //date_NgayTao.Value = DateTime.Now;

            LoadDataInfo();
        }
        void LoadDataInfo()
        {
            try
            {
                SqlDataReader dataReader = dlDH.ThongTinChiTietDonHang(MaDH);
                while (dataReader.Read())
                {
                    //txt_MaDH.Text = dataReader.GetValue(0).ToString();
                    txt_maKH.Text = "#" + dataReader.GetValue(1).ToString();
                    MaKH = Convert.ToInt32(dataReader.GetValue(1).ToString());
                    txt_TenKhachHang.Text = dataReader.GetValue(2).ToString();
                    txt_TongTien.Text = dataReader.GetValue(3).ToString();
                    txt_TraTruoc.Text = dataReader.GetValue(4).ToString();
                    //txt_MaNV.Text = "#" + dataReader.GetValue(5).ToString();
                    //txt_NhanVien.Text = dataReader.GetValue(6).ToString();
                    if (Convert.ToBoolean(dataReader.GetValue(7).ToString()))
                        rbt_DaThanhToan.Checked = true;
                    else
                        rbt_Chua.Checked = true;
                    date_NgayTao.Value = Convert.ToDateTime(dataReader.GetValue(8).ToString());
                    cbx_GiaoHang.Checked = Convert.ToBoolean(dataReader.GetValue(9).ToString());
                    txt_GhiChu.Text = dataReader.GetValue(10).ToString();
                    //cbx_Huy.Checked = Convert.ToBoolean(dataReader.GetValue(11).ToString());
                    txt_Sdt.Text = dataReader.GetValue(12).ToString();
                    txt_Email.Text = dataReader.GetValue(13).ToString();
                    txt_DiaChi.Text = dataReader.GetValue(14).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }
        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Quay lại và không lưu?", "Trả Lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trl == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                int tt = 0;
                int gh = 0;
                int huy = 0;
                if (cbx_GiaoHang.Checked)
                    gh = 1;
                if (rbt_DaThanhToan.Checked)
                    tt = 1;
                dlDH = new BLDonHang();
                bool kq = dlDH.ChinhSuaDonHang(MaDH, MaKH, Convert.ToInt32(txt_TongTien.Text.Trim()), Convert.ToInt32(txt_TraTruoc.Text.Trim()), MaNV, tt,
                            date_NgayTao.Value.ToString("yyyy/MM/dd"), gh, txt_GhiChu.Text.Trim(), huy, ref err);
                if (kq)
                {
                    MessageBox.Show("Đã lưu!");
                    this.Close();
                }
                else
                    MessageBox.Show("Lưu không thành công!");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi! Xem lại Trả trước!");
            }
        }
        void LoadDanhSachSPMua()
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.DanhSachSanPhamMua(MaDH);
                dtDH = ds.Tables[0];
                dgv_DanhSachSPMua.DataSource = dtDH;
                dgv_DanhSachSPMua.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm mua. Lỗi rồi!!!");
            }
        }
        private void btn_ThemSanPhamMua_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ThemSanPhamMua frm = new frm_ThemSanPhamMua(MaDH);
                frm.ShowDialog();
                LoadDanhSachSPMua();
                try
                {
                    int tongTien = dlDH.LayTongTienDH(MaDH, ref err);
                    txt_TongTien.Text = tongTien.ToString();
                }
                catch
                {
                    MessageBox.Show("Không thể lấy tổng tiền!");
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void btn_ThayDoiKhachHang_Click(object sender, EventArgs e)
        {
            frm_ThayDoiKhachHang frm = new frm_ThayDoiKhachHang(SetValue);
            frm.ShowDialog();
            txt_maKH.Text = "#" + MaKH.ToString();
            LoadInfoKH();
        }
        private void SetValue(int value)
        {
            MaKH = value;
        }
        void LoadInfoKH()
        {
            try
            {
                SqlDataReader dataReader = dlDH.LayThongTinKhachHang(MaKH);
                while (dataReader.Read())
                {
                    //txt_maKH.Text = dataReader.GetValue(0).ToString();
                    txt_TenKhachHang.Text = dataReader.GetValue(1).ToString();
                    txt_Sdt.Text = dataReader.GetValue(2).ToString();
                    txt_Email.Text = dataReader.GetValue(3).ToString();
                    txt_DiaChi.Text = dataReader.GetValue(4).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }
        void layTenNhanVien()
        {
            try
            {
                SqlDataReader dataReader = dlDH.LayTenNV(MaNV);
                while (dataReader.Read())
                {
                    txt_NhanVien.Text = dataReader.GetValue(0).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được tên nhân viên!");
            }
        }

        private void rbt_Chua_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbt_Chua.Checked)
            {
                txt_TraTruoc.Text = "0";
                txt_TraTruoc.Enabled = true;
            }
        }

        private void rbt_DaThanhToan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbt_DaThanhToan.Checked)
            {
                txt_TraTruoc.Enabled = false;
                txt_TraTruoc.Text = txt_TongTien.Text;
            }
        }

        private void txt_TongTien_TextChanged_1(object sender, EventArgs e)
        {
            if (rbt_DaThanhToan.Checked)
            {
                txt_TraTruoc.Text = txt_TongTien.Text;
            }
        }
    }
}
