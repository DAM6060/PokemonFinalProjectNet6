using System.Security.Claims;
namespace PokemonFinalProjectNet6.Extension
{
    public static class ClaimPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);


    }
}
