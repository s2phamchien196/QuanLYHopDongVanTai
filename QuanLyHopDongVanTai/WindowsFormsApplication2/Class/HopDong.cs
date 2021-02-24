using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class HopDong
    {
        public string lhopdong, noinhan, noigiao;
        public int sohopdong, datcoc, khoiluong, haohut;
        public DateTime ngaykiHD, ngayBD, ngayKT, ngayBaogia;
        public HopDong(string hopDong, string noiNhan, string noiGiao, int soHopDong, int datCoc, int khoiLuong, int haoHut, DateTime ngayKi, DateTime ngayBatDau,DateTime ngayKetThuc, DateTime ngayBaoGia)
        {
            lhopdong = hopDong;
            noinhan = noiNhan;
            noigiao = noiGiao;
            sohopdong = soHopDong;
            datcoc = datCoc;
            khoiluong = khoiLuong;
            haohut = haoHut;
            ngaykiHD = ngayKi;
            ngayBD = ngayBatDau;
            ngayKT = ngayKetThuc;
            ngayBaogia = ngayBaoGia;
        }
        public static void themHD(string loaiHopDong, string noiNhan, string noiGiao, string datCoc, string khoiLuong, string haoHut, string ngayKi, string ngayBatDau, string ngayKetThuc, string ngayBaoGia)
        {
            string caulenh = String.Format("insert into HopDong(LoaiHopDong, NoiNhan, NoiGiao, DatCoc, KhoiLuong, HaoHut, NgayKy, NgayBatDau, NgayKetThuc, NgayBaoGia) values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})", loaiHopDong, noiNhan, noiGiao, datCoc, khoiLuong, haoHut, ngayKi, ngayBatDau, ngayKetThuc, ngayBaoGia);
            KetNoi.ThucThi(caulenh);
        }
        public static void suaHD(string loaiHopDong, string noiNhan, string noiGiao, string soHopDong, string datCoc, string khoiLuong, string haoHut, string ngayKi, string ngayBatDau, string ngayKetThuc, string ngayBaoGia)
        {
            string caulenh = String.Format("update HopDong set LoaiHopDong = {0}, NoiNhan = {1}, NoiGiao = {2}, DatCoc = {3}, KhoiLuong = {4}, HaoHut = {5}, NgayKy = {6}, NgayBatDau = {7}, NgayKetThuc = {8}, NgayBaoGia = {9} where SoHopDong = {10}", loaiHopDong, noiNhan, noiGiao, datCoc, khoiLuong, haoHut, ngayKi, ngayBatDau, ngayKetThuc, ngayBaoGia, soHopDong);
            KetNoi.ThucThi(caulenh);
        }
        public static void huyHD(string sohopdong) {
            string cauLenh = "delete from HopDong where SoHopDong = '" + sohopdong + "'";
            KetNoi.ThucThi(cauLenh);
        }
        public static void ThemLoaiHD() { }
        public static void SuaLoaiHD() { }
        public static void XoaLoaiHD() { }
        public static void getmaloai(string tenloaihopdong) { }
        public static void ThemLoaiHang() {  }
        public static void SuaLoaiHang(){ }
        public static void XoaLoaiHang() { }
        public static void getmaloaiHang(string tenloaiHang) { }
        public static DataTable Timkiemhopdong(string sohopdong) {
            string cauLenh = "select * from HopDong where SoHopDong = '"+sohopdong+"'";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienthiHD() {
            string cauLenh = "select * from HopDong";
            return KetNoi.loadTable(cauLenh);
        }
    }
}
