using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface ITeamService
    {
        Task<int> CreateAsync(Team3v3FormModel model, int playerId);

    }
}
