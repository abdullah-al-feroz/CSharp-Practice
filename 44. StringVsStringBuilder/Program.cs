//string userString = "C#";
//userString += "Video";
//userString += "Tutorial";
//userString += "For";
//userString += "Beginners";
//Console.WriteLine(userString);

using System.Text;

StringBuilder userString = new StringBuilder("C#");
userString.Append("Video");
userString.Append("Tutorial");
userString.Append("For");
userString.Append("Beginners");
Console.WriteLine(userString);

//As StringBuilder objects are mutable, they offer better performance than
// string objects of type system, string, when heavy string manipulation is involved.