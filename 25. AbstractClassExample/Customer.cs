using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class Customer
    {
        public abstract void Print(); // its not mendatory abstract type abstract class can have all members

        //Note: Any abstract class can not have implementation
    }

    //public abstract sealed class Customer
    //{
    //    public abstract void Print();
    //}
    //Error! because abstract class can not be sealed and sealed class can not be abstract
}
