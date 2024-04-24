using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    
    public class Player 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<Team> Teams { get; set; } = new List<Team>();

        public List<Pokemon> Pokemon { get; set; } = new List<Pokemon>();

       
       
    }
}
