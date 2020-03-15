using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace MailDemo
{
    class SocketConnect
    {
        private static byte[] result = new byte[1024];
        public static Socket ConnectToServer(string IP, int PORT)
        {
            IPAddress ip = IPAddress.Parse(IP);
            Socket clientScoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.Tcp);
            try
            {
                clientScoket.Connect(new IPEndPoint(ip, PORT));
                Console.WriteLine("连接服务器成功");
                return clientScoket;
            }
            catch
            {
                Console.WriteLine("连接服务器失败");
                return clientScoket = null;
            }
            return clientScoket = null;
        }

        public static void DisconnectServer(Socket conn)
        {
            conn.Close();
        }
    }
}
