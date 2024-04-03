using Microsoft.EntityFrameworkCore;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
	public  class Pokemon
	{
		// for now we can make a pokemon factory in the service layer to create a SpecificPokemon object
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public int PokeDexNumber { get; set; }

		public int Level { get; set; } = PokemonLevel;

		[Required]
		public int BaseHP { get; set; }

		[Required]
		[Comment("Effort values for health points set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvHP { get; set; } = 0;

		[Required]
		[Comment("Actual HP")]
		public int HP { get; set; }

        [Required]
		public int BaseAttack { get; set; }

		[Required]
		[Comment("Effort values for attack set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvAttack { get; set; } = 0;

		[Required]
		[Comment("Actual Attack")]
		public int Attack { get; set; }

		[Required]
		public int BaseDefense { get; set; }


		[Required]
		[Comment("Effort values for defence set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvDefence { get; set; } = 0;
		[Required]
		[Comment("Actual Defense")]
		public int Defense { get; set; }

        [Required]
		public int BaseSpecialAttack { get; set; }

		[Required]
		[Comment("Effort values for Speacial Attack set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvSpecialAttack { get; set; } = 0;
		[Required]
		[Comment("Actual Special Attack")]
		public int SpecialAttack { get; set; }

        [Required]
		public int BaseSpecialDefense { get; set; }

		[Required]
		[Comment("Effort values for Speacial Defeense set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvSpecialDefense { get; set; } = 0;

		[Required]
		[Comment("Actual Special Defense")]
		public int SpecialDefense { get; set; }

        [Required]
		public int BaseSpeed { get; set; }

		[Required]
		[Comment("Effort values for Speed set by player upon creation. Starting Value set to 0")]
		[Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
		public int EvSpeed { get; set; } = 0;

		[Required]
		[Comment("Actual Speed")]
		public int Speed { get; set; }

        [NotMapped]
		[Range(0, MaxTotalEvPoints, ErrorMessage = MaxEvStatErrorMessage)]
		public int TotalEvPoints => EvHP + EvAttack + EvDefence + EvSpecialAttack + EvSpecialDefense + EvSpeed;

		[Required]
		[Display(Name = "PrimaryPokemonType")]
		[Comment("The primary type of a pokemon")]
		public string Type1 { get; set; } = null!;

		[Required]
		[Display(Name = "SecondaryPokemonType")]
		[Comment("The secondary type of a pokemon")]
		public string Type2 { get; set; } = null!;

		[Required]
		[Comment("Generation in which Pokemon is introduced")]
		[Range(0, 10)]
		public int GenerationCustom { get; set; }

		[Required]
		public int AbilityId { get; set; }

		[Required]
		[Comment("Passive abuliity chosen by user")]
		[ForeignKey(nameof(AbilityId))]
		public Ability Ability { get; set; } = null!;


		[Required]
		[Comment("Collection of moves used by the pokemon in battle")]
        public List<PokemonMove> PokemonMoves { get; set; } = new List<PokemonMove>();

        [Required]
		[Comment("Team Identifier")]
		public int TeamId { get; set; }

		[Required]
		[ForeignKey(nameof(TeamId))]
		public Team Team { get; set; } = null!;





        //public static async Task<PokemonMyModel> CreatAsync(string name)
        //{
        //	var instance = new PokemonMyModel();

        //	instance.pokeAPiClient = new PokeApiClient();

        //	await instance.GetBaseDataCustom(name.ToLower());

        //	return instance;

        //}

        //public async Task GetBaseDataCustom(string name)
        //{
        //	Pokemon pk = await pokeAPiClient.GetResourceAsync<Pokemon>(name);

        //	Name = pk.Name;

        //	//Base Stat Asignement
        //	List<PokemonStat> stats = pk.Stats;
        //	BaseHP = stats[0].BaseStat;
        //	BaseAttack = stats[1].BaseStat;
        //	BaseDefense = stats[2].BaseStat;
        //	BaseSpecialAttack = stats[3].BaseStat;
        //	BaseSpecialDefense = stats[4].BaseStat;
        //	BaseSpeed = stats[5].BaseStat;
        //	//Generation varaible

        //	string versionName = pk.GameIndicies[0].Version.Url;
        //	char gen = versionName[^2];
        //	GenerationCustom = int.Parse(gen.ToString());

        //	//Types
        //	List<PokemonType> typeList = pk.Types;

        //	string type1 = pk.Types[0].Type.Name;
        //	string type2 = string.Empty;

        //	if (typeList.Count > 1)
        //	{
        //		type2 = typeList[1].Type.Name.ToLower();
        //	}
        //	else
        //	{
        //		type2 = "none";
        //	}
        //	Types.Add(type1);
        //	Types.Add(type2);
        //}





    }
}



