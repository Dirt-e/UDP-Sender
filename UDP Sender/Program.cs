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
            int ToPort = 31090;
            string ToIP = "127.0.0.1";

            UdpClient MyClient = new UdpClient();
            Console.WriteLine($"Sending on port {ToPort}.");

            while (true)
            {
                string Message = Console.ReadLine();
                byte[] bytes = Encoding.ASCII.GetBytes(Message);

                MyClient.Send(bytes, bytes.Length, ToIP, ToPort);
            }
        }
    }
}
