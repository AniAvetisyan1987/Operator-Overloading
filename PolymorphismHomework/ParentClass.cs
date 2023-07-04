using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismHomework
{
    internal class ParentClass
    {
        public virtual void MyParentMethod()
        {
            Console.WriteLine("Parent Class");
        }

        public void StaticMethod()
        {
            Console.WriteLine("Parent Class Static method");
        }
    }

    internal class ChildClass2 : ParentClass
    {
        public override void MyParentMethod()
        {
            Console.WriteLine("Child2 class");
        }

        public void StaticMethod()
        {
            Console.WriteLine("Child Class Static method");
        }
    }
}
