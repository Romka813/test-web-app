using System;
using System.Web.Http;
using WebApp.Interfaces.Calculator;

namespace WebApp.Controllers
{
	public class CalculatorController : ApiController
	{
		private readonly ICalculatorService _calculatorService;

		public CalculatorController(ICalculatorService calculatorService)
		{
			_calculatorService = calculatorService;
		}

		[HttpPost]
		public IHttpActionResult Calculate(decimal[] values)
		{
			try
			{
				return Ok(new {status = "success", result = _calculatorService.Calculate(values) });
			}
			catch (Exception ex)
			{
				return Ok(new {status = "error", result = ex.Message});
			}
		}
	}
}
