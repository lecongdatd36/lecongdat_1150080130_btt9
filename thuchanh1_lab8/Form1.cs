using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace thuchanh1_lab8
{
    public partial class frmReportSinhVien : Form
    {
        public frmReportSinhVien()
        {
            InitializeComponent();
        }

     
        string strCon = @"Data Source=Admin-PC\CONGDAT;
                          Initial Catalog=quanlysinhvien1;
                          Integrated Security=True";

        SqlConnection sqlCon = null;

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void frmReportSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string query = "SELECT * FROM SinhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SinhVien");

                reportViewer1.LocalReport.ReportEmbeddedResource = "thuchanh1_lab8.rptSinhVien.rdlc";
                ReportDataSource rds = new ReportDataSource("dsSinhVien", ds.Tables["SinhVien"]);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
