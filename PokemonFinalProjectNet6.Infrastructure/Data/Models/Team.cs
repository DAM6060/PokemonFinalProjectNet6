using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		[MaxLength(TeamNameMaxLength, ErrorMessage = TeamNameMaxLengthErrorMessage)]
		public string Name { get; set; } = string.Empty;

		
		[Comment("Collection of teams's pokemons")]
		public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        [Required]
        [Comment("User Identifier")]
        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;

		[Required]
		[Comment("Number of Wins")]
		public int Wins { get; set; } = 0;

		[Required]
        [Comment("Number of Losses")]
        public int Losses { get; set; } = 0;

		public int? LobbyId { get; set; }
		[ForeignKey(nameof(LobbyId))]
		public Lobby? Lobby { get; set; }
		
    }

}
