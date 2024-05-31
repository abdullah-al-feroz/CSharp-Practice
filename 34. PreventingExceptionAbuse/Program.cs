try
{
    Console.WriteLine("Please Enter Numerator");
    //int Numerator = Convert.ToInt32(Console.ReadLine());
    int Numerator;
    bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

    if(IsNumeratorConversionSuccessful)
    {
        Console.WriteLine("Please enter denominator");
        int Denominator;
        bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(),out Denominator);
        if(IsDenominatorConversionSuccessful && Denominator != 0)
        {
            int Result = Numerator / Denominator;
            Console.WriteLine("Result = {0}", Result);

        }
        else
        {
            if (Denominator == 0)
            {
                Console.WriteLine("Denominator Can not be zero");
            }
            else
            {
                Console.WriteLine("Denominator should be a valid number between {0} && {1} ar allowed", Int32.MinValue, Int32.MaxValue);
            }
        }
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}