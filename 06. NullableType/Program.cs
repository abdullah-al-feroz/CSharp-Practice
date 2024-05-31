string Name = null;
int? i = null;


//bool type nullable example
bool? AreYouStudent = false;
if(AreYouStudent == true)
{
    Console.WriteLine("User is Student");
}
else if (!AreYouStudent.Value)
{
    Console.WriteLine("User is Not Student");
}
else if(AreYouStudent == false)
{
    Console.WriteLine("User is Not Student");
}
else
{
    Console.WriteLine("User is Did not answer the question");
}


//Int type Nullable example
//int? TicketOnSale = null;
//int AvailableTickets;

//if(TicketOnSale == null)
//{
//    AvailableTickets = 0;
//}
//else
//{
//    AvailableTickets = TicketOnSale.Value;
//    //AvailableTickets = (int)TicketOnSale;
//}
//Console.WriteLine("AvailableTickets, {0}", AvailableTickets);

//This problem solution using null coalescing operator
int? TicketOnSale = 100;
int AvailableTickets = TicketOnSale ?? 0;
Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
