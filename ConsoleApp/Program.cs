﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial fac = new Factorial(5);
            Console.WriteLine(fac.Calculate());
        }
    }
}
