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

        private bool CheckLogic(string sHOTEN, string sMATKHAU)
        {
            if (string.IsNullOrEmpty(sHOTEN) || string.IsNullOrEmpty(sMATKHAU))
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sHOTEN.Length > 30)
            {
                MessageBox.Show("Họ và tên không quá 30 ký tự!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sMATKHAU.Length > 20)
            {
                MessageBox.Show("Mật khẩu không quá 20 ký tự!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sHOTEN.Where(x => Char.IsDigit(x)).Any())
            {
                MessageBox.Show("Họ và tên không có ký tự số!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sMATKHAU.Where(x => x == ' ').Any())
            {
                MessageBox.Show("Mật khẩu không có khoảng trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckLogic(txtHoTen.Text.Trim(), txtMatKhau.Text.Trim()))
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
}