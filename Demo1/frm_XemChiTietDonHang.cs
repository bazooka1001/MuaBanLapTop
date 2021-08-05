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
    public partial class frm_XemChiTietDonHang : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();

        private int MaDH;
        public frm_XemChiTietDonHang(int id)
        {
            MaDH = id;
            InitializeComponent();
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
        void LoadDataInfo()
        {
            try
            {
                SqlDataReader dataReader = dlDH.ThongTinChiTietDonHang(MaDH);
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
        private void frm_XemChiTietDonHang_Load(object sender, EventArgs e)
        {
            //txt_MaDH.Text = MaDH.ToString();
            LoadDataInfo();
            LoadDanhSachSPMua();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XemSanPhamMua_Click(object sender, EventArgs e)
        {
            frm_XemChiTietSPMua frm = new frm_XemChiTietSPMua(MaDH);
            frm.Show();
        }
    }
}
