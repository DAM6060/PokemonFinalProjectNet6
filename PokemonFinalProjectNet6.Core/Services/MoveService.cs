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

		public async Task<int> CreateAsync(MoveFormModel model)
		{
			var manipulatedModel = MoveManipulation(model);
			Move move = new Move
            {
				Name = manipulatedModel.Name,
				Description = manipulatedModel.Description,
				Type = manipulatedModel.Type.ToString(),
				Power = manipulatedModel.Power,
				PowerPoints = manipulatedModel.PowerPoints,
				Accuracy = manipulatedModel.Accuracy,
				EffectChance = manipulatedModel.EffectChance,
				Effect = manipulatedModel.Effect,
				IsEffectUser = string.IsNullOrWhiteSpace(manipulatedModel.Effect)? null : manipulatedModel.IsEffectUser,
				EffectDuration = manipulatedModel.EffectDuration,
				Ailment = string.IsNullOrWhiteSpace(manipulatedModel.Ailment) ? "" : manipulatedModel.Ailment,
				AilmentChance = string.IsNullOrWhiteSpace(manipulatedModel.Ailment) ? 0 : manipulatedModel.AilmentChance,
				DamageClass = manipulatedModel.DamageClass,			
				HealAmount = manipulatedModel.HealAmount,
				HealType = manipulatedModel.HealAmount == 0 ? 0 : manipulatedModel.HealType,
				Priority = manipulatedModel.Priority
			};
            await repository.AddAsync(move);
            await repository.SaveChangesAsync();

            return move.Id;
		}

		public async Task EditAsync(MoveFormModel model)
		{
            var manipulatedModel = MoveManipulation(model);
			var move = await repository.All<Move>()
				.Where(m => m.Name == model.Name)
				.FirstOrDefaultAsync();
            if (move!= null)
            {
                move.Name = manipulatedModel.Name;
                move.Description = manipulatedModel.Description;
                move.Type = manipulatedModel.Type.ToString();
                move.Power = manipulatedModel.Power;
                move.PowerPoints = manipulatedModel.PowerPoints;
                move.Accuracy = manipulatedModel.Accuracy;
                move.EffectChance = manipulatedModel.EffectChance;
                move.Effect = manipulatedModel.Effect;
                move.IsEffectUser = string.IsNullOrWhiteSpace(manipulatedModel.Effect) ? null : manipulatedModel.IsEffectUser;
                move.EffectDuration = manipulatedModel.EffectDuration;
                move.Ailment = string.IsNullOrWhiteSpace(manipulatedModel.Ailment) ? "" : manipulatedModel.Ailment;
                move.AilmentChance = string.IsNullOrWhiteSpace(manipulatedModel.Ailment) ? 0 : manipulatedModel.AilmentChance;
                move.DamageClass = manipulatedModel.DamageClass;
                move.HealAmount = manipulatedModel.HealAmount;
                move.HealType = manipulatedModel.HealAmount == 0 ? 0 : manipulatedModel.HealType;
                move.Priority = manipulatedModel.Priority;
                await repository.SaveChangesAsync();
            }
		}

		public async Task<bool> ExistsByIdAsync(int id)
		{
			return await repository.AllAsReadOnly<Move>()
				.AnyAsync(m => m.Id == id);
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

		public async Task<MoveFormModel> GetMoveFormModelAsync(int moveId)
		{
			return await repository.AllAsReadOnly<Move>()
				.Where(m => m.Id == moveId)
				.Select(m => new MoveFormModel
                {
					Name = m.Name,
					Description = m.Description,
					Type = Enum.Parse<PokemonTypeCustom>(m.Type),
					Power = m.Power,
					PowerPoints = m.PowerPoints,
					Accuracy = m.Accuracy,
					EffectChance = m.EffectChance,
					Effect = m.Effect,
					IsEffectUser = m.IsEffectUser,
					EffectDuration = m.EffectDuration,
					Ailment = m.Ailment,
					AilmentChance = m.AilmentChance,
					DamageClass = m.DamageClass,
					HealAmount = m.HealAmount,
					HealType = m.HealType,
					Priority = m.Priority
				})
				.FirstOrDefaultAsync();
		}
		private MoveFormModel MoveManipulation(MoveFormModel model)
		{
			if (model.Effect.ToLower() == "none")
			{
				model.Effect = "";
				model.EffectChance = 0;
				model.EffectDuration = 0;
			}
			if (model.Ailment.ToLower() == "none")
			{
				model.Ailment = "";
				model.AilmentChance = 0;

			}
			if (model.isEffectUserString == "Not applicable")
			{
				model.IsEffectUser = null;
			}
			else
			{
				model.IsEffectUser = model.isEffectUserString == "Yes";
			}
			return model;
		}
	}
}
