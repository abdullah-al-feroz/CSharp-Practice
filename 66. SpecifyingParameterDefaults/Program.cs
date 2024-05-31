//Test(1, c:2);
Test(1, 2);

static void Test(int a, int b = 10, int c = 20)
{
    Console.WriteLine("a =" + a);
    Console.WriteLine("b =" + b);
    Console.WriteLine("c =" + c);
}


