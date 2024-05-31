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

Queue<Customer> queueCustomer = new Queue<Customer>();
queueCustomer.Enqueue(customer1);
queueCustomer.Enqueue(customer2);
queueCustomer.Enqueue(customer3);

//Customer c1 = queueCustomer.Dequeue();
//Console.WriteLine(c1.Id+"-"+c1.Name);
//Console.WriteLine("Total items in the Queue = " + queueCustomer.Count);

//Customer c2 = queueCustomer.Dequeue();
//Console.WriteLine(c2.Id + "-" + c2.Name);
//Console.WriteLine("Total items in the Queue = " + queueCustomer.Count);

//Customer c3 = queueCustomer.Dequeue();
//Console.WriteLine(c3.Id + "-" + c3.Name);
//Console.WriteLine("Total items in the Queue = " + queueCustomer.Count);

//Customer c = queueCustomers.Peek();
//foreach(Customer c in queueCustomer)
//{
//    Console.WriteLine(c.Id+"-"+c.Name);
//    Console.WriteLine("Total Items in the Queue = " + queueCustomer.Count);
//}

//Customer c = queueCustomer.Peek();
//Console.WriteLine(c.Id+"-"+c.Name);
//Console.WriteLine("Total Items in the Queue = " + queueCustomer.Count);

//Customer c2 = queueCustomer.Peek();
//Console.WriteLine(c2.Id + "-" + c2.Name);
//Console.WriteLine("Total Items in the Queue = " + queueCustomer.Count);

if(queueCustomer.Contains(customer1))
{
    Console.WriteLine("Customer1 exists");
}
else
{
    Console.WriteLine("Customer1 do not exist");
}

public class Customer 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}
