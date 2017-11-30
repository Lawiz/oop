using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace laba14_newVersion
{
	[DataContract]
	[Serializable]
	class ArrayListController
	{
		public ArrayList arr1{ get; set; }
		public ArrayListController(int count)
		{
			arr1 = new ArrayList();
			Random rnd = new Random();
			for(int i=1;i<count;i++){
				arr1.Add(rnd.Next(100));
			}

		}
		public void addString(string str)
		{
			arr1.Add(str);
		}
		public void deleteElem()
		{
			Console.WriteLine("введите индекс элемента, который хотите удалить");
			int deleteNumb = int.Parse(Console.ReadLine());
			try{
				arr1.Remove(deleteNumb);
			}
			catch{
				Console.WriteLine("введенный вами индес привышает размерность списка");
				deleteElem();
			}
		}
		public void printArr()
		{
			Console.WriteLine("колличетсво элементов в списке=" + arr1.Count);
			for(int i=0;i<arr1.Count;i++)
			{
				Console.Write(arr1[i] + " ");
			}
			Console.WriteLine(" ");
		}
		public int findOfValue(string value)
		{
			for(int i=0;i<arr1.Count;i++){
				if (arr1[i].ToString() == value)
				{
					return i;
#pragma warning disable CS0162 // Обнаружен недостижимый код
					break;
#pragma warning restore CS0162 // Обнаружен недостижимый код
				}
			}
			return 0;
		}
	}
}
