using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2.Class;


namespace WindowsFormsApplication2
{
    public partial class AddDonHang : Form
    {
        public AddDonHang()
        {
            InitializeComponent();
        }

        private void AddDonHang_Load(object sender, EventArgs e)
        {
           lbSHD.Text = HopDong.sohopdong;
           lbKH.Text = KhachHang.tenkhachhang;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DonHang DH = new DonHang(0, Int32.Parse(txtkhoiluong.Text), Int32.Parse(txtkhoiluong.Text), int.Parse(String.Format("{0:G}", Double.Parse(txtDatCoc.Text))), "Chờ", txtmota.Text, dtThoiGianVanChuyen.Value, lbSHD.Text, Int16.Parse(txtKhoangCach.Text));
            DonHang.addDonHang();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDatCoc_TextChanged(object sender, EventArgs e)
        {
            if (txtDatCoc.Text != "")
            {
                string khachtra = String.Format("{0:G}", Double.Parse(txtDatCoc.Text));
                txtDatCoc.Text = string.Format("{0:n0}", int.Parse(khachtra));

                txtDatCoc.SelectionStart = txtDatCoc.Text.Length;
                txtDatCoc.SelectionLength = 0;
            }
        }
    }
}
