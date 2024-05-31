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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName+" " + LastName);
        }
    }
}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName+" " + LastName + "-Contractor");
    } 
  
}

public class FullTimeEmployee : Employee
{

}