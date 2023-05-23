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
        static string connectionString = "Server = LAPTOP-PJUPPCNI\\MSSQLSERVER01;" +
                                 "Database = Restaurant_Management;" +
                                 "Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        int id_table_selected = 0;
        List<Table> tables = new List<Table>(6);
        List<THUCDON> menu = new List<THUCDON>();
        public Client_NV()
        {
            InitializeComponent();
            connection.Open();
            for (int i = 1; i <= 6; i++)
            {
                Table table = new Table();
                table.MaBan = "B0" + i;
                table.TongTien = 0;
                table.bill = new ListView();
                tables.Add(table);
            }
            //Lấy tên món
            string query = "SELECT TENMON FROM THUCDON";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb_name.Items.Add((reader.GetValue(0).ToString()));
            }
            reader.Close();
            query = "SELECT * FROM THUCDON";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                THUCDON dish = new THUCDON();
                dish.MAMON = reader.GetValue(0).ToString();
                dish.TENMON = reader.GetValue(1).ToString();
                dish.GIA = Convert.ToDecimal(reader.GetValue(3).ToString());
                menu.Add(dish);
            }
            reader.Close();
        }

        private void btn_table1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B01'";
            id_table_selected = 0;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
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

        private void btn_order_table_Click(object sender, EventArgs e)
        {
            string query;
            if (lb_table_status.Text == "Tình trạng bàn: còn trống.")
            {
                lb_table_status.Text = "Tình trạng bàn: có người.";
                query = "UPDATE BAN SET TINHTRANGBAN = 1" +
                               "WHERE MABAN = @MABAN";
                
            }
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

        private void btn_table2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B02'";
            id_table_selected = 1;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
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

        private void btn_table3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B03'";
            id_table_selected = 2;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
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

        private void btn_table4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B04'";
            id_table_selected = 3;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
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

        private void btn_table5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B05'";
            id_table_selected = 4;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
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

        private void btn_table6_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BAN Where MABAN = 'B01'";
            id_table_selected = 5;
            Load_bill();
            SqlCommand command = new SqlCommand(query, connection);
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

        private void btn_add_dish_Click(object sender, EventArgs e)
        {
            ListViewItem bill_detail = new ListViewItem();
            decimal price = 0, total = 0;
            foreach (THUCDON disk in menu)
            {
                if (cb_name.Text == disk.TENMON)
                {
                    price = disk.GIA;
                    break;
                }    
            }
            total = price * Convert.ToDecimal(txt_quantity.Text);
            bill_detail.Text = cb_name.Text;
            lv_Bill.Items.Add(bill_detail);
            bill_detail.SubItems.Add(txt_quantity.Text);
            bill_detail.SubItems.Add(price.ToString());
            bill_detail.SubItems.Add(total.ToString());
            Cal_total(total);
            Save_bill();
        }

        void Load_bill()
        {
            lv_Bill.Items.Clear();
            foreach (ListViewItem item in tables[id_table_selected].bill.Items)
            {
                lv_Bill.Items.Add((ListViewItem)item.Clone());
            }
        }

        void Save_bill()
        {
            tables[id_table_selected].bill.Items.Clear();
            foreach (ListViewItem item in lv_Bill.Items)
            {
                tables[id_table_selected].bill.Items.Add((ListViewItem)item.Clone());
            }
        }

        void Cal_total(decimal total)
        {
            tables[id_table_selected].TongTien += total;
            lb_total_payment.Text = "Tổng tiền: " + tables[id_table_selected].TongTien + " VND";
        }

        public class Table
        {
            public string MaBan { get; set; }
            public decimal TongTien { get; set; }
            public ListView bill { get; set; }
        }

        public class THUCDON
        {
            public string MAMON { get; set; }
            public string TENMON { get; set; }
            public decimal GIA { get; set; }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            tables[id_table_selected].bill.Items.Clear();
            lv_Bill.Items.Clear();
            lb_table_status.Text = "Tình trạng bàn: còn trống.";
            lb_total_payment.Text = "Tổng tiền: 0 VND";
            //
            //Liên hoàn Update
            //
            txt_MABAN.Text = "";
            txt_MAHD.Text = "";
            txt_MAKH.Text = "";
            txt_MANV.Text = "";
            txt_NGAYHD.Text = "";
        }
    }
}
