using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Questionexception:Exception
    {
        public Questionexception(string messege)
        :base(messege)
        {
            
        }
    }
}
