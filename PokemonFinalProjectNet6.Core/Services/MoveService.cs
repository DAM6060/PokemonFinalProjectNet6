using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
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
