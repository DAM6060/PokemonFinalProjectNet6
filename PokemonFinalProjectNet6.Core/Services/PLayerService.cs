using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class PLayerService : IPlayerService
    {
        private readonly IRepository repository;

        public PLayerService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(string userId, string name)
        {
            await repository.AddAsync(new Player
            {
                UserId = userId,
                Name = name
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllAsReadOnly<Player>()
                .AnyAsync(p => p.UserId == userId);
           
        }

        public async Task<int?> GetPlayerIdAsync(string userId)
        {
            return (await repository.AllAsReadOnly<Player>()
                .FirstOrDefaultAsync(p => p.UserId == userId))?.Id;
        }

        public async Task<bool> UserHasTeamsAsync(string userId)
        {
            return await repository.AllAsReadOnly<Team>()
                .AnyAsync(t => t.Player.UserId == userId);
        }

        public Task<bool> UserWithNameExistsAsync(string name)
        {
            return repository.AllAsReadOnly<Player>()
                .AnyAsync(p => p.Name == name);
        }
    }
}
