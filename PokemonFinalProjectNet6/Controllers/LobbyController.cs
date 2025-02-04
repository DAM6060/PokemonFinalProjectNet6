using Microsoft.AspNetCore.Mvc;

namespace PokemonFinalProjectNet6.Controllers
{
    public class LobbyController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
