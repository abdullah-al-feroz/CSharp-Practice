//int i = 0;
//SimpleMethod(ref i);
//Console.WriteLine(i);

//static void SimpleMethod(ref int j)
//{
//    j = 101;
//}

///Another Example

int Total = 0;
int Product = 0;
Calculate(10,20, out Total, out Product);
Console.WriteLine("Sum={0} && Product = {1}", Total, Product);

static void Calculate(int FN, int SN, out int Sum, out int Product)
{
    Sum = FN + SN;
    Product = FN * SN;
}

//Another Example

int[] Numbers = new int[3];
    Numbers[0] = 101;
    Numbers[1] = 102;
    Numbers[2] = 103;

ParamsMethod(Numbers);

static void ParamsMethod(params int[] Numbers)
{
    Console.WriteLine("There are {0} elements", Numbers.Length);
    foreach(int i in Numbers)
    {
        Console.WriteLine(i);
    }
}
