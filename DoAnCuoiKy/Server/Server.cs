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
using System.Data;

namespace Server
{
    public class Server
    {
        private SqlConnection conn;
        private TcpListener tcpServer;
        private List<EndPoint> userList = new List<EndPoint>();
        private Packet receivedData;

        public Server()
        {
            conn = DatabaseAccess.GetConnection();
            conn.Open();
        }

        public TcpListener TcpServer
        {
            get { return this.tcpServer; }
            set { this.tcpServer = value; }
        }

        public Packet ReceivedData
        {
            get { return this.receivedData; }
            set { this.receivedData = value; }
        }

        public bool CheckLogin(Packet receivedData)
        {
            bool check = true;
            string sql_query = "select * from TaiKhoan where HoTen = @hoten and MatKhau = @matkhau";
            SqlCommand sql_cmd = new SqlCommand(sql_query, this.conn);
            //sql_cmd.Parameters.AddWithValue("hoten", $"N'{receivedData.HoTen}'");
            //sql_cmd.Parameters.AddWithValue("matkhau", $"N'{receivedData.MatKhau}'");
            sql_cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = receivedData.HoTen;
            sql_cmd.Parameters.Add("matkhau", SqlDbType.NVarChar).Value = receivedData.MatKhau;
            SqlDataReader dataReader = sql_cmd.ExecuteReader();
            if (!dataReader.HasRows)
            {
                check = false;
            }
            dataReader.Close();
            return check;
        }

        public void Receive(object obj)
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
                this.receivedData = new Packet(data);
                this.userList.Add(client.Client.RemoteEndPoint);
                byte[] sendData;
                if (CheckLogin(this.receivedData))
                {
                    // tao goi tin de gui lai (sau nay)
                    sendData = Encoding.UTF8.GetBytes("Đăng nhập thành công!");
                }
                else
                {
                    sendData = Encoding.UTF8.GetBytes("Tài khoản không tồn tại!");
                }
                net_stream.Write(sendData, 0, sendData.Length);
                net_stream.Flush();
                // Con bo sung sau
            }
        }

        /*public static void Listen()
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
        }*/
    }
}