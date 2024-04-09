using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PokemonFinalProjectNet6.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
