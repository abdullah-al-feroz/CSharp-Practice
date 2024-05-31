using MethodHiding;

FullTimeEmployee FTE = new FullTimeEmployee();
FTE.FirstName = "FullName";
FTE.LastName = "Employee";
FTE.PrintFullName();

PartTimeEmployee PTE = new PartTimeEmployee();
PTE.FirstName = "PartName";
PTE.LastName = "Employee";
//PTE.PrintFullName();
((Employee)PTE).PrintFullName(); // BaseClass hidden method is call using new keyword


Employee PTE1 = new PartTimeEmployee(); // Base class take all responsibility to child class
PTE1.FirstName = "PartName";
PTE1.LastName = "Employee";
//PTE.PrintFullName();
((Employee)PTE1).PrintFullName(); // BaseClass hidden method is call using new keyword
