using MethodHiding;

Employee[] employees = new Employee[4];

employees[0] = new Employee();
employees[1] = new PartTimeEmployee(); // A BaseClass Reference Variable can contain child class object
employees[2] = new FullTimeEmployee();
employees[3] = new TemporaryEmployee();

foreach(Employee employee in employees)
{
    employee.PrintFullName();
}