using MethodHiding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName+" -Part Time");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName+"- Full Time");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Temporary");
    }
}