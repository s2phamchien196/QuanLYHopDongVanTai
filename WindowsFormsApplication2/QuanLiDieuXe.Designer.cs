namespace WindowsFormsApplication2
{
    partial class QuanLiDieuXe
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgNgayVanTai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLaiPhu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTaiXe = new System.Windows.Forms.DataGridView();
            this.MâTiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDieuXe = new System.Windows.Forms.DataGridView();
            this.SoDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaiPhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDieuXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vận tải ngày:";
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(7, 44);
            this.txtTk.Multiline = true;
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(201, 32);
            this.txtTk.TabIndex = 3;
            this.txtTk.TextChanged += new System.EventHandler(this.txtTk_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vận tải cho Công ty:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.dgNgayVanTai);
            this.panel3.Controls.Add(this.txtTk);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dgLaiPhu);
            this.panel3.Controls.Add(this.dgTaiXe);
            this.panel3.Controls.Add(this.dgKhachHang);
            this.panel3.Controls.Add(this.dgDieuXe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 660);
            this.panel3.TabIndex = 1;
            // 
            // dgNgayVanTai
            // 
            this.dgNgayVanTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNgayVanTai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dgNgayVanTai.Location = new System.Drawing.Point(351, 47);
            this.dgNgayVanTai.Name = "dgNgayVanTai";
            this.dgNgayVanTai.Size = new System.Drawing.Size(200, 26);
            this.dgNgayVanTai.TabIndex = 4;
            this.dgNgayVanTai.Value = new System.DateTime(2019, 5, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1219, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Xé Phụ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1203, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Xé Chính";
            // 
            // dgLaiPhu
            // 
            this.dgLaiPhu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLaiPhu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgLaiPhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLaiPhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgLaiPhu.Location = new System.Drawing.Point(1085, 382);
            this.dgLaiPhu.Name = "dgLaiPhu";
            this.dgLaiPhu.Size = new System.Drawing.Size(217, 263);
            this.dgLaiPhu.TabIndex = 1;
            this.dgLaiPhu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLaiPhu_CellClick);
            this.dgLaiPhu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLaiPhu_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaTaiXe";
            this.dataGridViewTextBoxColumn3.HeaderText = "MTX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenTaiXe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tài Xế";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgTaiXe
            // 
            this.dgTaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTaiXe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgTaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MâTiXe,
            this.TenTaiXe});
            this.dgTaiXe.Location = new System.Drawing.Point(1085, 90);
            this.dgTaiXe.Name = "dgTaiXe";
            this.dgTaiXe.Size = new System.Drawing.Size(217, 263);
            this.dgTaiXe.TabIndex = 1;
            this.dgTaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaiXe_CellClick);
            this.dgTaiXe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaiXe_CellDoubleClick);
            // 
            // MâTiXe
            // 
            this.MâTiXe.DataPropertyName = "MaTaiXe";
            this.MâTiXe.HeaderText = "MTX";
            this.MâTiXe.Name = "MâTiXe";
            this.MâTiXe.Width = 40;
            // 
            // TenTaiXe
            // 
            this.TenTaiXe.DataPropertyName = "TenTaiXe";
            this.TenTaiXe.HeaderText = "Tài Xế";
            this.TenTaiXe.Name = "TenTaiXe";
            // 
            // dgKhachHang
            // 
            this.dgKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.dgKhachHang.Location = new System.Drawing.Point(0, 90);
            this.dgKhachHang.Name = "dgKhachHang";
            this.dgKhachHang.Size = new System.Drawing.Size(242, 555);
            this.dgKhachHang.TabIndex = 1;
            this.dgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDonHang_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "makhachhang";
            this.dataGridViewTextBoxColumn6.HeaderText = "MãKH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dgDieuXe
            // 
            this.dgDieuXe.AllowUserToAddRows = false;
            this.dgDieuXe.AllowUserToDeleteRows = false;
            this.dgDieuXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDieuXe.BackgroundColor = System.Drawing.Color.White;
            this.dgDieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDieuXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoDon,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column8,
            this.tinhtrang});
            this.dgDieuXe.Location = new System.Drawing.Point(248, 90);
            this.dgDieuXe.MultiSelect = false;
            this.dgDieuXe.Name = "dgDieuXe";
            this.dgDieuXe.ReadOnly = true;
            this.dgDieuXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDieuXe.Size = new System.Drawing.Size(831, 555);
            this.dgDieuXe.TabIndex = 0;
            this.dgDieuXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDieuXe_CellClick);
            // 
            // SoDon
            // 
            this.SoDon.DataPropertyName = "MaDieuXe";
            this.SoDon.FillWeight = 105.471F;
            this.SoDon.HeaderText = "Mã điều xe";
            this.SoDon.Name = "SoDon";
            this.SoDon.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BienSo";
            this.Column2.FillWeight = 105.471F;
            this.Column2.HeaderText = "Biển Số";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenLoaiHang";
            this.Column4.FillWeight = 105.471F;
            this.Column4.HeaderText = "Loại Hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngayvanchuyen";
            this.Column3.FillWeight = 105.471F;
            this.Column3.HeaderText = "Ngày vận chuyển";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thuccho";
            this.Column5.FillWeight = 50.76142F;
            this.Column5.HeaderText = "Khối Lượng hàng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "noinhan";
            this.Column1.FillWeight = 105.471F;
            this.Column1.HeaderText = "Nơi nhân";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "noigiao";
            this.Column6.FillWeight = 105.471F;
            this.Column6.HeaderText = "Nơi giao";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenTaiXe";
            this.Column7.FillWeight = 105.471F;
            this.Column7.HeaderText = "Lái Chính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenTaiXe1";
            this.Column8.FillWeight = 105.471F;
            this.Column8.HeaderText = "Phụ Lái";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "trangthai";
            this.tinhtrang.FillWeight = 105.471F;
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 660);
            this.panel1.TabIndex = 1;
            // 
            // QuanLiDieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QuanLiDieuXe";
            this.Size = new System.Drawing.Size(1305, 660);
            this.Load += new System.EventHandler(this.QuanLiDieuXe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaiPhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDieuXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dgNgayVanTai;
        private System.Windows.Forms.DataGridView dgDieuXe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgTaiXe;
        private System.Windows.Forms.DataGridView dgLaiPhu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MâTiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;

    }
}
