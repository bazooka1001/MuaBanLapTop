using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Demo1.BS_Layer;
namespace Demo1
{
    public partial class ChitietNcc : Form
    {
        DataTable dtCTNcc = null;
        private int Ma_Ncc;
        Ncc Ct = new Ncc();
        public ChitietNcc(int id)
        {
            Ma_Ncc = id;
            InitializeComponent();
        }
        void LoadCTNcc()
        {
            try
            {
                dtCTNcc = new DataTable();
                dtCTNcc.Clear();

                DataSet ds = Ct.LayCtNcc(Ma_Ncc);
                txt_Mancc.Text = Ma_Ncc.ToString();
                dtCTNcc = ds.Tables[0];

                dgv_Ct.DataSource = dtCTNcc;
                dgv_Ct.AutoResizeColumns();
                dgv_Ct.AllowUserToAddRows = false;
                dgv_Ct.EditMode = DataGridViewEditMode.EditProgrammatically;

                dgv_Ct.Columns[0].HeaderText = "Mã sản phẩm";
                dgv_Ct.Columns[1].HeaderText = "Mã Nhà cung cấp";
                dgv_Ct.Columns[2].HeaderText = "Số lượng";

                dgv_Ct.Columns[0].Width = 100;
                dgv_Ct.Columns[1].Width = 100;
                dgv_Ct.Columns[2].Width = 100;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được thông tin");
            }
        }
        private void ChitietNcc_Load(object sender, EventArgs e)
        {
            LoadCTNcc();
        }
    }
}
