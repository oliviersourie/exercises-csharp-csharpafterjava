namespace ConsoleApp
{
    class Factorial
    {
        private readonly int _value;

        public Factorial(int startValue)
        {
            _value = startValue;
        }

        public string Calculate()
        {
            return $"The factorial of {_value} is {FacCount(_value)}";
        }

        private long FacCount(long v)
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