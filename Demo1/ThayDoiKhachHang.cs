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
    public partial class frm_ThayDoiKhachHang : Form
    {
        DataTable dtDH = null;
        string err;
        BLDonHang dlDH = new BLDonHang();
        private int MaKH;

        public SendMessage send;
        public frm_ThayDoiKhachHang(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void frm_ThayDoiKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.LayDanhSachKhachHang();
                dtDH = ds.Tables[0];
                dgv_DanhSachKH.DataSource = dtDH;
                dgv_DanhSachKH.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách khách hàng. Lỗi rồi!!!");
            }
        }

        private void dgv_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_DanhSachKH.CurrentCell.RowIndex;
            MaKH = Convert.ToInt32(dgv_DanhSachKH.Rows[r].Cells[0].Value);
            txt_maKH.Text = "#" + dgv_DanhSachKH.Rows[r].Cells[0].Value.ToString();
            txt_TenKhachHang.Text = dgv_DanhSachKH.Rows[r].Cells[1].Value.ToString();
            txt_Sdt.Text = dgv_DanhSachKH.Rows[r].Cells[2].Value.ToString();
            txt_Email.Text = dgv_DanhSachKH.Rows[r].Cells[3].Value.ToString();
        }

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtDH = new DataTable();
                dtDH.Clear();

                DataSet ds = dlDH.TimKiemKhachHang(txt_TuKhoa.Text.Trim());
                dtDH = ds.Tables[0];
                dgv_DanhSachKH.DataSource = dtDH;
                dgv_DanhSachKH.AutoResizeColumns();
            }
            catch
            {
                //MessageBox.Show("Không lấy được danh sách khách hàng. Lỗi rồi!!!");
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            this.send(MaKH);
            this.Close();
        }
    }
}
