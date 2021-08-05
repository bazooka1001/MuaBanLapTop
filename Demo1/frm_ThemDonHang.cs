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
    public delegate void SendMessage(int value);
    public partial class frm_ThemDonHang : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();

        private int MaNV;
        private int MaKH;
        private int MaDH;
        
        public frm_ThemDonHang(int manv)
        {
            MaNV = manv;
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Quay lại và không lưu?", "Trả Lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trl == DialogResult.OK)
            {
                if (KiemTraDaTonTai())
                {
                    dlDH.XoaDonHang(MaDH, ref err);
                }
                this.Close();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (!txt_TenKhachHang.Text.Equals(""))
            {
                try
                {
                    int tt=0;
                    int gh=0;
                    int huy=0;
                    if (cbx_GiaoHang.Checked)
                        gh = 1;
                    if (rbt_DaThanhToan.Checked)
                        tt = 1;
                    dlDH = new BLDonHang();
                    if(KiemTraDaTonTai())//chinh sua thong tin
                    {
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
                    else //them moi
                    {
                        bool kq = dlDH.ThemDonHang(MaDH, MaKH, Convert.ToInt32(txt_TongTien.Text.Trim()), Convert.ToInt32(txt_TraTruoc.Text.Trim()), MaNV, tt,
                            date_NgayTao.Value.ToString("yyyy/MM/dd"), gh, txt_GhiChu.Text.Trim(), huy, ref err);
                        if (kq)
                        {
                            MessageBox.Show("Đã Thêm Xong!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Thêm không thành công!");
                    }
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi! Xem lại Trả trước!");
                }
            }
            else
                MessageBox.Show("Chưa chọn khách hàng!");
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
        private void btn_ThemSanPhamMua_Click(object sender, EventArgs e)
        {
            if (!txt_TenKhachHang.Text.Equals(""))
            {
                try
                {
                    if (!KiemTraDaTonTai())
                    {
                        int tt = 0;
                        int gh = 0;
                        int huy = 0;
                        if (cbx_GiaoHang.Checked)
                            gh = 1;
                        if (rbt_DaThanhToan.Checked)
                            tt = 1;
                        dlDH = new BLDonHang();
                        bool kq = dlDH.ThemDonHang(MaDH, MaKH, Convert.ToInt32(txt_TongTien.Text.Trim()), Convert.ToInt32(txt_TraTruoc.Text.Trim()), MaNV, tt,
                                    date_NgayTao.Value.ToString("yyyy/MM/dd"), gh, txt_GhiChu.Text.Trim(), huy, ref err);
                        if (kq)
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
                        else
                            MessageBox.Show("Thêm không thành công!");
                    }
                    else
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
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi!");
                }
            }
            else
                MessageBox.Show("Chưa chọn khách hàng!");
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

        private void frm_ThemDonHang_Load(object sender, EventArgs e)
        {
            txt_MaDH.Enabled = false;
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
            date_NgayTao.Value = DateTime.Now;
            try
            {
                MaDH = dlDH.TaoMaDH(ref err);
                txt_MaDH.Text = MaDH.ToString();
            }
            catch
            {
                MessageBox.Show("Không thể tạo mã đơn hàng!");
            }
        }
        void LoadInfoKH ()
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
        bool KiemTraDaTonTai()
        {
            int id = dlDH.TaoMaDH(ref err);
            if (MaDH == id)
                return false;
            return true;
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {
            if(rbt_DaThanhToan.Checked)
            {
                txt_TraTruoc.Text = txt_TongTien.Text;
            }
        }

        private void rbt_Chua_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_Chua.Checked)
            {
                txt_TraTruoc.Text = "0";
                txt_TraTruoc.Enabled = true;
            }
        }

        private void rbt_DaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_DaThanhToan.Checked)
            {
                txt_TraTruoc.Enabled = false;
                txt_TraTruoc.Text = txt_TongTien.Text;
            }
        }
    }
}
