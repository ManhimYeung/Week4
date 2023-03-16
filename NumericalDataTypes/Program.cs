using System.Collections.Generic;
namespace NumericalDataTypesApp;

public class Program
{
    static void Main(string[] args)
    {
        int anInt = 3;
        var vInt = 4;
        var v2Int = vInt;

        var name = "Nish";
        var isClean = true;
        var letter = 'P';
        var vlongnum = 52uL; // only positive
        
        var prices = new List<int>();

        /*
        short n1 = -65;
        ushort n2 = 65;
        int n3 = 100_000;
        uint n4 = 100_100;
        uint n5 = 4_000_000_000;
        long n6 = -5_000_000_000;
        ulong n7 = 5_000_000_000;
        */
        /*
        var n1 = -65;            // int
        var n2 = 65;             // int
        var n3 = 100_000;        // int
        var n4 = 100_000;        // int
        var n5 = 4_000_000_000;  // int
        var n6 = -5_000_000_000; // long
        var n7 = 5_000_000_000;  // long
        */

        decimal sum = 0;
        for (int i = 0; i < 100_000; i++)
            sum += 2 / (decimal)5.0;
        Console.WriteLine("2/5 added 100,000 times: " + sum);
        Console.WriteLine("2/5 multiplied by 100,000: " + 2 / 5.0f * 100_000);

        var result = 5.50 / 5; // default to double

        int uInt1 = 5;
        //uint int1 = uInt1;

        char myChar = 'c';
        int myInt = 21;

        int charInt = myChar;
        //byte myByte = 1000;
    }
}