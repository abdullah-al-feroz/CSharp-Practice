using GenericExample;

bool Equal = Calculator<int>.AreEqual(10, 10);
if (Equal)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not Equal");
}