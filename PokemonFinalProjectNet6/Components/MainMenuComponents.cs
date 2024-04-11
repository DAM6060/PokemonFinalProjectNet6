using Microsoft.AspNetCore.Mvc;

namespace PokemonFinalProjectNet6.Components
{
	public class MainMenuComponents : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult<IViewComponentResult>(View());
		}
	}
}
