using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class LobbyService : ILobbyService
    {
        private readonly IRepository repository;
        private readonly IPlayerService playerService;

        public LobbyService(IRepository _repository,
                            IPlayerService _playerService)
        {
            repository = _repository;
            playerService = _playerService;

        }
        public async Task<int> CreateLobbyAsync(string lobbyName, int playerId)
        {
            var lobby = new Lobby
            {
                LobbyName = lobbyName
            };

            var player = await playerService.GetPlayerByIdAsync(playerId) ?? throw new InvalidOperationException("Player not found");

            lobby.Players.Add(player);

            await repository.AddAsync(lobby);
            await repository.SaveChangesAsync();

            return lobby.Id;

        }

        public async Task DeleteLobbyAsync(int lobbyId)
        {
            await repository.DeleteAsync<Lobby>(lobbyId);
            await repository.SaveChangesAsync();
        }

        public async Task<int> GetLobbyIdByPlayerIdAsync(int playerId)
        {
            return await repository.AllAsReadOnly<Lobby>()
                .Where(l => l.Players.Any(p => p.Id == playerId))
                .Select(l => l.Id)
                .FirstOrDefaultAsync();
        }
    }
}
