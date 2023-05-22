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
        static string connectionString = "Server = LAPTOP-PJUPPCNI\\MSSQLSERVER01;" +
                                         "Database = Restaurant_Management;" +
                                         "Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);

        public Client_QL()
        {
            InitializeComponent();
            connection.Open();
        }

        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN ORDER BY MANV asc";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_NhanVien.DataSource = datatable;
        }

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
            btn_Refresh_NhanVien_Click(sender, e);
            MessageBox.Show("Data added.", "Notification");
        }

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
            btn_Refresh_NhanVien_Click(sender, e);
            MessageBox.Show("Data updated.", "Notification");
        }

        private void btn_Delete_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MANV", txt_MaNV.Text);
            command.ExecuteNonQuery();
            btn_Show_NhanVien_Click(sender, e);
            btn_Refresh_NhanVien_Click(sender, e);
            MessageBox.Show("Data deleted.", "Notification");
        }

        private void btn_Refresh_NhanVien_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_HoTen_NhanVien.Text = "";
            txt_NgLV.Text = "";
            txt_ChucVu.Text = "";
            txt_Luong.Text = "";
        }

        private void btn_Find_NhanVien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN Where MANV = @MANV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MANV", txt_MaNV.Text);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_NhanVien.DataSource = datatable;
        }

        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.SelectedCells[0].Value.ToString();
            txt_HoTen_NhanVien.Text = dgv_NhanVien.SelectedCells[1].Value.ToString();
            txt_NgLV.Text = dgv_NhanVien.SelectedCells[2].Value.ToString();
            txt_ChucVu.Text = dgv_NhanVien.SelectedCells[3].Value.ToString();
            txt_Luong.Text = dgv_NhanVien.SelectedCells[4].Value.ToString();
        }

    }
}
