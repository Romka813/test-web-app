using System.Web.Mvc;
using WebApp.Interfaces.Calculator;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
	    private readonly ICalculatorService _calculatorService;

	    public HomeController(ICalculatorService calculatorService)
	    {
		    _calculatorService = calculatorService;
	    }

	    [HttpGet]
        public ActionResult Index()
        {		
            return View(_calculatorService.GetNumberOfArguments());
        }
    }
}