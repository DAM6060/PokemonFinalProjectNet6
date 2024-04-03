using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb
{
    public class AbilityConfiguration : IEntityTypeConfiguration<Ability>
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            var data= new SeedData();

            builder.HasData(new Ability[] { data.IronFist , data.Adaptability, data.Chlorophyll, data.Technichian });
        }
    }
}
