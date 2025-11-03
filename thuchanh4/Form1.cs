using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace thuchanh4
{
    public partial class Form1 : Form
    {
   
        string strCon = @"Data Source=Admin-PC\CONGDAT;
                          Initial Catalog=QuanLyBanSach;
                          Integrated Security=True;";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vt = -1; 

        public Form1()
        {
            InitializeComponent();
        }

       
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

      
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

       
        private void HienThiDuLieu()
        {
            try
            {
                MoKetNoi();
                string query = "SELECT * FROM NhaXuatBan";
                adapter = new SqlDataAdapter(query, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");
                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi hiển thị dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

      
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show(" Bạn chưa chọn dữ liệu để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaDuLieu();
                HienThiDuLieu();
            }
        }

        private void XoaDuLieu()
        {
            try
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
                row.Delete();

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show(" Xóa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show(" Xóa dữ liệu không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }
    }
}
