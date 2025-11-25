using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameConsole
{
	internal class Attack
	{
		public string Name { get; set; }
		public ElementType ElementType { get; set; }
		public int BasePower { get; set; }

		public Attack(string name, ElementType elementType, int basePower)
		{
			Name = name;
			ElementType = elementType;
			BasePower = basePower;
		}

		public void Use(int level)
		{
			Console.WriteLine($"{Name} hit with a total power of {BasePower * level}");
		}
	}
}
