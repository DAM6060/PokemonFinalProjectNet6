using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPokemonService
    {       

        Task<bool> SpeciesExistsAsync(string name);

        Task<int> CreateAsync(PokemonFormModel model, int playerId, int teamId);

        Task<IEnumerable<string>> AllSpeciesNamesAsync();

        Task<bool> PlayerHasPokemonWithId(int pokemonId, int playerId);

        Task<bool> ExistsAsync(int id);

        Task<PokemonViewModel> PokemonDetailsByIdAsync(int pokemonId);

        Task EditAsync(int pokemonId, PokemonFormModel model);

        Task<PokemonFormModel> GetPokemonBaseValuesByNameAsync(string name);

        Task<Pokemon> GetPokemonByIdAsync(int pokemonId);

        Task DeleteAsync(int pokemonId);

        Task<PokemonFormModel> GetPokemonFormModelByIdAsync(int id);
		Task CreateSpeciesAsync(PokemonSpeciesFormModel model);
		Task<PokemonSpeciesFormModel> GetPokemonSpeciesFormModelAsync(string name);
		Task EditSpecies(PokemonSpeciesFormModel model);
	}
}
