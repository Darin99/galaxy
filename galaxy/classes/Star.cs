using System;
using System.Collections.Generic;
using System.Text;

namespace galaxy.classes
{
	class Star : BaseClass
	{
		private string type;
		private double mass;
		private double size;
		private int temperature;
		private double luminosity;
		private List<Planet> planets;
		public Star(string name, double mass, double size, int temperature, double luminosity)
		{
			setName(name);
			this.mass = mass;
			this.size = size;
			this.temperature = temperature;
			this.luminosity = luminosity;
			type = chooseTypeOfStar(mass, size, temperature, luminosity);
			planets = new List<Planet>();
		}
		private string chooseTypeOfStar(double mass, double size, double temperature, double luminosity)
		{
			if((mass >= 0.08 && mass <= 0.45) && (size <= 0.7) && (temperature >= 2400 && temperature <= 3700) 
				&& (luminosity <= 0.08))
			{
				return "M";

			} else if ((mass >= 0.45 && mass <= 0.8) && (size >= 0.7 && size <= 0.96) && 
				(temperature >= 3700 && temperature <= 5200) && (luminosity >= 0.08 && luminosity <= 0.6))
			{
				return "K";	

			} else if((mass >= 0.8 && mass <= 1.04) && (size >= 0.96 && size <= 1.15) &&
				(temperature >= 5200 && temperature <= 6000) && (luminosity >= 0.6 && luminosity <= 1.5))
			{
				return "G";

			} else if ((mass >= 1.04 && mass <= 1.4) && (size >= 1.15 && size <= 1.4) &&
				(temperature >= 6000 && temperature <= 7500) && (luminosity >= 1.5 && luminosity <= 5))
			{
				return "F";

			} else if ((mass >= 1.4 && mass <= 2.1) && (size >= 1.4 && size <= 1.8) &&
				(temperature >= 7500 && temperature <= 10000) && (luminosity >= 5 && luminosity <= 25))
			{
				return "A";

			} else if ((mass >= 2.1 && mass <= 16) && (size >= 1.8 && size <= 6.6) &&
				(temperature >= 10000 && temperature <= 30000) && (luminosity >= 25 && luminosity <= 30000))
			{
				return "B";

			} else
			{
				return "O";
			}
		}
		public void addPlanet(Planet planet)
		{
			planets.Add(planet);
		}
		public string GetStarType()
		{
			return type;
		}
		public double getMass()
		{
			return mass;
		}
		public double getSize()
		{
			return size;
		}
		public int getTemperature()
		{
			return temperature;
		}
		public double getluminosity()
		{
			return luminosity;
		}
		public string printStar()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("-- Name: ").Append(getName())
			.Append(Environment.NewLine)
			.Append("-- Class: ").Append(GetStarType()).Append($" ({getMass()}, {getSize()}, {getTemperature()}, {getluminosity()})")
			.Append(Environment.NewLine)
			.Append("-- Planets: ")
			.Append(Environment.NewLine);
			if(Database.planets.Count == 0)
			{
				builder.Append("---- none").Append(Environment.NewLine);
			}
			else
			{
				foreach (var planet in planets)
				{
					builder.Append(planet.printPlanet());
				}
			}
			return builder.ToString();
		}
	}
}