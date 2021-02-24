using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class Xe
    {
        public string Loaixe, bienso;
        public int pallet, trongtai;
        public DateTime hanbaohiem;
        public static void Themxe(string bienso, string LoaiXe, string MaTaiXe, string pallet, string trongtai, DateTime hanbaohiem) {
            string cauLenh = "insert into Xe(LoaiXe, BienSo, Pallet, TrongTai, HanBaoHiem) values(N'" + LoaiXe + "', '" + MaTaiXe + "', N'" + pallet + "', '" + trongtai + "', '" + hanbaohiem + "')";
            KetNoi.ThucThi(cauLenh);
        }
        public static void Suaxe(string bienso, string LoaiXe, string MaTaiXe, string pallet, string trongtai, DateTime hanbaohiem) {
            string cauLenh = "update Xe set LoaiXe = N'" + LoaiXe + "', MaTaiXe = '" + MaTaiXe + "', Pallet = '" + pallet + "', TrongTai = '" + trongtai + "', HanBaoHiem = '" + hanbaohiem + "' where BienSo = '" + bienso + "'";
            KetNoi.ThucThi(cauLenh);         
        }
        public static void Xoaxe(string BienSo) {
            string cauLenh = "delete from Xe where BienSo = '" + BienSo + "'";
            KetNoi.ThucThi(cauLenh);      
        }
        public DataTable Timxe(string BienSo) {
            string cauLenh = "select LoaiXe, BienSo, Pallet, TrongTai, HanBaoHiem from Xe where BienSo = '"+BienSo+"'";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienThiDSTxe() {
            string cauLenh = "select LoaiXe, BienSo, Pallet, TrongTai, HanBaoHiem from Xe";
            return KetNoi.loadTable(cauLenh);
        }
    }
}
