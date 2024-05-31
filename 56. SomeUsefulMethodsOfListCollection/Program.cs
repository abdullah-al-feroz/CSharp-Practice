
using System.Collections.ObjectModel;

Customer customer1 = new Customer();
{
    customer1.Id = 101;
    customer1.Name = "Faysal";
    customer1.Salary = 5000;
}

Customer customer2 = new Customer();
{
    customer2.Id = 102;
    customer2.Name = "Rahat";
    customer2.Salary = 5500;
}

Customer customer3 = new Customer();
{
    customer3.Id = 103;
    customer3.Name = "Sarder";
    customer3.Salary = 6000;
}

List<Customer> listCustomers = new List<Customer>(4);
listCustomers.Add(customer1);
listCustomers.Add(customer2);
listCustomers.Add(customer3);

Console.WriteLine("Are all salaries greate than 5000 = " +
listCustomers.TrueForAll(x => x.Salary > 4500));

ReadOnlyCollection<Customer> readOnlyCustomers = listCustomers.AsReadOnly();
Console.WriteLine("Item = "+ readOnlyCustomers.Count);

Console.WriteLine("Capacity before triming = " + listCustomers.Capacity);
listCustomers.TrimExcess();
Console.WriteLine("Capacity after triming =" + listCustomers.Capacity);


public class Customer
{
    public int Id { get; set; }
    public string Name { get; set;}
    public int Salary { get; set; }
}
