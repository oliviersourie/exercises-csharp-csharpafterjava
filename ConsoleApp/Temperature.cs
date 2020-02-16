namespace ConsoleApp
{
    class Temperature
    {
        public Temperature(int tempInCelsius)
        {
            Celsius = tempInCelsius;
        }

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

        public int Celsius { get; set; } = 25;
    }
}