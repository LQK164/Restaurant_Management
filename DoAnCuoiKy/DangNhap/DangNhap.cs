using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using PacketStructure;
using System.Net.Http;
using System.Threading;

namespace DangNhap
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private Packet sendData;
        private TcpClient tcpClient;
        private IPEndPoint server_endpoint = new IPEndPoint(IPAddress.Loopback, 10000);

        private void Connect()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(server_endpoint);
            sendData = new Packet()
            {
                HoTen = txtHoTen.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                //VaiTro = (int)VaiTroNguoiDung.NhanVien
            };
            byte[] data = sendData.GetDataStream();
            NetworkStream net_stream = tcpClient.GetStream();
            net_stream.Write(data, 0, data.Length);
            net_stream.Flush();
        }

        private void Receive()
        {
            while (true)
            {
                NetworkStream net_stream = tcpClient.GetStream();
                byte[] data = new byte[1024];
                int byte_count = net_stream.Read(data, 0, data.Length);
                if (byte_count == 0)
                {
                    break;
                }
                // nhan thong diep tu server
                MessageBox.Show(Encoding.UTF8.GetString(data, 0, byte_count));
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                Thread clientThread = new Thread(Receive)
                {
                    IsBackground = true
                };
                clientThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}