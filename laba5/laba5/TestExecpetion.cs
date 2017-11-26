using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class TestExecpetion:Exception
    {
        public TestExecpetion(string message)
        :base(message)
        {
            
        }
    }
}
