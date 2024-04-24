using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Infrastructure.Data.SeedDb
{
	public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            var data = new SeedData();

            builder.HasData(new Player[]
            {
                data.Player1,
                data.Player2
            });
        }
    }
}
