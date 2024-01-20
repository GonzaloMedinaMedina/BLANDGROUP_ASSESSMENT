using AgeCalculator.Server.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgeCalculator.Server.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class AgeCalculatorController : ControllerBase
	{
		private readonly ILogger<AgeCalculatorController> _logger;

		public AgeCalculatorController(ILogger<AgeCalculatorController> logger)
		{
			_logger = logger;
		}

		[HttpPost(Name = "GetAgeCalculator")]
		public Age Get(DateTime birthDate)
		{
			return new Age();
		}
	}
}
