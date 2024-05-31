Customer customer1 = new Customer()
{
    Id = 101,
    Name = "Faysal",
    Gender = "Male"
};
Customer customer2 = new Customer()
{
    Id = 102,
    Name = "Rahat",
    Gender = "Male"
};
Customer customer3 = new Customer()
{
    Id = 103,
    Name = "Y",
    Gender = "Female"
};

Stack<Customer> stackCustomers = new Stack<Customer>();
stackCustomers.Push(customer1);
stackCustomers.Push(customer2);
stackCustomers.Push(customer3);

//Customer c1 = stackCustomers.Pop();
//Console.WriteLine(c1.Id + "-" + c1.Name);
//Console.WriteLine("Items left in the stack =" + stackCustomers.Count);

//Customer c2 = stackCustomers.Pop();
//Console.WriteLine(c2.Id + "-" + c2.Name);
//Console.WriteLine("Items left in the stack =" + stackCustomers.Count);

//Customer c3 = stackCustomers.Pop();
//Console.WriteLine(c3.Id + "-" + c3.Name);
//Console.WriteLine("Items left in the stack =" + stackCustomers.Count);

//or
//foreach(Customer c1 in stackCustomers)
//{
//    Console.WriteLine(c1.Id + "-" + c1.Name);
//    Console.WriteLine("Items left in the stack =" + stackCustomers.Count);
//}

Customer c1 = stackCustomers.Peek();
Console.WriteLine(c1.Id + "-" + c1.Name);
Console.WriteLine("Items left in the stack =" + stackCustomers.Count);

stackCustomers.Contains(customer1);

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}
