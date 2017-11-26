using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Trial
    {
        public string areaOfTrial { get; set; }

        public Trial(string name)
        {
            if (name == "" || name == null)
                throw new trialexecein("имя не введено");
        }

        public void goTrial()
        {
            Console.WriteLine("испытание " + areaOfTrial + "пройдено");
        }
    }
}
