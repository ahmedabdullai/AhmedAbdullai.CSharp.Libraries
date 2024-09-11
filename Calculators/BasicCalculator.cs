using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class BasicCalculator
    {
        // Method for addition
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Method for subtraction
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method for multiplication
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Method for division
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
