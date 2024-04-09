using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
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

        public Task<IEnumerable<PokemonFormModel>> AllPokemonByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PokemonFormModel>> AllPokemonByPlayerIdAsync(int playerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> AllSpeciesNamesAsync()
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Select(p => p.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> CreateAsync(PokemonFormModel model, int playerId, params MoveServiceModel[] moves)
        {
            //Need to Populate PokemonMove From PokemonFormModelinput
            // maybe we can do the same as in the TeamService
            //Add Params PokemonMoveFormModel[] moves to the method signature
            //them foreach and creat Move that has Id of the Pokemon
            List<int> move = new List<int>();      

            

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
                TeamId = model.TeamId,
                AbilityId = model.AbilityId,
                Type1 = model.Type1,
                Type2 = model.Type2
                

                               

            };

            
            await repository.AddAsync(pokemon);
            await repository.SaveChangesAsync();

            //If it doesnt work like this we can pull this guy

            for (int i = 0; i < 3; i++)
            {
                PokemonMove pokemonMove = new PokemonMove()
                {
                    MoveId = moves[i].Id,
                    PokemonId = pokemon.Id
                };
            }

            await repository.SaveChangesAsync();

            return pokemon.Id;
        }

        public async Task DeleteAsync(int pokemonId)
        {
            await repository.DeleteAsync<Pokemon>(pokemonId);

            await repository.SaveChangesAsync();
        }

        public Task EditAsync(int pokemonId, PokemonFormModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .AnyAsync(p => p.Id == id);
        }

        public async Task<PokemonFormModel?> GetPokemonFormModelByIdAsync(int id)
        {
            //Again we need to populate PokemonMove from PokemonFormModel

            // Create A method to add moves From PokemonMove Model to PokemonFormModel
            //Similar to what is done with the categories maybe 
            var pokemon = await  repository.AllAsReadOnly<Pokemon>()
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
                    AbilityId = p.AbilityId

                })
                .FirstOrDefaultAsync();

            //Add  moves to pokemon here

            return pokemon;

        }

        public Task<bool> HasPlayerWithIdAsync(int pokemonId, string playerId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SpeciesExistsAsync(int pokedexnumber)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .AnyAsync(p => p.PokeDexNumber == pokedexnumber);
           
        }

        public Task<Pokemon?> GetPokemonByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PokemonServiceModel> PokemonDetailsByIdAsync(int id)
        {
            return await repository.AllAsReadOnly<Pokemon>()
                .Where(p => p.Id == id)
                .Select(p => new PokemonServiceModel
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
                    BaseSpecialAttack = p.BaseSpecialAttack,
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
                        Name = p.Ability.Name,
                        Description = p.Ability.Description
                    },
                    //await abilityService.AbilityByIdAsync(p.AbilityId)
                    //Player = await playerService.PlayerByIdAsync(p.PlayerId),
                    //Moves = await moveService.AllMovesByPokemonIdAsync(p.Id)
                    
                })
                .FirstAsync();
        }
    }
}
