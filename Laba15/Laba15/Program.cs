 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba15
{
	class Program
	{
		static void Main(string[] args)
		{
			ThredsInfo.ShowInformation();
			WorkWithdomain.ShiwInformationFoCurentDomain();
			WorkWithdomain.CreateNewDomenLoadAssemblyAndUnload();
			WorkWithdomain.countingNumber();
			Console.WriteLine("----------------------------------------------");
			Couunter.Show(20);
			Console.ReadKey();
		}
	}
}
