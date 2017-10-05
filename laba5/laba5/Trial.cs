using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Trial
    {
        public string areaOfTrial { get; set; }
        public void goTrial()
        {
            Console.WriteLine("испытание " + areaOfTrial + "пройдено");
        }
    }
}
