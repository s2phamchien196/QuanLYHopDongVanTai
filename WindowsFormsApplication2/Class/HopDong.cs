using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication2.Class
{
    class HopDong
    {
        public static string tenhopdong,sohopdong,noinhan,noigiao,mathang;
        public static int khoiluong, sothang, haohut,loaihang,khachhang;
        public static DateTime ngayki, ngayhethan;
        public HopDong(string Tenhopdong, string Sohopdong, int Khachhang, int Loaihang, DateTime Ngayki, int Sothang, DateTime Ngayhethan, int Khoiluong, string Noinhan, string Noigiao, string Mathang, int Haohut)
        {
            tenhopdong = Tenhopdong;
            sohopdong = Sohopdong;
            khachhang = Khachhang;
            loaihang = Loaihang;
            ngayki = Ngayki;
            sothang = Sothang;
            ngayhethan = Ngayhethan;
            khoiluong = Khoiluong;
            noigiao = Noigiao;
            noinhan = Noinhan;
            mathang = Mathang;
            haohut = Haohut;
        }
        public static void themHD()
        {
            //string tenhopdong, string sohopdong,string khachhang, string loaihang,string ngayki,string sothang,string ngayhethan,string khoiluong, string noinhan, string noigiao, string mathang, string haohut
            string caulenh = "insert into HopDong(NgayHopDong,NoiNhan,NoiGiao,MaLoaiHang,KhoiLuong,HaoHut,makhachhang,LoaiHopDong,trangthai,SoHopDong,ngayhethan,mathang,sothang) values ('" + ngayki + "',N'" + noinhan + "',N'" + noigiao + "','" + loaihang + "','" + khoiluong + "','" + haohut + "',N'" + khachhang + "',N'" + tenhopdong + "','0','" + sohopdong + "','" + ngayhethan + "',N'" + mathang + "','" + sothang + "')";
            KetNoi.ThucThi(caulenh);
            MessageBox.Show("Thêm hợp đồng thành công!!!!");
        }
       
        public static void huyHD(string sohopdong) 
        {
          
            string cauLenh = "update HopDong  set trangthai = '1' where SoHopDong = '" + sohopdong + "'";
            KetNoi.ThucThi(cauLenh);
        }
        //
      
        //
        public static DataTable Timkiemhopdong(string trangthai,string tk)
        {
            string cauLenh = "select SoHopDong,KhachHang.TenKhachHang,LoaiHopDong,LoaiHang.tenloaihang,ngayhopdong,ngayhethan,sothang,noinhan,noigiao,haohut,khoiluong,mathang from HopDong inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang inner join KhachHang on HopDong.makhachhang = KhachHang. MaKhachHang where trangthai = '" + trangthai + "' and KhachHang.TenKhachHang like N'%"+tk+"%'";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienthiHD(string trangthai) {
            return KetNoi.loadTable("select SoHopDong,KhachHang.TenKhachHang,LoaiHopDong,LoaiHang.tenloaihang,ngayhopdong,ngayhethan,sothang,noinhan,noigiao,haohut,khoiluong,mathang from HopDong inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang inner join KhachHang on HopDong.makhachhang = KhachHang. MaKhachHang where trangthai = '" + trangthai + "'");
        }
        public static string _getSohopdong(int sothang)
        {
            if (sothang > 12)
            {
                return "DH" + DateTime.Now.Year + "-00" + KetNoi.loadTable("select max(ID) from hopdong").Rows[0][0].ToString();
            }
            else
                return "NH" + DateTime.Now.Year + "-00" +KetNoi.loadTable("select max(ID) from hopdong").Rows[0][0].ToString();
        }

        
       
    }

}
