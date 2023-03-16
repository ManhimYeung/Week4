namespace ExceptionApp;

internal class Program
{
    static void Main(string[] args)
    {
        string text;
        string filename = "HelloWorld.txt";
        try // try to print text in filename, catch to throw the exception error instead
        {
            text = File.ReadAllText(filename);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Sorry I can't find: " + filename);
        }
        catch(ArgumentException e) // only if the error has been caught
        {
            Console.WriteLine("You gave me an empty file name");
        }
        finally { // running any code that must execute even if there is an exception

            Console.WriteLine("Finished!");
        }

    }
}