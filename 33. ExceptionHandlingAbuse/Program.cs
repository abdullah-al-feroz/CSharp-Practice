try
{
    Console.WriteLine("Please Enter Numerator");
    int Numerator = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter Your Denominator");
    int Denominator = Convert.ToInt32(Console.ReadLine());

    int Result = Numerator / Denominator;
    Console.WriteLine("Result = {0}", Result);
}
catch (FormatException)
{
    Console.WriteLine("Please enter a number");
}
catch(OverflowException)
{
    Console.WriteLine("Only numbers between {0} && {1} ar allowed",Int32.MinValue, Int32.MaxValue);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Dinominator Can not be zero");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}