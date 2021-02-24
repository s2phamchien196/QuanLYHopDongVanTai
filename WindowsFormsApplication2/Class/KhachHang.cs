using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class KhachHang
    {
        public static string makhachhang, tenkhachhang, sodienthoai, diachi;
        public static int sotaikhoan, masothue;
        public static void ThemKH(string tenkhachhang, string sdt, string diachi, string sotaikhoan, string masothue) {
            string cauLenh = "insert into KhachHang(TenKhachHang, SDT, DiaChi, SoTaiKhoan, MaSoThue) values(N'"+tenkhachhang+"', '"+sdt+"', N'"+diachi+"', '"+sotaikhoan+"', '"+masothue+"')";
            KetNoi.ThucThi(cauLenh);
        }
        public static void SuaKH(string makhachhang, string tenkhachhang, string sdt, string diachi, string sotaikhoan, string masothue) {
            string cauLenh = "update KhachHang set TenKhachHang = N'" + tenkhachhang + "', SDT = '" + sdt + "', DiaChi = N'" + diachi + "', SoTaiKhoan = '" + sotaikhoan + "', MaSoThue = '" + masothue + "' where MaKhachHang = '"+makhachhang+"'";
            KetNoi.ThucThi(cauLenh);
        }
        public static void XoaKH(string MaKhachHang) {
            string cauLenh = "delete from KhachHang where MaKhachHang = '" + MaKhachHang + "'";
            KetNoi.ThucThi(cauLenh);
        }
        public static DataTable HienThiDSKH() {
            string cauLenh = "select MaKhachHang, TenKhachHang, SDT, DiaChi, SoTaiKhoan, MaSoThue from KhachHang";
            return KetNoi.loadTable(cauLenh);
        }

        //
        public static DataTable _dsKhachHang()
        {
            return KetNoi.loadTable("select makhachhang,tenkhachhang from khachhang");
        }
        //
        public static DataTable TimKHDieuxe(string TenKhachHang)
        {
            string cauLenh = "select  makhachhang,tenkhachhang from KhachHang where TenKhachHang like N'%" + TenKhachHang + "%'";
            return KetNoi.loadTable(cauLenh);
        }
        //
        public static DataTable TimKH(string TenKhachHang)
        {
            string cauLenh = "select MaKhachHang, TenKhachHang, SDT, DiaChi, SoTaiKhoan, MaSoThue from KhachHang where TenKhachHang like N'%"+TenKhachHang+"%'";
            return KetNoi.loadTable(cauLenh);
        }

        public static DataTable getKhachHang()
        {
            string cauLenh = "select MaKhachHang, TenKhachHang from KhachHang ";
            return KetNoi.loadTable(cauLenh);
        }
        public static string _getMakhachhang(string i)
        {
            string cauLenh = "select TenKhachHang from KhachHang where MaKhachHang= '"+i+"' ";
            DataTable dt = KetNoi.loadTable(cauLenh);
            return dt.Rows[0][0].ToString();
        }
        public static string _getMakhachhang_ten(string i)
        {
            string cauLenh = "select makhachhang from KhachHang where TenKhachHang like '%"+i+"%' ";
            DataTable dt = KetNoi.loadTable(cauLenh);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
             return "0";
        }
    }
}
