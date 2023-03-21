using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            try
            {
                return checked(num1 + num2);
            }
            catch (OverflowException e) // give it a name
            {
                // print message instead of exception
                throw new OverflowException("error");
            }
        }

        public static int Subtract(int num1, int num2)
        {
            try
            {
                return checked(num1 - num2);
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }

        public static int Multiply(int num1, int num2)
        {
            try
            {
                return checked(num1 * num2);
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0) throw new ArgumentException("Can't divide by zero");
            try
            {
                return checked(num1 / num2);
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }

        public static int Modulus(int num1, int num2)
        {
            if (num2 == 0) throw new ArgumentException("Can't modulo by zero");
            try
            {
                return checked(num1 % num2);
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
