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
    public partial class QuanLiXe : UserControl
    {
        public QuanLiXe()
        {
            InitializeComponent();
        }

        private void QuanLiXe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xe.Themxe(txtBienSo.Text, txtLoaiXe.Text, txtTaiXe.Text, txtPallet.Text, txtTrongTai.Text, dtpHanBaoHiem.Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Xe.Suaxe(txtBienSo.Text, txtLoaiXe.Text, txtTaiXe.Text, txtPallet.Text, txtTrongTai.Text, dtpHanBaoHiem.Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xe.Xoaxe(txtBienSo.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadInfo();
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = Xe.HienThiDSTxe();
        }

        private void LoadInfo()
        {
            txtBienSo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLoaiXe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPallet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTaiXe.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTrongTai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtpHanBaoHiem.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
