using System;

namespace ConsoleApp
{
    class Factorial
    {
        private readonly int value;

        public Factorial(int startValue)
        {
            value = startValue;
        }

        public string Calculate()
        {
            return $"De faculteit van {value} is {FacCount(value)}";
        }

        private int FacCount(int v)
        {
            if (v > 0)
            {
                return v * FacCount(v - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}