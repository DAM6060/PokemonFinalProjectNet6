using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Constants;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IMoveService
    {
        Task<MoveServiceModel> MoveByIdAsync(int id);

        Task<List<MoveServiceModel>> GetAllMovesServiceModel();

        Task<MoveQueryModel> AllMovesSearch(
            string? searchTerm = null,
            PokemonTypeCustom? typeFilter = null,
            DamageClass? damageClassFilter = null,
            MoveSorting sorting = MoveSorting.Alphabetical,
            int currentPage = 1,
            int teamsPerPage = 10);

        
    }
}
