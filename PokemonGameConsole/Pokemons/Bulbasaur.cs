using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole.Pokemons
{
	internal class Bulbasaur : GrassPokemon, IEvolvable
	{
		public Bulbasaur(List<Attack> attacks, int level = 1) : base(1, "Bulbasaur", level, attacks)
		{
		}
		
		public void Evolve()
		{
			DoEvolve("Ivysaur");
		}
	}
}
