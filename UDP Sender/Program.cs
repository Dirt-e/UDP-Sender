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
            string ToIP = "127.0.0.1";
            int ToPort = 10000;
            while (true)
            {
                Message = Console.ReadLine();
                SendUdp(FromPort, ToIP, ToPort, Message) ;
            }
        }

        static void SendUdp(int srcPort, string dstIp, int dstPort, string msg)
        {   
            byte[] bytes = Encoding.ASCII.GetBytes(msg);

            using (UdpClient c = new UdpClient(srcPort))
                c.Send(bytes, bytes.Length, dstIp, dstPort);
        }
    }
}
