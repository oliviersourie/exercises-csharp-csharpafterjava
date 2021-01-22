using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    enum Show
    {
        Numbers,
        Names
    }

    [Flags]
    enum WeekDays: byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Midweek = Monday | Tuesday | Wednesday | Thursday | Friday,
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday,
        Weekend = Saturday | Sunday
    }

    class Calendar
    {
        public void ShowDays()
        {
            //To do
        }
        public void AddEventDay()
        {
            //To do
        }
    }
}
