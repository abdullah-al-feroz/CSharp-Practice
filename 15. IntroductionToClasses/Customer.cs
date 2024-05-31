using System;

namespace IntroductionToClasses
{
    public class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() 
            : this("No FirstName Provide", "No LastName Provide")
        {
            
        }

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);

        }
        ~Customer()
        {

        }
    }
}
