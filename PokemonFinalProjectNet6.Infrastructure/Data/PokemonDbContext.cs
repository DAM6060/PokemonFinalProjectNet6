using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb;

namespace PokemonFinalProjectNet6.Data
{
    public class PokemonDbContext : IdentityDbContext
    {
        public PokemonDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PokemonMove>()
        .HasKey(pm => new { pm.PokemonId, pm.MoveId });


            builder.Entity<PokemonMove>()
         .HasOne(pm => pm.Pokemon)
         .WithMany(p => p.PokemonMoves)
         .HasForeignKey(pm => pm.PokemonId);

            builder.Entity<PokemonMove>()
                .HasOne(pm => pm.Move)
                .WithMany(m => m.PokemonMoves)
                .HasForeignKey(pm => pm.MoveId);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new AbilityConfiguration());
            builder.ApplyConfiguration(new MoveConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new PokemonConfiguration());
            builder.ApplyConfiguration(new PokemonMoveConifguration());




            base.OnModelCreating(builder);
        }

        public DbSet<Ability> Abilities { get; set; } = null!;
        public DbSet<Pokemon> Pokemons { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Sudoko> Sudokos { get; set; } = null!;
        public DbSet<Move> Moves { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<PokemonMove> PokemonsMoves { get; set; } = null!;
    }
}
