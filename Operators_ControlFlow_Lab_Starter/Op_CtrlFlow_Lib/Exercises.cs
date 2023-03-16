using System;
using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool Compare(int num1, int num2) //renamed from myMethod
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            return nums.Count != 0 ? nums.Average() : throw new ArgumentException("This is an empty list.");            
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            if (age < 0 || age > 122) throw new ArgumentOutOfRangeException(age + " is an invalid age.");

            if (age < 5 && age >= 0) ticketType = "Free";
            else if (age <= 12 && age >= 5) ticketType = "Child";
            else if (age <= 17 && age >= 13) ticketType = "Student";
            else if (age <= 59 && age >= 18) ticketType = "Standard";
            else if (age <= 122 && age >= 60) ticketType = "OAP";

            return ticketType;
        }

        public static string Grade(int mark)
        {
            string grade = string.Empty;
            if (mark < 0 || mark > 100) throw new ArgumentOutOfRangeException(mark + " is not valid");
            if (mark <= 39 && mark >= 0) grade = "Fail";
            else if (mark >= 40)
            {
                if (mark <= 59) grade = "Pass";
                else if (mark <= 74 && mark >= 60) grade = "Pass with Merit";
                else if (mark <= 100 && mark >= 75) grade = "Pass with Distinction";
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxAttendees;
            switch (covidLevel)
            {
                case 0: maxAttendees = 200;
                    break;
                case 1: maxAttendees = 100;
                    break;
                case 2: maxAttendees = 50;
                    break;
                case 3: maxAttendees = 50;
                    break;
                case 4: maxAttendees = 20;
                    break;
                default: throw new ArgumentOutOfRangeException(covidLevel + " is not correct.");
            }
            return maxAttendees;
        }
    }
}
