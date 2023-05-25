using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client_NV : Form
    {
        //Khởi tạo chuỗi kết nối tới cơ sở dữ liệu.
        static string connectionString = "Server = LAPTOP-PJUPPCNI\\MSSQLSERVER01;" +
                                 "Database = Restaurant_Management;" +
                                 "Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        //Cờ kiểu soát bàn đang được chọn.
        int id_table_selected = -1;
        //Khởi tạo danh sách bàn ăn.
        List<Table> tables = new List<Table>();
        //Khởi tạo danh sách món ăn.
        List<Dish> menu = new List<Dish>();

        public Client_NV()
        {
            InitializeComponent();
            //Kết nối tới cơ sở dữ liệu.
            connection.Open();
            string query = "SELECT MABAN FROM BAN";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            //Tạo các đối tượng 'bàn ăn' và thêm vào danh sách.
            while (reader.Read())
            {
                Table table = new Table();
                table.MaBan = reader.GetValue(0).ToString();
                table.TongTien = 0;
                table.bill = new ListView();
                tables.Add(table);
            }
            reader.Close();
            query = "SELECT TENMON FROM THUCDON";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            //Thêm các tên món ăn vào mục chọn món ăn.
            while (reader.Read())
            {
                cb_Name_dish.Items.Add((reader.GetValue(0).ToString()));
            }
            reader.Close();
            query = "SELECT * FROM THUCDON";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            //Khởi tạo các đối tượng 'món ăn' và thêm vào danh sách.
            while (reader.Read())
            {
                Dish dish = new Dish();
                dish.MAMON = reader.GetValue(0).ToString();
                dish.TENMON = reader.GetValue(1).ToString();
                decimal temp_gia = 0;
                temp_gia = Convert.ToDecimal(reader.GetValue(3).ToString());
                dish.GIA = Convert.ToInt32(temp_gia);
                menu.Add(dish);
            }
            reader.Close();
            //Khóa các chức năng.
            btn_add_dish.Enabled = false;
            btn_order_table.Enabled = false;
            btn_pay.Enabled = false;
        }
        
        //Hiện thông tin của 1 bàn bao gồm: chi tiết hóa đơn, tình trạng bàn, tổng giá trị của hóa đơn.
        //Bàn 1
        private void btn_table1_Click(object sender, EventArgs e)
        {
            //Mở khóa các tính năng.
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 0;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            //Hiển thị tình trạng bàn.
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }    
            }
            reader.Close();
            //Hiển thị tổng giá trị của hóa đơn.
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Bàn 2
        private void btn_table2_Click(object sender, EventArgs e)
        {
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 1;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }
            }
            reader.Close();
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Bàn 3
        private void btn_table3_Click(object sender, EventArgs e)
        {
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 2;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }
            }
            reader.Close();
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Bàn 4
        private void btn_table4_Click(object sender, EventArgs e)
        {
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 3;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }
            }
            reader.Close();
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Bàn 5
        private void btn_table5_Click(object sender, EventArgs e)
        {
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 4;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }
            }
            reader.Close();
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Bàn 6
        private void btn_table6_Click(object sender, EventArgs e)
        {
            btn_add_dish.Enabled = true;
            btn_order_table.Enabled = true;
            btn_pay.Enabled = true;
            string query = "SELECT * FROM BAN Where MABAN = @MABAN";
            id_table_selected = 5;
            Auto_fill_MaBan();
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "False")
                {
                    lb_table_status.Text = "Tình trạng bàn: còn trống.";
                }
                else
                {
                    lb_table_status.Text = "Tình trạng bàn: có người.";
                }
            }
            reader.Close();
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Cập nhật trình trạng của 1 bàn ăn.
        private void btn_order_table_Click(object sender, EventArgs e)
        {
            string query;
            //Nếu tình trạng bàn là đang trống.
            if (lb_table_status.Text == "Tình trạng bàn: còn trống.")
            {
                lb_table_status.Text = "Tình trạng bàn: có người.";
                query = "UPDATE BAN SET TINHTRANGBAN = 1" +
                               "WHERE MABAN = @MABAN";
            }
            //Nếu tình trạng bàn là đã có người.
            else
            {
                lb_table_status.Text = "Tình trạng bàn: còn trống.";
                query = "UPDATE BAN SET TINHTRANGBAN = 0" +
                               "WHERE MABAN = @MABAN";
            }
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            command.ExecuteNonQuery();
        }

        //Thêm 1 món ăn với số lượng phần ăn vào thông tin hóa đơn.
        private void btn_add_dish_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ thông tin chi tiết hóa đơn.
            if (txt_quantity.Text == "" || cb_Name_dish.Text == "" || cb_Name_dish.Text == "Tên món")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn và số lượng món ăn.", "Notice");
                return;
            }
            //Cập nhật bảng chi tiết hóa đơn với tên món ăn, giá 1 phần ăn, số lượng phần ăn và giá của số phần ăn đó.
            ListViewItem bill_detail = new ListViewItem();
            int price = 0, total = 0;
            foreach (Dish dish in menu)
            {
                if (cb_Name_dish.Text == dish.TENMON)
                {
                    price = dish.GIA;
                    break;
                }    
            }
            total = price * Convert.ToInt32(txt_quantity.Text);
            bill_detail.Text = cb_Name_dish.Text;
            lv_Bill.Items.Add(bill_detail);
            bill_detail.SubItems.Add(txt_quantity.Text);
            bill_detail.SubItems.Add(price.ToString());
            bill_detail.SubItems.Add(total.ToString());
            Cal_total(total);
            Save_bill();
        }

        //Hiển thị thông tin hóa đơn của 1 bàn.
        void Load_bill()
        {
            lv_Bill.Items.Clear();
            foreach (ListViewItem item in tables[id_table_selected].bill.Items)
            {
                lv_Bill.Items.Add((ListViewItem)item.Clone());
            }
        }

        //Lưu hóa đơn của 1 bàn lại
        void Save_bill()
        {
            tables[id_table_selected].bill.Items.Clear();
            foreach (ListViewItem item in lv_Bill.Items)
            {
                tables[id_table_selected].bill.Items.Add((ListViewItem)item.Clone());
            }
        }

        //Tính tổng số tiền của 1 hóa đơn và hiển thị giá trị đó.
        void Cal_total(int total)
        {
            tables[id_table_selected].TongTien += total;
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        //Tự cập nhật mã bàn ăn trên vùng điền thông tin hóa đơn.
        void Auto_fill_MaBan()
        {
            txt_MABAN.Text = tables[id_table_selected].MaBan;
        }

        //Thanh toán hóa đơn = lưu thông tin hóa đơn và chi tiết của nó lên cơ sở dữ liệu.
        private void btn_pay_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ thông tin hóa đơn.
            if (txt_MAHD.Text == "" || txt_MANV.Text == "" || txt_MAKH.Text == "" || txt_NGAYHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn.", "Notice");
                return;
            }
            //Thêm hpá đơn.
            string query = "INSERT INTO HOADON (MAHD, MANV, MAKH, MABAN, NGAYHD, TRIGIA)" +
                           "VALUES(@MAHD, @MANV, @MAKH, @MABAN, @NGAYHD, @TRIGIA)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MAHD", txt_MAHD.Text);
            command.Parameters.AddWithValue("@MANV", txt_MANV.Text);
            command.Parameters.AddWithValue("@MAKH", txt_MAKH.Text);
            command.Parameters.AddWithValue("@MABAN", txt_MABAN.Text);
            command.Parameters.AddWithValue("@NGAYHD", txt_NGAYHD.Text);
            command.Parameters.AddWithValue("@TRIGIA", tables[id_table_selected].TongTien);
            command.ExecuteNonQuery();
            //Thêm chi tiết hóa đơn.
            foreach (ListViewItem item in lv_Bill.Items)
            {
                query = "INSERT INTO CTHD(MAHD, MAMON, SL)" +
                    "VALUES (@MAHD, @MAMON, @SL)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MAHD", txt_MAHD.Text);
                foreach (Dish dish in menu)
                {
                    if (item.SubItems[0].Text == dish.TENMON)
                    {
                        command.Parameters.AddWithValue("@MAMON", dish.MAMON);
                        break;
                    }
                }    
                command.Parameters.AddWithValue("@SL", item.SubItems[1].Text);
                command.ExecuteNonQuery();
            }
            //Cập nhật tình trạng bàn về còn trống và xóa các thông tin hóa đơn để tiện cho lần nhập tiếp theo.
            lb_table_status.Text = "Tình trạng bàn: còn trống.";
            query = "UPDATE BAN SET TINHTRANGBAN = 0" +
                           "WHERE MABAN = @MABAN";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MABAN", tables[id_table_selected].MaBan);
            command.ExecuteNonQuery();
            tables[id_table_selected].bill.Items.Clear();
            lv_Bill.Items.Clear();
            txt_MABAN.Text = "";
            txt_MAHD.Text = "";
            txt_MAKH.Text = "";
            txt_MANV.Text = "";
            txt_NGAYHD.Text = "";
        }

        //Đối tượng 'bàn ăn'.
        public class Table
        {
            public string MaBan { get; set; }
            public int TongTien { get; set; }
            public ListView bill { get; set; }
    }

        //Đối tượng 'món ăn'.
        public class Dish
        {
            public string MAMON { get; set; }
            public string TENMON { get; set; }
            public int GIA { get; set; }
        }

    }
}
