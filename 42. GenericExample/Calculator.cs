using System;

namespace GenericExample
{
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
