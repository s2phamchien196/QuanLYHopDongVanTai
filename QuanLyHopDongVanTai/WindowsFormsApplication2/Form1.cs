using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (!checkTab("Thông tin khách hàng"))
            {
                ThongTinKhachHang usercontrol = new ThongTinKhachHang();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Thông tin khách hàng", "ttkh");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản lí hợp đồng"))
            {
                QuanLiHopDong usercontrol = new QuanLiHopDong();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản lí hợp đồng", "qlhd");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản lí xe"))
            {
                QuanLiXe usercontrol = new QuanLiXe();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản lí xe", "qlx");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản lí tài xế"))
            {
                QuanLiTaiXe usercontrol = new QuanLiTaiXe();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản lí tài xế", "qltx");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản lí đơn hàng"))
            {
                QuanLiDonHang usercontrol = new QuanLiDonHang();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản lí đơn hàng", "qldh");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản lí điều xe"))
            {
                QuanLiDieuXe usercontrol = new QuanLiDieuXe();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản lí điều xe", "qldx");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (!checkTab("Định vị đơn hàng"))
            {
                DinhViDonHang usercontrol = new DinhViDonHang();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Định vị đơn hàng", "dvdh");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private bool checkTab(string tabName)
        {
            foreach (TabFormItem tab in tabFormControl1.Items)
            {
                if(tab.Text.Equals(tabName)){
                    tabFormControl1.SelectedTab = tab;
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi.Open();
           
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KetNoi.Close();
        }
    }
}
