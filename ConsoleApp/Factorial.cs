namespace ConsoleApp
{
    class Factorial(int value) //Use of Primary constructor (new in C# 12)
    {
        //private readonly int _value;

        //public Factorial(int startValue)
        //{
        //    _value = startValue;
        //}

        public string Calculate()
        {
            return $"The factorial of {value} is {FacCount(value)}";
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