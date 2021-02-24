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
    public partial class QuanLiTaiXe : UserControl
    {
        public QuanLiTaiXe()
        {
            InitializeComponent();
        }

        private void QuanLiTaiXe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadInfo();
        }
        private void LoadDataGridView()
        {
            dataGridView1.DataSource = TaiXe.HienThiDSTaixe();
        }

        private void LoadInfo()
        {
            try
            {
                txtMaTaiXe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenTaiXe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiXe.ThemTaixe(txtTenTaiXe.Text, dtpNgaySinh.Text, cbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiXe.SuaTaixe(txtMaTaiXe.Text, txtTenTaiXe.Text, dtpNgaySinh.Text, cbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiXe.XoaTaixe(txtMaTaiXe.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadInfo();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiXe.Timkiemtaixe(txtTimKiem.Text);
        }


    }
}
