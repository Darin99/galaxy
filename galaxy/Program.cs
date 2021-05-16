using System;
using galaxy.classes;

namespace galaxy
{
	class Program
	{
		static void Main(string[] args)
		{
            string line = Console.ReadLine();
			
            while (!line.Equals("exit"))
            {
				string[] tokens = line.Split(" ");
				
				if (tokens[0].Equals("add"))
				{
					if(tokens[1].Equals("galaxy"))
					{
						if (tokens[2].StartsWith("[") && tokens[2].EndsWith("]"))
						{
							string name = tokens[2].Replace("[", "").Replace("]", "");
							string typeOfGalaxy = tokens[3];
							string age = tokens[4];
							Galaxy galaxy = new Galaxy(name, typeOfGalaxy, age);
							Database.galaxies.Add(galaxy);
						} else
						{
							string name = tokens[2].Replace("[", "");
							string name2 = tokens[3].Replace("]", "");
							string combinedName = name + " " + name2;
							string typeOfGalaxy = tokens[4];
							string age = tokens[5];
							Galaxy galaxy = new Galaxy(combinedName, typeOfGalaxy, age);
							Database.galaxies.Add(galaxy);
						}

					} else if(tokens[1].Equals("star"))
					{
						if (tokens[2].StartsWith("[") && tokens[2].EndsWith("]"))
						{
							string nameOfGalaxy = tokens[2].Replace("[", "").Replace("]", "");
							string nameOfStar = tokens[3].Replace("[", "").Replace("]", "");
							double mass = double.Parse(tokens[4], System.Globalization.CultureInfo.InvariantCulture);
							double size = double.Parse(tokens[5], System.Globalization.CultureInfo.InvariantCulture);
							int temperature = int.Parse(tokens[6]);
							double luminosity = double.Parse(tokens[7], System.Globalization.CultureInfo.InvariantCulture);

							Star star = new Star(nameOfStar, mass, size, temperature, luminosity);
							Database.stars.Add(star);

							foreach (var galaxy in Database.galaxies)
							{
								if (galaxy.getName().Equals(nameOfGalaxy))
								{
									galaxy.addStar(star);
								}
							}
						} else
						{
							string nameOfGalaxy1 = tokens[2].Replace("[", "");
							string nameOfGalaxy2 = tokens[3].Replace("]", "");
							string combinedName = nameOfGalaxy1 + " " + nameOfGalaxy2;
							string nameOfStar = tokens[4].Replace("[", "").Replace("]", "");
							double mass = double.Parse(tokens[5], System.Globalization.CultureInfo.InvariantCulture);
							double size = double.Parse(tokens[6], System.Globalization.CultureInfo.InvariantCulture);
							int temperature = int.Parse(tokens[7]);
							double luminosity = double.Parse(tokens[8], System.Globalization.CultureInfo.InvariantCulture);

							Star star = new Star(nameOfStar, mass, size, temperature, luminosity);
							Database.stars.Add(star);

							foreach (var galaxy in Database.galaxies)
							{
								if (galaxy.getName().Equals(combinedName))
								{
									galaxy.addStar(star);
								}
							}
						}

					} else if(tokens[1].Equals("planet"))
					{
						string nameOfStar = tokens[2].Replace("[", "").Replace("]", "");
						string nameOfPlanet = tokens[3].Replace("[", "").Replace("]", "");
						string typeOfPlanet = tokens[4];
						string isInhabited = tokens[5];

						Planet planet = new Planet(nameOfPlanet, typeOfPlanet, isInhabited);
						Database.planets.Add(planet);

						foreach (var star in Database.stars)
						{
							if (star.getName().Equals(nameOfStar))
							{
								star.addPlanet(planet);
							}
						}

					} else
					{
						string nameOfPlanet = tokens[2].Replace("[", "").Replace("]", "");
						string nameOfMoon = tokens[3].Replace("[", "").Replace("]", "");

						Moon moon = new Moon(nameOfMoon);
						Database.moons.Add(moon);

						foreach (var planet in Database.planets)
						{
							if (planet.getName().Equals(nameOfPlanet))
							{
								planet.addMoon(moon);
							}
						}
					}

				} else if(tokens[0].Equals("stats"))
				{
					if (Database.galaxies.Count == 0 && Database.stars.Count == 0 && Database.planets.Count == 0
						&& Database.moons.Count == 0)
					{
						Console.WriteLine("none");
					}
					else
					{
						Console.WriteLine(Database.stats());
					}

				} else if(tokens[0].Equals("list"))
				{
					if(tokens[1].Equals("galaxies"))
					{
						if(Database.galaxies.Count == 0)
						{
							Console.WriteLine("none");
						} else
						{
							Console.WriteLine(Database.listGalaxies());
						}
					} else if(tokens[1].Equals("stars"))
					{
						if (Database.stars.Count == 0)
						{
							Console.WriteLine("none");
						}
						else
						{
							Console.WriteLine(Database.listStars());
						}
					} else if (tokens[1].Equals("planets"))
					{
						if (Database.planets.Count == 0)
						{
							Console.WriteLine("none");
						}
						else
						{
							Console.WriteLine(Database.listPlanets());
						}
					} else
					{
						if (Database.moons.Count == 0)
						{
							Console.WriteLine("none");
						}
						else
						{
							Console.WriteLine(Database.listMoons());
						}
					}
				} else
				{
					if (Database.galaxies.Count == 0)
					{
						Console.WriteLine("none");
					}
					else
					{
						if (tokens[1].StartsWith("[") && tokens[1].EndsWith("]"))
						{
							string nameOfGalaxy = tokens[1].Replace("[", "").Replace("]", "");
							foreach (var galaxy in Database.galaxies)
							{
								if (galaxy.getName().Equals(nameOfGalaxy))
								{
									Console.WriteLine(galaxy.printGalaxy());
								}
							}
						} else
						{
							string nameOfGalaxy = tokens[1].Replace("[", "");
							string nameOfGalaxy2 = tokens[2].Replace("]", "");
							string name = nameOfGalaxy + " " + nameOfGalaxy2;
							foreach (var galaxy in Database.galaxies)
							{
								if (galaxy.getName().Equals(name))
								{
									Console.WriteLine(galaxy.printGalaxy());
								}
							}
						}
					}
				}
				line = Console.ReadLine();
            }
        }
	}
}