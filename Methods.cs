using System;
namespace MethodOverloading
{
    public class Methods
    {
        public Methods()
        {
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool withDollars)
        {
            var sum = num1 + num2;

            if (withDollars == true && sum != 1)
            {
                return $"{num1 + num2} dollars";
            }

            else if (withDollars && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{num1 + num2}";
            }
        }
    }
}

