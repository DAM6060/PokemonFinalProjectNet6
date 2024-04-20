using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Core.Models.Move
{
    public class MoveServiceModel
    {
        public int Id { get; set; }

        
        public string Name { get; set; } = string.Empty;

       
        public string Description { get; set; } = string.Empty;

        
        public int Power { get; set; }

        
        public int Accuracy { get; set; }

        
        public int PowerPoints { get; set; }

        
        public string Type { get; set; } = string.Empty;


    }
}
