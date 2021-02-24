using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Class
{
    class TaiXe
    {
        public string mataixe, tentaixe, ngaysinh, gioitinh, diachi, sdt;
        public static void ThemTaixe(string tentaixe, string ngaysinh, string gioitinh, string diachi, string sdt) {
            string cauLenh = "insert into TaiXe(TenTaiXe, NgaySinh, GioiTinh, DiaChi, SDT) values(N'" + tentaixe + "', '" + ngaysinh + "', N'" + gioitinh + "', N'" + diachi + "', '" + sdt + "')";
            KetNoi.ThucThi(cauLenh);
        }
        public static void SuaTaixe(string mataixe, string tentaixe, string ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string cauLenh = "update TaiXe set TenTaiXe = N'" + tentaixe + "', NgaySinh = '" + ngaysinh + "', GioiTinh = N'" + gioitinh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "' where MaTaiXe = '"+mataixe+"'";
            KetNoi.ThucThi(cauLenh);
        }
        public static void XoaTaixe(string mataixe) {
            string cauLenh = "delete from TaiXe where MaTaiXe = '"+mataixe+"'";
            KetNoi.ThucThi(cauLenh);
        }
        public static DataTable Timkiemtaixe(string tentaixe) {
            string cauLenh = "select * from TaiXe where TenTaiXe = N'%"+tentaixe+"%'";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienThiDSTaixe() {
            string cauLenh = "select * from TaiXe";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienThiLaiXechinh(string ngayvanchuyen)
        {
          // MessageBox.Show(ngayvanchuyen);
            string sql = "select Mataixe,tentaixe from TaiXe  where MaTaiXe !=4 and  MaTaiXe not in (select MaTaiXe from DieuXe where trangthai != 'Hoàn Thành' and( '" + ngayvanchuyen + "' <= vebai and '" + ngayvanchuyen + "' >= khoihanh))";
            return KetNoi.loadTable(sql);
        }
        public static DataTable HienThiLaiXePhu(string ngayvanchuyen)
        {
            string sql = "select Mataixe,tentaixe from laiphu  where  MaTaiXe != 1 and  MaTaiXe not in (select taixephu from DieuXe where trangthai != 'Hoàn Thành' and( '" + ngayvanchuyen + "' <= vebai and '" + ngayvanchuyen + "' >= khoihanh))";
             return KetNoi.loadTable(sql);
        }

        public static string _getTenTaiXe(string MaTaiXe)
        {
                return KetNoi.loadTable("select TenTaiXe from TaiXe where MaTaiXe ='" + MaTaiXe + "'").Rows[0][0].ToString();
        }
        public static string _getTenTaiXePhu(string MaTaiXe)
        {
                return KetNoi.loadTable("select TenTaiXe from LaiPhu where MaTaiXe ='" + MaTaiXe + "'").Rows[0][0].ToString();
        }
        public static void getMataixe(string tentaixe) { }
    }
}
