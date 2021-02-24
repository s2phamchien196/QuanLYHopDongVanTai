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
    public partial class QuanLiDonHang : UserControl
    {
        public QuanLiDonHang()
        {
            InitializeComponent();
        }
        private void QuanLiDonHang_Load_1(object sender, EventArgs e)
        {
            cbLuaChon.Text = "All";
           // dGKeHoach.DataSource = DonHang.hienthi();
            dgHopDong.DataSource = HopDong.HienthiHD("0");
            dGKeHoach.DataSource = DonHang.hienthi("Chờ");
            dgHopDong.Font = new Font("", 12);
            dGKeHoach.Font = new Font("", 12);
            
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
          
        }
        void AddHopDong(string SoHopDong, string Tuyen, string pallet)
        {
       
        }
        DateTime ngaydi, ngayve;
        private void dGKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ngaydi = DateTime.Parse(dGKeHoach.CurrentRow.Cells[5].Value.ToString());
            ngayve = ngaydi.AddHours(Int16.Parse(dGKeHoach.CurrentRow.Cells[8].Value.ToString())*2 / 40);
          
            lbKhachHang.Text = "Khách Hàng :";
            lbMadon.Text = "";
            lbKhachHang.Text += dGKeHoach.CurrentRow.Cells[1].Value.ToString();
            lbMadon.Text += dGKeHoach.CurrentRow.Cells[0].Value.ToString();
            dGxe.DataSource = Xe.HienThiDSTDieuXe(ngaydi);
            dgNhomXe.DataSource = DieuXe.DSDieuXe(dGKeHoach.CurrentRow.Cells[0].Value.ToString());
        }
        //
        void loadxe()
        {
 
        }
        //

        private void dgHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        void TaoLichTrinh(string MaDieuXe)
        {
            
        }

        //

        void NewDieuXe()
        {
            DieuXe DX = new DieuXe(dGxe.CurrentRow.Cells[1].Value.ToString(), "Chờ", 0, Int16.Parse(dGKeHoach.CurrentRow.Cells[0].Value.ToString()), thuccho, 0, 0, 0, 0, ngaydi, ngayve);
            DieuXe.addDieuxe();
            dgNhomXe.DataSource = DieuXe.HienthiDieuxe(dGKeHoach.CurrentRow.Cells[0].Value.ToString());
            DonHang._addSoLuongXe(DieuXe.Madon);
            DonHang._updateKLuongConlai(DieuXe.Madon, klcl-thuccho);
            dGKeHoach.DataSource = DonHang.hienthi("Chờ");
            dGxe.DataSource = Xe.HienThiDSTDieuXe(ngaydi);

        }
        //
        float thuccho;
        float klcl, tt;

        //
        private void dGxe_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void dgNhomXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void m_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLuaChon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgHopDong_DoubleClick(object sender, EventArgs e)
        {
            HopDong.sohopdong = dgHopDong.CurrentRow.Cells[0].Value.ToString();
            KhachHang.tenkhachhang = dgHopDong.CurrentRow.Cells[1].Value.ToString();
            AddDonHang f = new AddDonHang();
            this.Hide();
            f.Show();
            this.Show();

           
        }

        private void cbLuaChon_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbLuaChon.Text == "All")
            {
                dGKeHoach.DataSource = DonHang.hienthi("'or 1= '1");
            }
               if(cbLuaChon.Text == "Đơn chưa đủ xe vận chuyển")
               {
                   dGKeHoach.DataSource = DonHang.hienthi("Chờ");
               }


                      if(cbLuaChon.Text == "Đơn đủ  sẵng sàng vận chuyển")
                      {
                          dGKeHoach.DataSource = DonHang.hienthi("Sẵn sàng");
                      }
                      if (cbLuaChon.Text == "Đơn hoàn thành")
                      {
                          dGKeHoach.DataSource = DonHang.hienthi("Hoàn Thành");
                      }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGxe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klcl = float.Parse(dGKeHoach.CurrentRow.Cells[4].Value.ToString());
            tt = float.Parse(dGxe.CurrentRow.Cells[0].Value.ToString());
            if (klcl != 0)
            {
                if (klcl > tt)
                {
                    thuccho = tt;
                }
                else { thuccho = klcl; }
                NewDieuXe();
                dgNhomXe.DataSource = DieuXe.DSDieuXe(dGKeHoach.CurrentRow.Cells[0].Value.ToString());

            }
            else MessageBox.Show("Đã đủ xe vận chuyển");

        }
        //
        
        //
        private void dgNhomXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dGKeHoach.DataSource = DonHang.hienthi("Chờ");
        }

      
    }
}
