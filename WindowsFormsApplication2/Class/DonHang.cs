using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class DonHang
    {

        public static int soluongxe, sohangconlai,khoiluong, datcoc ,khoangcach, madon;
        public static string trangThai,mota,sohopdong;
        public static DateTime ngayvanchuyen;

        public DonHang(int Soluongxe, int Sohangconlai, int Khoiluong, int Datcoc, string TrangThai, string Mota, DateTime Ngayvanchuyen, string Sohopdong, int Khoangcach)
        {
            soluongxe = Soluongxe;
            sohangconlai = Sohangconlai;
            khoiluong = Khoiluong;
            datcoc = Datcoc;
            trangThai = TrangThai;
            mota = Mota;
            ngayvanchuyen = Ngayvanchuyen;
            sohopdong = Sohopdong;
            khoangcach = Khoangcach;
        }

        public static void addDonHang()
        {
          
            string sql = "insert into DonHang Values('0','" +sohangconlai+ "',N'Chờ','"+sohopdong+"','"+ngayvanchuyen+"',N'"+mota+"','"+khoiluong+"','"+datcoc+"','"+khoangcach+"')";
            KetNoi.ThucThi(sql);
            MessageBox.Show("Add Thành công");
        }
        public static DataTable  hienthi(string tt)
        {
            string sql = "select madonhang,KhachHang.TenKhachHang, soluongxe, Donhang.khoiluong,sohangconlai,ngayvanchuyen,mota,Donhang.datcoc,sokm from Donhang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join KhachHang on HopDong.makhachhang = KhachHang.MaKhachHang where Donhang.trangthai = N'" + tt + "' order by ngayvanchuyen asc";
            return KetNoi.loadTable(sql);
        }
      
        public static DataTable TKhienthi(string ten)
        {
            string sql = "select MaDonHang, DonHang.SoHopDong,KhachHang.TenKhachHang, LoaiHang.TenLoaiHang, SoHangConLai, SoLuongXe, TenTuyen, GiaoTuNgay,GiaoDenNgay from donhang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join KhachHang on HopDong.makhachhang = KhachHang.MaKhachHang inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang where TenKhachHang like '%" + ten + "%';";
            return KetNoi.loadTable(sql);
        }
       
           public static void _addSoLuongXe(int madonhang)
           {
               KetNoi.ThucThi("Update DonHang set SoLuongXe = SoLuongXe + 1 where MaDonHang = '" + madonhang + "' ");
           }
           public static void _updateKLuongConlai(int madonhang, float khoiluong)
           {
               KetNoi.ThucThi("Update DonHang set SoHangConLai = '"+khoiluong+"' where MaDonHang = '" + madonhang + "' ");
           }

           public static DataTable dsKhachHang() 
           {
               return KetNoi.loadTable("select DonHang.MaDonHang, KhachHang.TenKhachHang from DonHang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join KhachHang on HopDong.makhachhang = KhachHang.MaKhachHang");
           }
           public static void _updateTrangThai(string madieuxe, string sokm)
           {
                KetNoi.ThucThi("Update DonHang set trangthai = N'Hoàn Thành', sokm = '"+sokm+"' where MaDonHang= (select madon from dieuxe where madieuxe = '" + madieuxe + "') ");

           }
           public static DataTable TKDonHangTT(string ten)
           {
               string sql = "select madonhang,KhachHang.TenKhachHang, soluongxe, Donhang.khoiluong,sohangconlai,ngayvanchuyen,mota,Donhang.datcoc,sokm from Donhang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join KhachHang on HopDong.makhachhang = KhachHang.MaKhachHang where Donhang.trangthai = N'Hoàn Thành' order by ngayvanchuyen asc";
               return KetNoi.loadTable(sql);
           }

        //public static DataTable thanhtoan()
    }
}
