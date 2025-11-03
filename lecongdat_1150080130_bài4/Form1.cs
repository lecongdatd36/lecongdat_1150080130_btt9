using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lecongdat_1150080130_bai4
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=Admin-PC\CONGDAT;
                          Initial Catalog=QLBanHang;
                          Integrated Security=True;";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        SqlCommand cmd;
        int vt = -1;
        string trangThai = ""; // “THEM”, “SUA”

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
                string sql = "SELECT * FROM tblMatHang";
                adapter = new SqlDataAdapter(sql, sqlCon);
                ds = new DataSet();
                adapter.Fill(ds, "tblMatHang");
                dgvDanhSach.DataSource = ds.Tables["tblMatHang"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            SetButton(true);
            SetInput(false);
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            vt = e.RowIndex;
            DataGridViewRow row = dgvDanhSach.Rows[vt];
            txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
            dtpNgaySX.Value = Convert.ToDateTime(row.Cells["NgaySX"].Value);
            dtpNgayHH.Value = Convert.ToDateTime(row.Cells["NgayHH"].Value);
            txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangThai = "THEM";
            ClearInput();
            SetInput(true);
            SetButton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            trangThai = "SUA";
            SetInput(true);
            SetButton(false);
            txtMaSP.Enabled = false; // khóa mã sản phẩm khi sửa
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi();
                    string sql = "DELETE FROM tblMatHang WHERE MaSP=@MaSP";
                    cmd = new SqlCommand(sql, sqlCon);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        HienThiDuLieu();
                        ClearInput();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
                finally
                {
                    DongKetNoi();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                if (trangThai == "THEM")
                {
                    string sql = @"INSERT INTO tblMatHang (MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
                                   VALUES (@MaSP, @TenSP, @NgaySX, @NgayHH, @DonVi, @DonGia, @GhiChu)";
                    cmd = new SqlCommand(sql, sqlCon);
                }
                else if (trangThai == "SUA")
                {
                    string sql = @"UPDATE tblMatHang
                                   SET TenSP=@TenSP, NgaySX=@NgaySX, NgayHH=@NgayHH, DonVi=@DonVi, DonGia=@DonGia, GhiChu=@GhiChu
                                   WHERE MaSP=@MaSP";
                    cmd = new SqlCommand(sql, sqlCon);
                }

                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySX", dtpNgaySX.Value);
                cmd.Parameters.AddWithValue("@NgayHH", dtpNgayHH.Value);
                cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text.Trim());
                cmd.Parameters.AddWithValue("@DonGia", double.Parse(txtDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    MessageBox.Show(trangThai == "THEM" ? "Thêm mới thành công!" : "Cập nhật thành công!");

                HienThiDuLieu();
                SetButton(true);
                SetInput(false);
                txtMaSP.Enabled = true;
                trangThai = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetButton(true);
            SetInput(false);
            trangThai = "";
            txtMaSP.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM tblMatHang WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtTimMaSP.Text))
                    sql += " AND MaSP LIKE @MaSP";
                if (!string.IsNullOrWhiteSpace(txtTimTenSP.Text))
                    sql += " AND TenSP LIKE @TenSP";

                cmd = new SqlCommand(sql, sqlCon);

                if (!string.IsNullOrWhiteSpace(txtTimMaSP.Text))
                    cmd.Parameters.AddWithValue("@MaSP", "%" + txtTimMaSP.Text.Trim() + "%");
                if (!string.IsNullOrWhiteSpace(txtTimTenSP.Text))
                    cmd.Parameters.AddWithValue("@TenSP", "%" + txtTimTenSP.Text.Trim() + "%");

                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "tblMatHang");
                dgvDanhSach.DataSource = ds.Tables["tblMatHang"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ===================== HÀM TIỆN ÍCH =====================
        private void ClearInput()
        {
            txtMaSP.Text = txtTenSP.Text = txtDonVi.Text = txtDonGia.Text = txtGhiChu.Text = "";
            dtpNgaySX.Value = DateTime.Now;
            dtpNgayHH.Value = DateTime.Now;
        }

        private void SetInput(bool enable)
        {
            txtMaSP.Enabled = txtTenSP.Enabled = txtDonVi.Enabled = txtDonGia.Enabled = txtGhiChu.Enabled =
                dtpNgaySX.Enabled = dtpNgayHH.Enabled = enable;
        }

        private void SetButton(bool normal)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = normal;
            btnLuu.Enabled = btnHuy.Enabled = !normal;
        }
    }
}
