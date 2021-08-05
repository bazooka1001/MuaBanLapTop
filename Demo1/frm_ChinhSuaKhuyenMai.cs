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
    public partial class frm_ChinhSuaKhuyenMai : Form
    {
        DataTable dtKM = null;
        string err;
        BLKhuyenMai dlKM = new BLKhuyenMai();
        private int MaKm;
        public frm_ChinhSuaKhuyenMai(int id)
        {
            MaKm = id;
            InitializeComponent();
        }

        private void frm_ChinhSuaKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDataInfo(MaKm);
            txt_MaKM.Enabled = false;
            date_NgayTao.Enabled = false;
        }
        void LoadDataInfo(int MaKM)
        {
            resetTextBox();
            try
            {
                SqlDataReader dataReader = dlKM.LayThongTinKM(MaKM);
                while (dataReader.Read())
                {
                    txt_MaKM.Text = dataReader.GetValue(0).ToString();
                    txt_TenKM.Text = dataReader.GetValue(1).ToString();
                    txt_NoiDung.Text = dataReader.GetValue(2).ToString();
                    txt_Giam.Text = dataReader.GetValue(3).ToString();
                    if (Convert.ToBoolean(dataReader.GetValue(4).ToString()))
                        rbt_ApDung.Checked = true;
                    else
                        rbt_Khoa.Checked = true;
                    date_NgayTao.Value = Convert.ToDateTime(dataReader.GetValue(5).ToString());

                }
                LoadDanhSachSpKM(Convert.ToInt32(txt_MaKM.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }
        void LoadDanhSachSpKM(int MaKM)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.LayDanhSachSpKM(MaKM);
                dtKM = ds.Tables[0];
                dgv_DanhSachSP.DataSource = dtKM;
                dgv_DanhSachSP.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm khuyến mãi!");
            }
        }
        void resetTextBox()
        {
            txt_MaKM.ResetText();
            txt_TenKM.ResetText();
            txt_NoiDung.ResetText();
            txt_Giam.ResetText();
            date_NgayTao.ResetText();
            rbt_ApDung.Checked = false;
            rbt_Khoa.Checked = false;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (!txt_TenKM.Text.Equals(""))
            {
                try
                {
                    dlKM = new BLKhuyenMai();
                    bool kq = dlKM.ChinhSuaKM(MaKm, txt_TenKM.Text.Trim(), txt_NoiDung.Text.Trim(),
                        Convert.ToInt32(txt_Giam.Text.Trim()), rbt_ApDung.Checked, date_NgayTao.Value.ToString("yyyy/MM/dd"), ref err);
                    if (kq)
                    {
                        MessageBox.Show("Đã chỉnh sửa xong!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Chỉnh sửa không thành công!");
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi! Xem lại số tiền giảm!");
                }
            }
            else
                MessageBox.Show("Tên không được bỏ trống!");
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            frm_ThemSanPhamKhuyenMai frm = new frm_ThemSanPhamKhuyenMai(MaKm, txt_TenKM.Text.Trim());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadDanhSachSpKM(MaKm);
        }
    }
}
