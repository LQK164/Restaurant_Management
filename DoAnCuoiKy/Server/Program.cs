using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Server server = new Server();
            server.TcpServer = new TcpListener(IPAddress.Any, 10000);
            server.TcpServer.Start();
            try
            {
                while (true)
                {
                    TcpClient client = server.TcpServer.AcceptTcpClient();
                    Thread receiveThread = new Thread(server.Receive)
                    {
                        IsBackground = true
                    };
                    receiveThread.Start(client);
                }
            }
            catch
            {
                server.TcpServer = new TcpListener(IPAddress.Any, 10000);
            }
        }
    }
}