using System.Runtime.InteropServices;

//AddNumbers(10, 20, new int[] { 30, 40, 50 });
AddNumbers(10, 20);

static void AddNumbers(int firtsNumber, int secondNumber, [Optional]int[] restOfNumbers)
{
    int result = firtsNumber + secondNumber;
    if (restOfNumbers != null)
    {
        foreach (int i in restOfNumbers)
        {
            result += i;
        }
    }
    Console.WriteLine("Sum=" + result);
}