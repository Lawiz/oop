using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace laba14_newVersion
{
	class SerializbleController
	{

		public static object bynarySerializToFile(object obj)
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using (MemoryStream fs = new MemoryStream())
			{
				formatter.Serialize(fs, obj);
				formatter.Context = new StreamingContext(StreamingContextStates.Clone);
				fs.Position = 0;
				Console.WriteLine("Объект сериализован");
				return formatter.Deserialize(fs);
			}
			
		}
		//public static void SoapSerializToFile(object obj)
		//{
		//	SoapFormatter formatter = new SoapFormatter();
		//	using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
		//	{
		//		formatter.Serialize(fs, obj);

		//		Console.WriteLine("Объект сериализован");
		//	}

		//}
		public static void JSONSerializToFile(object obj)
		{
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(object));

			using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
			{
				jsonFormatter.WriteObject(fs, obj);
			}
			Console.WriteLine("обьект сериализован");
				
		}
		public static void XMLSerializToFile(object obj)
		{
			
			using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
			{
				XmlSerializer formatter = new XmlSerializer(typeof(object));
				formatter.Serialize(fs, formatter);	

				Console.WriteLine("Объект сериализован");
				formatter.Deserialize(fs);
				Console.WriteLine("обьект десириализован");
			}
		}
		public static void exampleXPath()
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load(@"C:\Users\petrs.PETR\OneDrive\oop\oop\laba14 newVersion\users.xml");
			XmlElement xRoot = xDoc.DocumentElement;

			// выбор всех дочерних узлов
			XmlNodeList childnodes = xRoot.SelectNodes("*");
			foreach (XmlNode n in childnodes)
				Console.WriteLine(n.OuterXml);
			 childnodes = xRoot.SelectNodes("user");
			foreach (XmlNode n in childnodes)
				Console.WriteLine(n.SelectSingleNode("@name").Value);
			Console.ReadKey();
		}
		public static void exampelLINQInXml()
		{
			XDocument xdoc = XDocument.Load(@"C:\Users\petrs.PETR\OneDrive\oop\oop\laba14 newVersion\phones.xml");
			foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
			{
				XAttribute nameAttribute = phoneElement.Attribute("name");
				XElement companyElement = phoneElement.Element("company");
				XElement priceElement = phoneElement.Element("price");

				if (nameAttribute != null && companyElement != null && priceElement != null)
				{
					Console.WriteLine("Смартфон: {0}", nameAttribute.Value);
					Console.WriteLine("Компания: {0}", companyElement.Value);
					Console.WriteLine("Цена: {0}", priceElement.Value);
				}
				Console.WriteLine();
				
			}
			Console.ReadKey();
		}


	}
}
