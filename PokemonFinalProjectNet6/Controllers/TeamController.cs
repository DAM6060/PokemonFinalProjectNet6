using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Controllers
{

    public class TeamController : BaseController
    {
        private readonly ILogger logger;
        private readonly IPokemonService pokemonService;
        private readonly IPlayerService playerService;
        private readonly ITeamService teamService;
        private readonly IMoveService moveService;
        private readonly IAbilityService abilityService;

        public TeamController(
            ILogger<TeamController> _logger,
            IPokemonService _pokemonService,
            IPlayerService _playerService,
            ITeamService _teamService,
            IMoveService _moveService,
            IAbilityService _abilityService)

        {
            pokemonService = _pokemonService;
            teamService = _teamService;
            playerService = _playerService;
            logger = _logger;
            moveService = _moveService;
            abilityService = _abilityService;
        }
        public async Task<IActionResult> MyTeams()
        {
            var playerId = await playerService.GetPlayerIdAsync(User.Id());

            if (playerId == null)
            {
				return RedirectToAction(nameof(PlayerController.Become), "Player");
			}

            var teams = await teamService.GetTeamsByPlayerIdAsync(playerId.Value);

            return View(teams);
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

      
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new TeamFormModel()
            {
                PokemonSpecies = await pokemonService.AllSpeciesNamesAsync()
		    };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(TeamFormModel model)
        {
            int? playerId = await playerService.GetPlayerIdAsync(User.Id());

            if (playerId == null)
            {
                return RedirectToAction(nameof(PlayerController.Become), "Player");
            }
            

            model.ChosenPokemons.Add(model.ChosenPokemon1);
            model.ChosenPokemons.Add(model.ChosenPokemon2);
            model.ChosenPokemons.Add(model.ChosenPokemon3);

            foreach (var pokemon in model.ChosenPokemons)
            {
                if (await pokemonService.SpeciesExistsAsync(pokemon) == false)
                {
                    ModelState.AddModelError(nameof(model.ChosenPokemons), $"Pokemon {pokemon} does not exist.");
                }
            }
            ;
            if (ModelState.IsValid == false)
            {
                model.PokemonSpecies = await pokemonService.AllSpeciesNamesAsync();

                return View(model);
            }
			model.PlayerId = playerId.Value;


			return RedirectToAction(nameof(AddPokemonsToTeam),model);         
        }
        [HttpGet]
        public async Task<IActionResult> AddPokemonsToTeam(TeamFormModel model)
        {
			if (model == null)
            {
                logger.LogError("TeamController/AddPokemonsToTeam - Model is null After JSON Deserilization");
                return BadRequest();
            }
            var pokemonsToAdd = new List<PokemonFormModel>();
            for (int i = 0; i < model.ChosenPokemons.Count(); i++)
            {
                pokemonsToAdd.Add(await pokemonService.GetPokemonBaseValuesByNameAsync(model.ChosenPokemons[i]));               
            }

            model.PokemonForDB1 = pokemonsToAdd[0];
            model.PokemonForDB2 = pokemonsToAdd[1];
            model.PokemonForDB3 = pokemonsToAdd[2];
            model.MovesForDropDown = await moveService.GetAllMovesServiceModel();
            model.Abilities = await abilityService.GetAllAbilitiesServiceModel();

			return View(model);
        }
        [HttpPost]        
        public async Task<IActionResult> AddPokemonstoTeam(TeamFormModel model)
        {
            List<PokemonFormModel> PokemonsListForMoveDuplicates = new List<PokemonFormModel>(){ model.PokemonForDB1, model.PokemonForDB2, model.PokemonForDB3 };

            bool duplicates = false;

            foreach (var pokemon in PokemonsListForMoveDuplicates)
            {
                if (pokemon.MovesIdsForDb.Count() != 4)
                {
                    duplicates = true;
                    break;
                }
                
            }      

           
			if (ModelState.IsValid == false || duplicates == true)
            {
                
				model.PokemonSpecies = await pokemonService.AllSpeciesNamesAsync();
				model.MovesForDropDown = await moveService.GetAllMovesServiceModel();
				model.Abilities = await abilityService.GetAllAbilitiesServiceModel();

				return RedirectToAction(nameof(Add));
			}

			var playerId = await playerService.GetPlayerIdAsync(User.Id());

			if (playerId == null)
            {
				return RedirectToAction(nameof(PlayerController.Become), "Become");
			}

			model.PlayerId = playerId.Value;

			await teamService.CreateAsync(model);

			return RedirectToAction(nameof(LeaderBoards));
		}

        public async Task<IActionResult> Details(int id)
        {
			var team = await teamService.GetTeamDetailsAsync(id);

			if (team == null)
            {
				return NotFound();
			}

			return View(team);
		}
        
        [HttpGet]
		public async Task<IActionResult> Delete(int id)
        {
            if (await teamService.ExistsById(id) == false)
            {
                return BadRequest();
            }
            var playerId = await playerService.GetPlayerIdAsync(User.Id());

            if (playerId == null)
            {
                return RedirectToAction(nameof(PlayerController.Become), "Player");
            }
            if (await teamService.PlayerHasTeam(id, playerId ?? 0) == false)
            {
                return Unauthorized();
            }
			var team = await teamService.GetTeamDetailsAsync(id);

            var model = new TeamServiceModel()
            {
				Id = team.Id,
				Name = team.Name,
				PlayerId = team.PlayerId,
				Pokemons = team.Pokemons.Select(p => p.Name).ToList(),
				Wins = team.Wins,
				Losses = team.Losses
			};

            return View(model);			
		}
        [HttpPost]
        public async Task<IActionResult> Delete(TeamServiceModel model)
        {
			if (await teamService.ExistsById(model.Id) == false)
            {
				return BadRequest();
			}
			var playerId = await playerService.GetPlayerIdAsync(User.Id());

			if (playerId == null)
            {
				return RedirectToAction(nameof(PlayerController.Become), "Player");
			}
			if (await teamService.PlayerHasTeam(model.Id, playerId ?? 0) == false)
            {
				return Unauthorized();
			}
            await teamService.DeleteAsync(model.Id);

            return RedirectToAction(nameof(MyTeams));
        }

        
        

        
    }
}
