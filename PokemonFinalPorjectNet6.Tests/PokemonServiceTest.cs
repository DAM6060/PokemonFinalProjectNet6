
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Services;
using PokemonFinalProjectNet6.Data;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalPorjectNet6.Tests
{
    public class PokemonServiceTest
    {
        private IRepository repository;
        private TeamService teamService;
        private PokemonDbContext context;
        private PokemonService pokemonService;

        private List<Team> teams;
        private List<IdentityUser> users;
        private List<Player> players;
        private List<Pokemon> pokemons;
        private List<Move> moves;
        private List<Ability> abilities;

        [SetUp]
        public async Task SetUp()
        {
            users = new List<IdentityUser>()
            {
                new IdentityUser()
                {
                    Id = "8d16841e-7c17-44c5-b30d-5f10b43122c8",
                    UserName = "User1"
                },
            };
            players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    UserId = users[0].Id,
                    Name = "Player1",
                },
            };
            teams = new List<Team>()
            {
                new Team()
                {
                    Id = 1,
                    Name = "Team1",
                    PlayerId = 1,
                    Wins = 2,
                    Losses = 1,
                },
            };
            moves = new List<Move>()
            {
                 new Move()
                {
                    Id = 1,
                    Name = "Flame Thrower",
                    Type = "Fire",
                    Power = 90,
                    Accuracy = 100,
                    PowerPoints = 15,
                    Ailment = "Burn",
                    AilmentChance = 10,
                    DamageClass = DamageClass.Special,
                    Description = "The target is scorched with an intense blast of fire. This may also leave the target with a burn."
                },

                 new Move
                {
                    Id = 2,
                    Name = "Thunder Punch",
                    Type = "Electric",
                    Power = 75,
                    Accuracy = 100,
                    PowerPoints = 15,
                    Ailment = "Paralysis",
                    AilmentChance = 10,
                    DamageClass = DamageClass.Physical,
                    Description = "The target is punched with an electrified fist. This may also leave the target with paralysis."
                },

                new Move
                {
                    Id = 3,
                    Name = "Giga Drain",
                    Type = "Grass",
                    Power = 75,
                    Accuracy = 100,
                    PowerPoints = 10,
                    Effect = "Heal",
                    EffectChance = 100,
                    DamageClass = DamageClass.Special,
                    IsEffectUser = true,
                    HealAmount = 50,
                    HealType = HealType.OpponentHP,
                    Description = "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target."
                },

                 new Move
                {
                    Id = 4,
                    Name = "Sleep Powder",
                    Type = "Grass",
                    Power = 0,
                    Accuracy = 75,
                    PowerPoints = 15,
                    Ailment = "Sleep",
                    AilmentChance = 100,
                    DamageClass = DamageClass.Status,
                    Description = "The user scatters a big cloud of sleep-inducing dust around the target."
                }
            };
            abilities = new List<Ability>()
            {
                new Ability()
                {
                    Id = 1,
                    Name = "Adaptability",
                    Description = "Powers up moves of the same type.",
                },
            };

            pokemons = new List<Pokemon>()
            {
                 new Pokemon()
                {
                    Id = 1,
                    Name = "Venusaur",

                    Type1 = PokemonTypeCustom.Grass,
                    Type2 = PokemonTypeCustom.Poison,
                    AbilityId = abilities[0].Id,
                    BaseHP = 80,
                    BaseAttack = 82,
                    BaseDefense = 83,
                    BaseSpecialAttack = 100,
                    BaseSpecialDefense = 100,
                    BaseSpeed = 80,

                    EvHP = 0,
                    EvAttack = 0,
                    EvDefence = 0,
                    EvSpecialAttack = 0,
                    EvSpecialDefense = 4,
                    EvSpeed = 0,
                    HP = 80,
                    Attack = 82,
                    Defense = 83,
                    SpecialAttack = 100,
                    SpecialDefense = 100,
                    Speed = 80,
                    TeamId = teams[0].Id,
                    PlayerId = players[0].Id,
                    PokemonMoves = new List<PokemonMove>()
                    {
                        new PokemonMove()
                        {
                            PokemonId = 1,
                            MoveId = moves[2].Id
                        },
                        new PokemonMove()
                        {
                            PokemonId = 1,
                            MoveId = moves[1].Id
                        }
                    }


                },

                 new Pokemon()
                {
                    Id = 2,
                    Name = "Infernape",

                    Type1 = PokemonTypeCustom.Fire,
                    Type2 = PokemonTypeCustom.Fighting,
                    AbilityId = abilities[0].Id,
                     BaseHP = 76,
                    BaseAttack = 104,
                    BaseDefense = 71,
                    BaseSpecialAttack = 104,
                    BaseSpecialDefense = 71,
                    BaseSpeed = 108,
                    EvHP = 0,
                    EvAttack = 0,
                    EvDefence = 0,
                    EvSpecialAttack = 0,
                    EvSpecialDefense = 0,
                    EvSpeed = 0,
                    HP = 76,
                    Attack = 104,
                    Defense = 71,
                    SpecialAttack = 104,
                    SpecialDefense = 71,
                    Speed = 108,
                    TeamId = teams[0].Id,
                    PlayerId = players[0].Id,
                    PokemonMoves = new List<PokemonMove>()
                    {
                        new PokemonMove()
                        {
                            PokemonId = 2,
                            MoveId = moves[2].Id
                        },
                        new PokemonMove()
                        {
                            PokemonId = 2,
                            MoveId = moves[3].Id
                        }
                    }
                },

                 new Pokemon()
                {
                    Id = 3,
                    Name = "Tyranitar",

                    Type1 = PokemonTypeCustom.Rock,
                    Type2 = PokemonTypeCustom.Dark,
                    AbilityId = abilities[0].Id,
                    BaseHP = 100,
                    BaseAttack = 134,
                    BaseDefense = 110,
                    BaseSpecialAttack = 95,
                    BaseSpecialDefense = 100,
                    BaseSpeed = 61,

                    EvHP = 0,
                    EvAttack = 0,
                    EvDefence = 0,
                    EvSpecialAttack = 0,
                    EvSpecialDefense = 0,
                    EvSpeed = 0,
                    HP = 100,
                    Attack = 134,
                    Defense = 110,
                    SpecialAttack = 95,
                    SpecialDefense = 100,
                    Speed = 61,
                    TeamId = teams[0].Id,
                    PlayerId = players[0].Id,
                    PokemonMoves = new List<PokemonMove>()
                    {
                        new PokemonMove()
                        {
                            PokemonId = 3,
                            MoveId = moves[0].Id
                        },
                        new PokemonMove()
                        {
                            PokemonId = 3,
                            MoveId = moves[3].Id
                        }
                    }
                }, new Pokemon()
                {
                    Id = 4,
                    Name = "Venusaur",

                    Type1 = PokemonTypeCustom.Grass,
                    Type2 = PokemonTypeCustom.Poison,
                    AbilityId = abilities[0].Id,
                    BaseHP = 80,
                    BaseAttack = 82,
                    BaseDefense = 83,
                    BaseSpecialAttack = 100,
                    BaseSpecialDefense = 100,
                    BaseSpeed = 80,

                    EvHP = 0,
                    EvAttack = 0,
                    EvDefence = 0,
                    EvSpecialAttack = 0,
                    EvSpecialDefense = 4,
                    EvSpeed = 0,
                    HP = 80,
                    Attack = 82,
                    Defense = 83,
                    SpecialAttack = 100,
                    SpecialDefense = 100,
                    Speed = 80,
                    TeamId = teams[0].Id,
                    PlayerId = players[0].Id,
                    PokemonMoves = new List<PokemonMove>()
                    {
                        new PokemonMove()
                        {
                            PokemonId = 4,
                            MoveId = moves[2].Id
                        },
                        new PokemonMove()
                        {
                            PokemonId = 4,
                            MoveId = moves[1].Id
                        }
                    }


                },
            };

            var options = new DbContextOptionsBuilder<PokemonDbContext>()
                .UseInMemoryDatabase(databaseName: "PokemonDatabase" + Guid.NewGuid().ToString())
                .Options;

            context = new PokemonDbContext(options);

            context.AddRange(users);
            context.AddRange(players);
            context.AddRange(teams);
            context.AddRange(moves);
            context.AddRange(abilities);
            context.AddRange(pokemons);
            await context.SaveChangesAsync();

            repository = new Repository(context);
            pokemonService = new PokemonService(repository);
            teamService = new TeamService(repository, pokemonService);

        }
        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }


        [Test]
        public async Task GetPokemonByIdAsyncWorksCorrectly()
        {
            var nullPokemon = await pokemonService.GetPokemonByIdAsync(5);
            var NotNullPokemon = await pokemonService.GetPokemonByIdAsync(1);

            Assert.That(nullPokemon, Is.Null);
            Assert.That(NotNullPokemon, Is.Not.Null);
        }
        [Test]
        public async Task SpeciesExistsAsyncWorksCorrectly()
        {
            var exists = await pokemonService.SpeciesExistsAsync("Venusaur");
            var falseExists = await pokemonService.SpeciesExistsAsync("Charizard");
            Assert.That(exists, Is.True);
            Assert.That(falseExists, Is.False);
        }
        [Test]
        public async Task AllSpeciesNamesAsyncReturnsCorrectly()
        {
            var species = await pokemonService.AllSpeciesNamesAsync();
            Assert.That(species, Is.Not.Null);
            Assert.That(species.Count(), Is.EqualTo(3));
            Assert.That(species, Does.Contain("Venusaur"));
            Assert.That(species, Does.Contain("Infernape"));
            Assert.That(species, Does.Contain("Tyranitar"));
        }
        [Test]
        public async Task PlayerHasPokemonWithIdWorksCorrectly()
        {
            var hasPokemon = await pokemonService.PlayerHasPokemonWithId(1, 1);
            var falseHasPokemon = await pokemonService.PlayerHasPokemonWithId(5, 1);
            Assert.That(hasPokemon, Is.True);
            Assert.That(falseHasPokemon, Is.False);
        }
        [Test]
        public async Task ExistsAsyncWorksCorrectly()
        {
            var exists = await pokemonService.ExistsAsync(1);
            var falseExists = await pokemonService.ExistsAsync(5);
            Assert.That(exists, Is.True);
            Assert.That(falseExists, Is.False);
        }
        [Test]
        public async Task PokemonDetailsByIdAsyncReturnsCorrectly()
        {
            var pokemon = await pokemonService.PokemonDetailsByIdAsync(1);
            Assert.That(pokemon, Is.Not.Null);
            Assert.That(pokemon.Id, Is.EqualTo(1));
            Assert.That(pokemon.Name, Is.EqualTo("Venusaur"));
            Assert.That(pokemon.Type1, Is.EqualTo(PokemonTypeCustom.Grass.ToString()));
            Assert.That(pokemon.Type2, Is.EqualTo(PokemonTypeCustom.Poison.ToString()));
            Assert.That(pokemon.Ability.Id, Is.EqualTo(1));
            Assert.That(pokemon.BaseHp, Is.EqualTo(80));
            Assert.That(pokemon.BaseAttack, Is.EqualTo(82));
            Assert.That(pokemon.BaseDefense, Is.EqualTo(83));
            Assert.That(pokemon.BaseSpecialDefense, Is.EqualTo(100));
            Assert.That(pokemon.BaseSpecialDefense, Is.EqualTo(100));
            Assert.That(pokemon.BaseSpeed, Is.EqualTo(80));
            Assert.That(pokemon.EvHp, Is.EqualTo(0));
            Assert.That(pokemon.EvAttack, Is.EqualTo(0));
            Assert.That(pokemon.EvDefense, Is.EqualTo(0));
            Assert.That(pokemon.EvSpecialAttack, Is.EqualTo(0));
            Assert.That(pokemon.EvSpecialDefense, Is.EqualTo(4));
            Assert.That(pokemon.EvSpeed, Is.EqualTo(0));
            Assert.That(pokemon.HP, Is.EqualTo(80));
            Assert.That(pokemon.Attack, Is.EqualTo(82));
            Assert.That(pokemon.Defense, Is.EqualTo(83));
            Assert.That(pokemon.SpecialAttack, Is.EqualTo(100));
            Assert.That(pokemon.SpecialDefense, Is.EqualTo(100));
            Assert.That(pokemon.Speed, Is.EqualTo(80));
            Assert.That(pokemon.Moves.Count, Is.EqualTo(2));
        }
        [Test]
        public async Task EditAsyncWorksCorrectly()
        {
            var model = new PokemonFormModel()
            {
                Name = "Venusaur",
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Poison,
                AbilityId = 1,
                BaseHp = 80,
                BaseAttack = 82,
                BaseDefense = 83,
                BaseSpecialAttack = 100,
                BaseSpecialDefense = 100,
                BaseSpeed = 80,
                EvHp = 0,
                EvAttack = 0,
                EvDefense = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                Move1IdForDb = 3,
                Move2IdForDb = 1,
                Move3IdForDb = 2,
                Move4IdForDb = 4,
                TeamId = 1,
                PlayerId = 1

            };
            await pokemonService.EditAsync(1, model);
            var pokemon = context.Pokemons.FirstAsync(p => p.Id == 1).Result;

            Assert.That(pokemon.Name, Is.EqualTo("Venusaur"));
            Assert.That(pokemon.Type1, Is.EqualTo(PokemonTypeCustom.Fire));
            Assert.That(pokemon.Type2, Is.EqualTo(PokemonTypeCustom.Poison));
            Assert.That(pokemon.AbilityId, Is.EqualTo(1));
            Assert.That(pokemon.BaseHP, Is.EqualTo(80));
            Assert.That(pokemon.BaseAttack, Is.EqualTo(82));
            Assert.That(pokemon.BaseDefense, Is.EqualTo(83));
            Assert.That(pokemon.BaseSpecialAttack, Is.EqualTo(100));
            Assert.That(pokemon.BaseSpecialDefense, Is.EqualTo(100));
            Assert.That(pokemon.BaseSpeed, Is.EqualTo(80));
            Assert.That(pokemon.EvHP, Is.EqualTo(0));
            Assert.That(pokemon.EvAttack, Is.EqualTo(0));
            Assert.That(pokemon.EvDefence, Is.EqualTo(0));
            Assert.That(pokemon.EvSpecialAttack, Is.EqualTo(0));
            Assert.That(pokemon.EvSpecialDefense, Is.EqualTo(0));
            Assert.That(pokemon.EvSpeed, Is.EqualTo(0));
            Assert.That(pokemon.Level, Is.EqualTo(50));
            Assert.That(pokemon.HP, Is.EqualTo(140));
            Assert.That(pokemon.Attack, Is.EqualTo(87));
            Assert.That(pokemon.Defense, Is.EqualTo(88));
            Assert.That(pokemon.SpecialAttack, Is.EqualTo(105));
            Assert.That(pokemon.SpecialDefense, Is.EqualTo(105));
            Assert.That(pokemon.Speed, Is.EqualTo(85));
            Assert.That(pokemon.TeamId, Is.EqualTo(1));
            Assert.That(pokemon.PlayerId, Is.EqualTo(1));
            Assert.That(pokemon.PokemonMoves.Count, Is.EqualTo(4));
        }
        [Test]
        public async Task CreateWorksCorrectly()
        {
            var teamId = 1;
            var playerId = 1;
            var pokemonInput = new PokemonFormModel()
            {
                Name = "Charizard",
                Level = 50,
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Flying,
                AbilityId = 1,
                BaseHp = 78,
                BaseAttack = 84,
                BaseDefense = 78,
                BaseSpecialAttack = 109,
                BaseSpecialDefense = 85,
                BaseSpeed = 100,
                EvHp = 0,
                EvAttack = 0,
                EvDefense = 0,
                EvSpecialAttack = 255,
                EvSpecialDefense = 0,
                EvSpeed = 255,
                Move1IdForDb = 1,
                Move2IdForDb = 2,
                Move3IdForDb = 3,
                Move4IdForDb = 4,
            };
            var pokemonId = await pokemonService.CreateAsync(pokemonInput, teamId, playerId);
            var pokemon = context.Pokemons.FirstAsync(p => p.Id == pokemonId).Result;

            var hp = (int)((((double)2 * (double)pokemonInput.BaseHp + ((double)pokemonInput.EvHp / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)pokemonInput.Level + (double)10);
            var attack = (int)((((double)2 * (double)pokemonInput.BaseAttack + ((double)pokemonInput.EvAttack / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)5);
            var defense = (int)((((double)2 * (double)pokemonInput.BaseDefense + ((double)pokemonInput.EvDefense / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)5);
            var specialAttack = (int)((((double)2 * (double)pokemonInput.BaseSpecialAttack + ((double)pokemonInput.EvSpecialAttack / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)5);
            var specialDefense = (int)((((double)2 * (double)pokemonInput.BaseSpecialDefense + ((double)pokemonInput.EvSpecialDefense / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)5);
            var speed = (int)((((double)2 * (double)pokemonInput.BaseSpeed + ((double)pokemonInput.EvSpeed / (double)4)) * (double)pokemonInput.Level / (double)100) + (double)5);
            Assert.That(pokemon, Is.Not.Null);
            Assert.That(pokemon.Name, Is.EqualTo("Charizard"));
            Assert.That(pokemon.Type1, Is.EqualTo(PokemonTypeCustom.Fire));
            Assert.That(pokemon.Type2, Is.EqualTo(PokemonTypeCustom.Flying));
            Assert.That(pokemon.AbilityId, Is.EqualTo(1));
            Assert.That(pokemon.BaseHP, Is.EqualTo(78));
            Assert.That(pokemon.BaseAttack, Is.EqualTo(84));
            Assert.That(pokemon.BaseDefense, Is.EqualTo(78));
            Assert.That(pokemon.BaseSpecialAttack, Is.EqualTo(109));
            Assert.That(pokemon.BaseSpecialDefense, Is.EqualTo(85));
            Assert.That(pokemon.BaseSpeed, Is.EqualTo(100));
            Assert.That(pokemon.EvHP, Is.EqualTo(0));
            Assert.That(pokemon.EvAttack, Is.EqualTo(0));
            Assert.That(pokemon.EvDefence, Is.EqualTo(0));
            Assert.That(pokemon.EvSpecialAttack, Is.EqualTo(255));
            Assert.That(pokemon.EvSpecialDefense, Is.EqualTo(0));
            Assert.That(pokemon.EvSpeed, Is.EqualTo(255));
            Assert.That(pokemon.Level, Is.EqualTo(50));
            Assert.That(pokemon.HP, Is.EqualTo(hp));
            Assert.That(pokemon.Attack, Is.EqualTo(attack));
            Assert.That(pokemon.Defense, Is.EqualTo(defense));
            Assert.That(pokemon.SpecialAttack, Is.EqualTo(specialAttack));
            Assert.That(pokemon.SpecialDefense, Is.EqualTo(specialDefense));
            Assert.That(pokemon.Speed, Is.EqualTo(speed));
            Assert.That(pokemon.TeamId, Is.EqualTo(1));
            Assert.That(pokemon.PlayerId, Is.EqualTo(1));
            Assert.That(pokemon.PokemonMoves.Count, Is.EqualTo(4));
        }
        [Test]
        public async Task GetPokemonBaseValuesByNameAsyncWorksCorrectly()
        {
            string name = pokemons.First().Name;
            var pokemon = await pokemonService.GetPokemonBaseValuesByNameAsync(name);

            Assert.That(pokemon, Is.Not.Null);
            Assert.That(pokemon.Name, Is.EqualTo("Venusaur"));
            Assert.That(pokemon.Type1, Is.EqualTo(PokemonTypeCustom.Grass));
            Assert.That(pokemon.Type2, Is.EqualTo(PokemonTypeCustom.Poison));
            Assert.That(pokemon.AbilityId, Is.EqualTo(0));
            Assert.That(pokemon.BaseHp, Is.EqualTo(pokemons.First().BaseHP));
            Assert.That(pokemon.BaseAttack, Is.EqualTo(pokemons.First().BaseAttack));
            Assert.That(pokemon.BaseDefense, Is.EqualTo(pokemons.First().BaseDefense));
            Assert.That(pokemon.BaseSpecialAttack, Is.EqualTo(pokemons.First().BaseSpecialAttack));
            Assert.That(pokemon.BaseSpecialDefense, Is.EqualTo(pokemons.First().BaseSpecialDefense));
            Assert.That(pokemon.BaseSpeed, Is.EqualTo(pokemons.First().BaseSpeed));
        }
        [Test]
        public async Task AddPokemonSpeciesWorksCorrectly()
        {
            var model = new PokemonSpeciesFormModel()
            {
                Name = "Charizard",
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Flying,                
                BaseHP = 78,
                BaseAttack = 84,
                BaseDefense = 78,
                BaseSpecialAttack = 109,
                BaseSpecialDefense = 85,
                BaseSpeed = 100               
                
            };
            await pokemonService.CreateSpeciesAsync(model);

            var pokemonSpecies = await pokemonService.AllSpeciesNamesAsync();            
            var charizard =  context.Pokemons.FirstAsync(p => p.Id == 5).Result;

            Assert.That(pokemonSpecies, Is.Not.Null);
            Assert.That(pokemonSpecies.Count(), Is.EqualTo(4));
            Assert.That(pokemonSpecies, Does.Contain("Charizard"));
            Assert.That(charizard.Name, Is.EqualTo(model.Name));
            Assert.That(charizard.Type1, Is.EqualTo(model.Type1));
            Assert.That(charizard.Type2, Is.EqualTo(model.Type2));
            Assert.That(charizard.BaseHP, Is.EqualTo(model.BaseHP));
            Assert.That(charizard.BaseAttack, Is.EqualTo(model.BaseAttack));
            Assert.That(charizard.BaseDefense, Is.EqualTo(model.BaseDefense));
            Assert.That(charizard.BaseSpecialAttack, Is.EqualTo(model.BaseSpecialAttack));
            Assert.That(charizard.BaseSpecialDefense, Is.EqualTo(model.BaseSpecialDefense));
            Assert.That(charizard.BaseSpeed, Is.EqualTo(model.BaseSpeed));            
            Assert.That(charizard.AbilityId, Is.EqualTo(1));
            Assert.That(charizard.TeamId, Is.EqualTo(3));
            Assert.That(charizard.PlayerId, Is.EqualTo(2));            
        }
        [Test]
        public async Task EditSpeciesWorksCorrectly()
        {
            var oldVenasuar = context.Pokemons.FirstOrDefaultAsync(p => p.Id == 1).Result;

            var model = new PokemonSpeciesFormModel
            {
                Name = "Venusaur",
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Poison,
                BaseHP = 100,
                BaseAttack = 82,
                BaseDefense = 83,
                BaseSpecialAttack = 100,
                BaseSpecialDefense = 100,
                BaseSpeed = 80

            };

            await pokemonService.EditSpeciesAsync(model);

            var newVenasuar = context.Pokemons.FirstOrDefaultAsync(p => p.Id == 1).Result;
            Assert.That(newVenasuar.Type1, Is.EqualTo(PokemonTypeCustom.Fire));
            Assert.That(newVenasuar.Type1, Is.Not.EqualTo(PokemonTypeCustom.Grass));

            
        }



    }
}
