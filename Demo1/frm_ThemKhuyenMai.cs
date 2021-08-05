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
    public partial class frm_ThemKhuyenMai : Form
    {
        DataTable dtKM = null;
        string err;
        BLKhuyenMai dlKM = new BLKhuyenMai();
        private int MaKM;
        public frm_ThemKhuyenMai(int makm)
        {
            MaKM = makm;
            InitializeComponent();
        }

        private void frm_ThemKhuyenMai_Load(object sender, EventArgs e)
        {
            MaKM = dlKM.TaoMaKM(ref err);
            txt_MaKM.Text = MaKM.ToString();
            txt_MaKM.Enabled = false;
            rbt_ApDung.Checked = true;
            date_NgayTao.Enabled = false;
            date_NgayTao.Value = DateTime.Now;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    dlKM = new BLKhuyenMai();
                    if (KiemTraDaTonTai())// chinh sua thong tin
                    {
                        bool kq = dlKM.ChinhSuaKM(MaKM, txt_TenKM.Text.Trim(), txt_NoiDung.Text.Trim(),
                            Convert.ToInt32(txt_Giam.Text.Trim()), rbt_ApDung.Checked, date_NgayTao.Value.ToString("yyyy/MM/dd"), ref err);
                        if (kq)
                        {
                            MessageBox.Show("Đã lưu!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Lưu không thành công!");
                    }
                    else // them moi
                    {
                        bool kq = dlKM.ThemKM(MaKM, txt_TenKM.Text.Trim(), txt_NoiDung.Text.Trim(),
                            Convert.ToInt32(txt_Giam.Text.Trim()), rbt_ApDung.Checked, date_NgayTao.Value.ToString("yyyy/MM/dd"), ref err);
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
                    MessageBox.Show("Đã xảy ra lỗi!");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if(!KiemTraDaTonTai())
            {
                bool kq = dlKM.ThemKM(MaKM, txt_TenKM.Text.Trim(), txt_NoiDung.Text.Trim(),
                            0, rbt_ApDung.Checked, date_NgayTao.Value.ToString("yyyy/MM/dd"), ref err);
                if (!kq)
                    MessageBox.Show("Thêm không thành công!");
            }
            frm_ThemSanPhamKhuyenMai frm = new frm_ThemSanPhamKhuyenMai(MaKM, txt_TenKM.Text.Trim());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadDanhSachSpKM(MaKM);
        }
        bool KiemTra()
        {
            if (txt_TenKM.Text.Equals(""))
                return false;
            else if (txt_NoiDung.Text.Equals(""))
                return false;
            else if (txt_Giam.Text.Equals(""))
                return false;
            return true;
        }
        bool KiemTraDaTonTai()
        {
            int id = dlKM.TaoMaKM(ref err);
            if (MaKM == id)
                return false;
            return true;
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

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Quay lại và không lưu?", "Trả Lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trl == DialogResult.OK)
            {
                if (KiemTraDaTonTai())
                {
                    dlKM.XoaKhuyenMai(MaKM, ref err);
                }
                this.Close();
            }
        }
        void ThemKhuyenMai()
        {

        }
        private void txt_TenKM_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_NoiDung_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Giam_TextChanged(object sender, EventArgs e)
        {
        }

        private void date_NgayTao_ValueChanged(object sender, EventArgs e)
        {
        }

        private void rbt_ApDung_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbt_Khoa_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
