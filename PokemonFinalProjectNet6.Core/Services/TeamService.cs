using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repository;
        private readonly IPokemonService pokemonService;
       

        public TeamService(
            IRepository _repository, 
            IPokemonService _pokemonService)
        {
            repository = _repository;
            pokemonService = _pokemonService;
            
        }
        public async Task<int> CreateAsync(TeamFormModel model)
        {
			var team = new Team
			{
				Name = model.Name,
				PlayerId = model.PlayerId
			};
            await repository.AddAsync(team);
			await repository.SaveChangesAsync();

			List<Pokemon> pokemonsToAdd = new List<Pokemon>();

            List<PokemonFormModel> Pokemons = new List<PokemonFormModel>();
            Pokemons.Add(model.PokemonForDB1);
            Pokemons.Add(model.PokemonForDB2);
            Pokemons.Add(model.PokemonForDB3);
            

            foreach (var pokemon in Pokemons)
            {
                var pokemonId = await pokemonService.CreateAsync(pokemon , model.PlayerId, team.Id);              

                if (await pokemonService.ExistsAsync(pokemonId) == true)
                {
                    pokemonsToAdd.Add(await pokemonService.GetPokemonByIdAsync(pokemonId));
                } 
            }
            team.Pokemons = pokemonsToAdd;
			await repository.SaveChangesAsync();

			return team.Id;
        }

		public async Task DeleteAsync(int teamId)
		{
			var team = repository.All<Team>().FirstOrDefault(t => t.Id == teamId);

            foreach (var pokemon in team.Pokemons)
            {
                await pokemonService.DeleteAsync(pokemon.Id);
            }
            await repository.DeleteAsync<Team>(teamId);
            await repository.SaveChangesAsync();
		}

		public async Task<BattleTeamServiceModel> GetBattleTeamServiceByIdAsync(int teamId)
		{
			return await repository.AllAsReadOnly<Team>()
				.Where(t => t.Id == teamId)
				.Select(t => new BattleTeamServiceModel
                {
					Id = t.Id,
					Name = t.Name,
					PlayerId = t.PlayerId,
					Pokemons = t.Pokemons.Select(p => new BattlePokemonServiceModel
                    {
						Id = p.Id,
						Name = p.Name,
                        Level = p.Level,
						Health = p.HP,
						Attack = p.Attack,
						Defense = p.Defense,
						SpecialAttack = p.SpecialAttack,
						SpecialDefense = p.SpecialDefense,
						Speed = p.Speed,
						Moves = p.PokemonMoves.Select(pm => new BattleMoveServiceModel
                        {
							Id = pm.MoveId,
							Name = pm.Move.Name,
							Power = pm.Move.Power,
							Accuracy = pm.Move.Accuracy,
							PP = pm.Move.PowerPoints,
							Type = (PokemonTypeCustom)Enum.Parse(typeof(PokemonTypeCustom), pm.Move.Type),
                            EffectChance = pm.Move.EffectChance,
                            Effect = pm.Move.Effect,
                            EffectDuration = pm.Move.EffectDuration,
                            Ailment = pm.Move.Ailment,
                            AilmentChance = pm.Move.AilmentChance,
                            DamageClass = pm.Move.DamageClass,
                            IsEffectUser = pm.Move.IsEffectUser,
                            HealAmount = pm.Move.HealAmount,
                            HealType = pm.Move.HealType,
                            Priority = pm.Move.Priority
                        }).ToList(),
                        Ability = new BattleAbilityServiceModel
                        {
							Id = p.AbilityId,
							Name = p.Ability.Name,
							PhaseOfCombatAbilityActivation = p.Ability.PhaseOfCombatActivaton,
                            Description = p.Ability.Description
						},
                        Type1 = p.Type1,
                        Type2 = p.Type2,
                        IsFainted = false
					}).ToList()
				}).FirstAsync();
		}

		public async Task<IEnumerable<TeamServiceModel>> GetTeamsByPlayerIdAsync(int playerId)
		{
			return await repository.AllAsReadOnly<Team>()
				.Where(t => t.PlayerId == playerId)
				.Select(t => new TeamServiceModel
                {
					Id = t.Id,
					Name = t.Name,
					PlayerId = t.PlayerId,
					Pokemons = t.Pokemons.Select(p => p.Name).ToList(),
					Wins = t.Wins,
					Losses = t.Losses
				}).ToListAsync();
		}

		public async Task<IEnumerable<TeamServiceModel>> GetTeamsByPlayerIdForBattleAsync(int playerId)
		{
			return await repository.AllAsReadOnly<Team>()
				.Where(t => t.PlayerId == playerId)
				.Select(t => new TeamServiceModel
                {
					Id = t.Id,
					Name = t.Name,
					PlayerId = t.PlayerId,
					Pokemons = t.Pokemons.Select(p => p.Name).ToList(),
				}).ToListAsync();
		}

		public async Task<TeamLeaderBoardQueryModel> TeamLeaderBoardAsync(
            string? pokemonFiltering = null,
            TeamSorting sorting = TeamSorting.MostWins,
            int currentPage = 1,
            int itemsPerPage = 10)
        {
            var teamsToShow = repository.AllAsReadOnly<Team>();

            if (!string.IsNullOrWhiteSpace(pokemonFiltering))
            {
                teamsToShow = teamsToShow
                    .Where(x => x.Pokemons.Any(p => p.Name == pokemonFiltering));
            }

            teamsToShow = sorting switch
            {
                TeamSorting.Newest => teamsToShow.OrderByDescending(x => x.Id),
                TeamSorting.Oldest => teamsToShow.OrderBy(x => x.Id),
                TeamSorting.MostGamesPlayed => teamsToShow.OrderByDescending(x => x.Wins + x.Losses),
                TeamSorting.BiggestPostiveDifferential => teamsToShow.OrderByDescending(x => x.Wins - x.Losses),
                TeamSorting.BiggestNegativeDifferential => teamsToShow.OrderBy(x => x.Losses - x.Wins),
                _ => teamsToShow.OrderByDescending(x => x.Wins)
            };

            var teams = await teamsToShow
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(x => new TeamServiceModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    PlayerId = x.PlayerId,
                    Pokemons = x.Pokemons.Select(p => p.Name).ToList(),
                    Wins = x.Wins,
                    Losses = x.Losses
                })
                .ToListAsync();

            int totalTeamsCount = await teamsToShow.CountAsync();

            return new TeamLeaderBoardQueryModel
            {
                ItemsPerPage = itemsPerPage,
                CurrentPage = currentPage,
                TotalItemsCount = totalTeamsCount,
                Sorting = sorting,
                Teams = teams
            };
        }
    }
}
