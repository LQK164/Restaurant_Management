using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client
{
    public partial class Client_QL : Form
    {
        //Khởi tạo chuỗi kết nối tới cơ sở dữ liệu.
        static string connectionString = "Server = LAPTOP-PJUPPCNI\\MSSQLSERVER01;" +
                                         "Database = Restaurant_Management;" +
                                         "Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);

        public Client_QL()
        {
            InitializeComponent();
            //Kết nối tới cơ sở dữ liệu.
            connection.Open();
        }

        //Hiển thị toàn bộ dữ liệu của bảng nhân viên. 
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN ORDER BY MANV asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_NhanVien.DataSource = datatable;
        }

        //Thêm dữ liệu vào bảng nhân viên.
        private void btn_Add_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NHANVIEN (MANV, Hoten, NgVL, ChucVu, Luong)" +
                           "VALUES(@MANV, @Hoten, @NgVL, @ChucVu, @Luong)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Hoten", txt_HoTen_NhanVien.Text);
            command.Parameters.AddWithValue("@NgVL", Convert.ToDateTime(txt_NgLV.Text));
            command.Parameters.AddWithValue("@ChucVu", txt_ChucVu.Text);
            command.Parameters.AddWithValue("@Luong", Convert.ToDecimal(txt_Luong.Text));
            command.Parameters.AddWithValue("@MANV", txt_MaNV.Text);
            command.ExecuteNonQuery();
            btn_Show_NhanVien_Click(sender, e);
            btn_Clear_NhanVien_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        //Cập nhật dữ liệu vào bảng nhân viên theo mã nhân viên.
        private void btn_Update_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NHANVIEN SET Hoten =  @Hoten," +
                           "NgVL = @NgVL," +
                           "ChucVu = @ChucVu," +
                           "Luong = @Luong " +
                           "WHERE MANV = @MANV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Hoten", txt_HoTen_NhanVien.Text);
            command.Parameters.AddWithValue("@NgVL", Convert.ToDateTime(txt_NgLV.Text));
            command.Parameters.AddWithValue("@ChucVu", txt_ChucVu.Text);
            command.Parameters.AddWithValue("@Luong", Convert.ToDecimal(txt_Luong.Text));
            command.Parameters.AddWithValue("@MANV", txt_MaNV.Text);
            command.ExecuteNonQuery();
            btn_Show_NhanVien_Click(sender, e);
            btn_Clear_NhanVien_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        //Xóa dữ liệu ở bảng nhân viên theo mã nhân viên.
        private void btn_Delete_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MANV", txt_MaNV.Text);
            command.ExecuteNonQuery();
            btn_Show_NhanVien_Click(sender, e);
            btn_Clear_NhanVien_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        //Xóa các thông tin tạm trên các ô textbox để tiện cho thao tác tiếp theo.
        private void btn_Clear_NhanVien_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_HoTen_NhanVien.Text = "";
            txt_NgLV.Text = "";
            txt_ChucVu.Text = "";
            txt_Luong.Text = "";
            txt_Find_NhanVien.Text = "";
        }

        //Tìm kiếm thông tin nhân viên theo mã nhân viên.
        private void btn_Find_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN Where MANV = @MANV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MANV", txt_Find_NhanVien.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_NhanVien.DataSource = datatable;
        }

        //Chọn 1 hàng trong bảng nhân viên (chọn toàn bộ thông tin của 1 nhân viên).
        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.SelectedCells[0].Value.ToString();
            txt_HoTen_NhanVien.Text = dgv_NhanVien.SelectedCells[1].Value.ToString();
            txt_NgLV.Text = dgv_NhanVien.SelectedCells[2].Value.ToString();
            txt_ChucVu.Text = dgv_NhanVien.SelectedCells[3].Value.ToString();
            txt_Luong.Text = dgv_NhanVien.SelectedCells[4].Value.ToString();
        }

        private void btn_Show_ThucDon_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM THUCDON ORDER BY MAMON asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_ThucDon.DataSource = datatable;
        }

        private void btn_Add_ThucDon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO THUCDON (MAMON, TENMON, DVT, GIA)" +
                           "VALUES(@MAMON, @TENMON, @DVT, @GIA)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon.Text);
            command.Parameters.AddWithValue("@TENMON", txt_TenMon.Text);
            command.Parameters.AddWithValue("@DVT", txt_DVT.Text);
            command.Parameters.AddWithValue("@GIA", Convert.ToDecimal(txt_Gia.Text));
            command.ExecuteNonQuery();
            btn_Show_ThucDon_Click(sender, e);
            btn_Clear_ThucDon_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        private void btn_Update_ThucDon_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THUCDON SET TENMON =  @TENMON," +
                           "DVT = @DVT," +
                           "GIA = @GIA " +
                           "WHERE MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon.Text);
            command.Parameters.AddWithValue("@TENMON", txt_TenMon.Text);
            command.Parameters.AddWithValue("@DVT", txt_DVT.Text);
            command.Parameters.AddWithValue("@GIA", Convert.ToDecimal(txt_Gia.Text));
            command.ExecuteNonQuery();
            btn_Show_ThucDon_Click(sender, e);
            btn_Clear_ThucDon_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_ThucDon_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM THUCDON WHERE MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon.Text);
            command.ExecuteNonQuery();
            btn_Show_ThucDon_Click(sender, e);
            btn_Clear_ThucDon_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Clear_ThucDon_Click(object sender, EventArgs e)
        {
            txt_MaMon.Text = "";
            txt_TenMon.Text = "";
            txt_DVT.Text = "";
            txt_Gia.Text = "";
            txt_Find_ThucDon.Text = "";
        }

        private void btn_Find_ThucDon_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM THUCDON Where MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAMON", txt_Find_ThucDon.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_ThucDon.DataSource = datatable;
        }

        private void dgv_ThucDon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaMon.Text = dgv_ThucDon.SelectedCells[0].Value.ToString();
            txt_TenMon.Text = dgv_ThucDon.SelectedCells[1].Value.ToString();
            txt_DVT.Text = dgv_ThucDon.SelectedCells[2].Value.ToString();
            txt_Gia.Text = dgv_ThucDon.SelectedCells[3].Value.ToString();
        }

        private void btn_Show_all_Ban_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN ORDER BY MABAN asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_Ban.DataSource = datatable;
        }

        private void btn_Add_Ban_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO BAN (MABAN, SOLUONG, LOAIBAN, TINHTRANGBAN)" +
                           "VALUES(@MABAN, @SOLUONG, @LOAIBAN, @TINHTRANGBAN)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", txt_MaBan.Text);
            command.Parameters.AddWithValue("@SOLUONG", txt_SLBan.Text);
            command.Parameters.AddWithValue("@LOAIBAN", txt_LoaiBan.Text);
            command.Parameters.AddWithValue("@TINHTRANGBAN", txt_TinhTrangBan.Text);
            command.ExecuteNonQuery();
            btn_Show_all_Ban_Click(sender, e);
            btn_Clear_Ban_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        private void btn_Update_Ban_Click(object sender, EventArgs e)
        {
            string query = "UPDATE BAN SET SOLUONG =  @SOLUONG," +
                           "LOAIBAN = @LOAIBAN," +
                           "TINHTRANGBAN = @TINHTRANGBAN " +
                           "WHERE MABAN = @MABAN";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", txt_MaBan.Text);
            command.Parameters.AddWithValue("@SOLUONG", txt_SLBan.Text);
            command.Parameters.AddWithValue("@LOAIBAN", txt_LoaiBan.Text);
            command.Parameters.AddWithValue("@TINHTRANGBAN", txt_TinhTrangBan.Text);
            command.ExecuteNonQuery();
            btn_Show_all_Ban_Click(sender, e);
            btn_Clear_Ban_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_Ban_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM BAN WHERE MABAN = @MABAN";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", txt_MaBan.Text);
            command.ExecuteNonQuery();
            btn_Show_all_Ban_Click(sender, e);
            btn_Clear_Ban_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Clear_Ban_Click(object sender, EventArgs e)
        {
            txt_MaBan.Text = "";
            txt_SLBan.Text = "";
            txt_LoaiBan.Text = "";
            txt_TinhTrangBan.Text = "";
            txt_Find_Ban.Text = "";
        }

        private void btn_Find_Ban_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", txt_Find_Ban.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_Ban.DataSource = datatable;
        }

        private void dgv_Ban_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaBan.Text = dgv_Ban.SelectedCells[0].Value.ToString();
            txt_SLBan.Text = dgv_Ban.SelectedCells[1].Value.ToString();
            txt_LoaiBan.Text = dgv_Ban.SelectedCells[2].Value.ToString();
            txt_TinhTrangBan.Text = dgv_Ban.SelectedCells[3].Value.ToString();
        }

        private void btn_Show_HoaDon_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HOADON ORDER BY MAHD asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_HoaDon.DataSource = datatable;
        }

        private void btn_Add_HoaDon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO HOADON (MAHD, MANV, MAKH, MABAN, NGAYHD, TRIGIA)" +
                           "VALUES(@MAHD, @MANV, @MAKH, @MABAN, @NGAYHD, @TRIGIA)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD.Text);
            command.Parameters.AddWithValue("@MANV", txt_MaNV_HoaDon.Text);
            command.Parameters.AddWithValue("@MAKH", txt_MaKH_HoaDon.Text);
            command.Parameters.AddWithValue("@MABAN", txt_MaBan_HoaDon.Text);
            command.Parameters.AddWithValue("@NGAYHD", Convert.ToDateTime(txt_NgHD.Text));
            command.Parameters.AddWithValue("@TRIGIA", Convert.ToDecimal(txt_TriGia.Text));
            command.ExecuteNonQuery();
            btn_Show_HoaDon_Click(sender, e);
            btn_Clear_HoaDon_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        private void btn_Update_HoaDon_Click(object sender, EventArgs e)
        {
            string query = "UPDATE HOADON SET MANV =  @MANV," +
                           "MAKH = @MAKH," +
                           "MABAN = @MABAN," +
                           "NGAYHD = @NGAYHD," +
                           "TRIGIA = @TRIGIA " +
                           "WHERE MAHD = @MAHD";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD.Text);
            command.Parameters.AddWithValue("@MANV", txt_MaNV_HoaDon.Text);
            command.Parameters.AddWithValue("@MAKH", txt_MaKH_HoaDon.Text);
            command.Parameters.AddWithValue("@MABAN", txt_MaBan_HoaDon.Text);
            command.Parameters.AddWithValue("@NGAYHD", Convert.ToDateTime(txt_NgHD.Text));
            command.Parameters.AddWithValue("@TRIGIA", Convert.ToDecimal(txt_TriGia.Text));
            command.ExecuteNonQuery();
            btn_Show_HoaDon_Click(sender, e);
            btn_Clear_HoaDon_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_HoaDon_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM HOADON WHERE MAHD = @MAHD";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD.Text);
            command.ExecuteNonQuery();
            btn_Show_HoaDon_Click(sender, e);
            btn_Clear_HoaDon_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Clear_HoaDon_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = "";
            txt_MaNV_HoaDon.Text = "";
            txt_MaKH_HoaDon.Text = "";
            txt_MaBan_HoaDon.Text = "";
            txt_NgHD.Text = "";
            txt_TriGia.Text = "";
            txt_Find_HoaDon.Text = "";
        }

        private void btn_Find_HoaDon_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HOADON Where MAHD = @MAHD";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_Find_HoaDon.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_HoaDon.DataSource = datatable;
        }

        private void dgv_HoaDon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaHD.Text = dgv_HoaDon.SelectedCells[0].Value.ToString();
            txt_MaNV_HoaDon.Text = dgv_HoaDon.SelectedCells[1].Value.ToString();
            txt_MaKH_HoaDon.Text = dgv_HoaDon.SelectedCells[2].Value.ToString();
            txt_MaBan_HoaDon.Text = dgv_HoaDon.SelectedCells[3].Value.ToString();
            txt_NgHD.Text = dgv_HoaDon.SelectedCells[4].Value.ToString();
            txt_TriGia.Text = dgv_HoaDon.SelectedCells[5].Value.ToString();

        }

        private void btn_Show_KhachHang_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KHACHHANG ORDER BY MaKH asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_KhachHang.DataSource = datatable;
        }

        private void btn_Add_KhachHang_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KHACHHANG (MaKH, HoTen, SoDT)" +
                           "VALUES(@MaKH, @HoTen, @SoDT)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
            command.Parameters.AddWithValue("@HoTen", txt_HoTen_KhachHang.Text);
            command.Parameters.AddWithValue("@SoDT", txt_SDT.Text);
            command.ExecuteNonQuery();
            btn_Show_KhachHang_Click(sender, e);
            btn_Clear_KhachHang_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        private void btn_Update_KhachHang_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KHACHHANG SET HoTen =  @HoTen," +
                           "SoDT = @SoDT " +
                           "WHERE MaKH = @MaKH";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
            command.Parameters.AddWithValue("@HoTen", txt_HoTen_KhachHang.Text);
            command.Parameters.AddWithValue("@SoDT", txt_SDT.Text);
            command.ExecuteNonQuery();
            btn_Show_KhachHang_Click(sender, e);
            btn_Clear_KhachHang_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_KhachHang_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM KHACHHANG WHERE MaKH = @MaKH";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
            command.ExecuteNonQuery();
            btn_Show_KhachHang_Click(sender, e);
            btn_Clear_KhachHang_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Clear_KhachHang_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_HoTen_KhachHang.Text = "";
            txt_SDT.Text = "";
            txt_Find_KhachHang.Text = "";
        }

        private void btn_Find_KhachHang_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KHACHHANG Where MaKH = @MaKH";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_KhachHang.DataSource = datatable;
        }

        private void dgv_KhachHang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaKH.Text = dgv_KhachHang.SelectedCells[0].Value.ToString();
            txt_HoTen_KhachHang.Text = dgv_KhachHang.SelectedCells[1].Value.ToString();
            txt_SDT.Text = dgv_KhachHang.SelectedCells[2].Value.ToString();
        }

        private void btn_Show_CTHD_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CTHD ORDER BY MAHD asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_CTHD.DataSource = datatable;
        }

        private void btn_Add_CTHD_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CTHD (MAHD, MAMON, SL)" +
                           "VALUES(@MAHD, @MAMON, @SL)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD_CTHD.Text);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon_CTHD.Text);
            command.Parameters.AddWithValue("@SL", txt_SL.Text);
            command.ExecuteNonQuery();
            btn_Show_CTHD_Click(sender, e);
            btn_Clear_CTHD_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

        private void btn_Update_CTHD_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CTHD SET SL =  @SL " +
                           "WHERE MAHD = @MAHD AND MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD_CTHD.Text);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon_CTHD.Text);
            command.Parameters.AddWithValue("@SL", txt_SL.Text);
            command.ExecuteNonQuery();
            btn_Show_CTHD_Click(sender, e);
            btn_Clear_CTHD_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_CTHD_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CTHD WHERE MAHD = @MAHD AND MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD_CTHD.Text);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon_CTHD.Text);
            command.ExecuteNonQuery();
            btn_Show_CTHD_Click(sender, e);
            btn_Clear_CTHD_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Clear_CTHD_Click(object sender, EventArgs e)
        {
            txt_MaHD_CTHD.Text = "";
            txt_MaMon_CTHD.Text = "";
            txt_SL.Text = "";
            txt_Find_CTHD.Text = "";
        }

        private void btn_Find_CTHD_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CTHD WHERE MAHD = @MAHD AND MAMON = @MAMON";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MaHD_CTHD.Text);
            command.Parameters.AddWithValue("@MAMON", txt_MaMon_CTHD.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_CTHD.DataSource = datatable;
        }

        private void dgv_CTHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaHD_CTHD.Text = dgv_CTHD.SelectedCells[0].Value.ToString();
            txt_MaMon_CTHD.Text = dgv_CTHD.SelectedCells[1].Value.ToString();
            txt_SL.Text = dgv_CTHD.SelectedCells[2].Value.ToString();
        }
    }
}