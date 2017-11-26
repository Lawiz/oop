using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
	class Program
	{
		static void Main(string[] args)
		{
			Reflector reflector = new Reflector();
			reflector.getInfoFoAssemblies();
			reflector.printInFileInfoForClass("ArrayListController");
			Reflector.StartMethodFromClass(@"ArrayListController", "addString");
		}
	}
}
