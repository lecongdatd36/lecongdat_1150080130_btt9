namespace thuchanh2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(250, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm dữ liệu vào database";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(30, 70);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowTemplate.Height = 25;
            this.dgvDanhSach.Size = new System.Drawing.Size(300, 250);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // grpNhap
            // 
            this.grpNhap.Controls.Add(this.txtDiaChi);
            this.grpNhap.Controls.Add(this.txtTenXB);
            this.grpNhap.Controls.Add(this.txtMaXB);
            this.grpNhap.Controls.Add(this.lblDiaChi);
            this.grpNhap.Controls.Add(this.lblTen);
            this.grpNhap.Controls.Add(this.lblMa);
            this.grpNhap.Controls.Add(this.btnThemDL);
            this.grpNhap.Location = new System.Drawing.Point(360, 70);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(300, 250);
            this.grpNhap.TabIndex = 2;
            this.grpNhap.TabStop = false;
            this.grpNhap.Text = "Nhập thông tin:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 110);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 23);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(100, 75);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(180, 23);
            this.txtTenXB.TabIndex = 5;
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(100, 40);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(180, 23);
            this.txtMaXB.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 113);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 15);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 78);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(49, 15);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên XB:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 43);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(46, 15);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã XB:";
            // 
            // btnThemDL
            // 
            this.btnThemDL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemDL.Location = new System.Drawing.Point(70, 170);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(160, 40);
            this.btnThemDL.TabIndex = 0;
            this.btnThemDL.Text = "Thêm dữ liệu";
            this.btnThemDL.UseVisualStyleBackColor = true;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(30, 50);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(128, 15);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.grpNhap);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà xuất bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.Label lblDanhSach;
    }
}
