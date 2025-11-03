using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace thuchanh3
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

      
        private void XoaDuLieuForm()
        {
            txtMaXB.Text = "";
            txtTenXB.Text = "";
            txtDiaChi.Text = "";
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
                MessageBox.Show(" Lỗi hiển thị: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieuForm();
        }

       
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt < 0) return;

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            txtMaXB.Text = row["MaNXB"].ToString().Trim();
            txtTenXB.Text = row["TenNXB"].ToString().Trim();
            txtDiaChi.Text = row["DiaChi"].ToString().Trim();
        }

        
        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (vt < 0)
            {
                MessageBox.Show(" Bạn chưa chọn dữ liệu để chỉnh sửa!");
                return;
            }

            try
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
                row.BeginEdit();
                row["MaNXB"] = txtMaXB.Text.Trim();
                row["TenNXB"] = txtTenXB.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();
                row.EndEdit();

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show(" Chỉnh sửa dữ liệu thành công!");
                    HienThiDuLieu();
                    XoaDuLieuForm();
                }
                else
                {
                    MessageBox.Show(" Chỉnh sửa không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi khi chỉnh sửa: " + ex.Message);
            }
        }
    }
}
