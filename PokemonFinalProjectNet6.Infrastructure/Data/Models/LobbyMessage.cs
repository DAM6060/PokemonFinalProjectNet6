using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class LobbyMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = null!;

        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int LobbyId { get; set; }

        [Required]
        [ForeignKey(nameof(LobbyId))]
        public Lobby Lobby { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; } 
    }
}
