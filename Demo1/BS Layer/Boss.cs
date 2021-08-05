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
    class Boss
    {
        DBMain Db = null;
        public Boss()
        {
            Db = new DBMain();
        }
        public DataSet LayNhanvien()
        {
            return Db.ExecuteQueryDataSet("select * from NHANVIEN", CommandType.Text);
        }
        public int LayMaNv()
        {
            return Db.ExecuteScalarInt("Select MaNv from NHANVIEN order by MaNv desc", CommandType.Text);
        }
        public DataSet TimNv(string key)
        {
            return Db.ExecuteQueryDataSet("Select * From dbo.TimNv(N'" + key + "')", CommandType.Text);
        }
        public bool ThemNv(int MaNv, string TenNv, bool GioiTinh, string NgaySinh, string DiaChi, string Sdt, string Vitri, string Pass, bool TrangThai, ref string err)
        {
            string sqlString = "Exec dbo.usp_ThemNv " + MaNv + " ,N'" + TenNv + "'," + GioiTinh + ",'" + NgaySinh + "',N'" + DiaChi + "','" + Sdt + "'," + 0 + ",'" + Pass + "'," + TrangThai + "";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaNv(int MaNv, string TenNv, bool GioiTinh, string NgaySinh, string DiaChi, string Sdt, string Pass, bool TrangThai, ref string err)
        {
            string sqlString = "Exec dbo.usp_SuaNv " + MaNv + " ,N'" + TenNv + "'," + GioiTinh + ",'" + NgaySinh + "',N'" + DiaChi + "','" + Sdt + "','" + Pass + "'," + TrangThai + "";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNv(int MaNv, bool TrangThai, ref string err)
        {
            string sqlString = "Exec dbo.usp_XoaNv " + MaNv + "," + TrangThai + "";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public SqlDataReader LayThongTinCH()
        {
            return Db.MyExecuteReader("SELECT * FROM THONGTINCUAHANG WHERE id=1");
        }
        public bool ThayDoiThongTinCH(string ten, string diachi, string sdt, string email, ref string err)
        {
            string sqlString = "EXEC ThayDoiThongTinCH N'" + ten + "',N'" + diachi + "','" + sdt + "','" + email + "'";
            return Db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
