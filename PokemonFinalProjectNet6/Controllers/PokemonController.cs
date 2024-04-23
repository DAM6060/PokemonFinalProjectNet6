using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Attributes;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using System.Security.Claims;


namespace PokemonFinalProjectNet6.Controllers
{
    public class PokemonController : BaseController
    {
        private readonly ILogger logger;
        private readonly IPokemonService pokemonService;
        private readonly IPlayerService playerService;
        private readonly IMoveService moveService;
        private readonly IAbilityService abilityService;

        public PokemonController(
            IPokemonService _pokemonService,
            IPlayerService _playerService,
            ILogger<PokemonController> _logger,
            IMoveService _moveService,
            IAbilityService _abilityService)
        {
            pokemonService = _pokemonService;
            playerService = _playerService;
            logger = _logger;
            moveService = _moveService;
            abilityService = _abilityService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            //Need to add Pokemon Moves to the details page
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

        [HttpGet]
        [MustBePlayer]
        public async Task<IActionResult> Edit(int id)
        {
            if (await pokemonService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }
            var playerId = await playerService.GetPlayerIdAsync(User.Id());            

            if (await pokemonService.PlayerHasPokemonWithId(id , playerId.Value) ==false)
            {
                return Unauthorized();
            }

            var model = await pokemonService.GetPokemonFormModelByIdAsync(id);
            model.MovesForDropDown = await moveService.GetAllMovesServiceModel();
            model.Abilities = await abilityService.GetAllAbilitiesServiceModel();

            return View(model);
        }

        [HttpPost]
        [MustBePlayer]
        public async Task<IActionResult> Edit(int id, PokemonFormModel model)
        {
            if (await pokemonService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var playerId = await playerService.GetPlayerIdAsync(User.Id());

            if (await pokemonService.PlayerHasPokemonWithId(id, playerId.Value) == false)
            {
                return Unauthorized();
            }
            
            bool duplicateMoves = model.MovesIdsForDb.Count != 4;

			if (ModelState.IsValid == false || duplicateMoves == false)
            {
				model.MovesForDropDown = await moveService.GetAllMovesServiceModel();
				model.Abilities = await abilityService.GetAllAbilitiesServiceModel();                
				
				return View(model);
            }

            await pokemonService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new { id });
        }       
    }
}
