using System;

namespace MethodOverloading
{
    public class Calculator
    {
        public static int Add(int FN, int SN)
        {
            return FN + SN;
        }
        public static double Add(float FN, float SN, out float Sum)
        {
            Sum = FN + SN;
            return Sum;
        }    
    }
}
