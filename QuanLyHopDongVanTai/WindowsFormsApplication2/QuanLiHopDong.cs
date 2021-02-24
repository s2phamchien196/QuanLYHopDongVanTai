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
    public partial class QuanLiHopDong : UserControl
    {
        public QuanLiHopDong()
        {
            InitializeComponent();
        }

        private void QuanLiHopDong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadInfo();
        }
        private void LoadDataGridView()
        {
            dataGridView1.DataSource = HopDong.HienthiHD();
        }

        private void LoadInfo()
        {
            try
            {
                txtLoaiHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSoHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dtpNgayHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNoiNhan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNoiGiao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dtpNgayBaoGia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dtpGiaoTuNgay.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dtpGiaoDenNgay.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDatCoc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtLoaiHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtKhoiLuong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtHaoHut.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HopDong.themHD(txtLoaiHopDong.Text, txtNoiNhan.Text, txtNoiGiao.Text, txtDatCoc.Text, txtKhoiLuong.Text, txtHaoHut.Text, dtpNgayHopDong.Text, dtpGiaoTuNgay.Text, dtpGiaoDenNgay.Text, dtpNgayBaoGia.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HopDong.suaHD(txtLoaiHopDong.Text, txtNoiNhan.Text, txtNoiGiao.Text, txtSoHopDong.Text, txtDatCoc.Text, txtKhoiLuong.Text, txtHaoHut.Text, dtpNgayHopDong.Text, dtpGiaoTuNgay.Text, dtpGiaoDenNgay.Text, dtpNgayBaoGia.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HopDong.huyHD(txtSoHopDong.Text);
            LoadDataGridView();
            LoadInfo();
        }
    }
}
