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
    public partial class ThanhToanHD : Form
    {
        public ThanhToanHD()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToanHD_Load(object sender, EventArgs e)
        {
           
            DataTable dt = Thanhtoan._getThongtin(DonHang.madon.ToString());
            DataTable dt1 = Thanhtoan._getThoiGiancho(DonHang.madon.ToString());
            lbHD.Text = dt.Rows[0][0].ToString();
            LBKH.Text = dt.Rows[0][1].ToString();
            lbDH.Text = dt.Rows[0][2].ToString();
            lbLH.Text = dt.Rows[0][3].ToString();
            lbKL.Text = dt.Rows[0][4].ToString();
            lbDC.Text = dt.Rows[0][5].ToString();
            lbTT.Text = dt.Rows[0][6].ToString();
            lbTGDI.Text = dt.Rows[0][7].ToString();
            lbTGC.Text = dt1.Rows[0][0].ToString();
            lbGuiQD.Text = dt1.Rows[0][1].ToString();
            lbCanTra.Text = (Int32.Parse(lbTT.Text) + Int32.Parse(lbTT.Text) * 0.1 - Int32.Parse(lbDC.Text)).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            lbtraLai.Text = (int.Parse(String.Format("{0:G}", Double.Parse(textBox1.Text))) - Int32.Parse(lbCanTra.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thanhtoan._updateThanhToan(DonHang.madon.ToString(), textBox1.Text, lbtraLai.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string khachtra = String.Format("{0:G}", Double.Parse(textBox1.Text));
                textBox1.Text = string.Format("{0:n0}", int.Parse(khachtra));

                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
        }
    }
}
