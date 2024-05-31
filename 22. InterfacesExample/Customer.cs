using System;

namespace InterfacesExample
{
    public class Customer: ICustomer , IInterface2 //Class can Inherit inferface //Interface allowed multiple inheritance
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        //public void Print(int Name)
        //{ 
        //}
        //Note: Error! because its signature is not same in interface
        public void Print()
        {
            Console.WriteLine("Interface Print Method");  
        }
    }
}
