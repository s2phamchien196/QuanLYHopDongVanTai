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
            dtpNgayHopDong.Value = DateTime.Now;
            loadKhachHang();
            loadlHang();
            reset();
            //dataGridView1.Rows[0].Cells[0].Size = ;
            cbKieuHopDong.Text = "Hợp đồng còn hạn";
            
           
        }
        void reset()
        {
            DateTime dt = DateTime.Now;
            txtSoHopDong.Text = "";
            txtNoiNhan.Text = "";
            txtNoiGiao.Text = "";
            txtKhoiLuong.Text = "";
            txtTenHD.Text = "";
            txtmathang.Text = "";
           txtHaoHut.Text="";
            cbKhachhang.Text = "";
            cbMaloaihang.Text = "";
            txtKhoiLuong.Text = "";
            dtpNgayHopDong.Value = dt;
            dtpNgayhethan.Value = dt;

        }
        void loadKhachHang()
        {
            cbKhachhang.DataSource = KhachHang.getKhachHang();
            cbKhachhang.DisplayMember = "TenKhachHang";
            cbKhachhang.ValueMember = "MaKhachHang";
        }
       
        void loadlHang()
        {
            cbMaloaihang.DataSource = loaihang._getLoaiHang();
            cbMaloaihang.DisplayMember = "TenLoaiHang";
            cbMaloaihang.ValueMember = "MaLoaiHang";
        }
        private void LoadDataGridView()
        {
            dataGridView1.DataSource = HopDong.HienthiHD("0");
        }

        private void LoadInfo()
        {
            try
            {
                
                txtSoHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dtpNgayHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNoiNhan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNoiGiao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
               
                cbMaloaihang.ValueMember = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtKhoiLuong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
                
            }
            catch { }
        }
        //


        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        void selecteHopDong()
        {
            DateTime ngayKi, ngayHetHan;
            txtSoHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbKhachhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbMaloaihang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTenHD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ngayKi = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            dtpNgayHopDong.Value = ngayKi;
            ngayHetHan = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dtpNgayhethan.Value = ngayHetHan;
            cbSoThang.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNoiNhan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtNoiGiao.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtmathang.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtHaoHut.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtKhoiLuong.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbMaloaihang_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbHopDong_SelectedValueChanged(object sender, EventArgs e)
        {
        }
         

        private void txtTimKiem_FontChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtSoHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            selecteHopDong();
        
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        string _getTenHopDong()
        {
            if (Int16.Parse(cbSoThang.Text) > 12)
                return "Dài Hạn";
            else return "Ngắn Hạn";
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            HopDong Hd = new HopDong(txtTenHD.Text, HopDong._getSohopdong(Int16.Parse(cbSoThang.Text)), Int16.Parse(cbKhachhang.SelectedValue.ToString()),Int16.Parse( cbMaloaihang.SelectedValue.ToString()), dtpNgayHopDong.Value, Int16.Parse(cbSoThang.Text), dtpNgayHopDong.Value.AddMonths(Int16.Parse(cbSoThang.Text)), Int16.Parse(txtKhoiLuong.Text), txtNoiNhan.Text, txtNoiGiao.Text, txtmathang.Text, Int16.Parse(txtHaoHut.Text));
            HopDong.themHD();
            LoadDataGridView();
            LoadInfo();
        }

        private void cbSoThang_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cbSoThang_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTenHD.Text = _getTenHopDong();
            dtpNgayhethan.Value = dtpNgayHopDong.Value.AddMonths(Int16.Parse(cbSoThang.Text));
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            HopDong.huyHD(txtSoHopDong.Text);
            LoadDataGridView();
            LoadInfo();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (cbKieuHopDong.Text == "All")
            {
                dataGridView1.DataSource = HopDong.Timkiemhopdong("'or 1='1",txtTimKiem.Text);
            }
            if (cbKieuHopDong.Text == "Hợp đồng còn hạn")
            {
                dataGridView1.DataSource = HopDong.Timkiemhopdong("0",txtTimKiem.Text);
            }
            if (cbKieuHopDong.Text == "Hợp đồng hết hạn")
            {
                dataGridView1.DataSource = HopDong.Timkiemhopdong("1", txtTimKiem.Text);
            }
            
        }

        private void cbKieuHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbKieuHopDong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbKieuHopDong.Text == "All")
            {
                dataGridView1.DataSource = HopDong.HienthiHD("'or 1='1");
            }
            if (cbKieuHopDong.Text == "Hợp đồng còn hạn") {
                dataGridView1.DataSource = HopDong.HienthiHD("0");
            }
            if (cbKieuHopDong.Text == "Hợp đồng hết hạn") {
                dataGridView1.DataSource = HopDong.HienthiHD("1");
            }
        }

    }
}
