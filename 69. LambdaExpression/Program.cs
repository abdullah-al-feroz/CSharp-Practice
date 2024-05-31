List<Employee> listEmployees = new List<Employee>()
{
    new Employee{Id = 101, Name ="Faysal" },
    new Employee{Id = 102, Name ="Rahat" },
    new Employee{Id = 103, Name ="Sarder" }

};

Employee employee = listEmployees.Find(x => x.Id == 102);
Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);

int count = listEmployees.Count(x => x.Name.StartsWith("F"));
Console.WriteLine("Count"+ count);

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

