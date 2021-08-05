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
    public partial class User_HoaDonNhap : UserControl
    {
        DataTable dtHDN = null;
        string err;
        bool add;
        HDNhap dbHDN = new HDNhap();

        private static User_HoaDonNhap _instance;
        public static User_HoaDonNhap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_HoaDonNhap();
                return _instance;
            }
        }
        public User_HoaDonNhap()
        {
            InitializeComponent();
        }
        void LoadHDN()
        {
            try
            {
                dtHDN = new DataTable();
                dtHDN.Clear();

                DataSet ds = dbHDN.LayHDN();
                dtHDN = ds.Tables[0];

                dgv_HDNhap.DataSource = dtHDN;
                dgv_HDNhap.AutoResizeColumns();
                dgv_HDNhap.AllowUserToAddRows = false;
                dgv_HDNhap.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.panel1.Enabled = false;

                this.btn_CTN.Enabled = false;
                this.btn_SuaDH.Enabled = false;
                this.txt_SoHD.ResetText();
                this.cmb_NV.ResetText();
                this.txt_Thanhtien.ResetText();
                this.dtt_NgayNhap.ResetText();
                dgv_HDNhap.Columns[0].HeaderText = "Số hóa đơn";
                dgv_HDNhap.Columns[1].HeaderText = "Ngày nhập";
                dgv_HDNhap.Columns[2].HeaderText = "Tên nhân viên";
                dgv_HDNhap.Columns[3].HeaderText = "Tổng tiền nhập";

                cmb_NV.DataSource = dbHDN.LayNV().Tables[0].DefaultView;
                cmb_NV.DisplayMember = "TenNV";
                cmb_NV.ValueMember = "MaNV";




            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được thông tin Hóa đơn nhập. Lỗi!!!");
            }
        }
        bool Kiemtra()
        {
            bool kq = true;
            if (cmb_NV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên Nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_NV.Focus();
                kq = false;

            }

            else if (dtt_NgayNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thời hạn nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtt_NgayNhap.Focus();
                kq = false;
            }
            else if (txt_Thanhtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập Thành tiền!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Thanhtien.Focus();
                kq = false;
            }

            return kq;
        }

        private void User_HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadHDN();
        }

        private void dgv_HDNhap_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn_CTN.Enabled = true;
            this.btn_ThemHD.Enabled = true;
            this.btn_SuaDH.Enabled = true;
            this.btn_Huy.Enabled = true;
            this.btn_LuuDH.Enabled = false;

            this.panel1.Enabled = false;
            this.txt_SoHD.Enabled = false;

            int r = dgv_HDNhap.CurrentCell.RowIndex;
            this.txt_SoHD.Text = dgv_HDNhap.Rows[r].Cells[0].Value.ToString();
            this.cmb_NV.Text = dgv_HDNhap.Rows[r].Cells[2].Value.ToString();
            this.dtt_NgayNhap.Text = dgv_HDNhap.Rows[r].Cells[1].Value.ToString();
            this.txt_Thanhtien.Text = dgv_HDNhap.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_CTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_SoHD.Text);
            ChitietNhap CTN = new ChitietNhap(id);
            //CTN.soHD = txt_SoHD.Text;
            CTN.Show();
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            add = true;
            this.btn_SuaDH.Enabled = false;
            this.btn_CTN.Enabled = false;
            this.btn_ThemHD.Enabled = false;
            this.btn_LuuDH.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.panel1.Enabled = true;
            this.txt_SoHD.Text = (dbHDN.LaySoHD() + 1).ToString();
            this.txt_SoHD.Enabled = false;
            this.cmb_NV.Enabled = true;
            this.txt_Thanhtien.Enabled = true;
            this.dtt_NgayNhap.Enabled = true;
            this.dtt_NgayNhap.ResetText();
            this.txt_Thanhtien.ResetText();
            this.cmb_NV.Focus();
        }

        private void btn_SuaDH_Click(object sender, EventArgs e)
        {
            add = false;
            this.btn_SuaDH.Enabled = false;
            this.btn_ThemHD.Enabled = false;
            this.btn_CTN.Enabled = false;
            this.btn_LuuDH.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_SoHD.Enabled = false;
            this.cmb_NV.Enabled = true;
            this.txt_Thanhtien.Enabled = true;
            this.dtt_NgayNhap.Enabled = true;
            this.cmb_NV.Focus();
        }

        private void btn_LuuDH_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                if (add)
                {
                    try
                    {
                        HDNhap dbHDN = new HDNhap();
                        bool kq = dbHDN.ThemHDN(Convert.ToInt32(txt_SoHD.Text.Trim()), dtt_NgayNhap.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(cmb_NV.SelectedValue),
                            Convert.ToInt32(txt_Thanhtien.Text.Trim()), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadHDN();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error!!");
                    }
                }
                else
                {
                    try
                    {
                        HDNhap dbHDN = new HDNhap();
                        bool kq = dbHDN.SuaHDN(Convert.ToInt32(txt_SoHD.Text.Trim()), dtt_NgayNhap.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(cmb_NV.SelectedValue),
                            Convert.ToInt32(txt_Thanhtien.Text.Trim()), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã sửa xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không sửa được!!");
                        LoadHDN();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error!!");
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadHDN();
        }

        private void txt_TimSp_TextChanged(object sender, EventArgs e)
        {
            dtHDN = new DataTable();
            dtHDN.Clear();

            DataSet ds = dbHDN.TimHDN(txt_TimSp.Text.Trim());
            dtHDN = ds.Tables[0];
            dgv_HDNhap.DataSource = dtHDN;
            dgv_HDNhap.AutoResizeColumns();
        }

        private void txt_Thanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Thanhtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
