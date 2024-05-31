

List<Employee> listEmployees = new List<Employee>()
{
    new Employee { Id = 101, Name = "Rahat" },
    new Employee { Id = 102, Name = "Faysal" },
    new Employee { Id = 103, Name = "Sarder" },
};

Func<Employee, string> selector = employee => "Name =" + employee.Name;
//IEnumerable<string>names = listEmployees.Select(selector);
IEnumerable<string>names = listEmployees.Select(employee => "Name ="+ employee.Name);
foreach(string name in names)
{
    Console.WriteLine(name);
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }    
}

