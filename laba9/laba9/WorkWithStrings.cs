using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
	 class WorkWithStrings
	{
        public void removeExtangeSpace(string str)
        {
            var words = str.Split(new[] { ',', '.', ';', '?', '!',' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join("", words));
        }
        public void caseUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public void AddSymbol(string str)
        {
            str = str.Insert(1, "#");
            str = str.Insert(2, "#");
            str = str.Insert(3, "#");
            str = str.Insert(4, "#");
            str = str.Insert(5, "#");
            Console.WriteLine(str);
        }
	}
}
