using ExplicitInterfaces;


public class Program : IInterface1, I2
{
    //ex-2


    public void InterfaceMethod() //Explicitly implementing Interface1 method
    {
        Console.WriteLine("IInterface1 Interface method");
    } //Inteterface1 method normailly and I2 method explicitly

    //void IInterface1.InterfaceMethod() //Explicitly implementing Interface1 method
    //{
    //    Console.WriteLine("IInterface1 Interface method");
    //}

    void I2.InterfaceMethod() // Explicitly implementing Interface2 method
    {
        Console.WriteLine("IInterface2 Interface method");
    }

    public static void Main()
    {
        Program p = new Program();
        ((IInterface1)p).InterfaceMethod(); //type casting 
        ((I2)p).InterfaceMethod(); //type casting

        //or
        IInterface1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();

        //ex-2
        Program p1 = new Program();
        p1.InterfaceMethod();
        ((I2)p).InterfaceMethod(); //type casting
    }
}


