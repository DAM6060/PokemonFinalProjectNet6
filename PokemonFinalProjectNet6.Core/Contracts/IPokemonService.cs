using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPokemonService
    {
        Task<IEnumerable<PokemonSpeciesServiceModel>> AllPokemonSpeciesAsync();
        Task<IEnumerable<string>> AllPokemonSpeciesNameAsync();

        Task<int> CreateAsync(PokemonFormModel model, int teamId);

    }
}
