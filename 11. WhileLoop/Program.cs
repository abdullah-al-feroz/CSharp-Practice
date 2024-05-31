Console.WriteLine("Please enter your target?");
int userTarget = int.Parse(Console.ReadLine());

int Start = 0;

while (Start <= userTarget)
{
    Console.Write(Start + " ");
    Start = Start + 2;
}
