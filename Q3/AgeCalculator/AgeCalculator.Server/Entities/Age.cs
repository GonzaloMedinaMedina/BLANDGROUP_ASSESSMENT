namespace AgeCalculator.Server.Entities
{
	/// <summary>
	/// A Class that represent an Age
	/// </summary>
	public class Age
	{
		public int years { get; set; }
		public int months { get; set; }
		public int days { get; set; }
		public int hours { get; set; }
		public int minutes { get; set; }
		public int seconds { get; set; }

		public Age(int years, int months, int days, int hours, int minutes, int seconds)
		{
			this.years = years;
			this.months = months;
			this.days = days;
			this.hours = hours;
			this.minutes = minutes;
			this.seconds = seconds;
		}
	}
}
