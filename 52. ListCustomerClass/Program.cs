using ListCustomerClass;

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
    c2.Salary = 6100;
};

Customer c3 = new Customer();
{
    c3.Id = 103;
    c3.Name = "Sarder";
    c3.Salary = 6500;
};

List<Customer> customers = new List<Customer>(2);
customers.Add(c1);
customers.Add(c2);
customers.Add(c3);
//customers.Insert(0, c3); //insert specify the index position which location push item
//customers.IndexOf(c3);
//Console.WriteLine(customers.IndexOf(c3));
//Console.WriteLine(customers.IndexOf(c3, 1));//1 is index position
//Console.WriteLine(customers.IndexOf(c3, 1, 3));//3 is element

//---------------**Contains method*-----------------------
//if (customers.Contains(c3))
//{
//    Console.WriteLine("Customer object exist in the list");
//}
//else
//{
//    Console.WriteLine("Customer object does not exist in the list");
//}

//---------------**Contains method*-----------------------
//if (customers.Exists(cust => cust.Name.StartsWith("R")))
//{
//    Console.WriteLine("Customer object exist in the list");
//}
//else
//{
//    Console.WriteLine("Customer object does not exist in the list");
//}

//---------------**Find method*-----------------------
//Customer c = customers.Find(cust => cust.Salary > 5000);//Find method returns the object
//Console.WriteLine("ID ={0}, Name ={1}, Salary={2}", c.Id, c.Name, c.Salary);


//---------------**Find Last method*-----------------------
//Customer c = customers.FindLast(cust => cust.Salary > 5000);//Find method returns the object
//Console.WriteLine("ID ={0}, Name ={1}, Salary={2}", c.Id, c.Name, c.Salary);

//---------------**Find All method*-----------------------
//List<Customer> cust= customers.FindAll(cust => cust.Salary > 5000);//Find All method returns list who satisfy the condition
//foreach(Customer c in cust)
//{
//    Console.WriteLine("ID ={0}, Name ={1}, Salary={2}", c.Id, c.Name, c.Salary);
//}

//---------------**Find Index*-----------------------
//int index = customers.FindIndex(2,cust => cust.Salary > 5000);//2 is index
//Console.WriteLine("index = " + index);

//---------------**Find Last Index*-----------------------
//int index = customers.FindLastIndex(cust => cust.Salary > 5000);//2 is index
//Console.WriteLine("index = " + index);

//foreach(Customer c in customers)
//{
//    Console.WriteLine(c.Id);
//}
//for (int i = 0; i < customers.Count; i++)
//{
//    Customer c = customers[i];
//    Console.WriteLine("ID={0}, Name={1},Salary={2}", c.Id, c.Name, c.Salary);
//}

//foreach(Customer c in customers)
//{
//    Console.WriteLine("ID={0}, Name={1},Salary={2}", c.Id, c.Name, c.Salary);
//};



////-------------------ToList method--------------------

//Customer[] customerArray = new Customer[3];
//customerArray[0] = c1;
//customerArray[1] = c2;
//customerArray[2] = c3;

//List<Customer> listCustomers = customerArray.ToList();
//foreach (Customer c in customers)
//{
//    Console.WriteLine("ID={0}, Name={1},Salary={2}", c.Id, c.Name, c.Salary);
//};


//--- List To Array
//List<Customer> listCustomers = new List<Customer>();
//listCustomers.Add(c1);
//listCustomers.Add(c2);
//listCustomers.Add(c3);

//foreach (Customer c in listCustomers)
//{
//    Console.WriteLine("ID={0}, Name={1},Salary={2}", c.Id, c.Name, c.Salary);
//};

//----------------List TO Dictionary

List<Customer> listCustomers = new List<Customer>();
listCustomers.Add(c1);
listCustomers.Add(c2);
listCustomers.Add(c3);

Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.Id);
foreach (KeyValuePair<int, Customer> kvp in dictionary)
{
    Console.WriteLine("Key = "+ kvp.Key);
    Customer c = kvp.Value;
    Console.WriteLine("ID={0}, Name={1},Salary={2}", c.Id, c.Name, c.Salary);
};