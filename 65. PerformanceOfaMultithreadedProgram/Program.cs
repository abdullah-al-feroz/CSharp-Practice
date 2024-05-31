
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();
EvenNumbersSum();
OddNumbersSum();
stopwatch.Stop();
Console.WriteLine("Total milliseconds without multiple threads="+stopwatch.ElapsedMilliseconds);

stopwatch = Stopwatch.StartNew();
Thread T1 = new Thread(EvenNumbersSum);
Thread T2 = new Thread(OddNumbersSum);

T1.Start();
T2.Start();

T1.Join();
T2.Join();

stopwatch.Stop();
Console.WriteLine("Total milliseconds with multiple threads"+ stopwatch.ElapsedMilliseconds);



static void EvenNumbersSum()
{
    double Sum = 0;
    for(int i =0; i<=5000000; i++)
    {
        if (i % 2 == 0)
        {
            Sum = Sum + i;
        }
    }
    Console.WriteLine("Sum of even numbers ={0}", Sum);
}

static void OddNumbersSum()
{
    double Sum = 0;
    for (int i = 0; i <= 5000000; i++)
    {
        if (i % 2 == 1)
        {
            Sum = Sum + i;
        }
    }
    Console.WriteLine("Sum of odd numbers ={0}", Sum);
}
