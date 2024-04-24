using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Paging;
using PokemonFinalProjectNet6.Infrastructure.Constants;

namespace PokemonFinalProjectNet6.Core.Models.Move
{
    public class MoveQueryModel : PagingModel
    {
        static MoveQueryModel()
        {
            Types = Enum.GetValues(typeof(PokemonTypeCustom))
                .Cast<PokemonTypeCustom>()
                .ToList();
            DamageClasses = Enum.GetValues(typeof(DamageClass))
                .Cast<DamageClass>()
                .ToList();

        }
        public string SearchTerm { get; set; } 

        public IEnumerable<MoveServiceModel> Moves { get; set; } = new List<MoveServiceModel>();
        
        public MoveSorting Sorting { get; set; }

        public PokemonTypeCustom? TypeFilter { get; set; } 

        public DamageClass? DamageClassFilter { get; set; } 

        public static List<PokemonTypeCustom> Types { get; set; } = new List<PokemonTypeCustom>();

        public static List<DamageClass> DamageClasses { get; set; } =  new List<DamageClass>();

    }
}
