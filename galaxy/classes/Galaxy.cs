using System;
using System.Collections.Generic;
using System.Text;

namespace galaxy.classes
{
	class Galaxy : BaseClass
	{
		private string galaxyType;
		private string age;
		private List<Star> stars;
		public Galaxy(string name, string galaxyType, string age)
		{
			setName(name);
			this.galaxyType = galaxyType;
			this.age = age;
			stars = new List<Star>();
		}
		public void addStar(Star star)
		{
			stars.Add(star);
		}
		public string printGalaxy()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append($"--- Data for {getName()} galaxy ---")
				.Append(Environment.NewLine)
				.Append("Type: ").Append(galaxyType)
				.Append(Environment.NewLine)
				.Append("Age: ").Append(age)
				.Append(Environment.NewLine)
				.Append("Stars:")
				.Append(Environment.NewLine);
			if(Database.stars.Count == 0)
			{
				builder.Append("-- none").Append(Environment.NewLine);
			} else
			{
				foreach (var star in stars)
				{
					builder.Append(star.printStar());
				}
			}
			builder.Append($"--- End of data for {getName()} galaxy ---").Append(Environment.NewLine);
			return builder.ToString();
		}
	}
}