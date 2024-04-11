using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Controllers
{

    public class TeamController : BaseController
    {
        private readonly ILogger logger;
        private readonly IPokemonService pokemonService;
        private readonly IPlayerService playerService;
        private readonly ITeamService teamService;

        public TeamController(
            ILogger<TeamController> _logger,
            IPokemonService _pokemonService,
            IPlayerService _playerService,
            ITeamService _teamService)

        {
            pokemonService = _pokemonService;
            teamService = _teamService;
            playerService = _playerService;
            logger = _logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> LeaderBoards([FromQuery]TeamLeaderBoardQueryModel model)
        {
            var teams = await teamService.TeamLeaderBoardAsync(
                model.PokemonFiltering,
                model.Sorting,
                model.CurrentPage,
                model.ItemsPerPage);

            model.Teams = teams.Teams;
            model.TotalItemsCount = teams.TotalItemsCount;
            model.PokemonNames = await pokemonService.AllSpeciesNamesAsync();
            model.CurrentPage = teams.CurrentPage;

            return View(model);

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            //Need to add the logic to get the list of Pokemon for dropdown
            //need abilities and moves
            //Make into a 3 stage process First stage is to select the pokemon
            //This will be a dropdown list of all the pokemon
            //3 drpodown fields for the pokemon to send a request to get those base value stats
            //In the second stage we need to return the base stats of the pokemon drop down for ability and moves to select
            //and Finally post
            //So this sounds like 2 get requests and 1 post request
            //so in this model we need to have a list of pokemon, abilities, and moves
            //or just a list of pokemon and then we can get the abilities and moves from the pokemon           

            var model = new TeamFormModel()
            {
                PokemonSpecies = await pokemonService.AllSpeciesNamesAsync()
		    };
            return View(model);
        }


        
    }
}
