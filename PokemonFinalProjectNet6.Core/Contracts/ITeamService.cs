﻿using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Core.Contracts
{
	public interface ITeamService
    {
        Task<int> CreateAsync(TeamFormModel model);

        Task<TeamLeaderBoardQueryModel> TeamLeaderBoardAsync(
            string? pokemonFiltering = null,
            TeamSorting sorting=TeamSorting.MostWins,
            int currentPage=1,
            int teamsPerPage=10);

        Task<IEnumerable<TeamServiceModel>> GetTeamsByPlayerIdAsync(int playerId);

		Task DeleteAsync(int teamId);

        Task<TeamViewModel?> GetTeamDetailsAsync(int teamId);

        Task<bool> ExistsById(int teamId);

        Task<bool> PlayerHasTeamAsync(int teamId, int playerId);

        



	}
}
