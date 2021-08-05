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
    class BLKhuyenMai
    {
        DBMain db = null;
        public BLKhuyenMai()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachKhuyenMai()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachKhuyenMai", CommandType.Text);
        }
        public DataSet LayDanhSachSpKM(int MaKM)
        {
            return db.ExecuteQueryDataSet("select * from DanhSachSPDuocKM('" + MaKM + "')", CommandType.Text);
        }
        public SqlDataReader LayThongTinKM(int MaKM)
        {
            string sqlString = "SELECT * FROM KHUYENMAI WHERE MaKM=" + MaKM;
            return db.MyExecuteReader(sqlString);
        }
        public SqlDataReader LayThongTinSanPhamDcKM(int MaSp,int MaKm)
        {
            string sqlString = "select * from ThongTinSpDuocKM(" + MaSp + "," + MaKm + ")";
            return db.MyExecuteReader(sqlString);
        }
        public int TaoMaKM(ref string err)
        {
            string sqlString = "select dbo.TaoMaKM()";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public bool ThemKM(int MaKM, string TenKM, string NoiDungKM, int Giam, bool TrangThai, string NgayTao,ref string err)
        {
            string sqlString = "EXEC ThemKhuyenMai '" + MaKM + "',N'" + TenKM + "',N'" + NoiDungKM + "'," + Giam + "," + TrangThai + ",'" + NgayTao + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ChinhSuaKM(int MaKM, string TenKM, string NoiDungKM, int Giam, bool TrangThai, string NgayTao, ref string err)
        {
            string sqlString = "EXEC ChinhSuaKhuyenMai '" + MaKM + "',N'" + TenKM + "',N'" + NoiDungKM + "'," + Giam + "," + TrangThai + ",'" + NgayTao + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhuyenMai(int MaKM, ref string err)
        {
            return db.MyExecuteNonQuery("EXEC XoaKhuyenMai " + MaKM + "", CommandType.Text, ref err);
        }
        public bool ThemSanPhamKhuyenMai(int MaKM, int MaSP, string NgayBD, string NgayKT, ref string err)
        {
            string sqlString = "EXEC ThemSanPhamKhuyenMai '" + MaKM + "','" + MaSP + "','" + NgayBD + "','" + NgayKT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ChinhSuaSanPhamKhuyenMai(int MaKM, int MaSP, string NgayBD, string NgayKT, ref string err)
        {
            string sqlString = "EXEC ChinhSuaSPKhuyenMai '" + MaSP + "','" + MaKM + "','" + NgayBD + "','" + NgayKT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSanPhamKhuyenMai (int MaKM, int MaSP, ref string err)
        {
            string sqlString = "EXEC XoaSPKhuyenMai " + MaSP + "," + MaKM;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemKM(string key)
        {
            return db.ExecuteQueryDataSet("select * from TimKiemKhuyenMai(N'" + key + "')", CommandType.Text);
        }
        public DataSet BoLocKM(string key, int f)
        {
            return db.ExecuteQueryDataSet("select * from BoLocTimKiemKhuyenMai(N'" + key + "'," + f + ")", CommandType.Text);
        }
        public DataSet DanhSachSanPhamChuaKM(int MaKM)
        {
            return db.ExecuteQueryDataSet("select * from DanhSachSpTrongFromKM('" + MaKM + "')", CommandType.Text);
        }
        public DataSet TimKiemSanPhamTrongThemKM (int MaKM, string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemSanPhamTrongKM(" + MaKM + ",N'" + key + "')", CommandType.Text);
        }
        public DataSet TimKiemSanPhamKhuyenMai(int MaKM, string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemSanPhamKhuyenMai(" + MaKM + ", N'" + key + "')", CommandType.Text);
        }
    }
}
