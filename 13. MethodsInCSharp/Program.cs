EvenNumbers(30);
int Sum = Add(10, 20);
Console.WriteLine("Sum {0}", Sum);

int Add(int FN, int SN)
{
    return FN + SN;
}

static void EvenNumbers(int Target)
{
    int Start = 0;

    while(Start <= Target)
    {
        Console.WriteLine(Start);
        Start = Start + 2;
    }

}