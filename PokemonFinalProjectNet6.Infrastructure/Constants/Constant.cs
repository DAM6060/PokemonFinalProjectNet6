using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Infrastructure.Constants
{
	public static class Constant
	{
		public const string levelErrorMessage = "The {0} must be between 0 and 100";

		public const string RequiredErrorMessage = "The {0} field is required";

		public const int TeamNameMaxLength = 50;

		public const int TeamMaxPokemonCount3v3 = 3;

		public const string TeamMaxPokemonCountErrorMessage = "The {0} must be less than {1}";

		public const string TeamNameMaxLengthErrorMessage = "The {0} must be at most 50 characters long";

		public const int PokemonLevel = 50;

		public const int MaxEvPerStat = 255;

		public const int MinEvPerStat = 0;

		public const int MaxTotalEvPoints = 510;

		public const int MinGeneration = 0;

		public const int MaxGeneration = 10;

		public const string MaxEvStatErrorMessage = "The max EV is {2}}";

        public const string EVLenghtMessage = "The field {0} must be between {2} and {1} characters long";

    }
}
