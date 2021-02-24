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

            cbTrongtai.DataSource = GiaCuoc._getGiaCuoc();
            cbTrongtai.DisplayMember = "TrongTai";
            cbTrongtai.ValueMember = "ID";
            LoadDataGridView();
            LoadInfo();
            load_cbTaiXe();
            dataGridView1.Font = new Font("", 14);
        }
        //
        void Reset()
        {
            txtBienSo.Text = "";
           // txtBienSo.Enabled = true;
            txtLoaiXe.Text = "";
            txtMota.Text = "";
            txtTimKiem.Text = "";
        }
        //
        void NewXe()
        {
            if (txtBienSo.Text != "" && txtLoaiXe.Text != "" && txtMota.Text != "")
            {
                Xe Xe = new Xe(txtBienSo.Text, txtLoaiXe.Text, dtpHanBaoHiem.Value, txtMota.Text, Int16.Parse(cbTrongtai.SelectedValue.ToString()));
            }
            else MessageBox.Show("Bạn cần điền đầy đủ thông tin!!!");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NewXe();
            Xe.Themxe();
            dataGridView1.DataSource = Xe.HienThiDSTxe();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NewXe();
            Xe.Suaxe();
            dataGridView1.DataSource = Xe.HienThiDSTxe();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xe.Xoaxe(txtBienSo.Text);
            dataGridView1.DataSource = Xe.HienThiDSTxe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtBienSo.Enabled = false;
            txtBienSo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLoaiXe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbTrongtai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime dt = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            dtpHanBaoHiem.Value = dt;
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = Xe.HienThiDSTxe();

        }

        private void LoadInfo()
        {
          
        }
        private void load_cbTaiXe()
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
        }

        private void cbTrongtai_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Xe.Timxe(txtTimKiem.Text);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.DataSource = Xe.HienThiDSTxe();
        }
    }
}
