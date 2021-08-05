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
    public partial class User_ThongTinCuaHang : UserControl
    {
        string err;
        Boss dlBo = new Boss();
        private static User_ThongTinCuaHang _instance;
        public static User_ThongTinCuaHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_ThongTinCuaHang();
                return _instance;
            }
        }
        public User_ThongTinCuaHang()
        {
            InitializeComponent();
        }

        private void User_ThongTinCuaHang_Load(object sender, EventArgs e)
        {
            reLoad();
        }
        void reLoad()
        {
            txt_TenCH.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_Sdt.Enabled = false;
            txt_Email.Enabled = false;

            btn_ChinhSua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            loadData();
        }
        void loadData()
        {
            try
            {
                SqlDataReader dataReader = dlBo.LayThongTinCH();
                while(dataReader.Read())
                {
                    txt_TenCH.Text = dataReader.GetValue(0).ToString();
                    txt_DiaChi.Text = dataReader.GetValue(1).ToString();
                    txt_Sdt.Text = dataReader.GetValue(2).ToString();
                    txt_Email.Text = dataReader.GetValue(3).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            txt_TenCH.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_Sdt.Enabled = true;
            txt_Email.Enabled = true;

            btn_ChinhSua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = dlBo.ThayDoiThongTinCH(txt_TenCH.Text.Trim(), txt_DiaChi.Text.Trim(), txt_Sdt.Text.Trim(), txt_Email.Text.Trim(), ref err);
                if (kq)
                    MessageBox.Show("Đã sửa xong!");
                else
                    MessageBox.Show("Không sửa được!");
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi!");
            }
            reLoad();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            reLoad();
        }
    }
}
