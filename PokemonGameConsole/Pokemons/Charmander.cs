using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole.Pokemons
{
	internal class Charmander : FirePokemon, IEvolvable
	{
		public Charmander(List<Attack> attacks, int level = 1) : base(1, "Charmander", level, attacks)
		{
		}
		public void Evolve()
		{
			throw new NotImplementedException();
		}
	}
}
