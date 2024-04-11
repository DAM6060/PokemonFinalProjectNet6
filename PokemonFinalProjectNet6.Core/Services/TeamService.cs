using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
	public class TeamService : ITeamService
    {
        private readonly IRepository repository;
        private readonly IPokemonService pokemonService;
       

        public TeamService(IRepository _repository, IPokemonService _pokemonService)
        {
            repository = _repository;
            pokemonService = _pokemonService;
            
        }
        public async Task<int> CreateAsync(TeamFormModel model, int playerId, params PokemonFormModel[] pokemons)
        {
            List<Pokemon> pokemonsToAdd = new List<Pokemon>();

            foreach (var pokemon in pokemons)
            {
                var pokemonId = await pokemonService.CreateAsync(pokemon , playerId);

                if (await pokemonService.ExistsAsync(pokemonId) == true)
                {
                    pokemonsToAdd.Add(await pokemonService.GetPokemonByIdAsync(pokemonId));
                } 
            }

            var team = new Team
            {
                Name = model.Name,
                PlayerId = playerId,
                Pokemons = pokemonsToAdd
            };

            await repository.AddAsync(team);
            await repository.SaveChangesAsync();
            return team.Id;
        }

        public async Task<TeamLeaderBoardQueryModel> TeamLeaderBoardAsync(
            string? pokemonFiltering = null,
            TeamSorting sorting = TeamSorting.MostWins,
            int currentPage = 1,
            int itemsPerPage = 10)
        {
            var teamsToShow = repository.AllAsReadOnly<Team>();

            if (!string.IsNullOrWhiteSpace(pokemonFiltering))
            {
                teamsToShow = teamsToShow
                    .Where(x => x.Pokemons.Any(p => p.Name == pokemonFiltering));
            }

            teamsToShow = sorting switch
            {
                TeamSorting.Newest => teamsToShow.OrderByDescending(x => x.Id),
                TeamSorting.Oldest => teamsToShow.OrderBy(x => x.Id),
                TeamSorting.MostGamesPlayed => teamsToShow.OrderByDescending(x => x.Wins + x.Losses),
                TeamSorting.BiggestPostiveDifferential => teamsToShow.OrderByDescending(x => x.Wins - x.Losses),
                TeamSorting.BiggestNegativeDifferential => teamsToShow.OrderBy(x => x.Losses - x.Wins),
                _ => teamsToShow.OrderByDescending(x => x.Wins)
            };

            var teams = await teamsToShow
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(x => new TeamServiceModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    PlayerId = x.PlayerId,
                    Pokemons = x.Pokemons.Select(p => p.Name).ToList(),
                    Wins = x.Wins,
                    Losses = x.Losses
                })
                .ToListAsync();

            int totalTeamsCount = await teamsToShow.CountAsync();

            return new TeamLeaderBoardQueryModel
            {
                ItemsPerPage = itemsPerPage,
                CurrentPage = currentPage,
                TotalItemsCount = totalTeamsCount,
                Sorting = sorting,
                Teams = teams
            };
        }
    }
}
