using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class Lobby
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LobbyName { get; set; } = null!;

        public List<Player> Players{ get; set; } = new List<Player>();

        public List<LobbyMessage> Messages { get; set; } = new List<LobbyMessage>();

    }
}
