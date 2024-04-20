using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Abilitiy;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IAbilityService
    {
        Task<AbilityServiceModel> AbilityByIdAsync(int id);

        Task<AbilityQueryModel> AllAbilitiesSearch(
            string? searchTerm = null,
            AbilitySorting sorting = AbilitySorting.Alphabetical,
            int currentPage = 1,
            int teamsPerPage = 10);
        Task<List<AbilityServiceModel>> GetAllAbilitiesServiceModel();
    }

}
