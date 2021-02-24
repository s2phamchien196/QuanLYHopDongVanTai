namespace WindowsFormsApplication2
{
    partial class ThanhToan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dGDonHang = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(3, 32);
            this.txtTk.Multiline = true;
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(292, 32);
            this.txtTk.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm Kiếm";
            // 
            // dGDonHang
            // 
            this.dGDonHang.AllowUserToAddRows = false;
            this.dGDonHang.AllowUserToDeleteRows = false;
            this.dGDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dGDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dGDonHang.Location = new System.Drawing.Point(3, 70);
            this.dGDonHang.Name = "dGDonHang";
            this.dGDonHang.ReadOnly = true;
            this.dGDonHang.Size = new System.Drawing.Size(1216, 450);
            this.dGDonHang.TabIndex = 6;
            this.dGDonHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGDonHang_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaDonHang";
            this.Column4.FillWeight = 79.95062F;
            this.Column4.HeaderText = "Mã đơn hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tenkhachhang";
            this.Column5.FillWeight = 115.448F;
            this.Column5.HeaderText = "Tên khách hàng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "soluongxe";
            this.Column6.FillWeight = 79.95062F;
            this.Column6.HeaderText = "Số lượng xe";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "khoiluong";
            this.Column7.FillWeight = 79.95062F;
            this.Column7.HeaderText = "Khối lượng(Tấn)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sohangconlai";
            this.Column8.FillWeight = 79.95062F;
            this.Column8.HeaderText = "Khối lượng còn lại";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ngayvanchuyen";
            this.Column12.FillWeight = 162.9566F;
            this.Column12.HeaderText = "Ngày vận chuyển";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "mota";
            this.Column13.FillWeight = 138.6308F;
            this.Column13.HeaderText = "Mô tả";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "datcoc";
            this.Column14.FillWeight = 79.95062F;
            this.Column14.HeaderText = "Đặt cộc";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "sokm";
            this.Column15.FillWeight = 93.55405F;
            this.Column15.HeaderText = "Khoảng cách(KM)";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.dGDonHang);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.label6);
            this.Name = "ThanhToan";
            this.Size = new System.Drawing.Size(1219, 523);
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}
