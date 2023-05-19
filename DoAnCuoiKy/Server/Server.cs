using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PacketStructure;

namespace Server
{
    public class Server
    {
        private SqlConnection conn;
        private static TcpListener tcpServer;
        public static List<EndPoint> users = new List<EndPoint>();
        private static Packet receivedData;

        public Server()
        {
            conn = DatabaseAccess.GetConnection();
            conn.Open();
        }

        private bool NameExists(Packet receivedData)
        {
            bool check = true;
            string sql_query = "select * from TaiKhoan where HoTen = @hoten";
            SqlCommand sql_cmd = new SqlCommand(sql_query, this.conn);
            sql_cmd.Parameters.AddWithValue("hoten", receivedData.HoTen);
            SqlDataReader dataReader = sql_cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    sHoTen = dataReader.GetString(1);
                }
            }
            dataReader.Close();
        }

        private static void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            while (client.Connected)
            {
                NetworkStream net_stream = client.GetStream();
                byte[] data = new byte[1024];
                int byte_count = net_stream.Read(data, 0, data.Length);
                if (byte_count == 0)
                {
                    break;
                }
                receivedData = new Packet(data);
                users.Add(client.Client.RemoteEndPoint);
                // Con bo sung sau
            }
        }

        public static void Listen()
        {
            tcpServer = new TcpListener(IPAddress.Any, 10000);
            tcpServer.Start();
            try
            {
                while (true)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    Thread receiveThread = new Thread(Receive)
                    {
                        IsBackground = true
                    };
                    receiveThread.Start(client);
                }
            }
            catch
            {
                tcpServer = new TcpListener(IPAddress.Any, 10000);
            }
        }
    }
}