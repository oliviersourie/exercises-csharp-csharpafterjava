using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature() { Celsius = 30 }; // ..°C
            Console.WriteLine(temperature.Celsius); 
            Console.WriteLine(temperature.Fahrenheit); 
            Console.WriteLine(temperature.Kelvin);

            //temperature.Celsius = 23; // temp is now 23°C
            //temperature.Fahrenheit = 75;

            (double c, double f, _) = temperature;
            Console.WriteLine($"{c} °C is {f}°F");
        }
    }
}
