
using System.Reflection;

AssemblyLoadEventArgs executingAssembly = Assembly.GetExecutingAssembly();
Type customerType = executingAssembly.GetType("BindingOfReflection.Customer");
object customerInstance = Activator.CreateInstance(customerType);
MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

string[] parameters = new string[2];
parameters[0] = "Dot net";
parameters[1] = "Technology";

string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
Console.WriteLine("Full Name = {0}", fullName);
//Customer c1 = new Customer();
//string fullName = c1.GetFullName("Dot Net", "Technology");
//Console.WriteLine("FullName = {0}", fullName);