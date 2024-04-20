namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface ILobbyService
    {
        Task<int> JoinLobby(int Team1Id , int playerId);

    }
}
