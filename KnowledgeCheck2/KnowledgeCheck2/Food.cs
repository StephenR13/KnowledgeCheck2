﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
	public class Food
	{
		public string Name { get; set; }

		public Food(string name) 
		{ 
			Name = name;
		}

		public override string ToString()
		{
			return $"Food Item: {Name}";
		}
	}
}
