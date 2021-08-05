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
    class Sanpham
    {
        DBMain db = null;
        public Sanpham()
        {
            db = new DBMain();
        }
        public DataSet LaySanPham()
        {
            return db.ExecuteQueryDataSet("select * from dbo.SANPHAM_View", CommandType.Text);
        }

        public int LayMaSp()
        {
            return db.ExecuteScalarInt("select MaSp from SANPHAM order by MaSp desc", CommandType.Text);
        }

        public DataSet timSP(string key)
        {
            return db.ExecuteQueryDataSet("select * from dbo.TimSp(N'" + key + "')", CommandType.Text);
        }
        public bool ThemSp(int MaSp, string TenSp, int MaNSX, string BaoHanh, int Soluong, string ThongsoKT, int DonGia, bool TrangThai, ref string err)
        {
            string sqlString = "Exec  dbo.usp_Themsp " + MaSp + ", '" + TenSp + "', " + MaNSX + ", N'" + BaoHanh + "', " + Soluong + ", '" + ThongsoKT + "', " + DonGia + ", " + TrangThai + "";
            //string sqlString = "('" + MaSp +"',N'"+TenSp+"','"+MaNsx+"',N'"+Baohanh+"','" + Soluong + "',N'" + ThongsoKT + "','" + true + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateSp(int MaSp, string TenSp, int MaNSX, string BaoHanh, int Soluong, string ThongsoKT, int DonGia, bool TrangThai, ref string err)
        {
            string sqlString = "Exec dbo.usp_Suasp " + MaSp + ",'" + TenSp + "', " + MaNSX + ",N'" + BaoHanh + "', " + Soluong + ", '" + ThongsoKT + "', " + DonGia + "," + TrangThai + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSp(int MaSp, string TenSp, int MaNSX, string BaoHanh, int Soluong, string ThongsoKT, int DonGia, bool TrangThai, ref string err)
        {
            string sqlString = "Exec dbo.usp_Xoasp " + MaSp + ", '" + TenSp + "', " + MaNSX + ", N'" + BaoHanh + "', " + Soluong + ", '" + ThongsoKT + "', " + DonGia + ", " + TrangThai + "";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayCtsp(int Ma_Sp)
        {
            return db.ExecuteQueryDataSet("Select * from CHITIETNCC Where MaSp = " + Ma_Sp + "", CommandType.Text);
        }
    }
}
