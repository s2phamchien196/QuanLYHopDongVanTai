using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace WindowsFormsApplication2.Class
{
    class loaihang
    {
        
        public static DataTable _getLoaiHang()
        {
            string sql = "select * from LoaiHang";
            return KetNoi.loadTable(sql);
        }
        public static string _getMaLoaiHang(string i)
        {
            string cauLenh = "select TenLoaiHang from LoaiHang where MaLoaiHang= '" + i + "' ";
            DataTable dt = KetNoi.loadTable(cauLenh);
            return dt.Rows[0][0].ToString();
        }

    }
}
