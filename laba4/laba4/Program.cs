using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace laba4
{
    class Program
    {

        struct Employee
        {

            public string name;
            public short deptID;
        }

        public static void Main()
        {
            string str = null;
            try
            {
                Set<string> test = new Set<string>(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("set new value to the your string-arg");
            }
            Set<Employee> test2;
            Set<string> test1 = new Set<string>();
            string path = @"c:\temp\MyTest.txt";
            File.WriteAllLines(path,test1._list);
            string[] buff = File.ReadAllLines(path);
            
        }

    }
}

            

    



    

