using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Program
    {
		delegate void message();
        static void Main(string[] args)
        {
            Boss machine1 = new Boss();

            machine1.Turn_on += () => Console.WriteLine("сработало первое событие");
            machine1.UpgradeEvent += () => Console.WriteLine("сработало второе событие");
            machine1.On();
            machine1.Upgrade();


            string hrenStr = @"jfnfkjnkk\sfnj   nfjvnkjn?!   !fjnjnfgnHBHBHBnjnjfnbHIIbh";
            Console.WriteLine("исходная строка=" + hrenStr);
            WorkWithStrings workArea = new WorkWithStrings();
            workArea.AddSymbol(hrenStr);
            workArea.caseUpper(hrenStr);
            workArea.removeExtangeSpace(hrenStr);
           
            Console.ReadKey();
        }
        
    }
}
