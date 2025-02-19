﻿namespace calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can't divide by 0");
            }
            return a / b;
        }

        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
        public double Power(double a, double exp)
        {
            return Math.Pow(a, exp);
        }
    }
}
