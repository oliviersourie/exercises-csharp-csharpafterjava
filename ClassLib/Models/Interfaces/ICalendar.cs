using System.Collections.Generic;

namespace ClassLib.Models.Interfaces
{
    public interface ICalendar
    {
        void AddEventDay(string eventDescription, IEnumerable<WeekDays> days);
        void ShowDays(WeekDays? weekDays, Show showFormat = Show.Names);
        string ToString();
    }
}