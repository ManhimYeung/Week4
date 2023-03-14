using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args) 
    {
        int _timeOfDay = 21;
        string greeting = Greeting(_timeOfDay);
        Console.WriteLine(greeting);
        
    }
    public static string Greeting(int timeOfDay) 
    {
        string greeting;
        if (timeOfDay >= 4 && timeOfDay < 12) greeting = "Good Morning";
        else if (timeOfDay >= 12 && timeOfDay <= 18) greeting = "Good Afternoon";
        else greeting = "Good Evening";

        return greeting;
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;

        if (ageOfViewer < 12 && ageOfViewer >= 0) result = "U/PG films are available.";
        else if (ageOfViewer < 15 && ageOfViewer >= 12) result = "U/PG/12/12A films are available.";
        else if (ageOfViewer < 18 && ageOfViewer >= 15) result = "U/PG/12/12A/15 films are available.";
        else if (ageOfViewer < 122 && ageOfViewer >= 18) result = "All films are available.";
        else result = "Invalid age.";

        return result;
    }

}