using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class DatabaseAccess
    {
        // Khoi tao chuoi ket noi
        private static string sql_conn = @"Data Source=DESKTOP-U7NVEFD\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(sql_conn);
        }
    }
}