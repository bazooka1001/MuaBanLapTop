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
    public partial class User_NhaCungCap : UserControl
    {
        DataTable dtNcc = null;
        string err;
        bool add;
        Ncc dbNcc = new Ncc();

        private static User_NhaCungCap _instance;
        public static User_NhaCungCap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_NhaCungCap();
                return _instance;
            }
        }

        public User_NhaCungCap()
        {
            InitializeComponent();
        }
        void LoadDataNcc()
        {
            try
            {
                dtNcc = new DataTable();
                dtNcc.Clear();

                DataSet ds = dbNcc.LayNcc();
                dtNcc = ds.Tables[0];
                dgv_Ncc.DataSource = dtNcc;
                dgv_Ncc.AutoResizeColumns();

                dgv_Ncc.Columns[0].HeaderText = "Mã Ncc";
                dgv_Ncc.Columns[1].HeaderText = "Tên Ncc";
                dgv_Ncc.Columns[2].HeaderText = "Địa chỉ ";
                dgv_Ncc.Columns[3].HeaderText = "Sđt ";
                dgv_Ncc.Columns[4].HeaderText = "Mail ";
                dgv_Ncc.Columns[5].HeaderText = "Trạng thái";

                dgv_Ncc.Columns[0].Width = 100;
                dgv_Ncc.Columns[1].Width = 100;
                dgv_Ncc.Columns[2].Width = 100;
                dgv_Ncc.Columns[3].Width = 100;
                dgv_Ncc.Columns[4].Width = 100;
                dgv_Ncc.Columns[5].Width = 100;


                dgv_Ncc.AllowUserToAddRows = false;
                dgv_Ncc.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.txt_MaNcc.ResetText();
                this.txt_TenNcc.ResetText();
                this.txt_DiaChiNcc.ResetText();
                this.txt_SdtNcc.ResetText();
                this.txt_MailNcc.ResetText();

                this.btn_ThemNcc.Enabled = true;
                this.btn_Huy.Enabled = true;

                this.btn_XoaNcc.Enabled = false;
                this.btn_SuaNcc.Enabled = false;
                this.btn_LuuNcc.Enabled = false;
                this.btn_ChitietNcc.Enabled = false;

                this.txt_MaNcc.Enabled = false;
                this.txt_TenNcc.Enabled = false;
                this.txt_DiaChiNcc.Enabled = false;
                this.txt_MailNcc.Enabled = false;
                this.txt_SdtNcc.Enabled = false;
                this.cb_TrangthaiNcc.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được thông tin Nhà cung cấp. Lỗi rồi!!!");
            }
        }
        bool kiemtra()
        {
            bool kq = true;
            if (txt_TenNcc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNcc.Focus();
                kq = false;

            }

            else if (txt_DiaChiNcc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập thời hạn địa chỉ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChiNcc.Focus();
                kq = false;
            }
            else if (txt_SdtNcc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SdtNcc.Focus();
                kq = false;
            }
            else if (txt_MailNcc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập Mail!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MailNcc.Focus();
                kq = false;
            }
            return kq;
        }
        private void User_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataNcc();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadDataNcc();
        }

        private void dgv_Ncc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txt_MaNcc.Enabled = false;
            this.txt_TenNcc.Enabled = false;
            this.txt_DiaChiNcc.Enabled = false;
            this.txt_SdtNcc.Enabled = false;
            this.txt_MailNcc.Enabled = false;

            this.btn_ChitietNcc.Enabled = true;
            this.btn_SuaNcc.Enabled = true;
            this.btn_ThemNcc.Enabled = true;
            this.btn_XoaNcc.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.btn_LuuNcc.Enabled = false;
            int r = dgv_Ncc.CurrentCell.RowIndex;
            this.txt_MaNcc.Text = dgv_Ncc.Rows[r].Cells[0].Value.ToString();
            this.txt_TenNcc.Text = dgv_Ncc.Rows[r].Cells[1].Value.ToString();
            this.txt_DiaChiNcc.Text = dgv_Ncc.Rows[r].Cells[2].Value.ToString();
            this.txt_SdtNcc.Text = dgv_Ncc.Rows[r].Cells[3].Value.ToString();
            this.txt_MailNcc.Text = dgv_Ncc.Rows[r].Cells[4].Value.ToString();
            //this.cb_TrangthaiNcc.Text = dgv_Ncc.Rows[r].Cells[5].Value.ToString();
            if (dgv_Ncc.Rows[r].Cells[5].Value == null || (bool)dgv_Ncc.Rows[r].Cells[5].Value)
                this.cb_TrangthaiNcc.Checked = true;
            else
                this.cb_TrangthaiNcc.Checked = false;
        }

        private void btn_ThemNcc_Click(object sender, EventArgs e)
        {
            btn_SuaNcc.Enabled = false;
            btn_XoaNcc.Enabled = false;
            btn_ChitietNcc.Enabled = false;
            btn_ThemNcc.Enabled = false;

            btn_LuuNcc.Enabled = true;
            btn_Huy.Enabled = true;


            this.txt_TenNcc.ResetText();
            this.txt_DiaChiNcc.ResetText();
            this.txt_SdtNcc.ResetText();
            this.txt_MailNcc.ResetText();
            this.cb_TrangthaiNcc.ResetText();

            this.txt_MaNcc.Enabled = false;
            this.txt_TenNcc.Enabled = true;
            this.txt_DiaChiNcc.Enabled = true;
            this.txt_SdtNcc.Enabled = true;
            this.txt_MailNcc.Enabled = true;
            this.cb_TrangthaiNcc.Enabled = false;
            this.txt_TimNcc.Enabled = false;

            add = true;
            this.txt_MaNcc.Text = (dbNcc.LayMaNcc() + 1).ToString();
            this.txt_TenNcc.Focus();
            this.cb_TrangthaiNcc.Checked = true;
        }

        private void btn_SuaNcc_Click(object sender, EventArgs e)
        {
            add = false;
            this.txt_MaNcc.Enabled = false;
            this.btn_ChitietNcc.Enabled = false;
            this.btn_ThemNcc.Enabled = false;
            this.btn_SuaNcc.Enabled = false;
            this.btn_XoaNcc.Enabled = false;

            this.btn_LuuNcc.Enabled = true;
            this.btn_Huy.Enabled = true;

            this.txt_MaNcc.Enabled = false;
            this.txt_TenNcc.Enabled = true;
            this.txt_DiaChiNcc.Enabled = true;
            this.txt_SdtNcc.Enabled = true;
            this.txt_MailNcc.Enabled = true;
            this.cb_TrangthaiNcc.Enabled = true;
            this.txt_TimNcc.Enabled = false;

            this.txt_TenNcc.Focus();
        }

        private void btn_LuuNcc_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                if (add)
                {
                    try
                    {
                        Ncc ncc = new Ncc();
                        bool kq = dbNcc.ThemNcc(Convert.ToInt32(txt_MaNcc.Text.Trim()), txt_TenNcc.Text.Trim(), txt_DiaChiNcc.Text.Trim(),
                            txt_SdtNcc.Text.Trim(), txt_MailNcc.Text.Trim(), cb_TrangthaiNcc.Checked, ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadDataNcc();
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
                        Ncc ncc = new Ncc();
                        bool kq = dbNcc.UpdateNcc(Convert.ToInt32(txt_MaNcc.Text.Trim()), txt_TenNcc.Text.Trim(), txt_DiaChiNcc.Text.Trim(),
                            txt_SdtNcc.Text.Trim(), txt_MailNcc.Text.Trim(), cb_TrangthaiNcc.Checked, ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã sửa xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không Sửa được!!");
                        LoadDataNcc();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi!");
                    }
                }
            }
        }

        private void btn_XoaNcc_Click(object sender, EventArgs e)
        {
            add = false;
            Ncc ncc = new Ncc();
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc ngừng hợp tác nhà cung cấp này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                bool kq = ncc.XoaNcc(Convert.ToInt32(txt_MaNcc.Text.Trim()), cb_TrangthaiNcc.Checked, ref err);
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

            LoadDataNcc();
        }

        private void txt_TimNcc_TextChanged(object sender, EventArgs e)
        {
            dtNcc = new DataTable();
            dtNcc.Clear();

            DataSet ds = dbNcc.TimNcc(txt_TimNcc.Text.Trim());
            dtNcc = ds.Tables[0];
            dgv_Ncc.DataSource = dtNcc;
            dgv_Ncc.AutoResizeColumns();
        }

        private void txt_SdtNcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please input numbers only!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ChitietNcc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MaNcc.Text);
            ChitietNcc Ncc = new ChitietNcc(id);
            Ncc.Show();
        }
    }
}
