using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace laba14_newVersion
{
	class SynchronousSocketListener
	{

			const int port = 8888; 
			public static void startServer()
			{
				TcpListener server = null;
				try
				{
					IPAddress localAddr = IPAddress.Parse("127.0.0.1");
					server = new TcpListener(localAddr, port);

					server.Start();

					while (true)
					{
						Console.WriteLine("Ожидание подключений... ");

						TcpClient client = server.AcceptTcpClient();
						Console.WriteLine("Подключен клиент. Выполнение запроса...");

						NetworkStream stream = client.GetStream();

						string response = "Привет мир";
						byte[] data = Encoding.UTF8.GetBytes(response);

						stream.Write(data, 0, data.Length);
						Console.WriteLine("Отправлено сообщение: {0}", response);
						client.Close();
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				finally
				{
					if (server != null)
						server.Stop();
				}
			}
		}
	}