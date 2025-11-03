namespace lecongdat_1150080130_bai4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTimMaSP = new System.Windows.Forms.TextBox();
            this.txtTimTenSP = new System.Windows.Forms.TextBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(950, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblMaSP + lblTenSP + ô tìm kiếm
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(20, 55);
            this.lblMaSP.Text = "Mã SP:";
            this.txtTimMaSP.Location = new System.Drawing.Point(75, 52);
            this.txtTimMaSP.Size = new System.Drawing.Size(150, 23);

            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(260, 55);
            this.lblTenSP.Text = "Tên SP:";
            this.txtTimTenSP.Location = new System.Drawing.Point(320, 52);
            this.txtTimTenSP.Size = new System.Drawing.Size(200, 23);

            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(20, 90);
            this.dgvDanhSach.RowTemplate.Height = 25;
            this.dgvDanhSach.Size = new System.Drawing.Size(500, 330);
            this.dgvDanhSach.TabIndex = 5;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.txtGhiChu);
            this.grpChiTiet.Controls.Add(this.label7);
            this.grpChiTiet.Controls.Add(this.txtDonGia);
            this.grpChiTiet.Controls.Add(this.label6);
            this.grpChiTiet.Controls.Add(this.txtDonVi);
            this.grpChiTiet.Controls.Add(this.label5);
            this.grpChiTiet.Controls.Add(this.dtpNgayHH);
            this.grpChiTiet.Controls.Add(this.label4);
            this.grpChiTiet.Controls.Add(this.dtpNgaySX);
            this.grpChiTiet.Controls.Add(this.label3);
            this.grpChiTiet.Controls.Add(this.txtTenSP);
            this.grpChiTiet.Controls.Add(this.label2);
            this.grpChiTiet.Controls.Add(this.txtMaSP);
            this.grpChiTiet.Controls.Add(this.label1);
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.Location = new System.Drawing.Point(540, 50);
            this.grpChiTiet.Size = new System.Drawing.Size(380, 370);
            this.grpChiTiet.Text = "Chi tiết sản phẩm";

            // Các label + textbox bên phải
            this.label1.Text = "Mã SP:"; this.label1.Location = new System.Drawing.Point(15, 30);
            this.txtMaSP.Location = new System.Drawing.Point(100, 27); this.txtMaSP.Size = new System.Drawing.Size(250, 23);
            this.label2.Text = "Tên SP:"; this.label2.Location = new System.Drawing.Point(15, 60);
            this.txtTenSP.Location = new System.Drawing.Point(100, 57); this.txtTenSP.Size = new System.Drawing.Size(250, 23);
            this.label3.Text = "Ngày SX:"; this.label3.Location = new System.Drawing.Point(15, 90);
            this.dtpNgaySX.Location = new System.Drawing.Point(100, 87); this.dtpNgaySX.Size = new System.Drawing.Size(250, 23);
            this.label4.Text = "Ngày HH:"; this.label4.Location = new System.Drawing.Point(15, 120);
            this.dtpNgayHH.Location = new System.Drawing.Point(100, 117); this.dtpNgayHH.Size = new System.Drawing.Size(250, 23);
            this.label5.Text = "Đơn vị:"; this.label5.Location = new System.Drawing.Point(15, 150);
            this.txtDonVi.Location = new System.Drawing.Point(100, 147); this.txtDonVi.Size = new System.Drawing.Size(250, 23);
            this.label6.Text = "Đơn giá:"; this.label6.Location = new System.Drawing.Point(15, 180);
            this.txtDonGia.Location = new System.Drawing.Point(100, 177); this.txtDonGia.Size = new System.Drawing.Size(250, 23);
            this.label7.Text = "Ghi chú:"; this.label7.Location = new System.Drawing.Point(15, 210);
            this.txtGhiChu.Location = new System.Drawing.Point(100, 207);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Size = new System.Drawing.Size(250, 100);

            // 
            // panelChucNang (các nút bên dưới)
            // 
            this.panelChucNang.Controls.Add(this.btnTim);
            this.panelChucNang.Controls.Add(this.btnThem);
            this.panelChucNang.Controls.Add(this.btnSua);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Controls.Add(this.btnLuu);
            this.panelChucNang.Controls.Add(this.btnHuy);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Location = new System.Drawing.Point(20, 430);
            this.panelChucNang.Size = new System.Drawing.Size(900, 50);

            // Nút chức năng
            int y = 10;
            this.btnTim.Text = "Tìm kiếm"; this.btnTim.Location = new System.Drawing.Point(0, y);
            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(120, y);
            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(240, y);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(360, y);
            this.btnLuu.Text = "Lưu"; this.btnLuu.Location = new System.Drawing.Point(480, y);
            this.btnHuy.Text = "Hủy"; this.btnHuy.Location = new System.Drawing.Point(600, y);
            this.btnThoat.Text = "Thoát"; this.btnThoat.Location = new System.Drawing.Point(720, y);

            // Sự kiện nút
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.txtTimTenSP);
            this.Controls.Add(this.txtTimMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTieuDe);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTimMaSP;
        private System.Windows.Forms.TextBox txtTimTenSP;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
    }
}
