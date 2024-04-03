using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb
{
    public class PokemonMoveConifguration : IEntityTypeConfiguration<PokemonMove>
    {
        public void Configure(EntityTypeBuilder<PokemonMove> builder)
        {
            var data = new SeedData();


            builder.HasData(new PokemonMove[] 
            { 
                data.PokemonsMoves[1],
                data.PokemonsMoves[2],
                data.PokemonsMoves[3],
                data.PokemonsMoves[4],
                data.PokemonsMoves[0],
                data.PokemonsMoves[5],
                data.PokemonsMoves[6],
                data.PokemonsMoves[7],
                data.PokemonsMoves[8],
                data.PokemonsMoves[9],
                data.PokemonsMoves[10],
                data.PokemonsMoves[11],
                data.PokemonsMoves[12],
                data.PokemonsMoves[13],
                data.PokemonsMoves[14],
                data.PokemonsMoves[15],
                data.PokemonsMoves[16],
                data.PokemonsMoves[17],
                data.PokemonsMoves[18],
                data.PokemonsMoves[19],
                data.PokemonsMoves[20],
                data.PokemonsMoves[21],
                data.PokemonsMoves[22],
                data.PokemonsMoves[23],

            });
        }
    }
}
