using System.Reflection;
using System.Xml.Linq;
using WhyEnum;

Customer[] customers = new Customer[3];
customers[0] = new Customer
{
    Name = "Faysal",
    Gender = 1
};

customers[1] = new Customer
{
    Name = "Rahat",
    Gender = 2
};

customers[2] = new Customer
{
    Name = "Sarder",
    Gender = 0
};

foreach(Customer customer in customers)
{
    Console.WriteLine("Name ={0} && Gender ={1}", customer.Name, customer.Gender);
}

static string GetGender(int gender)
{
    switch (gender)
    {
        case 0:
            return "Unknown";
        case 1:
            return "Male";
        case 2:
            return "Female";
        default:
            return "Invalid data detected";
    }
}