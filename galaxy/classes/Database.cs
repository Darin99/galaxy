using System;
using System.Collections.Generic;
using System.Text;

namespace galaxy.classes
{
	class Database
	{
		public static List<Galaxy> galaxies = new List<Galaxy>();
		public static List<Star> stars = new List<Star>();
		public static List<Planet> planets = new List<Planet>();
		public static List<Moon> moons = new List<Moon>();
		public static string stats()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("--- Stats ---").Append(Environment.NewLine)
				.Append("Galaxies: ").Append(galaxies.Count).Append(Environment.NewLine)
				.Append("Stars: ").Append(stars.Count).Append(Environment.NewLine)
				.Append("Planets: ").Append(planets.Count).Append(Environment.NewLine)
				.Append("Moons: ").Append(moons.Count).Append(Environment.NewLine)
				.Append("--- End of stats ---").Append(Environment.NewLine);
			return builder.ToString();
		}
		public static string listGalaxies()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("--- List of all researched galaxies ---").Append(Environment.NewLine);
			foreach (var galaxy in galaxies)
			{
				builder.Append(galaxy.getName()).Append(Environment.NewLine);
			}
			builder.Append("--- End of galaxies list ---").Append(Environment.NewLine);
			return builder.ToString();
		}
		public static string listStars()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("--- List of all researched stars ---").Append(Environment.NewLine);
			foreach (var star in stars)
			{
				builder.Append(star.getName()).Append(Environment.NewLine);
			}
			builder.Append("--- End of stars list ---").Append(Environment.NewLine);
			return builder.ToString();
		}
		public static string listPlanets()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("--- List of all researched planets ---").Append(Environment.NewLine);
			foreach (var planet in planets)
			{
				builder.Append(planet.getName()).Append(Environment.NewLine);
			}
			builder.Append("--- End of planets list ---").Append(Environment.NewLine);
			return builder.ToString();
		}
		public static string listMoons()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("--- List of all researched moons ---").Append(Environment.NewLine);
			foreach (var moon in moons)
			{
				builder.Append(moon.getName()).Append(Environment.NewLine);
			}
			builder.Append("--- End of moons list ---").Append(Environment.NewLine);
			return builder.ToString();
		}
	}
}
