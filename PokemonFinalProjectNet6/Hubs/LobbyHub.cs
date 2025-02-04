using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using PokemonFinalProjectNet6.Attributes;

namespace PokemonFinalProjectNet6.Hubs
{
    [Authorize]
    [MustBePlayer]
    public class LobbyHub : Hub
    {
        // Key:RoomName  value:List<playerIds>
        private static readonly Dictionary<string, List<string>> Rooms = new();

        public async Task JoinRoom(string roomName)
        {
            if (!Rooms.ContainsKey(roomName))
            {
                Rooms[roomName] = new List<string>();
            }

            if (Rooms[roomName].Count < 2)
            { 
                Rooms[roomName].Add(Context.ConnectionId);
                await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
                await Clients.Caller.SendAsync("JoinedRoom", roomName);
            }
            else
            {
                await Clients.Caller.SendAsync("RoomFull", roomName);
            }
        }

        public async Task SendMessage(string roomName, string user, string message)
        {
            await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
        }
    }
}
