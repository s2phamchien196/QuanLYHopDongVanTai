using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit(); 

        }

        bool kiemtra(string tk, string mk)
        {
            if (KetNoi.loadTable("select * from taikhoan where tendangnhap = '" + tk + "' and matkhau ='" + mk + "'").Rows.Count > 0)
            {
               
                return true;

            }
            else return false;

        }

        private void btn_dnhap_Click(object sender, EventArgs e)
        {
            if (kiemtra(txtTaikhoan.Text, txtMatkhau.Text) == true)
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!");
        }
    }
}
