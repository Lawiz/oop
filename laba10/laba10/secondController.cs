using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
	class secondController
	{
		public SortedDictionary<int, string> dictionary;
		public List<string> list;
		private static Random random = new Random((int)DateTime.Now.Ticks);

		public secondController(int count)
		{
			dictionary = new SortedDictionary<int,string>();
			
			for(int i=0; i<count;i++)
			{
				string str = RandomString(16);
				dictionary.Add(i, str);
			}
			list = new List<string>();
			foreach(string stringValue in dictionary.Values)
			{
				list.Add(stringValue);
			}
			
		}
		//public void addOtheElements(string[] args)
		//{
		//	int iterator = 0;
		//	for(int i=dictionary.Count*(-1);i<dictionary.Count+args.Length*(-1)+1;i++)
		//	{
		//		dictionary.Add(i, args[iterator]);
		//		iterator++;
		//	}
		//}
		public void deleteRange(int startRange, int stopRange)
		{
			for (int i = startRange; i < stopRange;i++)
			{
				dictionary.Remove(i);
			}
		}
		public void Print()
		{
			foreach (KeyValuePair<int, string> keyValue in dictionary)
			{
				Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
			}
		}
		public void findInSecondColection(string findString)
		{
			int flag = 0;
			for(int i=0; i<list.Count;i++)
			{
				if (findString == list[i])
					Console.WriteLine("the serch string under the index" + i);
				else flag++;
			}
			if (flag == list.Count)
				Console.WriteLine("string not found");
		}
		public void secondColectionPrint()
		{
			foreach(string iterator in list)
			{
				Console.Write(iterator + " ");
			}
		}
		private string RandomString(int size)
		{
			StringBuilder builder = new StringBuilder();
			char ch;
			for (int i = 0; i < size; i++)
			{
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
				builder.Append(ch);
			}

			return builder.ToString();
		}

		
	}
}
