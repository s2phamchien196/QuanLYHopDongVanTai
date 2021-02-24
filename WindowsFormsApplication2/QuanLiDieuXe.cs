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
    public partial class QuanLiDieuXe : UserControl
    {
        public QuanLiDieuXe()
        {
            InitializeComponent();
        }
        private void QuanLiDieuXe_Load(object sender, EventArgs e)
        {
          //  dgXe.DataSource = Xe.HienThiDSTDieuXe();
            dgKhachHang.DataSource = KhachHang._dsKhachHang();
            dgDieuXe.Font = new Font("", 11);
            dgLaiPhu.Font = new Font("", 11);
            dgTaiXe.Font = new Font("", 11);
            dgKhachHang.Font = new Font("", 11);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgXe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
          
            
        }
      
        private void dgDieuXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getTaiXe();
        }

        private void dgTaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
        void getTaiXe()
        {
           // MessageBox.Show(dgDieuXe.CurrentRow.Cells[3].Value.ToString());
            DateTime dt;
            dt = DateTime.Parse(dgDieuXe.CurrentRow.Cells[3].Value.ToString()).AddMinutes(5);
            dgTaiXe.DataSource = TaiXe.HienThiLaiXechinh(String.Format("{0:yyyy-MM-dd HH:mm tt}", dt));
            dgLaiPhu.DataSource = TaiXe.HienThiLaiXePhu(String.Format("{0:yyyy-MM-dd HH:mm tt}", dt));
       
        }
        private void dgLaiPhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        string kieu;
        private void dgDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgDieuXe.DataSource = DieuXe.HienthiDieuxe(dgKhachHang.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgTaiXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
            DieuXe._updateTaiXe(dgTaiXe.CurrentRow.Cells[0].Value.ToString(), dgDieuXe.CurrentRow.Cells[0].Value.ToString());
           // DieuXe._HienThiTaiXe(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
            dgDieuXe.CurrentRow.Cells[7].Value = dgTaiXe.CurrentRow.Cells[1].Value.ToString();
            getTaiXe();

        }

        private void dgLaiPhu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DieuXe._updateTaiXePhu(dgLaiPhu.CurrentRow.Cells[0].Value.ToString(), dgDieuXe.CurrentRow.Cells[0].Value.ToString());
           // DieuXe._HienThiTaiXe(dgDieuXe.CurrentRow.Cells[0].Value.ToString());
            dgDieuXe.CurrentRow.Cells[8].Value = dgLaiPhu.CurrentRow.Cells[1].Value.ToString();
            getTaiXe();
        }

        private void txtTk_TextChanged(object sender, EventArgs e)
        {
            dgKhachHang.DataSource = KhachHang.TimKHDieuxe(txtTk.Text);
        }

        private void raAll_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void raBCho_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void raBSanSang_CheckedChanged(object sender, EventArgs e)
        {
      
        }

      
    }
}
