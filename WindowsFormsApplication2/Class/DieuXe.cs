using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApplication2.Class
{
    class DieuXe
    {
        public static string Bienso, Trangthai;
        public static int MaTaiXe, Madon,  Taixephu, Thoigiancho, Thoigiandi, Quadem;
        public static float ThucCho;
        public static DateTime KhoiHang, Vebai;

        public DieuXe(string bienso, string trangthai, int maTaiXe, int madon, float thucCho, int taixephu, int thoigiancho, int thoigiandi, int quadem, DateTime khoiHang, DateTime vebai)
        {
            Bienso = bienso;
            Trangthai = trangthai;
            MaTaiXe = maTaiXe;
            Madon = madon;
            ThucCho = thucCho;
            Taixephu = taixephu;
            Thoigiancho = thoigiancho;
            Thoigiandi = thoigiandi;
            Quadem = quadem;
            KhoiHang = khoiHang;
            Vebai = vebai;
        }
        public static DataTable HienthiDieuxe(string mkh) 
        {
            string sql = "select MaDieuXe,BienSo,TenLoaiHang,ngayvanchuyen, thuccho,noinhan,noigiao,TaiXe.TenTaiXe, LaiPhu.TenTaiXe, DieuXe.TrangThai from DieuXe inner join TaiXe on DieuXe.MaTaiXe = TaiXe.MaTaiXe inner join LaiPhu on DieuXe.TaiXePhu = LaiPhu.MaTaiXe  inner join DonHang on DieuXe.MaDon = DonHang.MaDonHang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang where DieuXe.TrangThai != N'Hoàn Thành'  and makhachhang = '" + mkh + "' order by trangthai asc";
           return KetNoi.loadTable(sql);
        }

        public static DataTable _HienthiDieuxe_DinhVi()
        {
            string sql = "select MaDieuXe,Tenkhachhang,BienSo,TenLoaiHang,ngayvanchuyen, thuccho,noinhan,noigiao,TaiXe.TenTaiXe,taixe.sdt, LaiPhu.TenTaiXe, DieuXe.TrangThai from DieuXe inner join TaiXe on DieuXe.MaTaiXe = TaiXe.MaTaiXe inner join LaiPhu on DieuXe.TaiXePhu = LaiPhu.MaTaiXe  inner join DonHang on DieuXe.MaDon = DonHang.MaDonHang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang inner join khachhang on hopdong.makhachhang= khachhang.makhachhang where DieuXe.TrangThai = N'Sẵn sàng'  order by trangthai asc";
            return KetNoi.loadTable(sql);
        }

        public static DataTable _TKDieuxe(string mkh)
        {
            string sql = "select MaDieuXe,Tenkhachhang,BienSo,TenLoaiHang,ngayvanchuyen, thuccho,noinhan,noigiao,TaiXe.TenTaiXe,taixe.sdt, LaiPhu.TenTaiXe, DieuXe.TrangThai from DieuXe inner join TaiXe on DieuXe.MaTaiXe = TaiXe.MaTaiXe inner join LaiPhu on DieuXe.TaiXePhu = LaiPhu.MaTaiXe  inner join DonHang on DieuXe.MaDon = DonHang.MaDonHang inner join HopDong on DonHang.SoHopDong = HopDong.SoHopDong inner join LoaiHang on HopDong.MaLoaiHang = LoaiHang.MaLoaiHang inner join khachhang on hopdong.makhachhang= khachhang.makhachhang where DieuXe.TrangThai = N'Sẵn sàng'  and tenkhachhang like '%" + mkh + "%'";
            return KetNoi.loadTable(sql);
        }

        public static DataTable DSDieuXe(string madon)
        {
            string sql = "select MaDieuXe,xe.BienSo, thuccho, TrongTai from DieuXe inner join xe on  DieuXe.BienSo = Xe.BienSo inner join GiaCuoc on GiaCuoc.ID = xe.IDGiaCuoc where  DieuXe.MaDon = '" + madon + "'";
            return KetNoi.loadTable(sql);
        }


        public static void addDieuxe()
        {
            string sql = "  insert into  DieuXe(bienso,trangthai,madon,khoihanh,vebai,thuccho,mataixe,taixephu) values ('" + Bienso + "',N'" + Trangthai + "','" + Madon + "','" + KhoiHang + "','"+Vebai+"','"+ThucCho+"',4,1)";
            KetNoi.ThucThi(sql);
            MessageBox.Show("Add Thành Công");
        }
       
        public static void XoaDieuXe(string madieuxe)
        {
            string sql = "Delete from LichTrinh Where MaDieuXe = '" + madieuxe + "';Delete from DieuXe Where MaDieuXe = '" + madieuxe + "'";

            KetNoi.ThucThi(sql);
            MessageBox.Show("Xóa Thành Công !!!!");
        }
       
        public static void _updateTaiXe(string MaTaiXe, string MaDieuXe)
        {
                string sql = "update DieuXe set MaTaiXe = '" + MaTaiXe + "', trangthai = N'Sẵn sàng' where MaDieuXe = '" + MaDieuXe + "'";
                KetNoi.ThucThi(sql);
                MessageBox.Show("Add Thành Công");
        }
        public static void _updateTaiXePhu(string MaTaiXe, string MaDieuXe)
        {
            string sql = "update DieuXe set TaiXePhu = '" + MaTaiXe + "'where MaDieuXe = '" + MaDieuXe + "'";
            KetNoi.ThucThi(sql);
            MessageBox.Show("Add Thành Công");
        }

        public static string _getLaiChinh(string MaDieuXe)
        {
            if (KetNoi.loadTable("Select TaiXe.TenTaiXe from DieuXe inner join  TaiXe on DieuXe.MaTaiXe = TaiXe.MaTaiXe  where MaDieuXe = '" + MaDieuXe + "'").Rows.Count > 0)
            {
            return KetNoi.loadTable("Select TaiXe.TenTaiXe from DieuXe inner join  TaiXe on DieuXe.MaTaiXe = TaiXe.MaTaiXe  where MaDieuXe = '" + MaDieuXe + "'").Rows[0][0].ToString();
            }
             else return "";
        }
        public static string _getLaiPhu(string MaDieuXe)
        {
            if (KetNoi.loadTable("Select LaiPhu.TenTaiXe  from DieuXe inner join  LaiPhu on DieuXe.TaiXePhu = LaiPhu.MaTaiXe where MaDieuXe = '" + MaDieuXe + "'").Rows.Count > 0)
            {
                return KetNoi.loadTable("Select LaiPhu.TenTaiXe  from DieuXe inner join  LaiPhu on DieuXe.TaiXePhu = LaiPhu.MaTaiXe where MaDieuXe = '" + MaDieuXe + "'").Rows[0][0].ToString();
            }
            else return "";
        }

        public static void _ktDieuXe(string madieuxe, string thoigiancho, string thoigiandi, string quadem)
        {
            KetNoi.ThucThi("update  Dieuxe set trangthai = N'Hoàn Thành', thoigiancho = '" + thoigiancho + "', thoigiandi ='" + thoigiandi + "',quadem = '" + quadem + "' where madieuxe = '"+madieuxe+ "' ");
        }
        public static void _thanhtien(string madieuxe)
        {
            int a = _tienCho(madieuxe) + _gia4kmdau(madieuxe) + _giakmtieptheo(madieuxe);
            KetNoi.ThucThi("update  Dieuxe set thanhtien = '"+a+"' where madieuxe = '"+madieuxe+"' ");
        }
        public static int _tienCho(string madon)
        {
            int tg = Int16.Parse( KetNoi.loadTable("select thoigiancho from DieuXE where MaDieuXe = '"+madon+"'").Rows[0][0].ToString());
            int giatien = Int32.Parse(KetNoi.loadTable("select GiaCuoc.thoigiancho from DieuXe inner join Xe on DieuXe.BienSo = Xe.BienSo inner join GiaCuoc on xe.IDGiaCuoc = GiaCuoc.ID where MaDieuXe = '" + madon + "'").Rows[0][0].ToString());
            return tg * giatien;
   }
        public static int _gia4kmdau(string madon)
        {
            return Int32.Parse(KetNoi.loadTable("select GiaCuoc.kmdau from DieuXe inner join Xe on DieuXe.BienSo = Xe.BienSo inner join GiaCuoc on xe.IDGiaCuoc = GiaCuoc.ID where MaDieuXe = '" + madon + "'").Rows[0][0].ToString());
        }
        public static int _giakmtieptheo(string madon)
        {
            int sokm = Int16.Parse(KetNoi.loadTable("select SoKm-4 from DonHang where MaDonHang = (select MaDon from DieuXe where  MaDieuXe = '"+madon+"')").Rows[0][0].ToString());
            int giatien = Int32.Parse(KetNoi.loadTable("select GiaCuoc.kmtieptheo from DieuXe inner join Xe on DieuXe.BienSo = Xe.BienSo inner join GiaCuoc on xe.IDGiaCuoc = GiaCuoc.ID where MaDieuXe = '" + madon + "'").Rows[0][0].ToString());
            return sokm * giatien;
        }
     
    }
}
