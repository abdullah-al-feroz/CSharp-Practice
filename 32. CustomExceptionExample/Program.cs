using System.Runtime.Serialization;

static void Main()
{
    //throw new FileNotFoundException("File XYZ is not fonud");
    try
    {
        throw new USerAlreadyLoggedInException("User is logged in-no dulplicate session allowed");
    }
    catch(USerAlreadyLoggedInException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

[Serializable]
public class USerAlreadyLoggedInException : Exception
{
    public USerAlreadyLoggedInException() : base()
    {

    }
    public USerAlreadyLoggedInException(string message): base(message)
    {

    }

    public USerAlreadyLoggedInException(string message, Exception innerException): base(message, innerException)
    {

    }

    public USerAlreadyLoggedInException(SerializationInfo info, StreamingContext context):base(info, context)
    {

    }
}
