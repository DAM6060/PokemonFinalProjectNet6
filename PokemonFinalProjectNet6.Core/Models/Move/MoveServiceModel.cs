using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Core.Models.Move
{
    public class MoveServiceModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; 


    }
}
