using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0) throw new ArgumentOutOfRangeException("totalDays must not be negative");

            int weeks = totalDays / 7;
            int days = totalDays % 7;

            return (weeks, days);
        }

        public static (int numSqr, int cube, double numSqrt) PowersRoot(int num)
        {
            if (num <= 0) throw new ArgumentException("Number must be greater than 0");

            int numSqr = (int)Math.Pow(num, 2);
            int cube = (int)Math.Pow(num, 3);
            double numSqrt = (double)Math.Sqrt(num);

            return (numSqr, cube, numSqrt);
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }


        // Coding exercise practice -----------------------------
        // READ CAREFULLY----------------------------------------
        // ------------------------------------------------------

        // Write a method which returns true if the number (int) it is provided with is divisably by 10 or 15
        public static bool Divisably(int num)
        {
            return (num % 10 == 0 || num % 15 == 0);
        }

        // Write a method which can be provided with a number (int) returns "Too fast" if 70 or over. "Too quick"
        // if between 50 - 70, "just right" if between 30 - 50, "Too slow" if between 30 - 1 and "Stationary" if 0
        public static string SpeedChecker(int speed)
        {
            // let highest to be 100

            return speed < 0 ? throw new ArgumentOutOfRangeException("Speed invalid") :
                speed == 0 ? "Stationary" :
                speed < 30 && speed > 0 ? "Too slow" :
                speed < 50 && speed >= 30 ? "Just right" :
                speed < 70 && speed >= 50 ? "Too quick" :
                "Too fast";

            /*
            if (speed < 0) throw new ArgumentOutOfRangeException("Speed invalid");
            
            string message = string.Empty;
            if (speed >= 70) message = "Too fast";
            else if (speed >= 50 && speed < 70) message = "Too quick";
            else if (speed >= 30 && speed < 50) message = "Just right";
            else if (speed >= 1 && speed < 30) message = "Too slow";
            else if (speed == 0) message = "Stationary";
            
            return message;*/
        }

        // Write a method which takes a number (int) and a List<int> as an arguement. If the number is more than 
        // the number of elements in a list, throws an argumentexception. The method should return the product of all numbers
        // from the first element to the nth element (number). Eg. 
        // list = 1, 4, 5, 6
        // number = 3
        // the method should return 20
        public static int Mult(int num, List<int> numList)
        {
            int product = 1;

            if (num > numList.Count) throw new ArgumentOutOfRangeException("Out of range");
            //else return numList.Aggregate((total, next) => total * next);
            else
            {
                for (int i = 0; i < num; i++)
                    product *= numList[i];
            }
            return product;
        }

        // ---------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------

        // Write a method which takes a string as an argument and remove the vowels
        public static string removeVowels(string input)
        {
            string newInput = input.ToLower().
                Replace("a", string.Empty).
                Replace("e", string.Empty).
                Replace("i", string.Empty).
                Replace("o", string.Empty).
                Replace("u", string.Empty);

            return newInput;
        }

        // Write a method which takes a string as an argument and reverses it
        // e.g. nish -> hsin. Include unit tests.
        public static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        // Write a method which takes an array if the elements are integers and returns the character
        // representation of that integers as a string eg. int[] arr = {78, 105, 115, 104}
        public static string IntToChar(int[] array)
        {
            string result = string.Empty;
            foreach (int i in array)
                result += (char)i;

            return result;
        }

        // Second highest number in array
        public static int SecondHighest(int[] array)
        {
            int highest = int.MinValue;
            for (int i = 0; i < array.Length; i++)
                if (highest < i) highest = i;

            int[] newArray = array.Where(i => i != highest).ToArray();

            for (int i = 0; i < newArray.Length; i++)
                if (highest < i) highest = i;

            return highest;
        }

    }
}

