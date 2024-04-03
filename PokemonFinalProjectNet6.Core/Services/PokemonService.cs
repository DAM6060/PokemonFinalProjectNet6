using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IRepository repository;

        public PokemonService(IRepository _repository) 
        {
            repository = _repository;
        }
        public async Task<IEnumerable<PokemonSpeciesServiceModel>> AllPokemonSpeciesAsync()
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Select(c => new PokemonSpeciesServiceModel()
                {
                    Id = c.Id,
                    PokeDexNumber = c.PokeDexNumber,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllPokemonSpeciesNameAsync()
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Select(p => p.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> CreateAsync(PokemonFormModel model, int teamId)
        {
            Pokemon pokemon = new Pokemon
            {
                Name = model.Name,
                PokeDexNumber = model.PokeDexNumber,
                TeamId = teamId,
                BaseHP = model.BaseHP,
                EvHP = model.EvHP,
                BaseAttack = model.BaseAttack,
                EvAttack = model.EvAttack,
                BaseDefense = model.BaseDefense,
                EvDefence = model.EvDefense,
                BaseSpecialAttack = model.BaseSpecialAttack,
                EvSpecialAttack = model.EvSpecialAttack,
                BaseSpecialDefense = model.BaseSpecialDefense,
                EvSpecialDefense = model.EvSpecialDefense,
                BaseSpeed = model.BaseSpeed,
                EvSpeed = model.EvSpeed,
                Type1 = model.Type1,
                Type2 = model.Type2,
                Level = model.Level,
                GenerationCustom = model.Generation,
                AbilityId = model.AbilityId,
                PokemonMoves = 





               
            };
        }

       
    }
}
