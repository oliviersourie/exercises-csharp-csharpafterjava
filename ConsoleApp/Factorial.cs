﻿using System;

namespace ConsoleApp
{
    class Factorial
    {
        public static string Calculate(int startValue = 1)
        {
            return $"The factorial of {startValue} is {FacCount(startValue)}";
        }

        private static int FacCount(int v)
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