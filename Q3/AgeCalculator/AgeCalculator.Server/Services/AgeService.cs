using AgeCalculator.Server.Entities;

namespace AgeCalculator.Server.Services
{
	/// <summary>
	/// Implementation of the IAgeService
	/// </summary>
	public class AgeService : IAgeService
	{
		public Age calculateAge(DateTime birthday, DateTime today)
		{
			int years = today.Year - birthday.Year,
				months = today.Month - birthday.Month,
				days = today.Day - birthday.Day,
				hours = today.Hour - birthday.Hour,
				minutes = today.Minute - birthday.Minute,
				seconds = today.Second - birthday.Second;

			if (seconds < 0)
			{
				minutes--;
				seconds += 60;
			}

			if (minutes < 0)
			{
				hours--;
				minutes += 60;
			}

			if (hours < 0)
			{
				days--;
				hours += 24;
			}

			if (days < 0)
			{
				months--;
				days += DateTime.DaysInMonth(birthday.Year, birthday.Month);
			}

			if (months < 0)
			{
				years--;
				months += 12;
			}

			return new Age(years, months, days, hours, minutes, seconds);
		}
	}
}
