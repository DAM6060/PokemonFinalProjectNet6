using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Paging;

namespace PokemonFinalProjectNet6.Core.Models.Abilitiy
{
	public class AbilityQueryModel : PagingModel
    {
        public string SearchTerm { get; set; }
        public IEnumerable<AbilityServiceModel> Abilities { get; set; }
        
        public AbilitySorting Sorting { get; set; }
    }
}
