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
    public partial class frm_XemChiTietSPMua : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();

        private int MaDH;
        public frm_XemChiTietSPMua(int id)
        {
            MaDH = id;
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frm_XemChiTietSPMua_Load(object sender, EventArgs e)
        {
            txt_MaDH.Text = MaDH.ToString();
            LoadDanhSachSPMua();
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

        private void dgv_DanhSachSPMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgv_DanhSachSPMua.CurrentCell.RowIndex;
                int maSp = Convert.ToInt32(dgv_DanhSachSPMua.Rows[r].Cells[0].Value);
                LoadDataInfo(maSp);
            }
            catch
            {
                MessageBox.Show("Vui lòng không chọn hàng này!");
            }
        }
        void LoadDataInfo(int MaSP)
        {
            try
            {
                SqlDataReader dataReader = dlDH.ThongTinChiTietSPMUa(MaDH, MaSP);
                while(dataReader.Read())
                {
                    txt_MaSP.Text = dataReader.GetValue(0).ToString();
                    txt_TenSP.Text = dataReader.GetValue(1).ToString();
                    //MaDH
                    txt_SoLuong.Text = dataReader.GetValue(3).ToString();
                    txt_ThanhTien.Text = dataReader.GetValue(4).ToString();
                    txt_MaKM.Text = dataReader.GetValue(5).ToString();
                    txt_TenKM.Text = dataReader.GetValue(6).ToString();
                    txt_Giam.Text = dataReader.GetValue(7).ToString();
                    txt_GiaBan.Text = dataReader.GetValue(8).ToString();
                    txt_MaNcc.Text = dataReader.GetValue(9).ToString();
                    txt_NhaCc.Text = dataReader.GetValue(10).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
