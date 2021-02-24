using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class Thanhtoan
    {
        public static void _addThanhtoan(string madon)
        {
            if (KetNoi.loadTable("select COUNT(tongtien) from thanhtoan where madon = '" + madon + "'").Rows[0][0].ToString() == "0")
            {
                int a = Int32.Parse(KetNoi.loadTable("select sum(thanhtien) from dieuxe where madon = '" + madon + "'").Rows[0][0].ToString());
                KetNoi.ThucThi("insert into thanhtoan(madon,tongtien) values('" + madon + "', '" + a + "')");
            }
        }

        public static DataTable _getThongtin(string madon)
        {
            return KetNoi.loadTable("select top(1) DonHang.SoHopDong,TenKhachHang,DonHang.MaDonHang,mota,DonHang.khoiluong,DonHang.DatCoc, thanhtoan.Tongtien,sokm from DonHang inner join HopDong on DonHang.SoHopDong = hopdong.SoHopDong inner join KhachHang on HopDong.makhachhang = KhachHang.MaKhachHang inner join thanhtoan on thanhtoan.madon = DonHang.MaDonHang where MaDonHang = '"+madon+"'");
        }
        public static DataTable _getThoiGiancho(string madon)
        {
            return KetNoi.loadTable("select SUM(thoigiancho), SUM(Quadem) from DieuXe where MaDon = '"+madon+"'");
        }

        public static void _updateThanhToan(string madon, string khachtra, string tralai)
        {
            KetNoi.ThucThi("update thanhtoan set khachtra = '" + khachtra + "', tralai = '" + tralai + "' , trangthai = 'false' where madon = '" + madon + "'");
        }
    }
}
