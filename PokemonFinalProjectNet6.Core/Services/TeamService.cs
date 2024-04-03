using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repository;

        public TeamService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> CreateAsync(Team3v3FormModel model, int playerId)
        {
            Team team = new Team
            {
                Name = model.Name,
            };

            await repository.AddAsync(team);

            await repository.SaveChangesAsync();

            return team.Id;
        }
    }
}
