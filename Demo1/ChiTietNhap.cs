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
    public partial class ChitietNhap : Form
    {
        DataTable dtChitietNhap = null;
        public string soHD { get; set; }
        string err;
        bool add;
        private int MaHD;
        chitietnhap CTNhap = new chitietnhap();
        public ChitietNhap(int id)
        {
            MaHD = id;
            InitializeComponent();
        }
        void LoadCTNhap()
        {
            try
            {
                dtChitietNhap = new DataTable();
                dtChitietNhap.Clear();

                DataSet ds = CTNhap.LayChitietNhap(MaHD);
                dtChitietNhap = ds.Tables[0];

                dgv_CTN.DataSource = dtChitietNhap;
                dgv_CTN.AutoResizeColumns();
                dgv_CTN.AllowUserToAddRows = false;
                dgv_CTN.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.panel1.Enabled = false;

                this.btn_Sua.Enabled = false;
                this.btn_Xoa.Enabled = false;
                this.btn_Luu.Enabled = false;
                this.btn_Them.Enabled = true;
                this.btn_Huy.Enabled = true;


                cmb_MaSp.DataSource = CTNhap.LayMaSp().Tables[0].DefaultView;
                cmb_MaSp.DisplayMember = "TenSp";
                cmb_MaSp.ValueMember = "MaSP";

                cmb_MaNcc.DataSource = CTNhap.LayMaNcc().Tables[0].DefaultView;
                cmb_MaNcc.DisplayMember = "TenNcc";
                cmb_MaNcc.ValueMember = "MaNcc";

                this.txt_SoHD.ResetText();
                this.cmb_MaSp.ResetText();
                this.cmb_MaNcc.ResetText();
                this.txt_SLNhap.ResetText();
                this.txt_Thanhtien.ResetText();
                this.txt_Giagoc.ResetText();
                this.txt_Ghichu.ResetText();

                dgv_CTN.Columns[0].HeaderText = "Tên sản phẩm";
                dgv_CTN.Columns[1].HeaderText = "Số hóa đơn";
                dgv_CTN.Columns[2].HeaderText = "Số lượng nhập";
                dgv_CTN.Columns[3].HeaderText = "Giá gốc";
                dgv_CTN.Columns[4].HeaderText = "Thành tiền";
                dgv_CTN.Columns[5].HeaderText = "Tên Nhà cung cấp";
                dgv_CTN.Columns[6].HeaderText = "Ghi chú";

                //DataSet data = CTNhap.TruyenSoHD(soHD);
                //dgv_CTN.DataSource = data.Tables[0].DefaultView;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được thông tin Chi tiết nhập. Lỗi rồi!!");
            }
        }
        bool Kiemtra()
        {
            bool kq = true;
            if (txt_SLNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SLNhap.Focus();
                kq = false;

            }
            else if (txt_Giagoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập giá gốc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Giagoc.Focus();
                kq = false;

            }
            else if (txt_Thanhtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thành tiền!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Thanhtien.Focus();
                kq = false;

            }
            else if (cmb_MaSp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_MaSp.Focus();
                kq = false;

            }
            else if (cmb_MaNcc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_MaNcc.Focus();
                kq = false;

            }
            return kq;
        }

        private void ChiTietNhap_Load(object sender, EventArgs e)
        {
            LoadCTNhap();
            //DataSet data = CTNhap.TruyenSoHD(soHD);
            //dgv_CTN.DataSource = data.Tables[0].DefaultView;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            add = true;
            this.btn_Sua.Enabled = false;
            this.btn_Them.Enabled = false;
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.btn_Xoa.Enabled = false;

            chitietnhap CTNhap = new chitietnhap();
            this.panel1.Enabled = true;
            //HDNhap hd = new HDNhap();
            //DataSet data = CTNhap.TruyenSoHD(soHD);
            this.txt_SoHD.Text = MaHD.ToString();
            this.txt_SoHD.Enabled = false;
            this.cmb_MaSp.Enabled = true;
            this.cmb_MaNcc.Enabled = true;
            this.txt_Giagoc.Enabled = true;
            this.txt_Thanhtien.Enabled =false;
            this.txt_SLNhap.Enabled = true;
            this.txt_Ghichu.Enabled = true;
            this.txt_Thanhtien.Text = CTNhap.thanhtien(Convert.ToInt32(txt_Giagoc.Text), Convert.ToInt32(txt_SLNhap.Text.Trim()));

            this.txt_SLNhap.ResetText();
            this.txt_Giagoc.ResetText();
            this.txt_Thanhtien.ResetText();
            this.txt_Ghichu.ResetText();
        }

        private void txt_Giagoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Thanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_SLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            add = false;
            this.btn_Sua.Enabled = false;
            this.btn_Them.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;

            HDNhap hd = new HDNhap();
            this.txt_SoHD.Text = hd.LaySoHD().ToString();
            this.txt_SoHD.Enabled = false;
            this.cmb_MaSp.Enabled = true;
            this.cmb_MaNcc.Enabled = true;
            this.txt_Giagoc.Enabled = true;
            this.txt_Thanhtien.Enabled = true;
            this.txt_SLNhap.Enabled = true;
            this.txt_Ghichu.Enabled = true;
        }

        private void dgv_CTN_MouseClick(object sender, MouseEventArgs e)
        {
            this.panel1.Enabled = true;
            this.txt_SoHD.Enabled = false;
            this.cmb_MaSp.Enabled = true;
            this.cmb_MaNcc.Enabled = true;
            this.txt_Giagoc.Enabled = true;
            this.txt_Thanhtien.Enabled = true;
            this.txt_SLNhap.Enabled = true;
            this.txt_Ghichu.Enabled = true;

            this.btn_Them.Enabled = true;
            this.btn_Xoa.Enabled = true;
            this.btn_Sua.Enabled = true;
            this.btn_Huy.Enabled = true;

            int r = dgv_CTN.CurrentCell.RowIndex;
            this.cmb_MaSp.Text =
                dgv_CTN.Rows[r].Cells[0].Value.ToString();
            this.txt_SoHD.Text =
                dgv_CTN.Rows[r].Cells[1].Value.ToString();
            this.txt_SLNhap.Text =
                dgv_CTN.Rows[r].Cells[2].Value.ToString();
            this.txt_Giagoc.Text =
                dgv_CTN.Rows[r].Cells[3].Value.ToString();
            this.txt_Thanhtien.Text =
                dgv_CTN.Rows[r].Cells[4].Value.ToString();
            this.cmb_MaNcc.Text =
                dgv_CTN.Rows[r].Cells[5].Value.ToString();
            this.txt_Ghichu.Text =
                dgv_CTN.Rows[r].Cells[6].Value.ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                if (add)
                {
                    try
                    {
                        chitietnhap dbChitietnhap = new chitietnhap();
                        bool kq = dbChitietnhap.ThemCTN(Convert.ToInt32(cmb_MaSp.SelectedValue), Convert.ToInt32(txt_SoHD.Text.Trim()), Convert.ToInt32(txt_SLNhap.Text.Trim()), Convert.ToInt32(txt_Giagoc.Text.Trim()), Convert.ToInt32(txt_Thanhtien.Text.Trim()), Convert.ToInt32(cmb_MaNcc.SelectedValue), txt_Ghichu.Text.Trim(), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadCTNhap();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi!!");
                    }
                }
                else
                {
                    try
                    {
                        chitietnhap dbChitietnhap = new chitietnhap();
                        bool kq = dbChitietnhap.SuaCTN(Convert.ToInt32(cmb_MaSp.SelectedValue), Convert.ToInt32(txt_SoHD.Text.Trim()), Convert.ToInt32(txt_SLNhap.Text.Trim()), Convert.ToInt32(txt_Giagoc.Text.Trim()), Convert.ToInt32(txt_Thanhtien.Text.Trim()), Convert.ToInt32(cmb_MaNcc.SelectedValue), txt_Ghichu.Text.Trim(), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã sửa xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không sửa được!!");
                        LoadCTNhap();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi!!");
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            add = false;
            chitietnhap dbchitietnhap = new chitietnhap();
            DialogResult traloi;
            traloi = MessageBox.Show("Có chắc xóa chi tiết này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                bool kq = dbchitietnhap.XoaCTN(Convert.ToInt32(cmb_MaSp.SelectedValue), Convert.ToInt32(txt_SoHD.Text.Trim()), ref err);
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
            LoadCTNhap();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }
    }
}
