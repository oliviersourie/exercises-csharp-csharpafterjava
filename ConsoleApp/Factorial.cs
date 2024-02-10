namespace ConsoleApp
{
    class Factorial(int? value = default) //primary constructor
    {
        public int Value { get; init; } = value ?? 0;

        public string Result 
        { 
            get => $"The factorial of {Value} is {FacCount(Value)}";
        }

        //public Factorial(int? startValue)
        //{
        //    Value = startValue ?? 0; //null coalescing
        //}

        //public Factorial() : this(null)
        //{

        //}

        private long FacCount(int v)
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