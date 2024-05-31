using System;

namespace InheritanceInCSharp
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;


        public void PrintFullName()
        {
            Console.WriteLine(FirstName+ " "+LastName);
        }
    }
}