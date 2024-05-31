using System.Threading;

Console.WriteLine("Please Enter your target number");
Object target = Console.ReadLine();

//Number number = new Number();
//ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
//Thread T1 = new Thread(parameterizedThreadStart);
//T1.Start(target);

//Explicitly creating an instance of parameterizedThreadStart
Number number = new Number();
Thread T1 = new Thread(number.PrintNumbers);
T1.Start(target);

class Number
{
    public void PrintNumbers(Object target)
    {
        int number = 0;
        if(int.TryParse(target.ToString(), out number)) 
        {
            for(int i = 0; i <= number;  i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}