using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingVsMethodHiding
{
    public class DerivedClass:BaseClass
    {
        //public override void Print()
        //{
        //    Console.WriteLine("I am a Derived class Print method");
        //}

        ///Method hiding example
        public new void Print()//new keyword use for hiding
        {
            Console.WriteLine("I am a Derived class Print method");
        }
    }
}
