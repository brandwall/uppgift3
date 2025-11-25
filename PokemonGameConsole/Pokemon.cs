using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal abstract class Pokemon
	{
		public int Id { get; set; }
		public string Name { get; private set; } // Måste vara 2-15 tecken
		public int Level { get; set; } // Måste vara >= 1
		public ElementType Element { get; set; }
		private List<Attack> _attacks;

		protected Pokemon(int id, string name, int level, ElementType element, List<Attack> attacks)
		{
			Id = id;

			if (attacks.Count <= 4 && attacks.Count > 0)
				_attacks = attacks;
			else
				throw new ArgumentException("Must contain 1-4 attacks");

			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException($"'{nameof(name)}' cannot be empty");
			else if (name.Length < 2 || name.Length > 15)
				throw new ArgumentException($"'{nameof(name)}' must be between 2 and 15 characters. ");
			else
				Name = name;

			Level = level > 0 ? level : throw new ArgumentException($"'{nameof(level)}' must be higher than 0");

			Element = element;
		}
		public void RandomAttack()
		{

		}

		public void Attack(string attackName)
		{
			Attack attack = _attacks.Where(a => a.Name == attackName).FirstOrDefault() ;
			
			if(attack is not null)
				attack.Use(Level);
		}

		public void RaiseLevel() => RaiseLevel(amount: 1);
		private void RaiseLevel(int amount)
		{
			Level += amount;
			Console.WriteLine($"Level up! {Name} is now level: {Level}");
		}

		protected void DoEvolve(string evolutionName)
		{
			if(this is IEvolvable)
			{
				if (Name == evolutionName)
				{
					Console.WriteLine("Your pokemon has already evolved");
				}
				else if (Level < 16)
				{
					Console.WriteLine("Level is not high enough to evolve.");
				}
				else
				{
					Console.WriteLine($"What? {Environment.NewLine}{Name} is evolving!");
					Console.WriteLine($"Congratulations! Your {Name} evolved into {evolutionName}!");
					Name = evolutionName;
					RaiseLevel(10);
				}
			}
		}
	}
}
