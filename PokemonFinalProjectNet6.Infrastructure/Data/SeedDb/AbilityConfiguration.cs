using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Infrastructure.Data.SeedDb
{
	public class AbilityConfiguration : IEntityTypeConfiguration<Ability>
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            var data = new SeedData();

            builder.HasData(new Ability[] { data.IronFist, data.Adaptability, data.Chlorophyll, data.Technichian });
        }
    }
}
