using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Infrastructure.Data.SeedDb
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var data = new SeedData();

            builder.HasData(new Team[]
            {
                data.Team1,
                data.Team2,
                data.AdminTean
            });
        }
    }
}
