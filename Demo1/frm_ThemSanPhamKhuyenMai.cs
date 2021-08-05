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
    public partial class frm_ThemSanPhamKhuyenMai : Form
    {
        private int MaKM;
        private string TenKM;
        private bool spkm=true;
        private bool them;

        DataTable dtKM = null;
        string err;
        BLKhuyenMai dlKM = new BLKhuyenMai();
        public frm_ThemSanPhamKhuyenMai(int id, string name)
        {
            MaKM = id;
            TenKM = name;
            InitializeComponent();
        }
        void enableReviewSanPham(bool a)
        {
            date_BatDau.Enabled = false;
            date_KetThuc.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            if (a) //xem thong tin san pham
            {
                btn_Them.Enabled = true;
                btn_ChinhSua.Enabled = false;
                btn_Xoa.Enabled = false;
                date_BatDau.ResetText();
                date_KetThuc.ResetText();
            }
            else //xem thong tin san pham duoc khuyen mai
            {
                btn_Them.Enabled = false;
                btn_ChinhSua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }
        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThemSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            label_MaKM.Text = MaKM.ToString();
            label_TenKM.Text = TenKM;
            reLoad();
        }
        void reLoad()
        {
            txt_MaSanPham.Enabled = false;
            txt_TenSanPham.Enabled = false;
            txt_GiaBan.Enabled = false;
            date_BatDau.Enabled = false;
            date_KetThuc.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            txt_MaSanPham.ResetText();
            txt_TenSanPham.ResetText();
            txt_GiaBan.ResetText();
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_ChinhSua.Enabled = false;
            
            loadDanhSachSP();
            loadDanhSachSPKM();
        }
        void loadDanhSachSP()
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.DanhSachSanPhamChuaKM(MaKM);
                dtKM = ds.Tables[0];
                dgv_DanhSachSP.DataSource = dtKM;
                dgv_DanhSachSP.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm. Lỗi rồi!!!");
            }
        }
        void loadDanhSachSPKM()
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.LayDanhSachSpKM(MaKM);
                dtKM = ds.Tables[0];
                dgv_DanhSachSPKM.DataSource = dtKM;
                dgv_DanhSachSPKM.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm khuyến mãi. Lỗi rồi!!!");
            }
        }

        private void dgv_DanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_Them.Enabled)
            {
                spkm = true;
                enableReviewSanPham(spkm);
            }
            int r = dgv_DanhSachSP.CurrentCell.RowIndex;
            txt_MaSanPham.Text = dgv_DanhSachSP.Rows[r].Cells[0].Value.ToString();
            txt_TenSanPham.Text = dgv_DanhSachSP.Rows[r].Cells[1].Value.ToString();
            txt_GiaBan.Text = dgv_DanhSachSP.Rows[r].Cells[2].Value.ToString();
        }

        private void dgv_DanhSachSPKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_ChinhSua.Enabled)
            {
                spkm = false;
                enableReviewSanPham(spkm);
            }
            try
            {
                int r = dgv_DanhSachSPKM.CurrentCell.RowIndex;
                int masp = Convert.ToInt32(dgv_DanhSachSPKM.Rows[r].Cells[0].Value);
                LoadInfo(masp);
            }
            catch
            {
                reLoad();
                MessageBox.Show("Vui lòng không chọn hàng này!");
            }
        }
        void LoadInfo(int masp)
        {
            try
            {
                SqlDataReader dataReader = dlKM.LayThongTinSanPhamDcKM(masp, MaKM);
                while(dataReader.Read())
                {
                    txt_MaSanPham.Text = dataReader.GetValue(0).ToString();
                    txt_TenSanPham.Text = dataReader.GetValue(1).ToString();
                    txt_GiaBan.Text = dataReader.GetValue(2).ToString();
                    date_BatDau.Value = Convert.ToDateTime(dataReader.GetValue(3).ToString());
                    date_KetThuc.Value = Convert.ToDateTime(dataReader.GetValue(4).ToString());
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!txt_MaSanPham.Text.Equals(""))
            {
                date_BatDau.Enabled = true;
                date_KetThuc.Enabled = true;

                btn_Luu.Enabled = true;
                btn_Huy.Enabled = true;

                btn_Them.Enabled = false;
                them = true;
            }
            else
            {

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dlKM = new BLKhuyenMai();
                bool kq = dlKM.XoaSanPhamKhuyenMai(MaKM, Convert.ToInt32(txt_MaSanPham.Text.Trim()), ref err);
                if (kq)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    reLoad();
                }
                else
                    MessageBox.Show("Xóa Không Thành Công!");
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            them = false;
            date_BatDau.Enabled = true;
            date_KetThuc.Enabled = true;

            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;

            btn_ChinhSua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(them)//them san pham khuyen mai
            {
                try
                {
                    dlKM = new BLKhuyenMai();
                    bool kq = dlKM.ThemSanPhamKhuyenMai(MaKM, Convert.ToInt32(txt_MaSanPham.Text.Trim()),
                        date_BatDau.Value.ToString("yyyy/MM/dd"), date_KetThuc.Value.ToString("yyyy/MM/dd"), ref err);
                    if (kq)
                    {
                        MessageBox.Show("Đã Thêm Thành Công!");
                        reLoad();
                    }
                    else
                        MessageBox.Show("Thêm Không Thành Công!");
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi!");
                }
            }
            else // chinh sua sp khuyen mai
            {
                try
                {
                    dlKM = new BLKhuyenMai();
                    bool kq = dlKM.ChinhSuaSanPhamKhuyenMai(MaKM, Convert.ToInt32(txt_MaSanPham.Text.Trim()),
                        date_BatDau.Value.ToString("yyyy/MM/dd"), date_KetThuc.Value.ToString("yyyy/MM/dd"), ref err);
                    if (kq)
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công!");
                        reLoad();
                    }
                    else
                        MessageBox.Show("Chỉnh Sửa Không Thành Công!");
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi!");
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            reLoad();
        }

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.TimKiemSanPhamTrongThemKM(MaKM, txt_TuKhoa.Text.Trim());
                dtKM = ds.Tables[0];
                dgv_DanhSachSP.DataSource = dtKM;
                dgv_DanhSachSP.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm. Lỗi rồi!!!");
            }
        }

        private void txt_TuKhoaSpDcKM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.TimKiemSanPhamKhuyenMai(MaKM, txt_TuKhoaSpDcKM.Text.Trim());
                dtKM = ds.Tables[0];
                dgv_DanhSachSPKM.DataSource = dtKM;
                dgv_DanhSachSPKM.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm. Lỗi rồi!!!");
            }
        }
    }
}
