using StaticAndInstanceClassMembers;

Circle c1 = new Circle(5);
float Area1 = c1.CalculationArea();
Console.WriteLine("Area={0}", Area1);

Circle c2 = new Circle(6);
float Area2 = c2.CalculationArea();
Console.WriteLine("Area={0}", Area2);