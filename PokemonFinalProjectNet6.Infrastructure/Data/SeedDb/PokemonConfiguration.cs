using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Infrastructure.Data.SeedDb
{
	public class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            var data = new SeedData();

            builder.HasData(new Pokemon[]
            {
               data.Venausor1,
               data.Venausor2,
               data.Infernoape1,
               data.Infernoape2,
               data.Scizor,
               data.Tyranitar
            });
        }
    }
}
