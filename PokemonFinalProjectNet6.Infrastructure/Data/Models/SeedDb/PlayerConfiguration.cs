using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            var data = new SeedData();

            builder.HasData( new Player[] { data.Player1, data.Player2});
        }
    }
}
