using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Core.Models.Move
{
    public class MoveServiceModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Power { get; set; }

        [Required]
        public int Accuracy { get; set; }

        [Required]
        public int PowerPoints { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty;


    }
}
