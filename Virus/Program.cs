
using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

namespace Arthur
{
	internal class Program
	{		
		public static void Main(string[] args) 
		{
			Console.WriteLine("Welecome to your control panel");
						
			sendCmd(Console.ReadLine());
						
			Console.ReadKey();
			
		}
		
		public static void  sendCmd (string cmd) {
			
			Socket s = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
			s.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
			IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 14568);
			Byte[] data = Encoding.ASCII.GetBytes(cmd);
			s.SendTo(data,ipep);
		}
	}
}