using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint value = default;
            if(args.Length > 0)
            {
                _ = uint.TryParse(args[0], out value);
            }
            Console.WriteLine(Factorial.Calculate(value));
            //Console.WriteLine(Factorial.Calculate(args.Length > 0 ? uint.Parse(args[0]) : default));
        }
    }
}
