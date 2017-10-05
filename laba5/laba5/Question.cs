using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Question:Trial
    {
        public string question { get; set; }
        public bool checkQuestion(string response)
        {
            if (question == response)
                return true;
            else
                return false;
        }
    }
}
