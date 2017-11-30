using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace laba14_newVersion
{
	class Program
	{
		static void Main(string[] args)
		{

			ArrayListController arr = new ArrayListController(10);
			var copyToArr= SerializbleController.bynarySerializToFile(arr.arr1);
			foreach(var i in (ArrayList)copyToArr)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
			//SynchronousSocketListener.startServer();
			
		}
	}
}
