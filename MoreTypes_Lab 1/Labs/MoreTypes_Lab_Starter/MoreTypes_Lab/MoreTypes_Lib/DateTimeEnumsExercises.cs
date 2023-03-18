using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            int age = date.Year - birthDate.Year;

            if (birthDate > date) throw new ArgumentException("Error - birthDate is in the future");
            if (birthDate > date.AddYears(-age)) age--;
            
            return age;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // Adds on years to a give a date and returns a string representation of the new date

        public static string AddYearGetDateString(DateOnly date)
        {
            return date.AddYears(1).ToString("dd MMMM yyyy");
        }

        // Returns a DateOnly instance from the using the date information from a DateTime instance
        public static DateOnly GetDateOnly(DateTime date)
        {
            return new DateOnly(date.Year, date.Month, date.Day);
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            switch (suit)
            {
                case Suit.CLUBS: return "And the seventh rule is if this is your first night at fight club, you have to fight.";
                case Suit.DIAMONDS: return "Diamonds are a girls best friend";
                case Suit.HEARTS: return "You've broken my heart";
                case Suit.SPADES: return "Bucket and spade";
                default: return string.Empty;
            }
        }
    }
}
