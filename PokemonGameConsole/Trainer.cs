using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal class Trainer
	{
		//public List<Pokemon> Pokemons { get; private set; } = new List<Pokemon>();
		private List<Pokemon> _pokemons = new List<Pokemon>();

		public Trainer(Pokemon starterPokemon)
		{
			_pokemons.Add(starterPokemon);
		}


		


		public IEnumerable<Pokemon> GetPokemons()
		{
			return _pokemons;
		}

		public void AddPokemon(Pokemon pokemon)
		{
			if (_pokemons.Contains(pokemon))
				throw new ArgumentException("Pokemon already belongs to the trainer");
			_pokemons.Add(pokemon);
		}
	}
}
