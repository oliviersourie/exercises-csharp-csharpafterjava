using System;

namespace ConsoleApp
{
    class Factorial
    {
        public int Value { get; set; }

        public Factorial(int? startValue)
        {
            Value = startValue ?? 0; //null coalescing
        }

        public Factorial() : this(null)
        {

        }

        public string Calculate()
        {
            return $"De faculteit van {Value} is {FacCount(Value)}";
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