using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public interface ICustomer
    {
        //1. Example

        //void Print()
        //{
        //    Console.WriteLine("Hello");
        //}

        //Note: Error! Because interface can not have declaration its only have implementation

        //2.
        //Example:
        void Print();
        //Note: Interface number have public by default and it can not have access modifier
    }
}
