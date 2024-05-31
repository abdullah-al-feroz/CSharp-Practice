
//SampleDelegate del1, del2, del3, del4;
//del1 = new SampleDelegate(SampleMethodOne);
//del2 = new SampleDelegate(SampleMethodTwo);
//del3 = new SampleDelegate(SampleMethodThree);

//del4 = del1 + del2 + del3 - del2;
//del4();
//Note: if you want to chain delegate together its plus sign and remove minus sign

//Another way

//SampleDelegate del = new SampleDelegate(SampleMethodOne);
//del += SampleMethodTwo;
//del += SampleMethodThree;
//del -= SampleMethodOne;
//del();
//static void SampleMethodOne()
//{
//    Console.WriteLine("SampleMethodOne Invoked");
//}
//static void SampleMethodTwo()
//{
//    Console.WriteLine("SampleMethodTwo Invoked");
//}static void SampleMethodThree()
//{
//    Console.WriteLine("SampleMethodThree Invoked");
//}

//public delegate void SampleDelegate();

//Note: if the delegate return value


//SampleDelegate del = new SampleDelegate(SampleMethodOne);
//del += SampleMethodTwo;

//int DelegateReturnValue = del();
//Console.WriteLine("DelegateReturnValue = {0}", DelegateReturnValue);
//static int SampleMethodOne()
//{
//    return 1;
//}

//static int SampleMethodTwo()
//{
//    return 2;
//}

//public delegate int SampleDelegate();

SampleDelegate del = new SampleDelegate(SampleMethodOne);
del += SampleMethodTwo;

int DelegateOutputParameterValue = -1;
del(out DelegateOutputParameterValue);

Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);
static void SampleMethodOne(out int Number)
{
    Number = 1;
}

static void SampleMethodTwo(out int Number)
{
    Number = 2;
}

public delegate void SampleDelegate(out int Integer);
