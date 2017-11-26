using System;
using System.Text;
using System.Reflection;
using System.IO;

namespace Laba12
{
	class Reflector
	{

		private Assembly[] assemblys = AppDomain.CurrentDomain.GetAssemblies();
		private string[] files = { @"C:\Users\petrs.PETR\OneDrive\oop\oop\Laba12\Laba12\ingoFoAssemles.txt",
		@"C:\Users\petrs.PETR\OneDrive\oop\oop\Laba12\Laba12\infoFoSinglAsseml.txt" };
		public void getInfoFoAssemblies()
		{
			foreach (Assembly assebly in assemblys)
			{
				using (FileStream file = new FileStream(files[0], FileMode.Append))
				{
					byte[] array = Encoding.Default.GetBytes("Assebly:" + assebly + "\r\n");
					file.Write(array, 0, array.Length);
					file.Flush();
					file.Close();
				}
				foreach (Type type in assebly.ExportedTypes)
				{
					using (FileStream file = new FileStream(files[0], FileMode.Append))
					{
						byte[] array = Encoding.Default.GetBytes("Type:" + type + "\r\n");
						file.Write(array, 0, array.Length);
						file.Flush();
						file.Close();
					}
					foreach (MemberInfo memeber in type.GetTypeInfo().DeclaredMembers)
					{
						string typeName = string.Empty;
						if (memeber is Type) typeName = "(Nested) Type";
						if (memeber is FieldInfo) typeName = "FieldInfo";
						if (memeber is MethodInfo) typeName = "MetodInfo";
						if (memeber is ConstructorInfo) typeName = "ConstructorInfo";
						if (memeber is PropertyInfo) typeName = "PropertyInfo";
						if (memeber is EventInfo) typeName = "EventInfo";
						using (FileStream file = new FileStream(files[0], FileMode.Append))
						{
							byte[] array = Encoding.Default.GetBytes(typeName + ":" + memeber + "\r\n" + "----------------------------" + "\r\n");

							file.Write(array, 0, array.Length);
							file.Flush();
							file.Close();
						}
					}
				}
			}
		}
		public void printInFileInfoForClass(string nameOfClass)
		{

			Assembly assembly = Assembly.LoadFrom(@"C:\Users\petrs.PETR\OneDrive\oop\oop\laba10\laba10\bin\Debug\laba10.exe");
			var types = assembly.DefinedTypes;
			foreach (var i in types)
			{
				if (i.Name.Equals(nameOfClass))
				{
					Show(i.FullName);
					foreach (var methods in i.GetRuntimeMethods())
					{
						Show(methods.ToString());

					}
					foreach (var property in i.GetRuntimeProperties())
					{
						Show(property.ToString());
					}
					foreach (var index in i.GetRuntimeFields())
					{
						Show(index.ToString());
					}
					foreach (var intrfaceInClass in i.GetInterfaces())
					{
						Show(intrfaceInClass.ToString());
					}
				}

			}




		}
		private void Show(string information)
		{
			using (FileStream file = new FileStream(files[1], FileMode.Append))
			{
				byte[] array = Encoding.Default.GetBytes("Assebly:" + information + "\r\n");
				file.Write(array, 0, array.Length);
				file.Flush();
				file.Close();
			}
		}
		public static void StartMethodFromClass(string nameOfClass,string nameOfMethod)
		{
			Assembly assembly = Assembly.LoadFrom(@"C:\Users\petrs.PETR\OneDrive\oop\oop\laba10\laba10\bin\Debug\laba10.exe");
			var type1 = assembly.DefinedTypes;
			Type type=default(Type);
			foreach(var i in type1)
			{
				if (i.Name.Equals(nameOfClass))
					type = i;
					
			}
			object calledClass = Activator.CreateInstance(type,10);
			var method = type.GetMethod(@nameOfMethod);
			object result = method.Invoke(calledClass, new object[] {"dfd" });
			Console.WriteLine("result{0}:", result);

		}




	}

	}

