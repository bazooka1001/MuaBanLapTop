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
    class chitietnhap
    {
        DBMain db = null;
        public chitietnhap()
        {
            db = new DBMain();
        }
        public DataSet LayChitietNhap(int MaHD)
        {
            return db.ExecuteQueryDataSet("Select * From ChiTietNhap_View Where SoHD = '" + MaHD + "'", CommandType.Text);
        }

        public bool ThemCTN(int MaSp, int SoHD, int SoLuongNhap, int GiaGoc, int ThanhTien, int MaNcc, string GhiChu, ref string err)
        {
            string sqlString = "Exec usp_ThemCTN " + MaSp + "," + SoHD + "," + SoLuongNhap + "," + GiaGoc + "," + ThanhTien + "," + MaNcc + ",N'" + GhiChu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaCTN(int MaSp, int SoHD, int SoLuongNhap, int GiaGoc, int ThanhTien, int MaNcc, string GhiChu, ref string err)
        {
            string sqlString = "Exec usp_SuaCTN " + MaSp + "," + SoHD + "," + SoLuongNhap + "," + GiaGoc + "," + ThanhTien + "," + MaNcc + ",N'" + GhiChu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaCTN(int MaSp, int SoHD, ref string err)
        {
            string sqlString = "Exec dbo.usp_XoaCTN " + MaSp + "," + SoHD + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayMaSp()
        {
            return db.ExecuteQueryDataSet("select MaSp, TenSp from SANPHAM order by MaSp desc", CommandType.Text);
        }

        public DataSet LayMaNcc()
        {
            return db.ExecuteQueryDataSet("select MaNcc, TenNcc from NHACUNGCAP order by MaNcc desc", CommandType.Text);
        }
        public DataSet TruyenSoHD(string soHD)
        {
            return db.ExecuteQueryDataSet("Select * From CHITIETNHAP Where SoHD = '" + soHD + "'", CommandType.Text);
        }
        public int LaySoHD(string soHD)
        {
            return db.ExecuteScalarInt(soHD, CommandType.Text);
        }
        public int thanhtien(int Giagoc, int SLNhap )
        {
            return db.(Giagoc * SLNhap);
        }

        //public DataSet TimCTN(String key)
        //{
        //    return db.ExecuteQueryDataSet("Select * From dbo.TimCTN(N'" + key + ")", CommandType.Text);
        //}
    }
}
