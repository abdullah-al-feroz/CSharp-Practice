
static void PrintSum(int sum)
{
    Console.WriteLine("Sum of Numbers = " + sum);
}

Console.WriteLine("Please Enter your target number");
int target = Convert.ToInt32(Console.ReadLine());

SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);
Number number = new Number(target, callback);

Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
T1.Start();

class Number
{
    int _target;
    SumOfNumbersCallback _callBackMethod;

    public Number(int target, SumOfNumbersCallback callBackMethod)
    {
        this._target = target;
        this._callBackMethod = callBackMethod;
    }
    public void PrintNumbers()
    {
        int sum = 0;

        for (int i = 1; i <= _target; i++)
        {
            sum = sum + i;
        }

        if (_callBackMethod != null)
            _callBackMethod(sum);
    }
}
public delegate void SumOfNumbersCallback(int SumOfNUmbers);