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
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSach()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachKhachHang", CommandType.Text);
        }
        public DataSet TimKiemKH(string key)
        {
            return db.ExecuteQueryDataSet("select * from TimKiemKhachHang(N'" + key + "')", CommandType.Text);
        }
        public SqlDataReader LayThongTin(int MaKH)
        {
            string sqlString = "SELECT * FROM ThongTinKhachHang(" + MaKH + ")";
            return db.MyExecuteReader(sqlString);
        }
        public int TaoMaKH(ref string err)
        {
            string sqlString = "select dbo.TaoMaKH()";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public bool ThemKH(int MaKH, string TenKH, bool GioiTinh, string NgaySinh, string DiaChi, string Sdt, string Email, ref string err)
        {
            string sqlString = "EXEC ThemKhachHang '" + MaKH + "', N'" + TenKH + "' , " + GioiTinh + ", '" + NgaySinh + "', N'" + DiaChi + "', '" + Sdt + "', '" + Email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ChinhSuaKH(int MaKH, string TenKH, bool GioiTinh, string NgaySinh, string DiaChi, string Sdt, string Email, ref string err)
        {
            string sqlString = "EXEC ChinhSuaThongTinKhachHang '" + MaKH + "', N'" + TenKH + "' , " + GioiTinh + ", '" + NgaySinh + "', N'" + DiaChi + "', '" + Sdt + "', '" + Email + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
