//Direction direction1 = Direction.East;
//Direction direction2 = Direction.West;

//Console.WriteLine(direction1 == direction2);
//Console.WriteLine(direction1.Equals(direction2));




//public enum Direction
//{
//    East = 1,
//    West = 2,
//    North = 3,
//    South = 4
//}

using OverrideEqualsMethod;

Customer c1 = new Customer();
c1.FirstName = "Tanvir";
c1.LastName = "Faysal";

Customer c2 = new Customer();
c1.FirstName = "Md";
c1.LastName = "Rahat";

Console.WriteLine(c1 == c2);
Console.WriteLine(c1.Equals(c2));