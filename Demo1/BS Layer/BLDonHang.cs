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
    class BLDonHang
    {
        DBMain db = null;
        public BLDonHang()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachDonHang()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DSDonHang()", CommandType.Text);
        }
        public SqlDataReader LayThongTinDH(int MaDH)
        {
            string sqlString = "select * from ThongTinDonHang(" + MaDH + ")";
            return db.MyExecuteReader(sqlString);
        }
        public DataSet TimKiemDonHang(string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemDonHang(N'" + key + "')", CommandType.Text);
        }
        public DataSet BoLocDonHang(string key, int f)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM BoLocDonHang(N'" + key + "'," + f + ")", CommandType.Text);
        }
        public SqlDataReader ThongTinChiTietDonHang(int MaDH)
        {
            string sqlString = "SELECT * FROM ThongTinChiTietDH(" + MaDH + ")";
            return db.MyExecuteReader(sqlString);
        }
        public DataSet DanhSachSanPhamMua(int MaDH)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachSPMua(" + MaDH + ")", CommandType.Text);
        }
        public SqlDataReader ThongTinChiTietSPMUa(int MaDH, int MaSP)
        {
            string sqlString = "SELECT * FROM ThongTinChiTietSPMua(" + MaDH + "," + MaSP + ")";
            return db.MyExecuteReader(sqlString);
        }
        public DataSet LayDanhSachKhachHang()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachKHDonHang()", CommandType.Text);
        }
        public DataSet TimKiemKhachHang(string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemKhachHangDoHa(N'" + key + "')", CommandType.Text);
        }
        public SqlDataReader LayThongTinKhachHang(int makh)
        {
            return db.MyExecuteReader("SELECT MaKH, TenKH, Sdt, Email, DiaChi FROM KHACHHANG WHERE MaKH=" + makh);
        }
        public SqlDataReader LayTenNV(int manv)
        {
            return db.MyExecuteReader("SELECT TenNV FROM NHANVIEN WHERE MaNV=" + manv);
        }
        public int TaoMaDH(ref string err)
        {
            string sqlString = "select dbo.TaoMaDH()";
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public bool ThemDonHang(int MaDH, int MaKH, int TongTien, int TraTruoc, int MaNV,
            int TrangThai, string NgayTao, int GiaoHang, string GhiChu, int Huy, ref string err)
        {
            string sqlString = "EXEC ThemDonHang " + MaDH + "," + MaKH + "," + TongTien + "," + TraTruoc + "," + MaNV + "," +
                TrangThai + ",'" + NgayTao + "'," + GiaoHang + ",N'" + GhiChu + "'," + Huy;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ChinhSuaDonHang(int MaDH, int MaKH, int TongTien, int TraTruoc, int MaNV,
            int TrangThai, string NgayTao, int GiaoHang, string GhiChu, int Huy, ref string err)
        {
            string sqlString = "EXEC ChinhSuaDonHang " + MaDH + "," + MaKH + "," + TongTien + "," + TraTruoc + "," + MaNV + "," +
                TrangThai + ",'" + NgayTao + "'," + GiaoHang + ",N'" + GhiChu + "'," + Huy;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaDonHang(int MaDH, ref string err)
        {
            return db.MyExecuteNonQuery("EXEC XoaDonHang " + MaDH, CommandType.Text, ref err);
        }
        public DataSet DanhSachSanPhamMuaChuaMua(int MaDH)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM DanhSachSPChuaMua(" + MaDH + ")", CommandType.Text);
        }
        public DataSet LoadCMBncc(int MaSP)
        {
            return db.ExecuteQueryDataSet("SELECT ncc.TenNcc, ncc.MaNcc FROM CHITIETNCC ct," +
                " NHACUNGCAP ncc WHERE ct.MaSp=" + MaSP + " and ct.MaNcc=ncc.MaNcc", CommandType.Text);
        }
        public DataSet LoadCMBkm(int MaSP)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KhuyenMaiDangApDung(" + MaSP + ")", CommandType.Text);
        }
        public DataSet TimKiemSPChuaMua(int MaDH, string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemSPChuaMua(" + MaDH + ",N'" + key + "')", CommandType.Text);
        }
        public DataSet TimKiemSPMua(int MaDH, string key)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM TimKiemSPMua(" + MaDH + ",N'" + key + "')", CommandType.Text);
        }
        public bool XoaSanPhamMua(int MaDH, int MaSP, ref string err)
        {
            return db.MyExecuteNonQuery("EXEC XoaSanPhamMua " + MaDH + "," + MaSP, CommandType.Text, ref err);
        }
        public int LaySoLuongTuNcc(int MaNCC, int MaSP,ref string err)
        {
            string sqlString = "SELECT SoLuong FROM CHITIETNCC WHERE MaNcc=" + MaNCC + " and MaSp=" + MaSP;
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public int LaySoTienGiamKM(int MaKM, ref string err)
        {
            string sqlString = "SELECT Giam FROM KHUYENMAI WHERE MaKM=" + MaKM;
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
        public bool ThemSanPhamMua(int MaSp, int MaDH, int SoLuong, int ThanhTien, int MaKM, int GiaBan, int MaNcc, ref string err)
        {
            string sqlString = "EXEC ThemSanPhamMua " + MaSp + "," + MaDH + "," + SoLuong + "," + ThanhTien + "," + MaKM + "," + GiaBan + "," + MaNcc;
            
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ChinhSuaSanPhamMua(int MaSp, int MaDH, int SoLuong, int ThanhTien, int MaKM, int GiaBan, int MaNcc, ref string err)
        {
            string sqlString = "EXEC ChinhSuaSPMua " + MaSp + "," + MaDH + "," + SoLuong + "," + ThanhTien + "," + MaKM + "," + GiaBan + "," + MaNcc;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public int LayTongTienDH(int MaDH, ref string err)
        {
            string sqlString = "SELECT TongTien FROM DONHANG WHERE MaDH=" + MaDH;
            return db.MyExecuteScalar(sqlString, CommandType.Text, ref err);
        }
    }
}
