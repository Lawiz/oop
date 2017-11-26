using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    interface IGeneric<universType1> where universType1: class
    {
        void Add(universType1 obj);
        void Del();
        universType1 LookAt(int index);
    }
}
