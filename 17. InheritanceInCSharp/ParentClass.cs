using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Construtor Callded");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }
}
