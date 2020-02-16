using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial fac = new Factorial() { Value = 5 };
            fac.Calculate();
        }
    }
}
