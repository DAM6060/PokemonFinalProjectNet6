﻿using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Contracts
{
    public interface IPokemonService
    {
        //Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> SpeciesExistsAsync(int pokedexnumber);

        Task<int> CreateAsync(PokemonFormModel model, int playerId, params MoveServiceModel[] moves);

        //Task<HouseQueryServiceModel> AllAsync(
        //    string? category = null,
        //    string? searchTerm = null,
        //    HouseSorting sorting = HouseSorting.Newest,
        //    int currentPage = 1,
        //    int housesPerPage = 1);

        Task<IEnumerable<string>> AllSpeciesNamesAsync();

        Task<IEnumerable<PokemonFormModel>> AllPokemonByPlayerIdAsync(int playerId);

        Task<IEnumerable<PokemonFormModel>> AllPokemonByUserId(string userId);

        Task<bool> ExistsAsync(int id);

        Task<PokemonServiceModel> PokemonDetailsByIdAsync(int id);

        Task EditAsync(int pokemonId, PokemonFormModel model);

        Task<bool> HasPlayerWithIdAsync(int pokemonId, string playerId);

        Task<PokemonFormModel?> GetPokemonFormModelByIdAsync(int id);

        Task<Pokemon> GetPokemonByIdAsync(int id);

        Task DeleteAsync(int pokemonId);
    }
}
