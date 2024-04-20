using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPokemonService
    {
        //Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> SpeciesExistsAsync(string name);

        Task<int> CreateAsync(PokemonFormModel model, int playerId, int teamId);

        //Task<HouseQueryServiceModel> AllAsync(
        //    string? category = null,
        //    string? searchTerm = null,
        //    HouseSorting sorting = HouseSorting.Newest,
        //    int currentPage = 1,
        //    int housesPerPage = 1);

        Task<IEnumerable<string>> AllSpeciesNamesAsync();

        Task<IEnumerable<PokemonFormModel>> AllPokemonByPlayerIdAsync(int playerId);

        Task<IEnumerable<PokemonFormModel>> AllPokemonByUserId(string userId);

        Task<bool> ExistsAsync(int id);

        Task<PokemonServiceModel> PokemonDetailsByIdAsync(int id);

        Task EditAsync(int pokemonId, PokemonFormModel model);

        Task<bool> HasPlayerWithIdAsync(int pokemonId, string playerId);

        Task<PokemonFormModel?> GetPokemonFormModelByIdAsync(int id);

        Task<PokemonFormModel> GetPokemonBaseValuesByNameAsync(string name);

        Task<Pokemon> GetPokemonByIdAsync(int id);

        Task DeleteAsync(int pokemonId);
        
    }
}
