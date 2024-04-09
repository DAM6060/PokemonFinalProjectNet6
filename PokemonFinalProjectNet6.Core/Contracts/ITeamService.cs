using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface ITeamService
    {
        Task<int> CreateAsync(TeamFormModel model, int playerId, params PokemonFormModel[] pokemons);

    }
}
