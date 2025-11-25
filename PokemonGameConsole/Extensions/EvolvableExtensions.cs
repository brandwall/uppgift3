using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole.Extensions
{
	internal static class EvolvableExtensions
	{
		public static void DefaultEvolve(this IEvolvable pokemon, string evolutionName)
		{
			Console.WriteLine("Evolution...");
		}
	}
}
