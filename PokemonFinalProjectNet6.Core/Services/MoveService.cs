using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class MoveService : IMoveService
    {
        private readonly IRepository repository;

        public MoveService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<MoveQueryModel> AllMovesSearch(
                                string? searchTerm = null,
                                PokemonTypeCustom? typeFilter = null,
                                DamageClass? damageClassFilter = null,
                                MoveSorting sorting = MoveSorting.Alphabetical,
                                int currentPage = 1, int itemsPerPage = 10)
        {
            var movesToShow = repository.AllAsReadOnly<Move>();
            
            if(typeFilter != null)
            {
                movesToShow = movesToShow
                    .Where(x => x.Type == typeFilter.ToString());
            }
            if (damageClassFilter != null)
            {
                movesToShow = movesToShow
                    .Where(x => x.DamageClass == damageClassFilter);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                movesToShow = movesToShow
                    .Where(x => x.Name.Contains(searchTerm));
            }
            
            movesToShow = sorting switch
            { 
                MoveSorting.HighestPower => movesToShow.OrderByDescending(x => x.Power),
                _ => movesToShow.OrderBy(x => x.Name)
            };

            var totalMoves = movesToShow.Count();

            var moves =  await movesToShow
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(m => new MoveServiceModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Power = m.Power,
                    Accuracy = m.Accuracy,
                    PowerPoints = m.PowerPoints,
                    Type = m.Type,
                    Description = m.Description
                })
                .ToListAsync();

            return new MoveQueryModel
            {
                ItemsPerPage = itemsPerPage,
                CurrentPage = currentPage,
                TotalItemsCount = totalMoves,
                Moves = moves
            };
        }

        public Task<List<MoveServiceModel>> GetAllMovesServiceModel()
        {
            return repository.AllAsReadOnly<Move>()
                .Select(m => new MoveServiceModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Power = m.Power,
                    Accuracy = m.Accuracy,
                    PowerPoints = m.PowerPoints,
                    Type = m.Type,
                    Description = m.Description
                })
                .ToListAsync(); 
        }

        public async Task<MoveServiceModel> MoveByIdAsync(int id)
        {
            return await repository.AllAsReadOnly<MoveServiceModel>()
                .Where(m => m.Id == id)
                .Select(m => new MoveServiceModel
                {
                    Id = m.Id,
                    Name = m.Name,                   
                })
                .FirstOrDefaultAsync();
        }
    }
}
