using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;


namespace PokemonFinalProjectNet6.Controllers
{
    public class PokemonController : BaseController
    {
        private readonly ILogger logger;
        private readonly IPokemonService pokemonService;
        private readonly IPlayerService playerService;

        public PokemonController(
            IPokemonService _pokemonService,
            IPlayerService _playerService,
            ILogger<PokemonController> _logger)
        {
            pokemonService = _pokemonService;
            playerService = _playerService;
            logger = _logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (await pokemonService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var pokemon = await pokemonService.PokemonDetailsByIdAsync(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

       
    }
}
