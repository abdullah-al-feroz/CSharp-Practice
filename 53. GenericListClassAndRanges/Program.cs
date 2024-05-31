using GenericListClassAndRanges;
using static GenericListClassAndRanges.Customer;

List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
Console.WriteLine("Numbers before sorting");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

numbers.Sort();

Console.WriteLine("Numbers after sorting");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

numbers.Reverse();

Console.WriteLine("Numbers in descending order");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

List<String> alphabets = new List<String>() { "A", "D", "B", "C" };
Console.WriteLine("Alphabet before sorting");
foreach (string alphabet in alphabets)
{
    Console.WriteLine(alphabet);
}

alphabets.Sort();
Console.WriteLine("Alphabet after sorting");
foreach (string alphabet in alphabets)
{
    Console.WriteLine(alphabet);
}

alphabets.Reverse();
Console.WriteLine("Alphabet in descending order");
foreach (string alphabet in alphabets)
{
    Console.WriteLine(alphabet);
}




Customer customer1 = new Customer();
{
    customer1.ID = 101;
    customer1.Name = "Rahat";
    customer1.Salary = 5000;
    customer1.Type = "Retail Customer";
}

Customer customer2 = new Customer();
{
    customer2.ID = 102;
    customer2.Name = "Faysal";
    customer2.Salary = 5500;
    customer2.Type = "Retail Customer";
}

Customer customer3 = new Customer();
{
    customer3.ID = 103;
    customer3.Name = "Sarder";
    customer3.Salary = 6000;
    customer3.Type = "Corporate Customer";
}

List<Customer> listCutomers = new List<Customer>();
listCutomers.Add(customer1);
listCutomers.Add(customer2);


List<Customer> listCorporateCutomers = new List<Customer>();
listCorporateCutomers.Add(customer3);

listCutomers.AddRange(listCorporateCutomers);
listCutomers.Remove(customer1);
listCutomers.RemoveAt(3);//3rd item remove
listCutomers.RemoveAll(x => x.Type == "Corporate Customer");
listCutomers.RemoveRange(3, 2);
listCutomers.InsertRange(0, listCorporateCutomers);//insert range insert multiple item at a time

List<Customer> customers =  listCutomers.GetRange(0, 3);

foreach(Customer c in listCutomers)
{
    Console.WriteLine("ID={0}, Name={1}, Salary={2}, Type={3}", c.ID, c.Name, c.Salary, c.Type);
}

Console.WriteLine("Before Sorting");
foreach (Customer c in listCutomers)
{
    Console.WriteLine(c.Salary);
}

listCutomers.Sort();
listCutomers.Reverse();
Console.WriteLine("After Sorting");
foreach (Customer c in listCutomers)
{
    Console.WriteLine(c.Salary);
}


//Name SOrting
Console.WriteLine("Before Sorting");
foreach (Customer c in listCutomers)
{
    Console.WriteLine(c.Name);
}

listCutomers.Sort();
listCutomers.Reverse();
Console.WriteLine("After Sorting");
foreach (Customer c in listCutomers)
{
    Console.WriteLine(c.Name);
}

//Sort Funtion
SortByName sortByName = new SortByName();
listCutomers.Sort(sortByName);
Console.WriteLine("After Sorting");
foreach (Customer c in listCutomers)
{
    Console.WriteLine(c.Name);
}