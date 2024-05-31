using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingVsMethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base class Print method");
        }
    }
}
