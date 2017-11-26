using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    class Person
    {
        public string name{ get; set; }
        public string surname{ get; set; }
        public void scan()
        {
            Console.WriteLine(name, surname);
        }
    }
}
