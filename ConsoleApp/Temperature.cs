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

        public int Celsius { get; init; } = 25;
    }
}