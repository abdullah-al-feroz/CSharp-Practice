
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main started");
        Thread T1 = new Thread(Program.Thread1Function);
        T1.Start();


        Thread T2 = new Thread(Program.Thread2Function);
        T2.Start();

        if(T1.Join(1000))
        {
            
            Console.WriteLine("ThreadFunction Completed");
        }
        else
        {
            Console.WriteLine("ThreadFunction has not completed in 1 Second");
        }

        for(int i = 1; i<=10; i++)
        {
            if (T1.IsAlive)
            {
                Console.WriteLine("ThreadFunction is still doing it work");
            }
            else
            {
                Console.WriteLine("Thread1Function Completed");
            }
        }

        T2.Join();
        Console.WriteLine("Thread2Funtion Completed");

        Console.WriteLine("Main COmpleted");
    }
    static void Thread1Function()
    {
        Console.WriteLine("Thread1Function started");
        Thread.Sleep(5000);
        Console.WriteLine("ThradFunction is about to return");
    }

    static void Thread2Function()
    {
        Console.WriteLine("Thread1Function started");
    }
}