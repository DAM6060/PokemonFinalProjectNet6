using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;

namespace PokemonFinalProjectNet6.Infrastructure.Data.SeedDb
{
	public class MoveConfiguration : IEntityTypeConfiguration<Move>
    {
        public void Configure(EntityTypeBuilder<Move> builder)
        {
            var data = new SeedData();

            builder.HasData(new Move[]
            {
                data.SolarBeam,
                data.SludgeBomb,
                data.SleepPowder,
                data.SuperPower,
                data.FlameThrower,
                data.ThunderPunch,
                data.GigaDrain,
                data.BrickBreak,
                data.WingAttack,
                data.BugBite,
                data.CloseCombat,
                data.EarthPower,
                data.FirePunch,
                data.UTurn,
                data.IceBeam,
                data.RockSlide,
                data.Crunch,
                data.BulletPunch,
                data.Reflect,
                data.LeechSeed,
                data.Earthquake

            });
        }
    }
}