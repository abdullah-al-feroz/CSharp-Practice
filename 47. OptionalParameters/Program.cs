AddNumbers(10, 20, new object[] { 30, 40, 50 });

static void AddNumbers(int firtsNumber, int secondNumber, params object[] restOfNumbers)
{
    int result = firtsNumber + secondNumber;
    if(restOfNumbers!= null)
    {
        foreach(int i in restOfNumbers)
        {
            result += i;
        }
    }
    Console.WriteLine("Sum=" + result);
}