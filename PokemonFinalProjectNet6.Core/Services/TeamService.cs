﻿using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Core.Models.Team;
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
			var team = repository.All<Team>().
                Where(t => t.Id == teamId).
                Select(t => new Team
                {
                    Id = t.Id,
                    Name = t.Name,
                    PlayerId = t.PlayerId,
                    Pokemons = t.Pokemons
                }).FirstOrDefault();

            foreach (var pokemon in team.Pokemons)
            {
                await pokemonService.DeleteAsync(pokemon.Id);
            }
            await repository.DeleteAsync<Team>(teamId);
            await repository.SaveChangesAsync();
		}

		public Task<bool> ExistsById(int teamId)
		{
            return repository.AllAsReadOnly<Team>().AnyAsync(t => t.Id == teamId);
		}		

		public async Task<TeamViewModel?> GetTeamDetailsAsync(int id)
		{
            return await repository.AllAsReadOnly<Team>()
                    .Where(t => t.Id == id)
                    .Select(t => new TeamViewModel()
                    {
                        Id = t.Id,
                        Name = t.Name,
                        PlayerId = t.PlayerId,
                        Pokemons = t.Pokemons.Select(p => new PokemonViewModel
                        {
                            Id = p.Id,
                            Name = p.Name,
                            
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
                            Ability = new AbilityServiceModel
                            {
                                Id = p.AbilityId,
                                Name = p.Ability.Name
                            },
                            Moves = p.PokemonMoves.Select(pm => new MoveServiceModel
                            {
                                Id = pm.MoveId,
                                Name = pm.Move.Name
                            }).ToList()
                        }).ToList()
                    }).FirstOrDefaultAsync();
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
		

		public async Task<bool> PlayerHasTeamAsync(int teamId, int playerId)
		{
            return await repository.AllAsReadOnly<Team>().AnyAsync(t => t.Id == teamId && t.PlayerId == playerId);
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
