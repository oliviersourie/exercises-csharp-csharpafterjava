using System;

namespace ClassLib
{
    [Flags]
    public enum WeekDays: ushort
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
}
