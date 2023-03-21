using System;
using System.Linq;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            input = input.Trim().ToUpper();
            for (int i = 0; i < num; i++)
                input += i; // 'i' doesn't need tostring()
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf) //remain as int
        {
            double percentage = Math.Round(((double)score/ outOf) * 100, 1);
            return $"You got {score} out of {outOf}: {percentage}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double result;
            return (double.TryParse(numString, out result)) ? result : -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            input = input.ToUpper();

            int aCount = input.Count(c => c == 'A');
            int bCount = input.Count(c => c == 'B');
            int cCount = input.Count(c => c == 'C');
            int dCount = input.Count(c => c == 'D');

            return $"A:{aCount} B:{bCount} C:{cCount} D:{dCount}";
        }
            
    }
}
