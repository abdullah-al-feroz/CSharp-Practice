using DictionaryExample;
using System.Collections.Generic;

Customer c1 = new Customer();
{
    c1.Id = 101;
    c1.Name = "Faysal";
    c1.Salary = 5000;
};

Customer c2 = new Customer();
{
    c2.Id = 102;
    c2.Name = "Rahat";
    c2.Salary = 6000;
};

Customer c3 = new Customer();
{
    c3.Id = 103;
    c3.Name = "Sarder";
    c3.Salary = 6500;
};

Dictionary<int, Customer> dic = new Dictionary<int, Customer>();
dic.Add(c1.Id, c1);
dic.Add(c2.Id, c2);
dic.Add(c3.Id, c3);
if (!dic.ContainsKey(c1.Id))
{
    dic.Add(c1.Id, c3);
}

//------Convert an array into a dictionary
List<Customer> customers = new List<Customer>();
    customers.Add(c1);
    customers.Add(c2);
    customers.Add(c3);

Dictionary<int, Customer> dictionary = customers.ToDictionary(cust => cust.Id, cust => cust);

foreach(KeyValuePair<int, Customer> kvp in dic)
{
    Console.WriteLine("Key = {0}", kvp.Key);
    Customer c = kvp.Value;
    Console.WriteLine("Id = {0}, Name = {1}, Salary={2}", c.Id, c.Name, c.Salary);
}





//TryGetValue Method
Customer cust;
if(dic.TryGetValue(119, out cust))
{
    Console.WriteLine("Id = {0}, Name = {1}, Salary={2}", cust.Id, cust.Name, cust.Salary);
}
else
{
    Console.WriteLine("The key is not found");
}

//Count property
//Console.WriteLine("Total Items = {0}", dic.Count);
Console.WriteLine("Total Items = {0}", dic.Count(a => a.Value.Salary > 4000)) ; ;

//Remove
//dic.Remove(101);

//Remove all items
dic.Clear();

//if (dic.ContainsKey(119))
//{
//   Customer c119 = dic[119];
//}

//foreach(var customerKeyValuePair in dic)
//{
//    Console.WriteLine("Key ={0}", customerKeyValuePair.Key);
//    Customer customer = customerKeyValuePair.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Salary={2}", customer.Id, customer.Name, customer.Salary);
//    Console.WriteLine("--------------------------------");
//}

foreach (int key in dic.Keys)
{
    Console.WriteLine(key);
}