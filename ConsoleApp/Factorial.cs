namespace ConsoleApp
{
    static class Factorial
    {
        public static string Calculate(uint startValue = 1)
        {
            return $"The factorial of {startValue} is {FacCount(startValue)}";
        }

        private static ulong FacCount(ulong v)
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