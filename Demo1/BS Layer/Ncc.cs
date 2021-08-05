using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Demo1.DB_Layer;

namespace Demo1.BS_Layer
{
    class Ncc
    {
        DBMain DB = null;
        public Ncc()
        {
            DB = new DBMain();
        }
        public DataSet LayNcc()
        {
            return DB.ExecuteQueryDataSet("select * from NHACUNGCAP", CommandType.Text);
        }
        public int LayMaNcc()
        {
            return DB.ExecuteScalarInt("select MaNcc from NHACUNGCAP order by MaNcc desc", CommandType.Text);
        }
        public bool ThemNcc(int MaNcc, string TenNcc, String DiaChi, String Sdt, String mail, bool TrangThai, ref string err)
        {
            string sqlString = "Exec usp_ThemNcc " + MaNcc + ", N'" + TenNcc + "', N'" + DiaChi + "', '" + Sdt + "', '" + mail + "'," + TrangThai + "";
            return DB.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateNcc(int MaNcc, string TenNcc, String DiaChi, String Sdt, String mail, bool TrangThai, ref string err)
        {
            string sqlString = "Exec usp_SuaNcc " + MaNcc + ", N'" + TenNcc + "', N'" + DiaChi + "', '" + Sdt + "', '" + mail + "'," + TrangThai + "";
            return DB.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaNcc(int MaNcc, bool TrangThai, ref string err)
        {
            string sqlString = "Exec usp_XoaNcc  " + MaNcc + "," + TrangThai + "";
            return DB.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimNcc(string key)
        {
            return DB.ExecuteQueryDataSet("select * from dbo.TimkiemNcc(N'" + key + "')", CommandType.Text);
        }
        public DataSet LayCtNcc(int Ma_Ncc)
        {
            return DB.ExecuteQueryDataSet("Select * from CHITIETNCC Where MaNcc = " + Ma_Ncc + "", CommandType.Text);
        }
    }
}
