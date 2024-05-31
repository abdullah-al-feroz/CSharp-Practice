
using EnumExample;

Customer[] customers = new Customer[3];
customers[0] = new Customer
{
    Name = "Faysal",
    Gender = Gender.Male,
};

customers[1] = new Customer
{
    Name = "Rahi",
    Gender = Gender.Female
};

customers[2] = new Customer
{
    Name = "Sarder",
    Gender = Gender.Unknown
};

foreach (Customer customer in customers)
{
    Console.WriteLine("Name ={0} && Gender ={1}", customer.Name, customer.Gender);
}

static string GetGender(Gender gender)
{
    switch (gender)
    {
        case Gender.Unknown:
            return "Unknown";
        case Gender.Male:
            return "Male";
        case Gender.Female:
            return "Female";
        default:
            return "Invalid data detected";
    }
}

public enum Gender
{
    Unknown,
    Male,
    Female
}