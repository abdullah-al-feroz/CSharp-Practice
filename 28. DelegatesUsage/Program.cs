using DelegatesUsage;
using System.Collections.Generic;

static void Main()
{
    List<Employee> empList = new List<Employee>();
    empList.Add(new Employee() { Id = 101, Name = "Faysal", Salary = 50000, Experience = 5 });
    empList.Add(new Employee() { Id = 102, Name = "Faysal", Salary = 40000, Experience = 4 });
    empList.Add(new Employee() { Id = 103, Name = "Faysal", Salary = 60000, Experience = 6 });
    empList.Add(new Employee() { Id = 104, Name = "Faysal", Salary = 30000, Experience = 3 });

    //IsPromotable IsPromotable = new IsPromotable(Promote);
    //Employee.PromoteEmployee(empList, IsPromotable);

    Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
    //bool Promote(Employee emp)
    //{
    //    if(emp.Experience >= 5)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}
