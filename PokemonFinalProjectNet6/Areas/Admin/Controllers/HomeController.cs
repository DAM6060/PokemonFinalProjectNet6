using Microsoft.AspNetCore.Mvc;

namespace PokemonFinalProjectNet6.Areas.Admin.Controllers
{
	public class HomeController : AdminController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
