using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Class
{
    class Xe
    {
        public  static string Loaixe, Bienso,Mota;
        public static int IDgiacuoc;
        public static DateTime Hanbaohiem;
        public Xe(string bienso, string loaixe, DateTime hanbaohiem, string mota, int idgiacuoc)
        {
            Bienso = bienso;
            Loaixe = loaixe;
            Hanbaohiem = hanbaohiem;
            Mota = mota;
            IDgiacuoc = idgiacuoc;

        }

        public static void Themxe() {
            if (KetNoi.loadTable("select * from xe where bienso = '" + Bienso + "'").Rows.Count == 0)
            {
                string cauLenh = "insert into Xe values('" + Bienso + "', N'" + Loaixe + "', '" + Hanbaohiem + "', N'" + Mota + "', '" + IDgiacuoc + "','1')";
                KetNoi.ThucThi(cauLenh);
            }
            else MessageBox.Show("Trùng Biển Sô!!!!");
        }
        public static void Suaxe() {
            string cauLenh = "update Xe set LoaiXe = N'" + Loaixe + "',IDGiaCuoc = '" + IDgiacuoc + "', HanBaoHiem = '" + Hanbaohiem + "',mota= '"+Mota+"' where BienSo = '" + Bienso + "'";
            KetNoi.ThucThi(cauLenh);         
        }
        public static void Xoaxe(string bienso) {
            string cauLenh = "update Xe set trangthai = '0' where BienSo = '"+bienso+"'";
            KetNoi.ThucThi(cauLenh);      
        }
        public static DataTable Timxe(string tk) {
            string cauLenh = "select LoaiXe, BienSo,mota,TrongTai,HanBaoHiem from Xe inner join giacuoc on xe.IDGiaCuoc = giacuoc.id where BienSo like '%" + tk + "%' and trangthai = 1";
            return KetNoi.loadTable(cauLenh);
        }
        public static DataTable HienThiDSTxe() {
            string cauLenh = "select LoaiXe, BienSo,mota,TrongTai,HanBaoHiem from Xe inner join giacuoc on xe.IDGiaCuoc = giacuoc.id where trangthai = 1";
            return KetNoi.loadTable(cauLenh);
        }


       
     
        //public static bool CheckBienSo(string bienso)
        //{
        //    string cauLenh = "select BienSo from Xe where BienSo = '"+bienso+"'";
        //    DataTable dt;
        //    dt = KetNoi.loadTable(cauLenh);
        //    if(dt.Rows.Count >0)
        //    {
        //            return true;
        //    }
        //    return false;
        //}
        public static DataTable HienThiDSTDieuXe(DateTime ngayvanchuyen)
        {
            string cauLenh = "select trongtaiBangso, xe.BienSo from Xe inner join GiaCuoc on xe.IDGiaCuoc = giacuoc.ID where trangthai = 1 and bienso not in (select bienso from DieuXe where trangthai = N'Chờ' and( '" + ngayvanchuyen + "' <= vebai and '" + ngayvanchuyen + "' >= khoihanh))";
            return KetNoi.loadTable(cauLenh);
        }
    }
}

    
