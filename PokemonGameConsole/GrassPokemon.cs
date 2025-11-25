using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal class GrassPokemon : Pokemon
	{
		public GrassPokemon(int id, string name, int level, List<Attack> attacks) : base(id, name, level, ElementType.Grass, attacks)
		{
		}
	}
}
