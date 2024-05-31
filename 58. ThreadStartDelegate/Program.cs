//Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
//Or
//Thread T1 = new Thread(() => Number.PrintNumbers());//if class is static then this function execute


//Number number = new Number(); //If non static then this intance create
//Thread T1 = new Thread(number.PrintNumbers);
T1.Start();

class Number
{
    public static void PrintNumbers()
    {
        for(int i =1; i<=10; i++)
        {
            Console.WriteLine(i);
        }
    }
}