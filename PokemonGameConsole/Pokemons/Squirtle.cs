using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole.Pokemons
{
	internal class Squirtle : WaterPokemon
	{
		public Squirtle(List<Attack> attacks, int level = 1) : base(1, "Squirtle", level, attacks)
		{
		}
	}
}
