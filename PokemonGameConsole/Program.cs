// See https://aka.ms/new-console-template for more information
using PokemonGameConsole;
using PokemonGameConsole.Pokemons;









List<Attack> grassAttacks = new List<Attack>() {
	new Attack("Vine Whip", ElementType.Grass, 6),
	new Attack("Razor Leaf", ElementType.Grass, 10)
};

List<Attack> waterAttacks = new List<Attack>() {
	new Attack("Bubble", ElementType.Water, 6),
	new Attack("Hydro Pump", ElementType.Water, 12)
};

List<Attack> fireAttacks = new List<Attack>() {
	new Attack("Ember", ElementType.Fire, 6),
	new Attack("Flamethrower", ElementType.Fire, 15)
};

List<Attack> electricAttacks = new List<Attack>() {
	new Attack("Thunderbolt", ElementType.Electric, 15)
};





Bulbasaur bulbasaur = new Bulbasaur(grassAttacks, level: 16);
Squirtle squirtle = new Squirtle(waterAttacks, level: 16);




squirtle.Attack("Bubble");

Trainer ash = new Trainer(new Pikachu(electricAttacks));

ash.AddPokemon(bulbasaur);
ash.AddPokemon(squirtle);

// försöker evolva alla pokemons som implementerar IEvolvable
foreach(var p in ash.GetPokemons())
{
	if (p is IEvolvable e)
		e.Evolve();
}





//var pokemon = PokemonFactory.CreatePokemonById(1);
//Console.WriteLine(pokemon.Id);
Console.ReadKey();