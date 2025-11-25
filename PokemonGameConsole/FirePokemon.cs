using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal class FirePokemon : Pokemon
	{
		public FirePokemon(int id, string name, int level, List<Attack> attacks) : base(id, name, level, ElementType.Fire, attacks)
		{
		}
	}
}
