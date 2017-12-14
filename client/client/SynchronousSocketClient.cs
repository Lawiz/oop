using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace client
{
	class SynchronousSocketClient
	{
		private const int port = 8888;
		private const string server = "127.0.0.1";

		static void Main(string[] args)
		{
			try
			{
				TcpClient client = new TcpClient();
				client.Connect(server, port);

				byte[] data = new byte[256];
				StringBuilder response = new StringBuilder();
				NetworkStream stream = client.GetStream();

				do
				{
					int bytes = stream.Read(data, 0, data.Length);
					response.Append(Encoding.UTF8.GetString(data, 0, bytes));
				}
				while (stream.DataAvailable);

				Console.WriteLine(response.ToString());

				// Закрываем потоки
				stream.Close();
				client.Close();
			}

			//допусттим клиент не установил связь с серваком и выдасться сообщение мол ты еблантус
			//  и прога закроется
			catch (SocketException e)// а ента шняга отловит исключение и просто в кансоль выведет мол не судьба, не подрубились
			//и можно потом опять попробовать
			{
				Console.WriteLine("SocketException: {0}", e);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: {0}", e.Message);
			}

			Console.WriteLine("Запрос завершен...");
			Console.Read();
		}
	}
}