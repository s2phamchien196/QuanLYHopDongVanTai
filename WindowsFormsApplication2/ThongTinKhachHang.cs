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
    public partial class ThongTinKhachHang : UserControl
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadInfo();
        }
        private void LoadDataGridView()
        {
            dataGridView1.DataSource = KhachHang.HienThiDSKH();
        }
        private void LoadInfo()
        {
            try
            {
                txtMaKhachHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtSoTaiKhoan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtMaSothue.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadInfo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang.ThemKH(txtTenKhachHang.Text, txtSDT.Text, txtDiaChi.Text, txtSoTaiKhoan.Text, txtMaSothue.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang.SuaKH(txtMaKhachHang.Text, txtTenKhachHang.Text, txtSDT.Text, txtDiaChi.Text, txtSoTaiKhoan.Text, txtMaSothue.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang.XoaKH(txtMaKhachHang.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KhachHang.TimKH(txtTimKiem.Text);
        }
    }
}
