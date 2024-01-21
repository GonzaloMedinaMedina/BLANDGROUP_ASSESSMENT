using AgeCalculator.Server.Entities;
using AgeCalculator.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgeCalculator.Server.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class AgeCalculatorController : ControllerBase
	{
		private IAgeService _ageService;

		public AgeCalculatorController(ILogger<AgeCalculatorController> logger)
		{
			_ageService = new AgeService();
		}

		[HttpPost(Name = "GetAgeCalculator")]
		public IActionResult Get([FromBody] DateTime birthDate)
		{
			var nowDateTime = DateTime.Now;

			if (DateTime.Compare(birthDate, nowDateTime) > 0)
			{
				Console.WriteLine("Non valid date.");
				return BadRequest("Invalid birthDate. It cannot be in the future.");
			}

			Age age = _ageService.calculateAge(birthDate, nowDateTime);

			return Ok(age);
		}
	}
}
