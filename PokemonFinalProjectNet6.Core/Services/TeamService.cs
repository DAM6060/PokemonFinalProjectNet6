using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repository;
        private readonly IPokemonService pokemonService;

        public TeamService(IRepository _repository, IPokemonService _pokemonService)
        {
            repository = _repository;
            pokemonService = _pokemonService;
        }
        public async Task<int> CreateAsync(TeamFormModel model, int playerId, params PokemonFormModel[] pokemons)
        {
            List<Pokemon> pokemonsToAdd = new List<Pokemon>();

            foreach (var pokemon in pokemons)
            {
                var pokemonId = await pokemonService.CreateAsync(pokemon , playerId);

                if (await pokemonService.ExistsAsync(pokemonId) == true)
                {
                    pokemonsToAdd.Add(await pokemonService.GetPokemonByIdAsync(pokemonId));
                } 
            }

            var team = new Team
            {
                Name = model.Name,
                PlayerId = playerId,
                Pokemons = pokemonsToAdd
            };

            await repository.AddAsync(team);
            await repository.SaveChangesAsync();
            return team.Id;
        }
    }
}
