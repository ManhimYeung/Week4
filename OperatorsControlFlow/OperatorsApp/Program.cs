namespace OperatorsApp;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        #region Incrementer
        int x = 1;
        int a = x++; // a = 1 then ++
        int y = 1;
        int b = ++y; // a = 2

        for (int i = 0; i < 5; ++i) // same as i++
        {
            // code
        }
        #endregion

        #region Integer division
        var c = 5 / 2; // 5 and 2 = ints
        var d = 5.0 / 2; // 5.0 = double
        var e = 5 / 3; // 5 and 3 = ints

        double f = 5 / 2; // f = 2 but stored as double because assigned as double, but both are ints
        #endregion

        #region Modulus
        var daysInAWeek = 7;
        var todayDaysToAlexsBirthday = 23;
        var weeksToBirthday = daysInAWeek / todayDaysToAlexsBirthday;
        var days = daysInAWeek % todayDaysToAlexsBirthday;
        //Console.WriteLine($"{weeksToBirthday} weeks and {todayDaysToAlexsBirthday} until Alex's surprise birthday party");
        #endregion

        #region Assignment operators

        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            sum += i;
        }
        //Console.WriteLine(sum);
        #endregion

        */
        /*
        bool isWearingParachut = false;
        // && - only needs to evaluate the left hand side condition
        // but if the LHS condition is true
        // It then checks the right hand side condition
        // & checks both
        if (isWearingParachut && JumpOutOfAircraft()) Console.WriteLine("Congrats, you have made a successful jump.");
        else Console.WriteLine("Splat");
        */

        /*
        string greeting = "Alright";
        if (greeting != null && greeting.ToLower().StartsWith('a')) Console.WriteLine(greeting + " starts with 'a'");
        */

        /*
        int n = 5, o = 3;
        // for this ^ to be printed
        // the lhs of the if statement
        // or the rhs of the if statemetn
        // need to be true
        // but they both can't be true
        if (n == 5 ^ o == 3) Console.WriteLine("Print this");
        */

    }

    public static bool JumpOutOfAircraft() 
    {
        Console.WriteLine("Jump");
        return true;
    }
}