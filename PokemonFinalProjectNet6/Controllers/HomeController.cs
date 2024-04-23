using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Models;
using System.Diagnostics;

namespace PokemonFinalProjectNet6.Controllers
{
	
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			if (statusCode == 400)
			{
				return View("Error400");
			}
			else if (statusCode== 404)
			{
				return View("Error404");
			}
			else if (statusCode == 401)
			{
                return View("Error500");
            }
            else if (statusCode == 500)
			{
                return View("Error500");
            }
			
            return View();
		}
	}
}
