using System;

namespace DelegatesUsage
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isElligaiblePromote)
        {
            foreach(Employee employee in employeeList)
            {
                //if(employee.Experience >= 5)// it's hardcoded logic for this reason we use delegate
                if(isElligaiblePromote(employee))
                {
                    Console.WriteLine(employee.Name + "Promoted");
                }
            }
        }
    }
    delegate bool IsPromotable(Employee empl);

}
