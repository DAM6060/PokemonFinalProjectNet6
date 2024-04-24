using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Services;
using PokemonFinalProjectNet6.Data;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalPorjectNet6.Tests
{
	public class MoveServiceTest
	{
		private IRepository repository;
		private MoveService moveService;
		private PokemonDbContext context;

		private List<Move> moves;

		[SetUp]
		public async Task SetUp() 
		{
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

			var options = new DbContextOptionsBuilder<PokemonDbContext>()
				.UseInMemoryDatabase(databaseName: "PokemonDb" + Guid.NewGuid().ToString())
				.Options;

			context = new PokemonDbContext(options);

			context.AddRange(moves);
			await context.SaveChangesAsync();

			repository = new Repository(context);
			moveService = new MoveService(repository);
		}
		[TearDown]
		public async Task TearDown()
		{
			await context.Database.EnsureDeletedAsync();
			await context.DisposeAsync();
		}
		[Test]
		public async Task CreateAsyncShouldCreateMove()
		{
			var moveFormModel = new MoveFormModel
			{
				Name = "Fire Blast",
				Type = PokemonTypeCustom.Fire,
				Power = 110,
				Accuracy = 85,
				PowerPoints = 5,
				Ailment = "Burn",
				AilmentChance = 10,
				DamageClass = DamageClass.Special,
				Description = "The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn.",
				Effect= "none",
				EffectChance = 0,
				EffectDuration = 0,
				HealAmount = 0,
				HealType = HealType.NoHeal,
				IsEffectUser = null,
				Priority = 0
				
			};

			var moveId = await moveService.CreateAsync(moveFormModel);

			var move = await repository.AllAsReadOnly<Move>().FirstAsync(m => m.Id == moveId);

			Assert.That(move, Is.Not.Null);
			Assert.That(move.Name, Is.EqualTo("Fire Blast"));
			Assert.That(move.Type, Is.EqualTo("Fire"));
			Assert.That(move.Power, Is.EqualTo(110));
			Assert.That(move.Accuracy, Is.EqualTo(85));
			Assert.That(move.PowerPoints, Is.EqualTo(5));
			Assert.That(move.Ailment, Is.EqualTo("Burn"));
			Assert.That(move.AilmentChance, Is.EqualTo(10));
			Assert.That(move.DamageClass, Is.EqualTo(DamageClass.Special));
			Assert.That(move.Description, Is.EqualTo("The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn."));
			Assert.That(move.Effect, Is.EqualTo(""));
			Assert.That(move.EffectChance, Is.EqualTo(0));
			Assert.That(move.EffectDuration, Is.EqualTo(0));
			Assert.That(move.HealAmount, Is.EqualTo(0));
			Assert.That(move.HealType, Is.EqualTo(HealType.NoHeal));
			Assert.That(move.IsEffectUser, Is.Null);
			Assert.That(move.Priority, Is.EqualTo(0));			
		}

		[Test]
		public async Task EditAsyncShouldEditMove()
		{

			var moveFormModel = new MoveFormModel
			{
				Name = "Flame Thrower",
				Type = PokemonTypeCustom.Water,
				Power = 90,
				Accuracy = 100,
				PowerPoints = 15,
				Ailment = "Burn",
				AilmentChance = 10,
				DamageClass = DamageClass.Special,
				Description = "The target is scorched with an intense blast of fire. This may also leave the target with a burn.",
				Effect = "none",
				EffectChance = 0,
				EffectDuration = 0,
				HealAmount = 0,
				HealType = HealType.NoHeal,
				IsEffectUser = null,
				Priority = 0
			};

			await moveService.EditAsync(moveFormModel);
			
			var move = await repository.AllAsReadOnly<Move>().FirstAsync(m => m.Id == 1);

			Assert.That(move, Is.Not.Null);
			Assert.That(move.Name, Is.EqualTo("Flame Thrower"));
			Assert.That(move.Type, Is.EqualTo("Water"));
			Assert.That(move.Power, Is.EqualTo(90));
			Assert.That(move.Accuracy, Is.EqualTo(100));
			Assert.That(move.PowerPoints, Is.EqualTo(15));
			Assert.That(move.Ailment, Is.EqualTo("Burn"));
			Assert.That(move.AilmentChance, Is.EqualTo(10));
			Assert.That(move.DamageClass, Is.EqualTo(DamageClass.Special));
			Assert.That(move.Description, Is.EqualTo("The target is scorched with an intense blast of fire. This may also leave the target with a burn."));
			Assert.That(move.Effect, Is.EqualTo(""));
			Assert.That(move.EffectChance, Is.EqualTo(0));
			Assert.That(move.EffectDuration, Is.EqualTo(0));
			Assert.That(move.HealAmount, Is.EqualTo(0));
			Assert.That(move.HealType, Is.EqualTo(HealType.NoHeal));
			Assert.That(move.IsEffectUser, Is.Null);
			Assert.That(move.Priority, Is.EqualTo(0));

		}
		[Test]
		public async Task ExistsByIAsyncdWorksCorrectly()
		{
			var moveExists = await moveService.ExistsByIdAsync(1);
			var moveDoesNotExist = await moveService.ExistsByIdAsync(5);

			Assert.That(moveExists, Is.True);
			Assert.That(moveDoesNotExist, Is.False);
		}
		[Test]
		public async Task GetMoveFormModelAsyncShouldReturnCorrectMove()
		{
			var moveFormModel = await moveService.GetMoveFormModelAsync(1);

			Assert.That(moveFormModel, Is.Not.Null);
			Assert.That(moveFormModel.Name, Is.EqualTo("Flame Thrower"));
			Assert.That(moveFormModel.Type, Is.EqualTo(PokemonTypeCustom.Fire));
			Assert.That(moveFormModel.Power, Is.EqualTo(90));
			Assert.That(moveFormModel.Accuracy, Is.EqualTo(100));
			Assert.That(moveFormModel.PowerPoints, Is.EqualTo(15));
			Assert.That(moveFormModel.Ailment, Is.EqualTo("Burn"));
			Assert.That(moveFormModel.AilmentChance, Is.EqualTo(10));
			Assert.That(moveFormModel.DamageClass, Is.EqualTo(DamageClass.Special));
			Assert.That(moveFormModel.Description, Is.EqualTo("The target is scorched with an intense blast of fire. This may also leave the target with a burn."));
			Assert.That(moveFormModel.Effect, Is.EqualTo(""));
			Assert.That(moveFormModel.EffectChance, Is.EqualTo(0));
			Assert.That(moveFormModel.EffectDuration, Is.EqualTo(0));
			Assert.That(moveFormModel.HealAmount, Is.EqualTo(0));
			Assert.That(moveFormModel.HealType, Is.EqualTo(HealType.NoHeal));
			Assert.That(moveFormModel.IsEffectUser, Is.Null);
			Assert.That(moveFormModel.Priority, Is.EqualTo(0));
		}

		[Test]
		public async Task GetAllMovesServiceModelShouldReturnAllMoves()
		{
			var movesServiceModel = await moveService.GetAllMovesServiceModel();

			Assert.That(movesServiceModel, Is.Not.Null);
			Assert.That(movesServiceModel.Count, Is.EqualTo(4));
			Assert.That(movesServiceModel[0].Name, Is.EqualTo("Flame Thrower"));
			Assert.That(movesServiceModel[0].Power,Is.EqualTo(90));
			Assert.That(movesServiceModel[0].Accuracy, Is.EqualTo(100));
			Assert.That(movesServiceModel[0].PowerPoints, Is.EqualTo(15));
			Assert.That(movesServiceModel[0].Type, Is.EqualTo("Fire"));
			Assert.That(movesServiceModel[0].Description, Is.EqualTo("The target is scorched with an intense blast of fire. This may also leave the target with a burn."));
			Assert.That(movesServiceModel[1].Name, Is.EqualTo("Thunder Punch"));
			Assert.That(movesServiceModel[2].Name, Is.EqualTo("Giga Drain"));
			Assert.That(movesServiceModel[3].Name, Is.EqualTo("Sleep Powder"));
		}
		[Test]
		public async Task GetMoveFormModelAsyncShouldReturnNullIfMoveDoesNotExist()
		{
			var moveFormModel = await moveService.GetMoveFormModelAsync(5);

			Assert.That(moveFormModel, Is.Null);
		}
		[Test]
		public async Task AllMovesSearchShouldWorkCorrectly()
		{
			var moves = await moveService.AllMovesSearch(null,PokemonTypeCustom.Fire,DamageClass.Special);

			Assert.That(moves, Is.Not.Null);
			Assert.That(moves.Moves.Count(), Is.EqualTo(1));
			Assert.That(moves.Moves.First().Name, Is.EqualTo("Flame Thrower"));
			Assert.That(moves.Moves.First().Type, Is.EqualTo("Fire"));			
		}


	}
}
