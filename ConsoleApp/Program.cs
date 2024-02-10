using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial fac = new Factorial() { Value = 6 };
            Console.WriteLine(fac.Result);

            Factorial facWithPrimaryConstructor = new Factorial(8);
            Console.WriteLine(facWithPrimaryConstructor.Result);
        }
    }
}
