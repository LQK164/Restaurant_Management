using System;
using System.Collections.Generic;
using System.Linq;
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
            Thread serverThread = new Thread(new ThreadStart(Server.Listen))
            {
                IsBackground = true
            };
            serverThread.Start();
        }
    }
}