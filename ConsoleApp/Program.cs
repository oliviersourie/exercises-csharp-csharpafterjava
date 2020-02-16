using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t1 = new Temperature(30); // ..°C
            Console.WriteLine(t1.Celsius); 
            Console.WriteLine(t1.Fahrenheit); 
            Console.WriteLine(t1.Kelvin); 
            
            t1.Celsius = 23; // temp is now 23°C
            Console.WriteLine(t1.Celsius); 
            Console.WriteLine(t1.Fahrenheit);

        }
    }
}
