using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal class WaterPokemon : Pokemon
	{
		public WaterPokemon(int id, string name, int level, List<Attack> attacks) : base(id, name, level, ElementType.Water, attacks)
		{
		}
	}
}
