using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Question:Trial
    {
        public string question { get; set; }
        public Question(string name)
        :base(name)
        {
            if (name == null)
                throw new Questionexception("вопрос не введен");
            else
            {
                question = name;

            }


        }

       

        public bool checkQuestion(string response)
        {
            if (question == response)
                return true;
            else
                return false;
        }
    }
}
