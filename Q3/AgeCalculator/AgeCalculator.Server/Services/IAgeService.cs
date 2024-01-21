using AgeCalculator.Server.Entities;

namespace AgeCalculator.Server.Services
{
	/// <summary>
	/// Interface that manage Age operations like calculate exact Age based on a birthday DateTime stamp.
	/// </summary>
	public interface IAgeService
	{
		/// <summary>
		/// Return an Age object that has Age information.
		/// </summary>
		/// <param name="birthday">The birthday of the person in DateTime format</param>
		/// <param name="todaysDate">The todays date time.</param>
		/// <returns>Age object with information about the Age calculated by the birthday parameter.</returns>
		Age calculateAge(DateTime birthday, DateTime todaysDate);
	}
}