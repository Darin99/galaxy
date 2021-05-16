using System;
using System.Collections.Generic;
using System.Text;

namespace galaxy.classes
{
	class Planet : BaseClass
	{
		private string type;
		private string isInhabited;
		private List<Moon> moons;
		public Planet(string name, string type, string isInhabited)
		{
			setName(name);
			this.type = type;
			this.isInhabited = isInhabited;
			moons = new List<Moon>();
		}
		public void addMoon(Moon moon)
		{
			moons.Add(moon);
		}
		public string printPlanet()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("---- Name: ").Append(getName()).Append(Environment.NewLine)
				.Append("---- Type: ").Append(type).Append(Environment.NewLine)
				.Append("---- Support life:").Append(isInhabited).Append(Environment.NewLine)
				.Append("---- Moons: ").Append(Environment.NewLine);
			if(Database.moons.Count == 0)
			{
				builder.Append("------ none").Append(Environment.NewLine);
			} else
			{
				foreach (var moon in moons)
				{
					builder.Append(moon.printMoon());
				}
			}
			return builder.ToString();
		}
	}
}