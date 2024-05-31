
HelloFuntionDelegate del = new HelloFuntionDelegate(Hello);
    del("Hello form Delegate");
static void Hello(string message)
{
    Console.WriteLine(message);
}
public delegate void HelloFuntionDelegate(string message);
