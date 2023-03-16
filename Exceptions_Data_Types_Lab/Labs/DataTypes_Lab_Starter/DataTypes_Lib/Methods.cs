using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(long n)
        {
            var factor = n;
            
            if (n == 0) n = 1;
            else if (n < 0) throw new ArgumentOutOfRangeException("Negative factorial is not possible.");

            for (int i = 1; i < factor; i++)
                n *= i;
            return n;
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
