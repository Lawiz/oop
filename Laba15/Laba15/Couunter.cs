using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Laba15
{
	class Couunter
	{
		public int _numb{ get; set; }
		private static void countingEventNumbs(int _numb)
		{
			int numb = (int)_numb;
			for (int i = 0; i < numb; i++)
			{
				if (numb % 2 == 0)
				Console.WriteLine("Выполняется задача {0}:{1}", Task.CurrentId,i);
				Thread.Sleep(1000);
			}
		}	
		private static void countingOddNumbs(int _numb)
		{
			int numb = (int)_numb;
			for (int i = 0; i < numb; i++)
			{
				if (numb % 2 == 1)
					Console.WriteLine("Выполняется задача {0}:{1}", Task.CurrentId, i);

			}
			Thread.Sleep(2000);
		}

		public static void Show(Object threadContext)
		{

			Parallel.For(1, 20, countingEventNumbs);
			Parallel.For(1, 20, countingOddNumbs);
		}


	}
}
