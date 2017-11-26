using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Exam:Test
    {
        public string nameOfExam { get; set; }
        public Exam(string name)
        :base(name)
        {

        }
        public int markToExam()
        {
            return trueCaunt / (trueCaunt + falseCaunt) * 100;

        }
    }
}
