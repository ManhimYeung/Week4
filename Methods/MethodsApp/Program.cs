using System.Runtime.Versioning;

namespace MethodsApp;

internal class Program
{
    static void Main(string[] args)
    {

        //var result = DoThis(10, 10, "Sad");
        //var result2 = DoThis(10, 10);
        //
        string pizza = OrderPizza(pineapple: true, chicken: false, tuna: true, isItalian: false);
        Console.WriteLine(pizza);

        /*
        /// Tuples, not frequently used in c#
        var myTuple = ("Lucas", "Adam", 45);

        (string, string, int) myTuple2 = ("Lucas", "Adam", 45);
        (string fName, string lName, int age) myTuple3 =  ("Lucas", "Adam", 45);
        var myTuple4 = (fName: "Lucas", lName: "Adam", age: 45);
        Console.WriteLine(myTuple4);

        string title = "Shrek";
        double boxOffice = 1_000_000_000;
        var file = (title, boxOffice);
        Console.WriteLine(file.title);
        Console.WriteLine(file.boxOffice);
        */

        /*
        int sum = Calculator.Add(1, 2);

        Calculator calc = new Calculator();
        int sumAlt = calc.Addition(1, 2); // non static requires new instance
        */

        //var result = ConvertPoundsToStones(89);
        //Console.WriteLine(result);

        //var result = DoThis(10, "Here is a string", out bool isLarge);

        int number = 10;

        Add(10);
        Console.WriteLine(number);
        Add(ref number);
        Console.WriteLine(number);

    }

    // method overloading, part of polymorphism
    // pass by value
    public static void Add(int num)
    {
        num++;
    }
    // pass by reference
    public static void Add(ref int num)
    {
        num++;
    }

    public static int DoThis(int x, string y, out bool z)
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    }

    public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
    {
        // return two ints in a tupe
        const int poundsInAStone = 14;
        var stones = pounds / poundsInAStone;
        var lbs = pounds % poundsInAStone; ;
        return (stones, lbs);
    }

    public static string OrderPizza(bool tuna, bool chicken, bool pineapple = false, bool isItalian = false)
    {
        string pizza = "Pizza with tomato sauce, cheese, ";
        if (!isItalian && pineapple) pizza += "pineapple, ";
        else throw new ArgumentException("Not nice.");
        if (tuna) pizza += "tuna, ";
        if (chicken) pizza += "chicken, ";

        return pizza.Remove(pizza.Length - 2);

    }
    /*
    public static int DoThis(int x, int z, string y = "Happy")
    {
        Console.WriteLine($"I am feeling {y}");
        return x * x;
    }

    
    public class Calculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    */
}