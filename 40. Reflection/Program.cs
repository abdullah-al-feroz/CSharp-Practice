using Reflection;
using System.Reflection;

//Type T = Type.GetType("Reflection.Customer");
Type T = typeof(Customer);
Console.WriteLine("Full Name = {0}", T.FullName);
Console.WriteLine("Just the Name={0}", T.Name);
Console.WriteLine("Just the NameSpace={0}", T.Namespace);
Console.WriteLine();

Console.WriteLine("Properties in customers");
PropertyInfo[] properties = T.GetProperties();
foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
    Console.WriteLine(property.PropertyType.Name+" "+ property.Name);
}

Console.WriteLine();
Console.WriteLine("Methods in customers");
MethodInfo[] methods = T.GetMethods();
foreach (MethodInfo method in methods)
{
    Console.WriteLine(method.ReturnType.Name + " " + method.Name);
}

Console.WriteLine();
Console.WriteLine("Constructors in customers class");
ConstructorInfo[] constructors = T.GetConstructors();
foreach (ConstructorInfo constructor in constructors)
{
    Console.WriteLine(constructor.Name);
    Console.WriteLine(constructor.ToString());
}
