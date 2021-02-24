using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2.Class;

namespace WindowsFormsApplication2
{
    public partial class ThanhToan : UserControl
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            dGDonHang.DataSource = DonHang.TKDonHangTT("");
        }

        private void dGDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DonHang.madon = Int16.Parse(dGDonHang.CurrentRow.Cells[0].Value.ToString());
            Thanhtoan._addThanhtoan(dGDonHang.CurrentRow.Cells[0].Value.ToString());
            ThanhToanHD tt = new ThanhToanHD();
            tt.Show();
        }
    }
}
