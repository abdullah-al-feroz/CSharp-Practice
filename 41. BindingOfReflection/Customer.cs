using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingOfReflection
{
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName+" " + LastName;
        }
    }
}
