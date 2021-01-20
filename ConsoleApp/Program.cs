using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Fibonacci(20))
            {
                Console.WriteLine(i);
            }

            static ICollection<int> Fibonacci(int range) //local function
            {
                int current = 1, next = 1;
                ICollection<int> fibonacciList = new List<int>();

                for (int counter = 0; counter < range; counter++)
                {
                    fibonacciList.Add(current);
                    next = current + (current = next);

                }
                return fibonacciList;
            }
        }
    }
}
