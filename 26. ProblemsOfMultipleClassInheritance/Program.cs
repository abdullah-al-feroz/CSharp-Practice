﻿AB ab = new AB();
ab.AMethod();
ab.BMethod();




//D d = new D();
//d.Print();

//class A
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("A Implementaion");
//    }
//}

//class B : A
//{
//    public override void Print()
//    {
//        Console.WriteLine("B Implementation");
//    }
//}

//class C: A
//{
//    public override void Print()
//    {
//        Console.WriteLine("C Implementation");
//    }
//}

//class D : B, C
//{

//}

//This Problem solution using Interface

interface IA
{
    void AMethod();
}
class A: IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void BMethod();
}
class B: IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}