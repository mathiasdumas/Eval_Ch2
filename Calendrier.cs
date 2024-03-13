using System;
using static System.Net.Mime.MediaTypeNames;

namespace MNS
{
	public class Calendrier
	{
        public event Action OnPremierDuMois;
        public int Year { get; set; }
        public Day Day { get; set; }
        public Month Month { get; set; }
        public int DayNumber { get; set; }

        public Calendrier(int year, Day day, Month month, int dayNumber)
        {
            Year = year;
            Day = day;
            Month = month;
            DayNumber = dayNumber;
        }


        public void AppelerPremierDuMois()
		{
            if (DayNumber == 1)
            OnPremierDuMois?.Invoke();
		}
	}
}

