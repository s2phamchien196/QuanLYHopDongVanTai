using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2.Class
{
    class LoaiHopDong
    {
        public static DataTable getLoaiHopDong()
        {
            string cauLenh = "select maloai,ten from LoaiHopDong";
            return KetNoi.loadTable(cauLenh);
        }
        public static string _getMaLoaihang(string i)
        {
            string cauLenh = "select ten from LoaiHopDong where maloai= '" + i + "' ";
            DataTable dt = KetNoi.loadTable(cauLenh);
            return dt.Rows[0][0].ToString();
        }
    }
}
