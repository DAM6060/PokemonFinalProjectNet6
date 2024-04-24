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

			if (!ModelState.IsValid || model == null)
			{
				return View(model);
			}

			await moveService.CreateAsync(model);

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
			if (!ModelState.IsValid || model == null)
			{
				return View(model);
			}
			await moveService.EditAsync(model);

			return RedirectToAction("Index", "Home", new { area = "Admin" });
		}

		


	}
}
