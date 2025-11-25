using PokemonGameConsole.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal static class PokemonFactory
	{
		// OBS: Inte en del av uppgiften
		//
		// Ville se hur man kan skapa ett objekt genom att ange dess id
		//
		//private static readonly Dictionary<int, Func<Pokemon>> _pokedex = new Dictionary<int, Func<Pokemon>>()
		//{
		//	{ 1, () => new Bulbasaur() },
		//	{ 2, () => new Charmander() },
		//	{ 3, () => new Squirtle() },
		//};

		//public static Pokemon CreatePokemonById(int id)
		//{
		//	if (_pokedex.TryGetValue(id, out var create))
		//		return create();

		//	throw new ArgumentException($"No Pokémon found with ID {id}.");
		//}
	}
}
