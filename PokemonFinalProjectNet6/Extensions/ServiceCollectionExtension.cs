using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Services;
using PokemonFinalProjectNet6.Data;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PLayerService>();
            services.AddScoped<IPokemonService, PokemonService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IAbilityService, AbilityService>();
            services.AddScoped<IMoveService, MoveService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<PokemonDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<PokemonDbContext>();

            return services;
        }
    }
}
