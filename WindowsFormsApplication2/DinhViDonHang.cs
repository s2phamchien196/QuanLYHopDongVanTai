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
    public partial class DinhViDonHang : UserControl
    {
        public DinhViDonHang()
        {
            InitializeComponent();
        }

        private void DinhViDonHang_Load(object sender, EventArgs e)
        {
            dgDieuXe.DataSource = DieuXe._HienthiDieuxe_DinhVi();
            cbTrangThai.Text = "Đang vận chuyển";
        }

        private void dGKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dgXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LichTrinh.Cap_Nhap(dgDieuXe.CurrentRow.Cells[0].Value.ToString(), txtDiaDiem.Text,cbTrangThai.Text, txtGhiChu.Text);
            dgDinhVi.DataSource = LichTrinh.HienThi(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgDieuXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTenTX.Text = dgDieuXe.CurrentRow.Cells[8].Value.ToString();
            lbSDT.Text = dgDieuXe.CurrentRow.Cells[9].Value.ToString();
            lbTuyenDuong.Text = dgDieuXe.CurrentRow.Cells[6].Value.ToString() + " / " + dgDieuXe.CurrentRow.Cells[7].Value.ToString();
            dgDinhVi.DataSource = LichTrinh.HienThi(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dgDieuXe.DataSource = DieuXe._TKDieuxe(txtTK.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgDieuXe.DataSource = DieuXe._HienthiDieuxe_DinhVi();
        }

        private void dgDieuXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
          //  DieuXe.Thoigiancho = KetNoi.ThucThi()
            DieuXe.Thoigiancho = LichTrinh._thoiGiabCho(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
          DieuXe.Thoigiandi = LichTrinh._thoiGiabDi(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
          DieuXe.Quadem = LichTrinh._quadem(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
          DieuXe.Madon =  Int16.Parse(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
       
           KetThuc kt = new KetThuc();
            kt.Show();
        }
    }
}
