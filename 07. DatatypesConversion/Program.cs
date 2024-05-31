//-- int to float conversion

//int i = 100;
//float f = i;
//Console.WriteLine(f);

//-- float to int conversion
//float f = 12.45F;
//int i = (int)f;
//or
//int i = Convert.ToInt32(f);
//Console.WriteLine(i);



//-- string to int conversion using Parse
//string strNumber = "100TG";
//int i = int.Parse(strNumber);
//Console.WriteLine(i);

//-- string to int conversion using TryParse
string strNumber = "100TG";
int Result = 0;
bool IsConversionSuccessful = int.TryParse(strNumber, out Result);
if(IsConversionSuccessful)
{
    Console.WriteLine(Result);
}
else
{
    Console.WriteLine("Plaese Enter a valid number");
}



