List<Employee> listEmployees = new List<Employee>()
{
    new Employee{Id = 101, Name ="Faysal" },
    new Employee{Id = 102, Name ="Rahat" },
    new Employee{Id = 103, Name ="Sarder" }

};

//Step2
//Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

//step 3

//Employee employee= listEmployees.Find(emp => FindEmployee(emp));
Employee employee= listEmployees.Find(delegate(Employee emp)
{
    return emp.Id == 102;
});
Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);
//step 1
//static bool FindEmployee(Employee emp)
//{
//    return emp.Id == 102;
//}
public class Employee
{
    public int Id { get; set; } 
    public string Name { get; set; }
}
