using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Abilitiy;
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

        public async Task<AbilityQueryModel> AllAbilitiesSearch(
                        string? searchTerm = null, 
                        AbilitySorting sorting = AbilitySorting.Alphabetical, 
                        int currentPage = 1, 
                        int teamsPerPage = 10)
        {
            var abilitiesToShow = repository.AllAsReadOnly<Ability>();
            var pokemon = repository.AllAsReadOnly<Pokemon>().Include(x=> x.Ability);

            

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                abilitiesToShow = abilitiesToShow
                    .Where(x => x.Name.Contains(searchTerm));
            }
            if (sorting != AbilitySorting.Alphabetical )
            {
                abilitiesToShow = sorting switch
                {
                    AbilitySorting.MostUsed => abilitiesToShow.OrderBy(a => pokemon.Where(p => p.AbilityId == a.Id).Count()),
                    AbilitySorting.LeastUsed => abilitiesToShow.OrderByDescending(a => pokemon.Where(p => p.AbilityId == a.Id).Count()),
                    _ => abilitiesToShow.OrderBy(x => x.Name),
                };
            }
            

            var abilities = await abilitiesToShow
                .Skip((currentPage - 1) * teamsPerPage)
                .Take(teamsPerPage)
                .Select(x => new AbilityServiceModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                })
                .ToListAsync();

            int totalItemsCount = await abilitiesToShow.CountAsync();

            return new AbilityQueryModel
            {
                ItemsPerPage = teamsPerPage,
                CurrentPage = currentPage,
                TotalItemsCount = totalItemsCount,
                Abilities = abilities
            };
        }

        public async Task<List<AbilityServiceModel>> GetAllAbilitiesServiceModel()
        {
            return await repository.AllAsReadOnly<Ability>()
                .Select(m => new AbilityServiceModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description
                })
                .ToListAsync();
        }
    }
}
