using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Sender
{
    class Program
    {
        static void Main()
        {
            string Message;
            int FromPort = 9999;
            int ToPort = 10000;
            string ToIP = "127.0.0.1";

            UdpClient MyClient = new UdpClient(FromPort);

            while (true)
            {
                Message = Console.ReadLine();

                byte[] bytes = Encoding.ASCII.GetBytes(Message);
                MyClient.Send(bytes, bytes.Length, ToIP, ToPort);
            }
        }
    }
}
