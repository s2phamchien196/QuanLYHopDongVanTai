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
    public partial class KetThuc : Form
    {
        public KetThuc()
        {
            InitializeComponent();
        }

        private void KetThuc_Load(object sender, EventArgs e)
        {
            txtthoigiancho.Text = DieuXe.Thoigiancho.ToString();
            txtthoigiandi.Text = DieuXe.Thoigiandi.ToString();
            txtquadem.Text = DieuXe.Quadem.ToString();
            lbMaDX.Text += DieuXe.Madon.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DieuXe._ktDieuXe(DieuXe.Madon.ToString(), txtthoigiancho.Text, txtthoigiandi.Text, txtquadem.Text);
            DonHang._updateTrangThai(DieuXe.Madon.ToString(),txtquangduong.Text);
            MessageBox.Show("Hoàn thành!!");
            DieuXe._thanhtien(DieuXe.Madon.ToString());
            this.Close();
        }
    }
}
