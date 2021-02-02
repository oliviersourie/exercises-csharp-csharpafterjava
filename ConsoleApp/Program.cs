using System;
using System.Collections.Generic;
using ClassLib;
using ClassLib.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar myCalendar = new ();

            myCalendar.ShowDays(WeekDays.Workdays, Show.Numbers);
            myCalendar.ShowDays(WeekDays.Weekend, Show.Names);
            myCalendar.ShowDays(WeekDays.Week);
            myCalendar.ShowDays(null);

            myCalendar.AddEventDay("CleanUp", new List<WeekDays> { WeekDays.Monday, WeekDays.Friday, WeekDays.Sunday });
            myCalendar.AddEventDay("Studying", new List<WeekDays> { WeekDays.Workdays, WeekDays.Saturday });

            Console.WriteLine(myCalendar);
        }
    }
}
