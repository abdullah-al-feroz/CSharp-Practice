
using System.IO;

StreamReader streamReader = null;
try // if file name changed
{
    streamReader = new StreamReader(@"C:\Users\Dreamless\Desktop\sample-file\Data.txt");
    Console.WriteLine(streamReader.ReadToEnd());
    
}
catch(FileNotFoundException ex)
{
    //Console.WriteLine(ex.Message);
    //Console.WriteLine();
    //Console.WriteLine();
    //Console.WriteLine(ex.StackTrace); // which line of a program exception
    Console.WriteLine("Please check if the file {0}  exist", ex.FileName);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    streamReader.Close();
    Console.WriteLine("Finally Block");

}


