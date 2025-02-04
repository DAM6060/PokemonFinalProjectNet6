using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface ILobbyService
    {
        // Create a new lobby
        Task<int> CreateLobbyAsync(string lobbyName, int playerId);

        //Get By PlayerId
        Task<int> GetLobbyIdByPlayerIdAsync(int playerId);

        //Delete Lobby
        Task DeleteLobbyAsync(int lobbyId);
    }
}
