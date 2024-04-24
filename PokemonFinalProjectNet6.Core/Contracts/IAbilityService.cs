using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Abilitiy;
using PokemonFinalProjectNet6.Core.Models.Ability;

namespace PokemonFinalProjectNet6.Core.Contracts
{
	public interface IAbilityService
    {
        Task<AbilityQueryModel> AllAbilitiesSearch(
            string? searchTerm = null,
            AbilitySorting sorting = AbilitySorting.Alphabetical,
            int currentPage = 1,
            int teamsPerPage = 10);
        Task<List<AbilityServiceModel>> GetAllAbilitiesServiceModel();
    }

}
