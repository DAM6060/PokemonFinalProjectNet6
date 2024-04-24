using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class Lobby
    {
        [Key]
        public int Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
