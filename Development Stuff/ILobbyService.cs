using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Core.Contracts
{
	public interface ILobbyService
    {
        Task<int> JoinLobbyAsync(int teamId, int playerId);

        Task<int> CreateAsync(Team team1, Player player1);

        Task EditAsync(int id, Team team2, Player player2);

        Task<LobbyServiceModel> GetLobbyByIdAsync(int lobbyId);

		Task<LobbyServiceModel> GetLobbyByConnectionIdAsync(string connectionId);
	}
}
