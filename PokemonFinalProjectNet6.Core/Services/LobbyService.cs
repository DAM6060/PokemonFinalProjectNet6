using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Core.Models.Team;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Services
{
	public class LobbyService : ILobbyService
	{
		private readonly IRepository repository;
		private readonly IBattleService battleService;
		private readonly IPlayerService playerService;
		private readonly ITeamService teamService;


		public LobbyService(
			IBattleService _battleService,
			IRepository _repository)
		{
			battleService = _battleService;
			repository = _repository;

		}

		public async Task<int> JoinLobbyAsync(int teamId, int playerId)
		{
			var lobby = await repository.All<Lobby>()
				.Where(l => l.Players.Count == 1)
				.Select(l => new Lobby
				{
					Id = l.Id,
					Players = l.Players,
					Teams = l.Teams
				}).FirstOrDefaultAsync();

			var player = await playerService.GetPlayerByPlayerIdAsync(playerId);
			var team = await teamService.GetTeamByTeamIdAsync(teamId);

			if (lobby == null)
			{
				lobby.Id =await CreateAsync(team, player);				
			}
			else
			{
				await EditAsync(lobby.Id,team, player);
				await repository.SaveChangesAsync();
			}
			return lobby.Id;

		}
		private async Task<bool> ExistsLobbyWithOnePlayer()
		{
			return await Task.FromResult(true);
		}

		public Task<bool> StartBattle()
		{
			throw new NotImplementedException();
		}

		public async Task<int> CreateAsync(Team team1, Player player1)
		{
			Lobby lobby = new Lobby()
			{
				Teams = new List<Team> { team1 },
				Players = new List<Player> { player1 },
				
			};
			await repository.AddAsync(lobby);
			await repository.SaveChangesAsync();
			return lobby.Id;
		}
		public async Task EditAsync(int id, Team team2 , Player player2)
		{
			var lobby = repository.All<Lobby>()
				.Where(l => l.Id == id)
				.Select(l => new Lobby
				{
					Id = l.Id,
					Players = l.Players,
					Teams = l.Teams
				}).FirstOrDefault();

			if (lobby!= null)
			{
				lobby.Teams.Add(team2);
				lobby.Players.Add(player2);
				await repository.SaveChangesAsync();
			}
				
		}

		public async Task<LobbyServiceModel> GetLobbyByIdAsync(int lobbyId)
		{
			return await repository.AllAsReadOnly<Lobby>().Include(l => l.Teams)
				.Where(l => l.Id == lobbyId)
				.Select(l => new LobbyServiceModel
				{
					Id = l.Id,
					Players = l.Players.Select(p => new PlayerServiceModel
					{
						Id = p.Id,
						Name = p.Name,						
					}).ToList(),
					Teams = l.Teams.Select(t => new BattleTeamServiceModel
					{
						Id =t.Id,
						Name = t.Name,
						Pokemons = t.Pokemons.Select(p => new BattlePokemonServiceModel
						{
							Id = p.Id,
							Name = p.Name,
							Level = p.Level,
							Health = p.HP,
							Attack = p.Attack,
							Defense = p.Defense,
							Speed = p.Speed,
							SpecialAttack = p.SpecialAttack,
							SpecialDefense = p.SpecialDefense,
							Type1 = p.Type1,
							Type2 = p.Type2,
							Ability = new BattleAbilityServiceModel
							{
								Id = p.Ability.Id,
								Name = p.Ability.Name,
								Description = p.Ability.Description
							},
							Moves = p.PokemonMoves.Select(m => new BattleMoveServiceModel
							{
								Id = m.PokemonId,
								Name = m.Move.Name,
								Power = m.Move.Power,
								Accuracy = m.Move.Accuracy,
								PP = m.Move.PowerPoints,
								Type = (PokemonTypeCustom)Enum.Parse(typeof(PokemonTypeCustom), m.Move.Type),
								EffectChance = m.Move.EffectChance,
								Effect = m.Move.Effect,
								EffectDuration = m.Move.EffectDuration,
								Ailment = m.Move.Ailment,
								AilmentChance = m.Move.AilmentChance,
								DamageClass =  m.Move.DamageClass,
								IsEffectUser = m.Move.IsEffectUser,
								isHealMove = m.Move.HealAmount != 0,
								HealAmount = m.Move.HealAmount,
								HealType = m.Move.HealType,
								Priority = m.Move.Priority
							}).ToList()
						}).ToList()
					}).ToList()
				
				}).FirstAsync();
		}
	}

	
}

