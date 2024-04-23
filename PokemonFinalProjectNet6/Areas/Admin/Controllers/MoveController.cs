using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Controllers;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Constants;

namespace PokemonFinalProjectNet6.Areas.Admin.Controllers
{
	public class MoveController : AdminController
	{
		private readonly IMoveService moveService;
		
		public MoveController(IMoveService _moveService)
		{
			moveService = _moveService;
		}
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Add(MoveFormModel model)
		{
			var manipulatedModel = MoveManipulation(model);

			if (!ModelState.IsValid || manipulatedModel == null)
			{
				return View(model);
			}

			await moveService.CreateAsync(manipulatedModel);

			return RedirectToAction("Index", "Home", new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> Edit(int Id)
		{
			
			if (await moveService.ExistsByIdAsync(Id) == false )
			{
				return BadRequest();
			}
			var model = await moveService.GetMoveFormModelAsync(Id);
			if (model == null)
			{
				return BadRequest();
			}
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> Edit(MoveFormModel model)
		{
			var manipulatedModel = MoveManipulation(model);

			if (!ModelState.IsValid || manipulatedModel == null)
			{
				return View(model);
			}
			await moveService.EditAsync(manipulatedModel);

			return RedirectToAction("Index", "Home", new { area = "Admin" });
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
