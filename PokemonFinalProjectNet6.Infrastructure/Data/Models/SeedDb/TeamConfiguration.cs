using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var data = new SeedData();

            builder.HasData(new Team[]
            {
                data.Team1,
                data.Team2
            });
        }
    }
}
