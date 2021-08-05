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
    class BLDangNhap
    {
        DBMain db = null;
        public BLDangNhap()
        {
            db = new DBMain();
        }
        public int KiemTraMaNV(int MaNV, ref string err)
        {
            string sqlString = "select dbo.KiemTraMaNV(" + MaNV + ")";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public int KiemTraMK(int MaNV, string pass, ref string err)
        {
            string sqlString = "select dbo.KiemTraMK(" + MaNV + ",'" + pass + "')";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public int KiemTraViTri(int MaNV, ref string err)
        {
            string sqlString = "select dbo.KiemTraViTri(" + MaNV + ")";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public SqlDataReader LayThongTinNV(int MaNV)
        {
            return db.MyExecuteReader("SELECT * FROM LayThongTinDayDuNV(" + MaNV + ")");
        }
        public bool DoiMatKhau(int MaNV, string pass, ref string err)
        {
            return db.MyExecuteNonQuery("EXEC DoiMatKhau " + MaNV + ",'" + pass + "'", CommandType.Text, ref err);
        }
    }
}
