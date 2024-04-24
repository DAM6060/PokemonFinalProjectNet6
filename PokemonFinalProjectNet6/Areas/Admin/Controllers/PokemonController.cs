using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Pokemon;

namespace PokemonFinalProjectNet6.Areas.Admin.Controllers
{
	public class PokemonController : AdminController
	{
		private readonly IPokemonService pokemonService;

		public PokemonController(IPokemonService _pokemonService)
		{
			pokemonService = _pokemonService;
		}

		[HttpGet]
		public IActionResult AddSpecies()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddSpecies(PokemonSpeciesFormModel model)
		{
			
			if (ModelState.IsValid == false || model.Type1==model.Type2)
			{
				return View(model);
			}
			await pokemonService.CreateSpeciesAsync(model);
			return RedirectToAction("Index", "Home");
		}
		[HttpGet]
		public async Task<IActionResult> ChooseSpeciesToEdit()
		{
			var model = await pokemonService.AllSpeciesNamesAsync();
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> ChooseSpeciesToEdit(string name)
		{
			if (await pokemonService.SpeciesExistsAsync(name)== false)
			{
				return BadRequest();
			}
			return RedirectToAction(nameof(EditSpecies), name);
		}
		[HttpGet]
		public async Task<IActionResult> EditSpecies(string name)
		{
			var model = await pokemonService.GetPokemonSpeciesFormModelAsync(name);

			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> EditSpecies(PokemonSpeciesFormModel model)
		{

			if (ModelState.IsValid == false || model.Type1 == model.Type2)
			{
				return View(model);
			}
			await pokemonService.EditSpecies(model);
			return RedirectToAction("Index", "Home");
		}



	}
}
