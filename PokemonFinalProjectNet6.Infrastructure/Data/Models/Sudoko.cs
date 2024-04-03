using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class Sudoko
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Row1 { get; set; } = string.Empty;

        [Required]
        public string Row2 { get; set; } = string.Empty;

        [Required]
        public string Row3 { get; set; } = string.Empty;

        [Required]
        public string Column1 { get; set; } = string.Empty;

        [Required]
        public string Column2 { get; set; } = string.Empty;

        [Required]
        public string Column3 { get; set; } = string.Empty;

        [Required]
        public string Row1xColumn1 { get; set; } = string.Empty;

        [Required]
        public string Row1xColumn2 { get; set; } = string.Empty;

        [Required]
        public string Row1xColumn3 { get; set; } = string.Empty;

        [Required]
        public string Row2xColumn1 { get; set; } = string.Empty;

        [Required]
        public string Row2xColumn2 { get; set; } = string.Empty;

        [Required]
        public string Row2xColumn3 { get; set; } = string.Empty;

        [Required]
        public string Row3xColumn1 { get; set; } = string.Empty;

        [Required]
        public string Row3xColumn2 { get; set; } = string.Empty;

        [Required]
        public string Row3xColumn3 { get; set; } = string.Empty;

        //[Comment("List of players that have completed the sudoko")]
        //public List<Player> PlayersThatHaveCompleted { get; set; } = new List<Player>();
    }
}
