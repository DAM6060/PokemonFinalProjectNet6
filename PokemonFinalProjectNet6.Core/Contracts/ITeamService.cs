using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface ITeamService
    {
        Task<int> CreateAsync(TeamFormModel model, int playerId, params PokemonFormModel[] pokemons);

        Task<TeamLeaderBoardQueryModel> TeamLeaderBoardAsync(
            string? pokemonFiltering = null,
            TeamSorting sorting=TeamSorting.MostWins,
            int currentPage=1,
            int teamsPerPage=10);

    }
}
