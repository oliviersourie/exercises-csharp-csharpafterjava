namespace ConsoleApp
{
    class Temperature
    {
        public double Fahrenheit
        {
            get
            {
                return Celsius * 1.8 + 32;
            }
        }
        public double Kelvin
        {
            get
            {
                return Celsius + 273.15;
            }
        }

        public double Celsius { get; init; } = 25;

        public void Deconstruct(out double celsius, out double fahrenheit, out double kelvin)
        {
            celsius = Celsius;
            fahrenheit = Fahrenheit;
            kelvin = Kelvin;
        }
    }
}