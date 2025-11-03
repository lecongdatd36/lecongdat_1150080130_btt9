namespace thuchanh1_lab8
{
    partial class frmReportSinhVien
    {
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmReportSinhVien_Load);
            this.ResumeLayout(false);
        }
    }
}
