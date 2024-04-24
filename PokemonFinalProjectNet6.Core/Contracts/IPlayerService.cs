using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPlayerService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> UserWithNameExistsAsync(string name);        

        Task CreateAsync(string userId, string name);

        Task<int?> GetPlayerIdAsync(string userId);

        
        
    }
}
