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
    public partial class User_KhachHang : UserControl
    {

        DataTable dtKH = null;
        string err;
        BLKhachHang dlKH = new BLKhachHang();
        bool Them = false;

        private static User_KhachHang _instance;
        public static User_KhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_KhachHang();
                return _instance;
            }
        }
        public User_KhachHang()
        {
            InitializeComponent();
        }

        private void User_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            enableReview();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            enableReview();
            txt_MaKhachHang.ResetText();
            resetTextBox();
            txt_TuKhoa.ResetText();
        }

        private void dgv_DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgv_DanhSach.CurrentCell.RowIndex;
                int maKH = Convert.ToInt32(dgv_DanhSach.Rows[r].Cells[0].Value);
                LoadDataInfo(maKH);
            }
            catch
            {
                MessageBox.Show("Vui lòng không chọn hàng này!");
            }
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dlKH.TaoMaKH(ref err);
                txt_MaKhachHang.Text = id.ToString();
                enableAdd();
                resetTextBox();
                Them = true;
                rbt_Nu.Checked = true;
            }
            catch
            {
                MessageBox.Show("Có lỗi với việc tạo mã khách hàng!");
            }
        }
        void LoadData()
        {
            enableReview();
            txt_MaKhachHang.ResetText();
            resetTextBox();
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();

                DataSet ds = dlKH.LayDanhSach();
                dtKH = ds.Tables[0];
                dgv_DanhSach.DataSource = dtKH;
                dgv_DanhSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        void enableReview()
        {
            txt_MaKhachHang.Enabled = false;
            txt_TenKhachHang.Enabled = false;
            rbt_Nu.Enabled = false;
            rbt_Nam.Enabled = false;
            date_NgaySinh.Enabled = false;
            txt_Sdt.Enabled = false;
            txt_Email.Enabled = false;
            txt_DiaChi.Enabled = false;

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            btn_ChinhSuaThongTin.Enabled = true;
            btn_ThemKhachHang.Enabled = true;
        }
        void enableAdd()
        {
            txt_TenKhachHang.Enabled = true;
            rbt_Nu.Enabled = true;
            rbt_Nam.Enabled = true;
            date_NgaySinh.Enabled = true;
            txt_Sdt.Enabled = true;
            txt_Email.Enabled = true;
            txt_DiaChi.Enabled = true;

            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;

            btn_ChinhSuaThongTin.Enabled = false;
            btn_ThemKhachHang.Enabled = false;
        }
        void resetTextBox()
        {
            txt_TenKhachHang.ResetText();
            rbt_Nu.Checked = false;
            rbt_Nam.Checked = false;
            date_NgaySinh.ResetText();
            txt_Sdt.ResetText();
            txt_Email.ResetText();
            txt_DiaChi.ResetText();
        }
        void LoadDataInfo(int MaKH)
        {
            enableReview();
            txt_MaKhachHang.ResetText();
            resetTextBox();
            try
            {
                SqlDataReader dataReader = dlKH.LayThongTin(MaKH);
                while (dataReader.Read())
                {
                    txt_MaKhachHang.Text = dataReader.GetValue(0).ToString();
                    txt_TenKhachHang.Text = dataReader.GetValue(1).ToString();
                    if (Convert.ToBoolean(dataReader.GetValue(2).ToString()))
                        rbt_Nam.Checked = true;
                    else
                        rbt_Nu.Checked = true;
                    date_NgaySinh.Value = Convert.ToDateTime(dataReader.GetValue(3).ToString());
                    txt_DiaChi.Text = dataReader.GetValue(4).ToString();
                    txt_Sdt.Text = dataReader.GetValue(5).ToString();
                    txt_Email.Text = dataReader.GetValue(6).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }

        }

        private void btn_ChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if(txt_MaKhachHang.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!");
            }
            else
                enableAdd();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            enableReview();
            if (Them)
            {
                Them = false;
                txt_MaKhachHang.ResetText();
                resetTextBox();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(kiemTra())
            {
                if (Them) // them khach hang
                {
                    try
                    {
                        dlKH = new BLKhachHang();
                        bool kq = dlKH.ThemKH(Convert.ToInt32(txt_MaKhachHang.Text), txt_TenKhachHang.Text.Trim(), rbt_Nam.Checked, date_NgaySinh.Value.ToString("yyyy/MM/dd"),
                            txt_DiaChi.Text.Trim(), txt_Sdt.Text.Trim(), txt_Email.Text.Trim(), ref err);
                        if (kq)
                        {
                            MessageBox.Show("Đã thêm xong!");
                            LoadData();
                            Them = false;
                            enableReview();
                            txt_MaKhachHang.ResetText();
                            resetTextBox();
                        }
                        else
                            MessageBox.Show("Thêm không thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Đã xảy ra lỗi!");
                    }
                }
                else //chỉnh sửa thông tin
                {
                    try
                    {
                        dlKH = new BLKhachHang();
                        bool kq = dlKH.ChinhSuaKH(Convert.ToInt32(txt_MaKhachHang.Text), txt_TenKhachHang.Text.Trim(), rbt_Nam.Checked, date_NgaySinh.Value.ToString("yyyy/MM/dd"),
                            txt_DiaChi.Text.Trim(), txt_Sdt.Text.Trim(), txt_Email.Text.Trim(), ref err);
                        if (kq)
                        {
                            MessageBox.Show("Đã chỉnh sửa xong!");
                            LoadData();
                            enableReview();
                        }
                        else
                            MessageBox.Show("Chỉnh sửa không thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Đã xảy ra lỗi!");
                    }
                }
            }
        }
        bool kiemTra()
        {
            bool kq;
            if (txt_TenKhachHang.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txt_TenKhachHang.Focus();
                kq = false;
            }
            else
                kq = true;
            return kq;
        }

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtKH = new DataTable();
                dtKH.Clear();

                DataSet ds = dlKH.TimKiemKH(txt_TuKhoa.Text.Trim());
                dtKH = ds.Tables[0];
                dgv_DanhSach.DataSource = dtKH;
                dgv_DanhSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
    }
}
