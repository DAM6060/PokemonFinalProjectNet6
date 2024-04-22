using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System.Reflection.Metadata.Ecma335;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;


namespace PokemonFinalProjectNet6.Core.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IRepository repository;
        private readonly IMoveService moveService;
        private readonly IAbilityService abilityService;
        private readonly IPlayerService playerService;

        public PokemonService(IRepository _repository, IMoveService moveService, IAbilityService abilityService, IPlayerService playerService)
        {
            repository = _repository;
            this.moveService = moveService;
            this.abilityService = abilityService;
            this.playerService = playerService;
        }

        public async Task<IEnumerable<string>> AllSpeciesNamesAsync()
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Select(p => p.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> CreateAsync(PokemonFormModel model, int playerId, int teamId)
        {            
            Pokemon pokemon = new Pokemon()
            {
                Name = model.Name,
                Level = PokemonLevel,
                BaseHP = model.BaseHp,
                EvHP = model.EvHp,
                HP = model.HP,
                BaseAttack = model.BaseAttack,
                EvAttack = model.EvAttack,
                Attack = model.Attack,
                BaseDefense = model.BaseDefense,
                EvDefence = model.EvDefense,
                Defense = model.Defense,
                BaseSpecialAttack = model.BaseSpecialAttack,
                EvSpecialAttack = model.EvSpecialAttack,
                SpecialAttack = model.SpecialAttack,
                BaseSpecialDefense = model.BaseSpecialDefense,
                EvSpecialDefense = model.EvSpecialDefense,
                SpecialDefense = model.SpecialDefense,
                BaseSpeed = model.BaseSpeed,
                EvSpeed = model.EvSpeed,
                Speed = model.Speed,
                TeamId = teamId,
                AbilityId = model.AbilityId,
                Type1 = model.Type1,
                Type2 = model.Type2,
                PlayerId = playerId
            };            
            await repository.AddAsync(pokemon);
            await repository.SaveChangesAsync();

			AddPokemonMoves(pokemon.Id, model.MovesIdsForDb);

			await repository.SaveChangesAsync();

            return pokemon.Id;
        }

        public async Task DeleteAsync(int pokemonId)
        {
            await repository.All<PokemonMove>()
				.Where(pm => pm.PokemonId == pokemonId)
				.ForEachAsync(pm => repository
                .DeleteAsync<PokemonMove>(pokemonId));
			

			await repository.DeleteAsync<Pokemon>(pokemonId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int pokemonId, PokemonFormModel model)
        {
			

			var pokemon = repository.All<Pokemon>().Include(p => p.PokemonMoves)
				.FirstOrDefault(p => p.Id == pokemonId);
            

			if (pokemon != null)
            {
                pokemon.Name = model.Name;
                pokemon.BaseHP = model.BaseHp;
                pokemon.EvHP = model.EvHp;
                pokemon.HP = model.HP;
                pokemon.BaseAttack = model.BaseAttack;
                pokemon.EvAttack = model.EvAttack;
                pokemon.Attack = model.Attack;
                pokemon.BaseDefense = model.BaseDefense;
                pokemon.EvDefence = model.EvDefense;
                pokemon.Defense = model.Defense;
                pokemon.BaseSpecialAttack = model.BaseSpecialAttack;
                pokemon.EvSpecialAttack = model.EvSpecialAttack;
                pokemon.SpecialAttack = model.SpecialAttack;
                pokemon.BaseSpecialDefense = model.BaseSpecialDefense;
                pokemon.EvSpecialDefense = model.EvSpecialDefense;
                pokemon.SpecialDefense = model.SpecialDefense;
                pokemon.BaseSpeed = model.BaseSpeed;
                pokemon.EvSpeed = model.EvSpeed;
                pokemon.Speed = model.Speed;
                pokemon.Type1 = model.Type1;
                pokemon.Type2 = model.Type2;
                pokemon.AbilityId = model.AbilityId;
                
                
				await repository.SaveChangesAsync();

                pokemon.PokemonMoves.Clear();

                await repository.SaveChangesAsync();
                AddPokemonMoves(pokemon.Id, model.MovesIdsForDb);				

				await repository.SaveChangesAsync();

			}
        }

        public async Task<bool> ExistsAsync(int pokemonId)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .AnyAsync(p => p.Id == pokemonId);
        }
                        

        public async Task<bool> SpeciesExistsAsync(string name)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .AnyAsync(p => p.Name == name);
           
        }

        public Task<Pokemon?> GetPokemonByIdAsync(int pokemonId)
        {
            return repository.All<Pokemon>()
				.Where(p => p.Id == pokemonId)
				.FirstOrDefaultAsync();
        }

        public async Task<PokemonViewModel> PokemonDetailsByIdAsync(int pokemonId)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Where(p => p.Id == pokemonId)
                .Select(p => new PokemonViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    PokeDexNumber = p.PokeDexNumber,
                    BaseHp = p.BaseHP,
                    EvHp = p.EvHP,
                    HP = p.HP,
                    BaseAttack = p.BaseAttack,
                    EvAttack = p.EvAttack,
                    Attack = p.Attack,
                    BaseSpeicalAttack = p.BaseSpecialAttack,
                    EvSpecialAttack = p.EvSpecialAttack,
                    SpecialAttack = p.SpecialAttack,
                    BaseDefense = p.BaseDefense,
                    EvDefense = p.EvDefence,
                    Defense = p.Defense,
                    BaseSpecialDefense = p.BaseSpecialDefense,
                    EvSpecialDefense = p.EvSpecialDefense,
                    SpecialDefense = p.SpecialDefense,
                    BaseSpeed = p.BaseSpeed,
                    EvSpeed = p.EvSpeed,
                    Speed = p.Speed,
                    Type1 = p.Type1.ToString(),
                    Type2 = p.Type2.ToString(),
                    Ability = new Models.Ability.AbilityServiceModel()
                    {
                        Id = p.AbilityId,
                        Name = p.Ability.Name                        
                    },
                    Moves = p.PokemonMoves.Select(pm => new MoveServiceModel
                    {
                        Id = pm.MoveId,
                        Name = pm.Move.Name                        
                    }).ToList()                    
                })
                .FirstAsync();
        }

        public async Task<PokemonFormModel> GetPokemonBaseValuesByNameAsync(string name)
        {
            return await repository.All<Pokemon>()
                .Where(p => p.Name == name)
                .Select(p => new PokemonFormModel
				{
                    Name = p.Name,
                    BaseHp = p.BaseHP,                    
                    BaseAttack = p.BaseAttack,                    
                    BaseSpecialAttack = p.BaseSpecialAttack,                    
                    BaseDefense = p.BaseDefense,                    
                    BaseSpecialDefense = p.BaseSpecialDefense,                    
                    BaseSpeed = p.BaseSpeed,                    
                    Type1 = p.Type1,
                    Type2 = p.Type2,                    
                })
                .FirstAsync();
        }

        public async Task<bool> PlayerHasPokemonWithId(int pokemonId, int playerId)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .AnyAsync(p => p.Id == pokemonId && p.PlayerId == playerId);
        }

        public async Task<PokemonFormModel> GetPokemonFormModelByIdAsync(int id)
        {
            var moves = await repository.All<PokemonMove>()
                .Where(pm => pm.PokemonId == id)
                .Select(pm => pm.MoveId).ToListAsync();
            

            return await repository.All<Pokemon>()
                .Where(p => p.Id == id)
                .Select(p => new PokemonFormModel
                {
                    Name = p.Name,
                    BaseHp = p.BaseHP,
                    EvHp = p.EvHP,                    
                    BaseAttack = p.BaseAttack,
                    EvAttack = p.EvAttack,                    
                    BaseDefense = p.BaseDefense,
                    EvDefense = p.EvDefence,                  
                    BaseSpecialAttack = p.BaseSpecialAttack,
                    EvSpecialAttack = p.EvSpecialAttack,                   
                    BaseSpecialDefense = p.BaseSpecialDefense,
                    EvSpecialDefense = p.EvSpecialDefense,                    
                    BaseSpeed = p.BaseSpeed,
                    EvSpeed = p.EvSpeed,                    
                    Type1 = p.Type1,
                    Type2 = p.Type2,
                    AbilityId = p.Ability.Id,                    
                    TeamId = p.TeamId,
                    PlayerId = p.PlayerId,
                    Move1IdForDb = moves[0],
                    Move2IdForDb = moves[1],
                    Move3IdForDb = moves[2],
                    Move4IdForDb = moves[3]
                    
                }).FirstAsync();
        }
        private async void AddPokemonMoves(int pokemonId, IEnumerable<int> moves)
        {
			for (int i = 0; i < 4; i++)
			{
				PokemonMove pokemonMove = new PokemonMove()
                {
					MoveId = moves.ElementAt(i),
					PokemonId = pokemonId
				};
				await repository.AddAsync(pokemonMove);
			}
		}
    }
}
