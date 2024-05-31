using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public class ChildClass: ParentClass
    {
        public ChildClass():base("Derived class controliling parent class")
        {
            Console.WriteLine("ChildClass Construtor called");
        }
    }
}
