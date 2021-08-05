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
    public partial class User_Boss : UserControl
    {
        DataTable dtNhanvien = null;
        string err;
        bool add;
        Boss DbBoss = new Boss();

        private static User_Boss _instance;
        public static User_Boss Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_Boss();
                return _instance;
            }
        }
        public User_Boss()
        {
            InitializeComponent();
        }
        void LoadDataNv()
        {
            try
            {
                dtNhanvien = new DataTable();
                dtNhanvien.Clear();

                DataSet ds = DbBoss.LayNhanvien();
                dtNhanvien = ds.Tables[0];

                dgv_Nhanvien.DataSource = dtNhanvien;
                dgv_Nhanvien.AutoResizeColumns();

                dgv_Nhanvien.AllowUserToAddRows = false;
                dgv_Nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.txt_MaNv.ResetText();
                this.txt_TenNv.ResetText();
                this.dtp_Ngaysinh.ResetText();
                //this.rdb_Nam.ResetText();
                //this.rdb_Nu.ResetText();
                this.txt_DiaChi.ResetText();
                this.txt_Sdt.ResetText();
                this.txt_Pass.ResetText();
                //this.cb_Trangthai.ResetText();

                this.btn_ThemNv.Enabled = true;
                this.btn_SuaNv.Enabled = false;
                this.btn_XoaNv.Enabled = false;
                this.btn_Huy.Enabled = false;

                this.txt_MaNv.Enabled = false;
                this.txt_TenNv.Enabled = false;
                this.dtp_Ngaysinh.Enabled = false;
                this.rdb_Nam.Enabled = false;
                this.rdb_Nu.Enabled = false;
                this.txt_DiaChi.Enabled = false;
                this.txt_Sdt.Enabled = false;
                this.txt_Pass.Enabled = false;
                this.cb_Trangthai.Enabled = false;

                dgv_Nhanvien.Columns[0].HeaderText = "Mã nhân viên";
                dgv_Nhanvien.Columns[1].HeaderText = "Tên nhân viên";
                dgv_Nhanvien.Columns[2].HeaderText = "Giới tính";
                dgv_Nhanvien.Columns[3].HeaderText = "Ngày sinh";
                dgv_Nhanvien.Columns[4].HeaderText = "Địa chỉ";
                dgv_Nhanvien.Columns[5].HeaderText = "Số điện thoại";
                dgv_Nhanvien.Columns[6].HeaderText = "Vị trí";
                dgv_Nhanvien.Columns[7].HeaderText = "Password";
                dgv_Nhanvien.Columns[8].HeaderText = "Trạng thái";


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được thông tin Nhân viên. Lỗi!!!");
            }
        }
        bool Kiemtra()
        {
            bool kq = true;
            if (txt_TenNv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà Nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNv.Focus();
                kq = false;

            }

            else if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thời hạn địa chỉ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                kq = false;
            }
            else if (txt_Sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Sdt.Focus();
                kq = false;
            }
            else if (txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập Mail!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Pass.Focus();
                kq = false;
            }
            return kq;
        }
        private void User_Boss_Load(object sender, EventArgs e)
        {
            LoadDataNv();
        }

        private void btn_ThemNv_Click(object sender, EventArgs e)
        {
            add = true;
            this.btn_SuaNv.Enabled = false;
            this.btn_ThemNv.Enabled = false;
            this.btn_XoaNv.Enabled = false;
            this.btn_LuuNv.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_MaNv.Enabled = false;
            this.txt_TenNv.Enabled = true;
            this.txt_DiaChi.Enabled = true;
            this.txt_Sdt.Enabled = true;
            this.txt_Pass.Enabled = true;
            this.dtp_Ngaysinh.Enabled = true;
            this.rdb_Nam.Enabled = true;
            this.rdb_Nu.Enabled = true;
            this.cb_Trangthai.Enabled = false;
            this.cb_Trangthai.Checked = true;

            this.txt_MaNv.ResetText();
            this.txt_TenNv.ResetText();
            this.dtp_Ngaysinh.ResetText();
            //this.rdb_Nam.ResetText();
            //this.rdb_Nu.ResetText();
            this.txt_DiaChi.ResetText();
            this.txt_Sdt.ResetText();
            this.txt_Pass.ResetText();
            //this.cb_Trangthai.ResetText();
            this.txt_TenNv.Focus();

            this.txt_MaNv.Text = (DbBoss.LayMaNv() + 1).ToString();
            if (this.rdb_Nu.Checked == true)
            {
                rdb_Nam.Checked = false;
            }
            else rdb_Nam.Checked = true;

        }

        private void btn_SuaNv_Click(object sender, EventArgs e)
        {
            add = false;
            this.btn_SuaNv.Enabled = false;
            this.btn_ThemNv.Enabled = false;
            this.btn_XoaNv.Enabled = false;
            this.btn_LuuNv.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_MaNv.Enabled = false;
            this.txt_TenNv.Enabled = true;
            this.txt_DiaChi.Enabled = true;
            this.txt_Sdt.Enabled = true;
            this.txt_Pass.Enabled = true;
            this.dtp_Ngaysinh.Enabled = true;
            this.rdb_Nam.Enabled = true;
            this.rdb_Nu.Enabled = true;
            this.cb_Trangthai.Enabled = true;

            this.txt_TenNv.Focus();
        }

        private void btn_XoaNv_Click(object sender, EventArgs e)
        {
            add = false;
            Boss boss = new Boss();
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa nhân viên này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                bool kq = boss.XoaNv(Convert.ToInt32(txt_MaNv.Text.Trim()), cb_Trangthai.Checked, ref err);
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

            LoadDataNv();
        }

        private void btn_LuuNv_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                if (add)
                {
                    try
                    {
                        Boss boss = new Boss();
                        bool kq = DbBoss.ThemNv(Convert.ToInt32(txt_MaNv.Text.Trim()), txt_TenNv.Text.Trim(), rdb_Nam.Checked, dtp_Ngaysinh.Value.ToString("yyyy/MM/dd"),
                                                txt_DiaChi.Text.Trim(), txt_Sdt.Text.Trim(), "0", txt_Pass.Text.Trim(), cb_Trangthai.Checked, ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadDataNv();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi rồi!");
                    }
                }
                else
                {
                    try
                    {
                        Boss boss = new Boss();
                        bool kq = DbBoss.SuaNv(Convert.ToInt32(txt_MaNv.Text.Trim()), txt_TenNv.Text.Trim(), rdb_Nam.Checked, dtp_Ngaysinh.Value.ToString("yyyy/MM/dd"),
                                                txt_DiaChi.Text.Trim(), txt_Sdt.Text.Trim(), txt_Pass.Text.Trim(), cb_Trangthai.Checked, ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã Sửa xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không sửa được!!");
                        LoadDataNv();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi rồi!!");
                    }
                }

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadDataNv();
        }

        private void txt_TimNv_TextChanged(object sender, EventArgs e)
        {
            dtNhanvien = new DataTable();
            dtNhanvien.Clear();

            DataSet ds = DbBoss.TimNv(txt_TimNv.Text.Trim());
            dtNhanvien = ds.Tables[0];
            dgv_Nhanvien.DataSource = dtNhanvien;
            dgv_Nhanvien.AutoResizeColumns();
        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Nhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn_ThemNv.Enabled = true;
            this.btn_SuaNv.Enabled = true;
            this.btn_XoaNv.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_MaNv.Enabled = false;
            this.txt_TenNv.Enabled = false;
            this.dtp_Ngaysinh.Enabled = false;
            this.rdb_Nam.Enabled = false;
            this.rdb_Nu.Enabled = false;
            this.txt_DiaChi.Enabled = false;
            this.txt_Sdt.Enabled = false;
            this.txt_Pass.Enabled = false;
            this.cb_Trangthai.Enabled = false;

            int r = dgv_Nhanvien.CurrentCell.RowIndex;
            this.txt_MaNv.Text =
            dgv_Nhanvien.Rows[r].Cells[0].Value.ToString();
            this.txt_TenNv.Text =
                dgv_Nhanvien.Rows[r].Cells[1].Value.ToString();
            if (dgv_Nhanvien.Rows[r].Cells[2].Value == null || (bool)dgv_Nhanvien.Rows[r].Cells[2].Value)
            {
                this.rdb_Nam.Checked = true;
                this.rdb_Nu.Checked = false;
            }
            else
            {
                this.rdb_Nam.Checked = false;
                this.rdb_Nu.Checked = true;
            }
            this.dtp_Ngaysinh.Text =
                dgv_Nhanvien.Rows[r].Cells[3].Value.ToString();
            this.txt_DiaChi.Text =
                dgv_Nhanvien.Rows[r].Cells[4].Value.ToString();
            this.txt_Sdt.Text =
                dgv_Nhanvien.Rows[r].Cells[5].Value.ToString();
            this.txt_Pass.Text =
                dgv_Nhanvien.Rows[r].Cells[7].Value.ToString();
            if (dgv_Nhanvien.Rows[r].Cells[8].Value == null || (bool)dgv_Nhanvien.Rows[r].Cells[8].Value)
                this.cb_Trangthai.Checked = true;
            else
                this.cb_Trangthai.Checked = false;
        }
    }
}
