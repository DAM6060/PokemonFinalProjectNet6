using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPlayerService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> UserWithNameExistsAsync(string name);

        Task<bool> UserHasTeamsAsync(string userId);

        Task CreateAsync(string userId, string name);

        Task<int?> GetPlayerIdAsync(string userId);
    }
}
