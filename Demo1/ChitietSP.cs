using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo1.BS_Layer;

namespace Demo1
{
    public partial class ChitietSP : Form
    {
        DataTable dtSp = null;
        private int Ma_Sp;
        Sanpham Sp = new Sanpham();
        public ChitietSP(int id)
        {
            Ma_Sp = id;
            InitializeComponent();
        }
        void LoadSp()
        {
            try
            {
                dtSp = new DataTable();
                dtSp.Clear();

                DataSet ds = Sp.LayCtsp(Ma_Sp);
                txt_MaSp.Text = Ma_Sp.ToString();
                dtSp = ds.Tables[0];

                dgv_CtSp.DataSource = dtSp;
                dgv_CtSp.AutoResizeColumns();
                dgv_CtSp.AllowUserToAddRows = false;
                dgv_CtSp.EditMode = DataGridViewEditMode.EditProgrammatically;

                dgv_CtSp.Columns[0].HeaderText = "Mã sản phẩm";
                dgv_CtSp.Columns[1].HeaderText = "Mã Nhà cung cấp";
                dgv_CtSp.Columns[2].HeaderText = "Số lượng";

                dgv_CtSp.Columns[0].Width = 100;
                dgv_CtSp.Columns[1].Width = 100;
                dgv_CtSp.Columns[2].Width = 100;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được thông tin");
            }
        }
        private void ChitietSP_Load(object sender, EventArgs e)
        {
            LoadSp();
        }
    }
}
