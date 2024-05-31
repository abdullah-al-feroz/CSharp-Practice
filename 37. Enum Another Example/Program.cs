
static void Main()
{
    short[] Values = (short[]) Enum.GetValues(typeof(Gender));
    foreach(short value in Values)
    {
        Console.WriteLine(value);
    }

    string[] Names = Enum.GetNames(typeof(Gender));
    foreach(string name in Names)
    {
        Console.WriteLine(name);
    }
}

public enum Gender: short
{
    Unknown = 1,
    Male,
    Female
}
