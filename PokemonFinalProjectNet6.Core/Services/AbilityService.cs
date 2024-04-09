using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class AbilityService : IAbilityService
    {
        private readonly IRepository repository;

        public AbilityService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<AbilityServiceModel> AbilityByIdAsync(int id)
        {
            return await repository.AllAsReadOnly<Ability>()
                .Where(m => m.Id == id)
                .Select(m => new AbilityServiceModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description
                })
                .FirstOrDefaultAsync();
        }

        
    }
}
