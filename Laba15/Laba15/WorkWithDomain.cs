using System;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
namespace Laba15
{
	class WorkWithdomain
	{
		private readonly string name;
		
		public static void ShiwInformationFoCurentDomain()
		{
			
			AppDomain domain = AppDomain.CurrentDomain;
			Console.WriteLine("Name: {0}", domain.FriendlyName);
			Console.WriteLine("Base Directory: {0}", domain.BaseDirectory);
			Console.WriteLine();

			Assembly[] assemblies = domain.GetAssemblies();
			foreach (Assembly asm in assemblies)
				Console.WriteLine(asm.GetName().Name);

			Console.Read();

		}
		public static void CreateNewDomenLoadAssemblyAndUnload()
		{
			AppDomain secondaryDomain = AppDomain.CreateDomain("Secondary domain");
			secondaryDomain.AssemblyLoad += Domain_AssemblyLoad;
			secondaryDomain.DomainUnload += SecondaryDomain_DomainUnload;


			Console.WriteLine("Домен: {0}", secondaryDomain.FriendlyName);
			secondaryDomain.Load(new AssemblyName("Laba15"));
			Assembly[] assemblies = secondaryDomain.GetAssemblies();
			foreach (Assembly asm in assemblies)
				Console.WriteLine(asm.GetName().Name);
			AppDomain.Unload(secondaryDomain);
			Console.Read();
		}

		
		public static void countingNumber()
		{
			Console.WriteLine("enter numb");
			int numb = int.Parse(Console.ReadLine());

			new Task(n => WritngNubs(numb), 1000000).Start();
		}
		//public static void countingTwoNumbs()
		//{
		//	ThreadPool.QueueUserWorkItem(
		//new WaitCallback(countingEventNumbs),20);
		//	// Queue another task.  
		//	ThreadPool.QueueUserWorkItem(
		//		new SyWaitCallback(countingOddNumbs),20);
		//}
	
		private static void WritngNubs(int numb)
		{
			for(;numb>0;numb--){
				Console.WriteLine(numb);
				string path = @"C:\Users\petrs.PETR\OneDrive\oop\oop\Новый текстовый документ.txt";
				using (StreamWriter f=new StreamWriter(path)){
					f.WriteLine(numb);
				}
			}
		}
		//private static void countingEventNumbs(object _numb){
		//	int numb = (int)_numb;
		//	for(int i=0;i<numb;i++)
		//	{
		//		if (numb % 2 == 0)
		//			Console.WriteLine("1 thread:"+i);
		//	}
		//}
		//private static void countingOddNumbs(object _numb)
		//{
		//	int numb = (int)_numb;
		//	for (int i = 0; i < numb; i++)
		//	{
		//		if (numb % 2 == 1)
		//			Console.WriteLine("2 thread:"+i);
		//	}
		//}
		private static void SecondaryDomain_DomainUnload(object sender, EventArgs e)
		{
			Console.WriteLine("Домен выгружен из процесса");
		}

		private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
			Console.WriteLine("Сборка загружена");
		}
	}
	
}
