using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    static class SomeMathOperation
    {
        public static Set enumList(Set m)
        {
            m._list.Clear();
            return m;

        }
        public static Set deleteNumber (Set m,int p)
        {
            m._list.Remove(p);
            return m;
        }
        public static Set Reverse(Set m)
        {
            m._list.Reverse();
            return m;
        }
    }
}
