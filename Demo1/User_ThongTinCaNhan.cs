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
    public partial class User_ThongTinCaNhan : UserControl
    {
        BLDangNhap dlDN = new BLDangNhap();

        private int MaNV;
        public User_ThongTinCaNhan(int id)
        {
            MaNV = id;
            InitializeComponent();
        }

        private void User_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            txt_MaNV.Enabled = false;
            txt_TenNV.Enabled = false;
            rbt_Nu.Enabled = false;
            rbt_Nam.Enabled = false;
            date_NgaySinh.Enabled = false;
            txt_Sdt.Enabled = false;
            txt_DiaChi.Enabled = false;

            txt_MaNV.Text = MaNV.ToString();
            LoadDataInfo();
        }
        void LoadDataInfo()
        {
            SqlDataReader dataReader = dlDN.LayThongTinNV(MaNV);
            while (dataReader.Read())
            {
                txt_TenNV.Text= dataReader.GetValue(0).ToString();
                if (Convert.ToBoolean(dataReader.GetValue(1).ToString()))
                    rbt_Nam.Checked = true;
                else
                    rbt_Nu.Checked = true;
                date_NgaySinh.Value = Convert.ToDateTime(dataReader.GetValue(2).ToString());
                txt_Sdt.Text = dataReader.GetValue(3).ToString();
                txt_DiaChi.Text = dataReader.GetValue(4).ToString();
            }
        }

        private void bnt_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau(MaNV);
            frm.ShowDialog();
        }
    }
}
