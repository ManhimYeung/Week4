using System.Text;

namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        var myArr = new int[] { 1, 2, 3 };
        var name = "Lucas";
        var lucasFirstLetter = name[0];
        myArr[1] = 1000;
        var myArrIndex1 = myArr[1];
        */

        //string book = new string ("Lord of the Rings"); // short hand for name = "Lucas"
        /*
        var myString = " C# List fundamentals ";
        var result = StringBuilderExercise(myString);
        Console.WriteLine(result);
        */

        //string firstName = "Cormac";
        //string lastName = "Chowdhury";
        // Console.WriteLine(firstName + " " + lastName);
        // Console.WriteLine(String.Concat(firstName, " ", lastName));
        // Console.WriteLine($"{firstName} {lastName}");
        // StringInterpolation(firstName, lastName);
        //var fString = $"{2} to the power of {7} is {Math.Pow(2, 7)}";
        //var fString2 = $"Log to the baase {2} of {7} is {Math.Log(2, 7):0.#####}";
        //var fString3 = $"That will be {2.0 / 5:P}";

        //Console.WriteLine(fString3);

        //var input = Console.ReadLine();
        //var inputParsed = Int32.Parse(input)

        //do
        //{
        //    Console.WriteLine("Please enter how many apples you want");
        //    var input = Console.ReadLine();
        //    bool isValidInput = Int32.TryParse(input, out int numApples); ;
        //    if (isValidInput) Console.WriteLine($"You asked for {input} apples");
        //    else Console.WriteLine("Please enter valid number");
        //} while (true);
        //int[] arr = new int[] { 1, 2, 3 };
        //foreach (var item in arr) 
        //    Console.WriteLine(item);

        //int[] arr = new int[3];
        //arr[0] = 1;
        //arr[1] = 2;
        //arr[2] = 3;

        //string[] names = {"a", "b", "c"};

        //Array.ForEach(names, x => Console.WriteLine(x));

        //int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int sum = intArr.Sum();

        //var now = DateTime.Now;
        //var mins = now.Minute;
        //var year = now.Year;
        //var day = now.Day;
        //var ticks = now.Ticks;
        //var yearsPassed = DateTime.MaxValue.Year - DateTime.MinValue.Year;

        //DateTime taylorSwiftBday = new DateTime(1989, 12, 13);
        //TimeSpan tsAge = DateTime.Now - taylorSwiftBday;
        //var tsAgeInYears = tsAge.Days/365.25;
        //Console.WriteLine(DateTime.Now.ToString("y-M-d"));
        //Console.WriteLine(DateTime.Now.ToString("dd/mm/yyyy"));
        //Console.WriteLine(DateTime.Now.ToString("dddd MMMM yyyy"));
        //
        //DateOnly now = new DateOnly(1999, 5, 12);
        //Console.WriteLine(now);
        //
        //DateOnly tsAlt = DateOnly.FromDateTime(taylorSwiftBday).AddDays(18);
        //Console.WriteLine(tsAlt.ToLongDateString());

        //Enums();
        //Suits theSuit = Suits.Hearts;
        //int theSuitInt = (int)Suits.Hearts;
        //Suits anotherSuit = (Suits)0;
        //switch (theSuit) // switch for enums 
        //{
        //    case Suits.Hearts:
        //        Console.WriteLine("Thanks");
        //        break;
        //    default:
        //        Console.WriteLine("Cya");
        //        break;
        //}
        var rng = new Random();
        var rngSeeded = new Random(42);
        //Console.WriteLine(rng.Next(1, 11));
        Console.WriteLine(rngSeeded.Next(1, 11));
    }

    public static void Enums()
    {
        Suits theSuit = Suits.Hearts;
        if (theSuit == Suits.Spades) Console.WriteLine($"Suit is {Suits.Spades}");
        else Console.WriteLine($"the Suit is {theSuit} not {Suits.Spades}");
    }

    private static int SumArray(int[] intArr)
    {
        int sum = 0;
        foreach (var item in intArr)
            sum += item;

        return sum;
    }

    public static void StringInterpolation(string fName, string lName)
    {
        // $ sign indicates that string uses interpolation
        // anything within that string iwthin {} is called an interpolated expression
        Console.WriteLine($"My name is: {fName} {lName}");
    }


    public static string StringBuilderExercise(string myString)
    {
        var trimmedUpperString = myString.Trim().ToUpper();
        var nPos = trimmedUpperString.IndexOf('N');
        // 2 strings created but 60% better
        // trim doesn't exist in the string builder
        StringBuilder sb = new StringBuilder(trimmedUpperString);
        sb.Replace('L', '*');
        sb.Replace('T', '*');
        sb.Remove(nPos + 1, sb.Length - nPos - 1);
        return sb.ToString();
    }

    public static string StringActivity(string myString)
    {
        string trimmedString = myString.Trim().ToUpper().Replace("L", "*").Replace("T", "*");
        string deleteString = trimmedString.Remove(trimmedString.IndexOf('N') + 1);
        return deleteString;
    }
}