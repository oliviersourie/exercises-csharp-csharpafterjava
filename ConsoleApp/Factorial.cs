namespace ConsoleApp
{
    class Factorial
    {
        public int Value { get; init; }

        public string Result 
        { 
            get => $"The factorial of {Value} is {FacCount(Value)}";
        }

        public Factorial(int? startValue)
        {
            Value = startValue ?? 0; //null coalescing
        }

        public Factorial() : this(null)
        {

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