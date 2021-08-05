using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Demo1.BS_Layer;

namespace Demo1
{
    public partial class User_DonHang : UserControl
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();
        private int MaNV;
        public User_DonHang(int id)
        {
            MaNV = id;
            InitializeComponent();
        }

        private void User_DonHang_Load(object sender, EventArgs e)
        {
            resetText();
            LoadDanhSachDH();
            setValueCMB();
            cmb_Loc.SelectedItem = 1;

            txt_MaDH.Enabled = false;
            cbx_Huy.Enabled = false;
            txt_TenKhachHang.Enabled = false;
            txt_TongTien.Enabled = false;
            txt_TraTruoc.Enabled = false;
            cbx_GiaoHang.Enabled = false;
            rbt_Chua.Enabled = false;
            rbt_DaThanhToan.Enabled = false;
            date_NgayTao.Enabled = false;
            txt_NhanVien.Enabled = false;
            txt_GhiChu.Enabled = false;
        }

        private void btn_themDonHang_Click(object sender, EventArgs e)
        {
            frm_ThemDonHang frm = new frm_ThemDonHang(MaNV);
            frm.ShowDialog();
            resetText();
            LoadDanhSachDH();
        }
        void resetText()
        {
            txt_MaDH.ResetText();
            cbx_Huy.Checked = false;
            txt_TenKhachHang.ResetText();
            txt_maKH.Text = "maKH";
            txt_TongTien.ResetText();
            txt_TraTruoc.ResetText();
            cbx_GiaoHang.Checked = false;
            rbt_Chua.Checked = false;
            rbt_DaThanhToan.Checked = false;
            date_NgayTao.ResetText();
            txt_NhanVien.ResetText();
            txt_MaNV.Text = "maNV";
            txt_GhiChu.ResetText();
            txt_TuKhoa.ResetText();

            btn_editDonHang.Enabled = false;
            btn_XemChiTiet.Enabled = false;
        }
        void LoadDanhSachDH()
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.LayDanhSachDonHang();
                dtDH = ds.Tables[0];
                dgv_DanhSachDonHang.DataSource = dtDH;
                dgv_DanhSachDonHang.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách đơn hàng. Lỗi rồi!");
            }
        }
        void LoadDataInfo(int id)
        {
            resetText();
            try
            {
                SqlDataReader dataReader = dlDH.LayThongTinDH(id);
                while(dataReader.Read())
                {
                    txt_MaDH.Text = dataReader.GetValue(0).ToString();
                    txt_maKH.Text = "#" + dataReader.GetValue(1).ToString();
                    txt_TenKhachHang.Text = dataReader.GetValue(2).ToString();
                    txt_TongTien.Text = dataReader.GetValue(3).ToString();
                    txt_TraTruoc.Text = dataReader.GetValue(4).ToString();
                    txt_MaNV.Text = "#" + dataReader.GetValue(5).ToString();
                    txt_NhanVien.Text = dataReader.GetValue(6).ToString();
                    if (Convert.ToBoolean(dataReader.GetValue(7).ToString()))
                        rbt_DaThanhToan.Checked = true;
                    else
                        rbt_Chua.Checked = true;
                    date_NgayTao.Value = Convert.ToDateTime(dataReader.GetValue(8).ToString());
                    cbx_GiaoHang.Checked = Convert.ToBoolean(dataReader.GetValue(9).ToString());
                    txt_GhiChu.Text = dataReader.GetValue(10).ToString();
                    cbx_Huy.Checked = Convert.ToBoolean(dataReader.GetValue(11).ToString());
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }
        void setValueCMB()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(2, "Tất Cả");
            dict.Add(1, "Đã Thanh Toán");
            dict.Add(0, "Chưa Thanh Toán");

            cmb_Loc.DataSource = new BindingSource(dict, null);
            cmb_Loc.DisplayMember = "Value";
            cmb_Loc.ValueMember = "Key";

        }

        private void dgv_DanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgv_DanhSachDonHang.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgv_DanhSachDonHang.Rows[r].Cells[0].Value);
                LoadDataInfo(id);
                btn_editDonHang.Enabled = true;
                btn_XemChiTiet.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vui lòng không chọn hàng này!");
            }
        }

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds;

                int f = Convert.ToInt32(cmb_Loc.SelectedValue);
                if (f == 2)
                    ds = dlDH.TimKiemDonHang(txt_TuKhoa.Text.Trim());
                else
                    ds = dlDH.BoLocDonHang(txt_TuKhoa.Text.Trim(), f);
                dtDH = ds.Tables[0];
                dgv_DanhSachDonHang.DataSource = dtDH;
                dgv_DanhSachDonHang.AutoResizeColumns();
            }
            catch
            {
                //MessageBox.Show("Không lấy được danh sách đơn hàng. Lỗi rồi!");
            }
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds;

                int f = Convert.ToInt32(cmb_Loc.SelectedValue);
                if (f == 2)
                    ds = dlDH.TimKiemDonHang(txt_TuKhoa.Text.Trim());
                else
                    ds = dlDH.BoLocDonHang(txt_TuKhoa.Text.Trim(), f);
                dtDH = ds.Tables[0];
                dgv_DanhSachDonHang.DataSource = dtDH;
                dgv_DanhSachDonHang.AutoResizeColumns();
            }
            catch
            {
                //MessageBox.Show("Không lấy được danh sách đơn hàng. Lỗi rồi!");
            }
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MaDH.Text.Trim());
            frm_XemChiTietDonHang frm = new frm_XemChiTietDonHang(id);
            frm.ShowDialog();
        }

        private void btn_editDonHang_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MaDH.Text.Trim());
            frm_ChinhSuaDonHang frm = new frm_ChinhSuaDonHang(MaNV, id);
            frm.ShowDialog();
            LoadDataInfo(id);
            LoadDanhSachDH();
        }
    }
}
