using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        private string connectionString = @"Data Source=AORUS\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True";
        public void ThemSanPham(SanPhamDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SET IDENTITY_INSERT SanPham ON; INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGia, XuatXu, NgayHetHan) VALUES (@MaSanPham, @Ten, @SoLuong, @DonGia, @XuatXu, @NgayHetHan); SET IDENTITY_INSERT SanPham OFF;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@Ten", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                cmd.Parameters.AddWithValue("@XuatXu", sp.XuatXu);
                cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool KiemTraMaSanPhamTonTai(int maSanPham)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
               
                return count > 0;
            }
        }

        public void SuaSanPham(SanPhamDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SanPham SET TenSanPham=@Ten, SoLuong=@SoLuong, DonGia=@DonGia, XuatXu=@XuatXu, NgayHetHan=@NgayHetHan WHERE MaSanPham=@Ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@Ten", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                cmd.Parameters.AddWithValue("@XuatXu", sp.XuatXu);
                cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaSanPham(int maSanPham)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SanPham WHERE MaSanPham=@Ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaTatCaSanPhamQuaHan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SanPham WHERE NgayHetHan <= GETDATE()";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable LayDanhSachSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
        public DataTable LaySanPhamQuaHan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham WHERE NgayHetHan <= GETDATE()";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable TimSanPhamDonGiaCaoNhat()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM SanPham ORDER BY DonGia DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable TimSanPhamXuatXuNhatBan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham WHERE XuatXu COLLATE Latin1_General_CI_AI = 'Nhat Ban'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable LaySanPhamTrongKhoangGia(decimal min, decimal max)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham WHERE DonGia BETWEEN @Min AND @Max";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Min", min);
                cmd.Parameters.AddWithValue("@Max", max);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}