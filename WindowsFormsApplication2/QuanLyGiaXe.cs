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
    public partial class QuanLyGiaXe : UserControl
    {
        public QuanLyGiaXe()
        {
            InitializeComponent();
        }

        void reset()
        {
            txtGioCho.Text = "";
            txtKmdau.Text = "";
            txtKmTiepTheo.Text = "";
            txtGioCho.Text = "";
            txtTrongTai.Text = "";
        }
        void NewGiaCuoc()
        {
            GiaCuoc GC = new GiaCuoc(txtTrongTai.Text, Int32.Parse(txtKmdau.Text), Int32.Parse(txtKmTiepTheo.Text), Int32.Parse(txtGioCho.Text));
        }
        //
        private void btnthem_Click(object sender, EventArgs e)
        {
            NewGiaCuoc();
            GiaCuoc._theoGiaCuoc();
           dgGC.DataSource = GiaCuoc._hienThi();
            reset();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NewGiaCuoc();
            GiaCuoc._updateGiaCuoc(dgGC.CurrentRow.Cells[0].Value.ToString());
            dgGC.DataSource = GiaCuoc._hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaCuoc._delete(dgGC.CurrentRow.Cells[0].Value.ToString());
            dgGC.DataSource = GiaCuoc._hienThi();
            reset();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dgGC.DataSource = GiaCuoc._timKiem(txtTK.Text);
        }

        private void QuanLyGiaXe_Load(object sender, EventArgs e)
        {
            dgGC.DataSource = GiaCuoc._hienThi();
            dgGC.Font = new Font("", 14);
        }

        private void dgGC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtTrongTai.Text = dgGC.CurrentRow.Cells[1].Value.ToString();
            txtKmdau.Text = dgGC.CurrentRow.Cells[2].Value.ToString();
            txtKmTiepTheo.Text = dgGC.CurrentRow.Cells[3].Value.ToString();
            txtGioCho.Text = dgGC.CurrentRow.Cells[4].Value.ToString();
               
        }

    }
}
