using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismHomework
{
    internal class ChildClass
    {
        public int MyMethod(int a)
        {
            return a;
        }

        public float MyMethod(float a, float b) 
        { 
            return a + b;
        }
    }
}
