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
    class Nsx
    {
        DBMain Db = null;
        public Nsx()
        {
            Db = new DBMain();
        }
        public int LayMaNsx()
        {
            return Db.ExecuteScalarInt("select MaNSX from NHASANXUAT order by MaNSX desc", CommandType.Text);
        }
        public DataSet LayNsx()
        {
            return Db.ExecuteQueryDataSet("select * from NHASANXUAT", CommandType.Text);
        }
        public bool ThemNSX(int MaNSX, string TenNSX, ref string err)
        {
            string sqlString = "Exec usp_themnsx " + MaNSX + ", '" + TenNSX + "'";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaNSX(int MaNSX, string TenNSX, ref string err)
        {
            string sqlString = "Exec usp_suansx " + MaNSX + ", '" + TenNSX + "'";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
