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
    class HDNhap
    {
        DBMain db = null;
        public HDNhap()
        {
            db = new DBMain();
        }
        public int LaySoHD()
        {
            return db.ExecuteScalarInt("Select SoHD From HOADONNHAP order by SoHD desc", CommandType.Text);
        }
        public DataSet LayHDN()
        {
            return db.ExecuteQueryDataSet("Select * From HoaDonNhap_View", CommandType.Text);
        }
        public DataSet LayNV()
        {
            return db.ExecuteQueryDataSet("Select MaNV, TenNV From NHANVIEN", CommandType.Text);
        }
        //public int LayMaSP()
        //{
        //    return db.ExecuteScalarInt("select MaSp from CHITIETNHAP order by MaSp desc", CommandType.Text);
        //}
        public bool ThemHDN(int SoHD, string NgayNhap, int MaNV, int ThanhTien, ref string err)
        {
            string sqlString = "Exec usp_ThemHDN " + SoHD + ", '" + NgayNhap + "', " + MaNV + ", " + ThanhTien + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaHDN(int SoHD, string NgayNhap, int MaNV, int ThanhTien, ref string err)
        {
            string sqlString = "Exec usp_SuaHDN " + SoHD + ", '" + NgayNhap + "', " + MaNV + ", " + ThanhTien + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimHDN(string key)
        {
            return db.ExecuteQueryDataSet("select * From dbo.TimHDN(N'" + key + "')", CommandType.Text);
        }
    }
}
