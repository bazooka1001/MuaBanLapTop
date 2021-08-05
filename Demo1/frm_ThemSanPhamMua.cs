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
    public partial class frm_ThemSanPhamMua : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();

        private int MaDH;
        private bool spm = true;
        private bool them;
        private bool tinh = false;

        private int giaBan;
        private int giam;
        private int soLuong;
        private int soLuongNcc;
        private int thanhTien;
        public frm_ThemSanPhamMua(int id)
        {
            MaDH = id;
            InitializeComponent();
        }

        private void frm_ThemSanPhamMua_Load(object sender, EventArgs e)
        {
            lbl_MaDH.Text = MaDH.ToString();
            reLoad();
        }
        void enableReviewSanPham(bool a)
        {
            cmb_KhuyenMai.Enabled = false;
            cmb_NhaCungCap.Enabled = false;
            txt_SoLuong.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            tinh = false;
            txt_SoLuong.Value = 1;
            if(a) //xem thong tin san pham
            {
                btn_Them.Enabled = true;
                btn_ChinhSua.Enabled = false;
                btn_Xoa.Enabled = false;
                txt_SoLuong.Value = 1;
            }
            else //xem thong tin san pham duoc mua
            {
                btn_Them.Enabled = false;
                btn_ChinhSua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }
        void reLoad()
        {
            txt_MaSanPham.Enabled = false;
            txt_TenSanPham.Enabled = false;
            txt_Giam.Enabled = false;
            txt_GiaBan.Enabled = false;
            txt_ThanhTien.Enabled = false;
            tinh = false;

            cmb_KhuyenMai.Enabled = false;
            cmb_NhaCungCap.Enabled = false;
            txt_SoLuong.Enabled = false;

            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_ChinhSua.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            txt_MaSanPham.ResetText();
            txt_TenSanPham.ResetText();
            txt_Giam.ResetText();
            txt_GiaBan.ResetText();
            txt_ThanhTien.ResetText();
            txt_SoLuong.Value = 1;

            LoadDanhSachSPMua();
            LoadDanhSachSPChuaMua();
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
        void LoadDanhSachSPChuaMua()
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.DanhSachSanPhamMuaChuaMua(MaDH);
                dtDH = ds.Tables[0];
                dgv_DanhSachSanPham.DataSource = dtDH;
                dgv_DanhSachSanPham.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm mua. Lỗi rồi!!!");
            }
        }
        void LoadCMBncc()
        {
            try
            {
                txt_SoLuongTon.Text = "trangThai";
                dtDH = new DataTable();
                dtDH.Clear();
                DataSet ds = dlDH.LoadCMBncc(Convert.ToInt32(txt_MaSanPham.Text.Trim()));
                dtDH = ds.Tables[0];
                cmb_NhaCungCap.DataSource = dtDH;
                cmb_NhaCungCap.DisplayMember = "TenNcc";
                cmb_NhaCungCap.ValueMember = "MaNcc";
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }
        void tinhTien()
        {
            layThongSo();
            thanhTien = (giaBan - giam) * soLuong;
            txt_ThanhTien.Text = thanhTien.ToString();
        }
        void LoadCMBkm()
        {
            try
            {
                txt_Giam.ResetText();
                dtDH = new DataTable();
                dtDH.Clear();
                DataSet ds = dlDH.LoadCMBkm(Convert.ToInt32(txt_MaSanPham.Text.Trim()));
                dtDH = ds.Tables[0];
                cmb_KhuyenMai.DataSource = dtDH;
                cmb_KhuyenMai.DisplayMember = "TenKM";
                cmb_KhuyenMai.ValueMember = "MaKM";
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }
        void layThongSo()
        {
            giaBan = Convert.ToInt32(txt_GiaBan.Text.Trim());
            soLuong = Convert.ToInt32(txt_SoLuong.Value);
        }
        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_Them.Enabled)
            {
                spm = true;
                enableReviewSanPham(spm);
            }
            int r = dgv_DanhSachSanPham.CurrentCell.RowIndex;
            txt_MaSanPham.Text = dgv_DanhSachSanPham.Rows[r].Cells[0].Value.ToString();
            txt_TenSanPham.Text = dgv_DanhSachSanPham.Rows[r].Cells[1].Value.ToString();
            txt_GiaBan.Text = dgv_DanhSachSanPham.Rows[r].Cells[2].Value.ToString();
            LoadCMBkm();
            LoadCMBncc();
        }
        void LoadDataInfo(int MaSP)
        {
            try
            {
                SqlDataReader dataReader = dlDH.ThongTinChiTietSPMUa(MaDH, MaSP);
                while (dataReader.Read())
                {
                    txt_TenSanPham.Text = dataReader.GetValue(1).ToString();

                    txt_SoLuong.Text = dataReader.GetValue(3).ToString();
                    txt_ThanhTien.Text = dataReader.GetValue(4).ToString();

                    txt_km.Text = dataReader.GetValue(6).ToString();
                    //cmb_KhuyenMai.SelectedIndex = cmb_KhuyenMai.FindStringExact(a);
                    //txt_Giam.Text = dataReader.GetValue(7).ToString();
                    txt_GiaBan.Text = dataReader.GetValue(8).ToString();

                    txt_ncc.Text = dataReader.GetValue(10).ToString();
                    //cmb_NhaCungCap.SelectedIndex = cmb_NhaCungCap.FindStringExact(b);
                }
                
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi! Không thể lấy dữ liệu!");
            }
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            cmb_KhuyenMai.Enabled = true;
            cmb_NhaCungCap.Enabled = true;
            txt_SoLuong.Enabled = true;

            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;

            btn_Them.Enabled = false;
            them = true;
            tinh = true;
            tinhTien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dlDH = new BLDonHang();
                bool kq = dlDH.XoaSanPhamMua(MaDH, Convert.ToInt32(txt_MaSanPham.Text.Trim()), ref err);
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
                MessageBox.Show("Xảy ra lỗi! Xóa không thành công!");
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            cmb_KhuyenMai.Enabled = true;
            cmb_NhaCungCap.Enabled = true;
            txt_SoLuong.Enabled = true;

            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;

            btn_ChinhSua.Enabled = false;
            btn_Xoa.Enabled = false;
            them = false;
            tinh = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (them)//them san pham khuyen mai
            {
                try
                {
                    dlDH = new BLDonHang();
                    bool kq = dlDH.ThemSanPhamMua(Convert.ToInt32(txt_MaSanPham.Text.Trim()), MaDH, soLuong, thanhTien, 
                        Convert.ToInt32(cmb_KhuyenMai.SelectedValue), giaBan, Convert.ToInt32(cmb_NhaCungCap.SelectedValue), ref err);
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
                    MessageBox.Show("Xảy ra lỗi! Thêm sản phẩm không thành công!");
                }
            }
            else // chinh sua sp khuyen mai
            {
                try
                {
                    dlDH = new BLDonHang();
                    bool kq = dlDH.ChinhSuaSanPhamMua(Convert.ToInt32(txt_MaSanPham.Text.Trim()), MaDH, soLuong, thanhTien,
                        Convert.ToInt32(cmb_KhuyenMai.SelectedValue), giaBan, Convert.ToInt32(cmb_NhaCungCap.SelectedValue), ref err);
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
                    MessageBox.Show("Xảy ra lỗi!4444");
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            reLoad();
        }

        private void txt_TuKhoaSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.TimKiemSPChuaMua(MaDH, txt_TuKhoaSanPham.Text.Trim());
                dtDH = ds.Tables[0];
                dgv_DanhSachSanPham.DataSource = dtDH;
                dgv_DanhSachSanPham.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm. Lỗi rồi!!!");
            }
        }

        private void txt_TuKhoaSpDcMua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.TimKiemSPMua(MaDH, txt_TuKhoaSpDcMua.Text.Trim());
                dtDH = ds.Tables[0];
                dgv_DanhSachSPMua.DataSource = dtDH;
                dgv_DanhSachSPMua.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm. Lỗi rồi!!!");
            }
        }

        private void cmb_NhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_SoLuongTon.Text = "trangThai";
                soLuongNcc = dlDH.LaySoLuongTuNcc(Convert.ToInt32(cmb_NhaCungCap.SelectedValue), Convert.ToInt32(txt_MaSanPham.Text.Trim()), ref err);
                txt_SoLuongTon.Text = "Còn " + soLuongNcc.ToString();
            }
            catch { }
        }

        private void cmb_KhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Giam.ResetText();
                giam = dlDH.LaySoTienGiamKM(Convert.ToInt32(cmb_KhuyenMai.SelectedValue), ref err);
                txt_Giam.Text = giam.ToString();
                if (tinh)
                    tinhTien();
            }
            catch { }
        }

        private void txt_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if(tinh)
            {
                if (txt_SoLuong.Value >= soLuongNcc)
                    MessageBox.Show("Đã hết hàng!");
                else
                    tinhTien();
            }
        }
    }
}
