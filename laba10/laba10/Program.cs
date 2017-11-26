using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace laba10
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayListController arrExample = new ArrayListController(20);
			arrExample.printArr();
			
			arrExample.addString("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
			arrExample.printArr();
			arrExample.deleteElem();
			arrExample.printArr();
			arrExample.findOfValue(arrExample.arr1[0].ToString());
			//the second part of the laba
			secondController example = new secondController(20);
			example.Print();
			example.deleteRange(1, 10);
			string[] str=new string[10];
			for(int i=0;i<10;i++)
			{
				str[i] = RandomString(16);
			}
			//example.addOtheElements(str);
			example.secondColectionPrint();
			example.findInSecondColection("qwertyuiopasdfgh");
			Console.ReadKey();
		}
		private static string RandomString(int size)
		{
			Random random = new Random((int)DateTime.Now.Ticks);

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
