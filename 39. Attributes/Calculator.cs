using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class Calculator
    {
        [Obsolete("Use Add(List<int> Numbers) Method")]
        public static int Add(int FirstName, int SecondNumber)
        {
            return FirstName + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int Number in Numbers)
            {
                Sum = Sum + Number;
            }
            return Sum;
        }
    }
}
