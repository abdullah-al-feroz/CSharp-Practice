using StructExample;

Customer c1 = new Customer(101, "Mark");
c1.PrintDetails();

Customer c2 = new Customer();
c2.Id = 102;
c2.Name = "Faysal";
c2.PrintDetails();

Customer c3 = new Customer
{
    Id = 103,
    Name = "Rahat"
};

c3.PrintDetails();