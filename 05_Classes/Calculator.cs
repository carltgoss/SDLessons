using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Challenge:

        public int Subtract(int numOne, int numTwo)
        {
            int sum = numOne - numTwo;
            return sum;
        }

        public double Multiply(double numOne, double numTwo)
        {
            double sum = numOne * numTwo;
            return sum;
        }

        public decimal Divide(decimal numOne, decimal numTwo)
        {
            decimal sum = numOne / numTwo;
            return sum;
        }

        public int Power(int x, int y)
        {
            int result =x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

    }
}
