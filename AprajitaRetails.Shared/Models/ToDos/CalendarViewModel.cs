using System;
using System.Globalization;

namespace AprajitaRetails.Shared.Models.ToDos
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class CalendarViewModel
    {
        public int OffsetFromSun { get; set; }
        public int NumberOfDays { get; set; }

        public string Name { get; set; }

        public CalendarViewModel(int month, int year)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            OffsetFromSun = (int)firstDay.DayOfWeek;
            NumberOfDays = DateTime.DaysInMonth(year, month);
            Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
    }
}
