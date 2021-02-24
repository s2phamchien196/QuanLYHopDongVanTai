using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class LichTrinh
    {
        public static void Cap_Nhap(string MaDieuXe, string diadiem, string tinhtrang,string ghichu)
        {
            string sql = "insert into LichTrinh(thoigian, MaDieuXe,diadiem,tinhtrang,ghichu) values ('" + DateTime.Now + "','" + MaDieuXe + "',N'"+diadiem+"',N'"+tinhtrang+"',N'"+ghichu+"')";
            KetNoi.ThucThi(sql);
        }
        public static DataTable HienThi(string MaDieuXe)
        {
            string sql = "select thoigian,diadiem,tinhtrang,ghichu from lichtrinh where madieuxe ='"+MaDieuXe+"'";
            return KetNoi.loadTable(sql);
        }
        public static int _thoiGiabCho(string madieu)
        {
            DateTime dt = DateTime.Parse(KetNoi.loadTable("select thoigian from LichTrinh where MaDieuXe = '" + madieu + "' and tinhtrang = N'Đang Chờ' ").Rows[0][0].ToString());
            DateTime dt2 = DateTime.Parse(KetNoi.loadTable("select thoigian from LichTrinh where MaDieuXe = '" + madieu + "' and tinhtrang = N'KT Chờ' ").Rows[0][0].ToString());
            TimeSpan KQ = dt2 - dt;
           return  KQ.Hours * 60  + KQ.Minutes;
        }

        public static int _thoiGiabDi(string madieu)
        {
            DateTime dt = DateTime.Parse(KetNoi.loadTable("select top(1) thoigian from LichTrinh where MaDieuXe = '" + madieu + "' and tinhtrang = N'Đang vận chuyển' ").Rows[0][0].ToString());
            DateTime dt2 = DateTime.Parse(KetNoi.loadTable("select thoigian from LichTrinh where MaDieuXe = '" + madieu + "' and tinhtrang = N'KT vận chuyên' ").Rows[0][0].ToString());
            TimeSpan KQ = dt2 - dt;
            return KQ.Days*24 + KQ.Hours + KQ.Minutes/60;
        }
        public static int _quadem(string madieu)
        {
            return  Int16.Parse( KetNoi.loadTable("select COUNT(thoigian) from LichTrinh where MaDieuXe = '"+madieu+"' and tinhtrang = N'qua đêm'").Rows[0][0].ToString());
        }
    }
}
