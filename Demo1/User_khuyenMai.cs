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
    public partial class User_khuyenMai : UserControl
    {
        DataTable dtKM = null;
        string err;
        BLKhuyenMai dlKM = new BLKhuyenMai();

        private static User_khuyenMai _instance;
        public static User_khuyenMai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_khuyenMai();
                return _instance;
            }
        }
        public User_khuyenMai()
        {
            InitializeComponent();
        }

        private void User_khuyenMai_Load(object sender, EventArgs e)
        {
            enableReview();
            LoadDanhSachKM();
            setValueCMB();
        }
        void enableReview()
        {
            txt_MaKM.Enabled = false;
            txt_TenKM.Enabled = false;
            txt_NoiDung.Enabled = false;
            txt_Giam.Enabled = false;
            rbt_ApDung.Enabled = false;
            rbt_Khoa.Enabled = false;
            date_NgayTao.Enabled = false;
        }
        void setValueCMB()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(2, "Tất Cả");
            dict.Add(1, "Đang Áp Dụng");
            dict.Add(0, "Khóa");

            cmb_Loc.DataSource = new BindingSource(dict, null);
            cmb_Loc.DisplayMember = "Value";
            cmb_Loc.ValueMember = "Key";

        }
        void resetTextBox()
        {
            txt_MaKM.ResetText();
            txt_TenKM.ResetText();
            txt_NoiDung.ResetText();
            txt_Giam.ResetText();
            date_NgayTao.ResetText();
            rbt_ApDung.Checked = false;
            rbt_Khoa.Checked = false;
        }
        void LoadDanhSachKM()
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.LayDanhSachKhuyenMai();
                dtKM = ds.Tables[0];
                dgv_DanhSachKM.DataSource = dtKM;
                dgv_DanhSachKM.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách khuyến mãi. Lỗi rồi!!!");
            }
        }
        void LoadDanhSachSpKM(int MaKM)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds = dlKM.LayDanhSachSpKM(MaKM);
                dtKM = ds.Tables[0];
                dgv_DanhSachSanPhamKM.DataSource = dtKM;
                dgv_DanhSachSanPhamKM.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được danh sách sản phẩm khuyến mãi!");
            }
        }
        void LoadDataInfo(int MaKM)
        {
            resetTextBox();
            try
            {
                SqlDataReader dataReader = dlKM.LayThongTinKM(MaKM);
                while(dataReader.Read())
                {
                    txt_MaKM.Text = dataReader.GetValue(0).ToString();
                    txt_TenKM.Text = dataReader.GetValue(1).ToString();
                    txt_NoiDung.Text = dataReader.GetValue(2).ToString();
                    txt_Giam.Text = dataReader.GetValue(3).ToString();
                    if (Convert.ToBoolean(dataReader.GetValue(4).ToString()))
                        rbt_ApDung.Checked = true;
                    else
                        rbt_Khoa.Checked = true;
                    date_NgayTao.Value = Convert.ToDateTime(dataReader.GetValue(5).ToString());
                    
                }
                LoadDanhSachSpKM(Convert.ToInt32(txt_MaKM.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void dgv_DanhSachKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgv_DanhSachKM.CurrentCell.RowIndex;
                int maKm = Convert.ToInt32(dgv_DanhSachKM.Rows[r].Cells[0].Value);
                LoadDataInfo(maKm);
            }
            catch
            {
                MessageBox.Show("Vui lòng không chọn hàng này!");
            }
        }

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds;

                int f = Convert.ToInt32(cmb_Loc.SelectedValue);
                if (f == 2)
                {
                    ds = dlKM.TimKiemKM(txt_TuKhoa.Text.Trim());
                }
                else
                {
                    ds = dlKM.BoLocKM(txt_TuKhoa.Text.Trim(), f);
                }
                dtKM = ds.Tables[0];
                dgv_DanhSachKM.DataSource = dtKM;
                dgv_DanhSachKM.AutoResizeColumns();
            }
            catch
            {
                //MessageBox.Show("Không lấy được nội dung. Lỗi!");
            }
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtKM = new DataTable();
                dtKM.Clear();

                DataSet ds;

                int f = Convert.ToInt32(cmb_Loc.SelectedValue);
                //MessageBox.Show(f.ToString());
                if (f == 2)
                {
                    ds = dlKM.TimKiemKM(txt_TuKhoa.Text.Trim());
                }
                else
                {
                    ds = dlKM.BoLocKM(txt_TuKhoa.Text.Trim(), f);
                }
                dtKM = ds.Tables[0];
                dgv_DanhSachKM.DataSource = dtKM;
                dgv_DanhSachKM.AutoResizeColumns();
            }
            catch
            {
                //MessageBox.Show("Không lấy được nội dung. Lỗi!");
            }
        }

        private void btn_ThemKhuyenMai_Click(object sender, EventArgs e)
        {
            int id= dlKM.TaoMaKM(ref err);
            frm_ThemKhuyenMai frm = new frm_ThemKhuyenMai(id);
            frm.ShowDialog();
            LoadDanhSachKM();
        }

        private void btn_ChinhSuaKM_Click(object sender, EventArgs e)
        {
            if(!txt_MaKM.Text.Equals(""))
            {
                int id = Convert.ToInt32(txt_MaKM.Text.Trim());
                frm_ChinhSuaKhuyenMai frm = new frm_ChinhSuaKhuyenMai(id);
                frm.ShowDialog();
                LoadDataInfo(id);
                LoadDanhSachKM();
            }
            else
            {
                MessageBox.Show("Chưa chọn khuyến mãi!");
            }
            
        }
    }
}
