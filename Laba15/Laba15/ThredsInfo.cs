using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Laba15
{
	class ThredsInfo
	{
		public static Process[] process = Process.GetProcesses();
		public static void ShowInformation()
		{
			foreach (Process process in Process.GetProcesses())
			{
				Console.WriteLine("ID: {0}  Name: {1}", process.Id, process.ProcessName);
			}
		}
	}
}
