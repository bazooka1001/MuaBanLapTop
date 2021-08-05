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
    public partial class Nhasanxuat : Form
    {
        DataTable dtNsx = null;
        string err;
        bool add;
        Nsx dbNsx = new Nsx();

        void LoadDataNSX()
        {
            try
            {
                dtNsx = new DataTable();
                dtNsx.Clear();
                DataSet Ds = dbNsx.LayNsx();
                dtNsx = Ds.Tables[0];

                dgv_NSX.DataSource = dtNsx;
                dgv_NSX.AutoResizeColumns();

                dgv_NSX.Columns[0].HeaderText = "Mã NSX";
                dgv_NSX.Columns[1].HeaderText = "Tên NSX";

                dgv_NSX.Columns[0].Width = 100;
                dgv_NSX.Columns[1].Width = 100;

                dgv_NSX.AllowUserToAddRows = false;
                dgv_NSX.EditMode = DataGridViewEditMode.EditProgrammatically;

                this.txt_MaNSX.ResetText();
                this.txt_TenNSX.ResetText();
                this.txt_MaNSX.Enabled = false;
                this.txt_TenNSX.Enabled = false;

                this.btn_ThemNSX.Enabled = true;
                this.btn_SuaNSX.Enabled = false;
                this.btn_LuuNSX.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được thông tin Nhà sản xuất. Lỗi!!!");
            }
        }
        public Nhasanxuat()
        {
            InitializeComponent();
        }

        private void Nhasanxuat_Load(object sender, EventArgs e)
        {
            LoadDataNSX();
        }

        private void dgv_NSX_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn_SuaNSX.Enabled = true;
            this.btn_ThemNSX.Enabled = true;
            this.btn_LuuNSX.Enabled = false;

            this.txt_MaNSX.Enabled = false;
            this.txt_TenNSX.Enabled = false;

            int r = dgv_NSX.CurrentCell.RowIndex;
            this.txt_MaNSX.Text =
                dgv_NSX.Rows[r].Cells[0].Value.ToString();
            this.txt_TenNSX.Text =
                dgv_NSX.Rows[r].Cells[1].Value.ToString();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadDataNSX();
        }

        private void btn_ThemNSX_Click(object sender, EventArgs e)
        {
            add = true;
            this.txt_MaNSX.Enabled = false;
            this.txt_TenNSX.Enabled = true;
            this.txt_MaNSX.Text = (dbNsx.LayMaNsx() + 1).ToString();
            this.txt_TenNSX.ResetText();

            this.btn_SuaNSX.Enabled = false;
            this.btn_Huy.Enabled = true;
            this.btn_LuuNSX.Enabled = true;
        }

        private void btn_SuaNSX_Click(object sender, EventArgs e)
        {
            add = false;
            this.txt_MaNSX.Enabled = false;
            this.txt_TenNSX.Enabled = true;
            this.txt_TenNSX.Focus();

            this.btn_ThemNSX.Enabled = false;
            this.btn_LuuNSX.Enabled = true;
            this.btn_Huy.Enabled = true;
        }
        bool kiemtra()
        {
            bool kq = true;
            if (txt_TenNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNSX.Focus();
                kq = false;

            }
            return kq;
        }

        private void btn_LuuNSX_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                if (add)
                {
                    try
                    {
                        Nsx dbNSX = new Nsx();
                        bool kq = dbNSX.ThemNSX(Convert.ToInt32(txt_MaNSX.Text.Trim()), txt_TenNSX.Text.Trim(), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã thêm xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không thêm được!!");
                        LoadDataNSX();
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
                        Nsx dbNSX = new Nsx();
                        bool kq = dbNSX.SuaNSX(Convert.ToInt32(txt_MaNSX.Text.Trim()), txt_TenNSX.Text.Trim(), ref err);
                        if (kq)
                            //Thong bao thanh cong
                            MessageBox.Show("Đã sửa xong!");
                        else
                            //Khong thanh cong
                            MessageBox.Show("Không sửa được!!");
                        LoadDataNSX();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi!!");
                    }
                }
            }
        }
    }
}
