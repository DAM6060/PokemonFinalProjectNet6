using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Admin.User
{
	public class UserServiceModel
	{
		public string Email { get; set; }

		public string Username { get; set; }

		public string? PlayerName { get; set; }

		public bool IsPlayer => PlayerName != null;
	}
}
