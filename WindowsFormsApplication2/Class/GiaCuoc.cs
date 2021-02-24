using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication2.Class
{
    class GiaCuoc
    {

        public static int  Kmdau, Kmtieptheo, Thoigiancho,ID;
        public static string TrongTai;
        public GiaCuoc(string trongtai, int kmdau,int kmtieptheo, int thoigiancho)
        {
            TrongTai = trongtai;
            Kmdau = kmdau;
            Kmtieptheo = kmtieptheo;
            Thoigiancho = thoigiancho;
        }

        public static void _theoGiaCuoc()
        {
          //  MessageBox.Show(TrongTai + "\n" + Kmdau + "\n" + Kmtieptheo + "\n" + Thoigiancho);
            KetNoi.ThucThi("insert into GiaCuoc(trongtai,kmdau,kmtieptheo,thoigiancho) values(N'" + TrongTai + "','" + Kmdau + "','" + Kmtieptheo + "','" + Thoigiancho + "')");
        }
        public static DataTable _getGiaCuoc()
        {
            return KetNoi.loadTable("select ID,TrongTai from giacuoc");
        }

        public static void _updateGiaCuoc(string ID)
        {
            KetNoi.ThucThi("update GiaCuoc set trongtai = N'"+TrongTai+"', kmdau ='" + Kmdau + "',kmtieptheo='" + Kmtieptheo + "',thoigiancho='" + Thoigiancho + "'  where  ID = '" + ID + "' ");

        }

        public static DataTable _hienThi()
        {
            return KetNoi.loadTable("select * from giacuoc");
        }

        public static DataTable _timKiem(string s)
        {
            return KetNoi.loadTable("select * from giacuoc where TrongTai like '%"+s+"%'");
        }

        public static void _delete(string ID)
        {
             KetNoi.ThucThi("DELete  from giacuoc where ID = '"+ID+"'");
        }
    }
}
