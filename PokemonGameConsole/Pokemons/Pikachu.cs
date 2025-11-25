using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole.Pokemons
{
	internal class Pikachu : ElectricPokemon, IEvolvable
	{
		public Pikachu(List<Attack> attacks, int level = 1) : base(id: 25, name: "Pikachu", level, attacks)
		{
		}
		
		public void Evolve()
		{
			DoEvolve("Raichu");
		}
	}
}
