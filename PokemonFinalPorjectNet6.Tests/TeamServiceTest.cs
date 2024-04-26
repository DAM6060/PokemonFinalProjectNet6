using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Models;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Core.Services;
using PokemonFinalProjectNet6.Data;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalPorjectNet6.Tests
{
	public class TeamServiceTest
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

		[OneTimeSetUp]
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
				}
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
		[OneTimeTearDown]
		public async Task TearDown()
		{
			await context.Database.EnsureDeletedAsync();
			await context.DisposeAsync();
		}
		[Test]
		public async Task CreateAsyncCreatesTeamCorrecly()
		{
			var pokemon = new PokemonFormModel()
			{
				Name = "Venusaur",
				Type1 = PokemonTypeCustom.Grass,
				Type2 = PokemonTypeCustom.Poison,
				AbilityId = abilities[0].Id,
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
				Move1IdForDb = moves[2].Id,
				Move2IdForDb = moves[1].Id,
				Move3IdForDb = moves[0].Id,
				Move4IdForDb = moves[3].Id,
			};
			var pokemon2 = new PokemonFormModel()
			{
				Name = "Venusaur",
				Type1 = PokemonTypeCustom.Grass,
				Type2 = PokemonTypeCustom.Poison,
				AbilityId = abilities[0].Id,
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
				Move1IdForDb = moves[2].Id,
				Move2IdForDb = moves[1].Id,
				Move3IdForDb = moves[0].Id,
				Move4IdForDb = moves[3].Id,
			};
			var pokemon3 = new PokemonFormModel()
			{
				Name = "Infernoape",
				Type1 = PokemonTypeCustom.Grass,
				Type2 = PokemonTypeCustom.Poison,
				AbilityId = abilities[0].Id,
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
				Move1IdForDb = moves[2].Id,
				Move2IdForDb = moves[1].Id,
				Move3IdForDb = moves[0].Id,
				Move4IdForDb = moves[3].Id,
			};

			var model = new TeamFormModel()
			{
				Name = "Team2",
				PlayerId = 1,
				PokemonForDB1 = pokemon,
				PokemonForDB2 = pokemon2,
				PokemonForDB3 = pokemon3,
			};

			await teamService.CreateAsync(model);
			var team = context.Teams.Include(t => t.Pokemons).ToList();
			Assert.That(team.Last().Name, Is.EqualTo("Team2"));
			Assert.That(team.Last().Wins, Is.EqualTo(0));
			Assert.That(team.Last().Losses, Is.EqualTo(0));
			Assert.That(team.Last().Pokemons.First().Name, Is.EqualTo("Venusaur"));
			Assert.That(team.Last().Pokemons.Last().Name, Is.EqualTo("Infernoape"));
			Assert.AreEqual(2, team.Count());

		}
		[Test]
		public async Task ExistAsyncReturnsCorrectResult()
		{
			var result = await teamService.ExistsById(1);
			var falseResult = await teamService.ExistsById(0);
			Assert.IsTrue(result);
			Assert.IsFalse(falseResult);
		}
		
		[Test]
		public async Task PlayerHasTeamAsyncReturnsCorrectResult()
		{
			var result = await teamService.PlayerHasTeamAsync(1, 1);
			var falseResult = await teamService.PlayerHasTeamAsync(1, 0);
			Assert.That(result, Is.True);
			Assert.That(falseResult, Is.False);
		}
		[Test]
		public async Task GetTeamsByPlayerIdAsyncReturnsCorrectTeams()
		{
			var result = await teamService.GetTeamsByPlayerIdAsync(1);
			Assert.That(result.First().Name, Is.EqualTo(teams[0].Name));
			Assert.That(result.First().Wins, Is.EqualTo(teams[0].Wins));
			Assert.That(result, Is.TypeOf<List<TeamServiceModel>>());
		}
		
		
		[Test]
		public async Task TeamLeaderBoardAsyncReturnsCorrectTeams()
		{
			var result = await teamService.TeamLeaderBoardAsync();
			Assert.That(result.Teams.First().Name, Is.EqualTo(teams[0].Name));
			Assert.That(result.Teams.First().Wins, Is.EqualTo(teams[0].Wins));
			Assert.That(result.Teams.First().Losses, Is.EqualTo(teams[0].Losses));
			Assert.That(result.Teams.First().Pokemons.First(), Is.EqualTo(teams[0].Pokemons[0].Name));
			Assert.That(result.Teams.First().Pokemons.Last(), Is.EqualTo(teams[0].Pokemons[2].Name));
			Assert.That(result, Is.TypeOf<TeamLeaderBoardQueryModel>());
		}
		

		

	}
}
