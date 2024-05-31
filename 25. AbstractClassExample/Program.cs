
using AbstractClassExample;

//public class Program : Customer
//{
//    public static void Main()
//    {
//        throw new NotImplementedException();
//    }
//}

//Note: Error! beacuse, a non abstract class derived from an abstract class
//must be provide implementations for all inherited abstract members

//public abstract class Program : Customer
//{
//    public static void Main()
//    {

//    }
//}

//NOte: No error because program and customer both abstract class

public class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print Method");
    }
    public static void Main()
    {
        Customer c = new Program();
        c.Print();
    }
}