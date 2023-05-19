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
                VaiTro = (int)VaiTroNguoiDung.NhanVien
            };
            byte[] data = sendData.GetDataStream();
            NetworkStream net_stream = tcpClient.GetStream();
            net_stream.Write(data, 0, data.Length);
            net_stream.Flush();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
