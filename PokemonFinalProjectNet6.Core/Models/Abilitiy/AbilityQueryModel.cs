using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Abilitiy
{
    public class AbilityQueryModel : PagingModel
    {
        public string SearchTerm { get; set; }
        public IEnumerable<AbilityServiceModel> Abilities { get; set; }
        
        public AbilitySorting Sorting { get; set; }
    }
}
