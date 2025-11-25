namespace PokemonGameConsole
{
	internal class ElectricPokemon : Pokemon
	{
		public ElectricPokemon(int id, string name, int level, List<Attack> attacks) : base(id, name, level, ElementType.Electric, attacks)
		{
		}
	}
}