using PokemonFinalProjectNet6.Core.Models.Ability;
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

    }
}
