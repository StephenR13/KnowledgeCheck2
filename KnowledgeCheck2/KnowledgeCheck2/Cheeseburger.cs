using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
	public class Cheeseburger : Food
	{
		public int Toppings { get; set; }

		public Cheeseburger(string name, int toppings) : base(name)
		{
			Toppings = toppings;
		}

		public override string ToString()
		{
			return $"{Name} with {Toppings} toppings";
		}
	}
}
