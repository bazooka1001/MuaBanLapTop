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
    public partial class User_SanPham : UserControl
    {
        DataTable dtSanpham = null;
        string err;
        bool add;
        Sanpham dbSp = new Sanpham();

        private static User_SanPham _instance;
        public static User_SanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_SanPham();
                return _instance;
            }
        }
        public User_SanPham()
        {
            InitializeComponent();
        }
        void LoadDataSP()
        {
            try
            {
                dtSanpham = new DataTable();
                dtSanpham.Clear();

                DataSet ds = dbSp.LaySanPham();
                dtSanpham = ds.Tables[0];

                dgv_Sanpham.DataSource = dtSanpham;
                dgv_Sanpham.AutoResizeColumns();

                dgv_Sanpham.Columns[0].HeaderText = "Mã sản phẩm";
                dgv_Sanpham.Columns[1].HeaderText = "Tên sản phẩm";
                dgv_Sanpham.Columns[2].HeaderText = "NSX";
                dgv_Sanpham.Columns[3].HeaderText = "Bảo hành";
                dgv_Sanpham.Columns[4].HeaderText = "Số lượng";
                dgv_Sanpham.Columns[5].HeaderText = "Thông số kỹ thuật";
                dgv_Sanpham.Columns[6].HeaderText = "Giá bán";
                dgv_Sanpham.Columns[7].HeaderText = "Trạng thái";

                dgv_Sanpham.Columns[0].Width = 100;
                dgv_Sanpham.Columns[1].Width = 100;
                dgv_Sanpham.Columns[2].Width = 100;
                dgv_Sanpham.Columns[3].Width = 100;
                dgv_Sanpham.Columns[4].Width = 100;
                dgv_Sanpham.Columns[5].Width = 100;
                dgv_Sanpham.Columns[6].Width = 100;
                dgv_Sanpham.Columns[7].Width = 100;

                dgv_Sanpham.AllowUserToAddRows = false;
                dgv_Sanpham.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.txt_MaSp.ResetText();
                this.txt_TenSp.ResetText();
                this.txt_BaoHanh.ResetText();
                this.txt_DonGia.ResetText();
                this.txt_sl.ResetText();
                this.txt_TSKT.ResetText();
                this.cmb_HangSp.ResetText();

                this.btn_chitietsp.Enabled = false;
                this.btn_SuaSp.Enabled = false;
                this.btn_LuuSp.Enabled = false;
                this.btn_XoaSp.Enabled = false;

                this.btn_Huy.Enabled = true;
                this.btn_ThemSp.Enabled = true;

                this.txt_MaSp.Enabled = false;
                this.txt_TenSp.Enabled = false;
                this.cmb_HangSp.Enabled = false;
                this.txt_BaoHanh.Enabled = false;
                this.txt_sl.Enabled = false;
                this.txt_DonGia.Enabled = false;
                this.txt_TSKT.Enabled = false;
                this.cb_Trangthai.Enabled = false;

                Nsx ns = new Nsx();
                cmb_HangSp.DataSource = ns.LayNsx().Tables[0].DefaultView;
                cmb_HangSp.DisplayMember = "TenNSX";
                cmb_HangSp.ValueMember = "MaNSX";

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được thông tin Sản phẩm. Lỗi!!!");
            }

        }
        bool kiemtra()
        {
            bool kq = true;
            if (txt_TenSp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenSp.Focus();
                kq = false;

            }

            else if (txt_BaoHanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thời hạn bảo hành!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_BaoHanh.Focus();
                kq = false;
            }
            else if (txt_sl.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sl.Focus();
                kq = false;
            }
            else if (txt_TSKT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thông số thống kê!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TSKT.Focus();
                kq = false;
            }
            return kq;
        }
        private void User_SanPham_Load(object sender, EventArgs e)
        {
            LoadDataSP();
        }

        private void dgv_Sanpham_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn_chitietsp.Enabled = true;
            this.btn_SuaSp.Enabled = true;
            this.btn_XoaSp.Enabled = true;
            this.btn_LuuSp.Enabled = false;

            this.txt_MaSp.Enabled = false;
            this.txt_TenSp.Enabled = false;
            this.cmb_HangSp.Enabled = false;
            this.txt_BaoHanh.Enabled = false;
            this.txt_sl.Enabled = false;
            this.txt_DonGia.Enabled = false;
            this.txt_TSKT.Enabled = false;
            this.cb_Trangthai.Enabled = false;

            int r = dgv_Sanpham.CurrentCell.RowIndex;
            this.txt_MaSp.Text =
                dgv_Sanpham.Rows[r].Cells[0].Value.ToString();
            this.txt_TenSp.Text =
                dgv_Sanpham.Rows[r].Cells[1].Value.ToString();
            this.cmb_HangSp.Text =
                dgv_Sanpham.Rows[r].Cells[2].Value.ToString();
            this.txt_BaoHanh.Text =
                dgv_Sanpham.Rows[r].Cells[3].Value.ToString();
            this.txt_sl.Text =
                dgv_Sanpham.Rows[r].Cells[4].Value.ToString();
            this.txt_TSKT.Text =
                dgv_Sanpham.Rows[r].Cells[5].Value.ToString();
            this.txt_DonGia.Text =
                dgv_Sanpham.Rows[r].Cells[6].Value.ToString();
            if (dgv_Sanpham.Rows[r].Cells[7].Value == null || (bool)dgv_Sanpham.Rows[r].Cells[7].Value)
                this.cb_Trangthai.Checked = true;
            else
                this.cb_Trangthai.Checked = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadDataSP();
        }

        private void btn_ThemSp_Click(object sender, EventArgs e)
        {
            add = true;
            this.txt_MaSp.Text = (dbSp.LayMaSp() + 1).ToString();
            this.cb_Trangthai.Checked = true;
            this.txt_MaSp.Enabled = false;
            this.btn_chitietsp.Enabled = false;
            this.btn_ThemSp.Enabled = false;
            this.btn_SuaSp.Enabled = false;
            this.btn_XoaSp.Enabled = false;
            this.cb_Trangthai.Enabled = false;

            this.btn_LuuSp.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_TenSp.Focus();
            this.txt_TenSp.ResetText();
            this.txt_DonGia.ResetText();
            this.txt_BaoHanh.ResetText();
            this.txt_sl.ResetText();
            this.txt_TSKT.ResetText();

            this.txt_TenSp.Enabled = true;
            this.cmb_HangSp.Enabled = true;
            this.txt_BaoHanh.Enabled = true;
            this.txt_sl.Enabled = true;
            this.txt_DonGia.Enabled = true;
            this.txt_TSKT.Enabled = true;
            this.txt_TimSp.Enabled = false;
        }

        private void btn_SuaSp_Click(object sender, EventArgs e)
        {
            add = false;
            this.txt_MaSp.Enabled = false;
            this.btn_chitietsp.Enabled = false;
            this.btn_ThemSp.Enabled = false;
            this.btn_SuaSp.Enabled = false;
            this.btn_XoaSp.Enabled = false;

            this.btn_LuuSp.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_MaSp.Enabled = false;
            this.txt_TenSp.Enabled = true;
            this.cmb_HangSp.Enabled = true;
            this.txt_BaoHanh.Enabled = true;
            this.txt_sl.Enabled = true;
            this.txt_DonGia.Enabled = true;
            this.txt_TSKT.Enabled = true;
            this.cb_Trangthai.Enabled = true;
            this.txt_TimSp.Enabled = false;

            this.txt_TenSp.Focus();
        }

        private void btn_XoaSp_Click(object sender, EventArgs e)
        {
            add = false;
            Sanpham dbsanpham = new Sanpham();
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc ngừng bán sản phẩm này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                bool kq = dbsanpham.XoaSp(Convert.ToInt32(txt_MaSp.Text.Trim()), txt_TenSp.Text.Trim(), Convert.ToInt32(cmb_HangSp.SelectedValue)
    , txt_BaoHanh.Text.Trim(), Convert.ToInt32(txt_sl.Text.Trim()), txt_TSKT.Text.Trim(), Convert.ToInt32(txt_DonGia.Text.Trim()), cb_Trangthai.Checked, ref err);
                if (kq)
                    //Thong bao thanh cong
                    MessageBox.Show("Đã xong!");
                else
                    //Khong thanh cong
                    MessageBox.Show("Không được!!");
            }
            else
            {
                MessageBox.Show("Không thực hiện!!");
            }

            LoadDataSP();
        }

        private void btn_LuuSp_Click(object sender, EventArgs e)
        {
            //string sql;
            if (kiemtra())
            {
                if (add)
                {
                    try
                    {
                        Sanpham dbsanpham = new Sanpham();
                        bool kq = dbsanpham.ThemSp(Convert.ToInt32(txt_MaSp.Text.Trim()), txt_TenSp.Text.Trim(), Convert.ToInt32(cmb_HangSp.SelectedValue)
                            , txt_BaoHanh.Text.Trim(), Convert.ToInt32(txt_sl.Text.Trim()), txt_TSKT.Text.Trim(), Convert.ToInt32(txt_DonGia.Text.Trim()), cb_Trangthai.Checked, ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadDataSP();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi!");
                    }
                }
                else //sửa
                {
                    try
                    {
                        Sanpham dbsanpham = new Sanpham();
                        int r = dgv_Sanpham.CurrentCell.RowIndex;
                        Sanpham sanpham = new Sanpham();
                        bool sua = dbsanpham.UpdateSp(Convert.ToInt32(txt_MaSp.Text.Trim()), txt_TenSp.Text.Trim(), Convert.ToInt32(cmb_HangSp.SelectedValue)
                            , txt_BaoHanh.Text.Trim(), Convert.ToInt32(txt_sl.Text.Trim()), txt_TSKT.Text.Trim(), Convert.ToInt32(txt_DonGia.Text.Trim()), cb_Trangthai.Checked, ref err);
                        if (sua)
                            MessageBox.Show("Đã sửa xong!");
                        else
                            MessageBox.Show("Không sửa được!");
                        LoadDataSP();
                        //MessageBox.Show("Đã sửa xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi rồi!");
                    }
                }
            }
        }

        private void btn_ThemNSX_Click(object sender, EventArgs e)
        {
            Nhasanxuat nhasanxuat = new Nhasanxuat();
            nhasanxuat.Show();
        }

        private void txt_TimSp_TextChanged(object sender, EventArgs e)
        {
            dtSanpham = new DataTable();
            dtSanpham.Clear();

            DataSet ds = dbSp.timSP(txt_TimSp.Text.Trim());
            dtSanpham = ds.Tables[0];
            dgv_Sanpham.DataSource = dtSanpham;
            dgv_Sanpham.AutoResizeColumns();
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_chitietsp_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MaSp.Text);
            ChitietSP Sp = new ChitietSP(id);
            Sp.Show();
        }
    }
}
