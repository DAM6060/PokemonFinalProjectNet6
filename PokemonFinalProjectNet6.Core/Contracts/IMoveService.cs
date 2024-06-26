﻿using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Constants;

namespace PokemonFinalProjectNet6.Core.Contracts
{
	public interface IMoveService
    {
        Task<List<MoveServiceModel>> GetAllMovesServiceModel();

        Task<MoveQueryModel> AllMovesSearch(
            string? searchTerm = null,
            PokemonTypeCustom? typeFilter = null,
            DamageClass? damageClassFilter = null,
            MoveSorting sorting = MoveSorting.Alphabetical,
            int currentPage = 1,
            int teamsPerPage = 10);
        
        Task<int> CreateAsync(MoveFormModel model);
		Task<MoveFormModel> GetMoveFormModelAsync(int moveId);

        Task<bool> ExistsByIdAsync(int id);
		Task EditAsync(MoveFormModel model);
	}
}
