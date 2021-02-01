using System;
using System.Collections.Generic;
using System.Text;

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

    enum Show
    {
        Numbers,
        Names
    }

    [Flags]
    enum WeekDays: int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Workdays = 128,
        Weekend = 256,
        Week = 512,
    }

    class Calendar
    {
        private readonly WeekDays _weekend;
        private readonly WeekDays _workdays;
        private readonly WeekDays _week;

        private readonly Dictionary<string, IEnumerable<WeekDays>> _events;

        public Calendar()
        {
            _weekend = WeekDays.Saturday | WeekDays.Sunday;
            _workdays = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            _week = _workdays | _weekend;

            _events = new Dictionary<string, IEnumerable<WeekDays>>();
        }
        public void ShowDays(WeekDays? weekDays, Show showFormat = Show.Names)
        {
            WeekDays daysToShow = default;

            switch(weekDays) {
                case WeekDays.Weekend:
                    daysToShow = _weekend;
                    break;
                case WeekDays.Workdays:
                    daysToShow = _workdays;
                    break;
                case WeekDays.Week:
                    daysToShow = _week;
                    break;
                case null:
                    break;
            }
            foreach (string day in getDays(showFormat == Show.Names ? daysToShow.ToString() : ((int)daysToShow).ToString()))
            {
                Console.WriteLine(day);
            }

            IEnumerable<string> getDays(string days)
            {
                return days.Split(", ");
            }
        }
        public void AddEventDay(string eventDescription, IEnumerable<WeekDays> days)
        {
            _events.Add(eventDescription, days);
        }

        public override string ToString()
        {
            StringBuilder calendarOutput = new StringBuilder();
            foreach (KeyValuePair<string, IEnumerable<WeekDays>> ev in _events)
            {
                calendarOutput.AppendLine($"Event {ev.Key} on ");
                foreach (WeekDays day in ev.Value)
                {
                    calendarOutput.AppendLine(day.ToString());
                }
            }
            return calendarOutput.ToString();
        }
    }
}
