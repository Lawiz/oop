using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;

namespace laba5
{   [Serializable()]
    class trialexecein:Exception
    {
        public trialexecein(string message):base(message){ }
        public trialexecein(string message, Exception inner ):base(message, inner){ }
        public trialexecein(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context){ }
    }
}
