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
            return nums.Count != 0 ? nums.Average() : 0;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (age < 5 && age >= 0) return "Free";
            else if (age <= 12 && age >= 5) return "Child";
            else if (age <= 17 && age >= 13) return "Student";
            else if (age <= 59 && age >= 18) return "Standard";
            else if (age <= 122 && age >= 60) return "OAP";
            else return "Invalid age";
            
        }

        public static string Grade(int mark)
        {
            if (mark <= 39 && mark >= 0) return "Fail";
            else if (mark >= 40)
            {
                if (mark <= 59) return "Pass";
                else if (mark <= 74 && mark >= 60) return "Pass with Merit";
                else if (mark <= 100 && mark >= 75) return "Pass with Distinction";
                else return "Invalid Mark";
            }
            else return "Invalid Mark";

            /* // without nested, didn't use my eyes to read properly
            if (mark <= 39 && mark >= 0) return "Fail";
            else if (mark <= 59 && mark >= 40) return "Pass";
            else if (mark <= 74 && mark >= 60) return "Pass with Merit";
            else if (mark <= 100 && mark >= 75) return "Pass with Distinction";
            else return "Invalid Mark";*/
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxAttendees = 0;
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
             //    default: //can't think of any default values
             //        break; 
            }
            return maxAttendees;
        }
    }
}
