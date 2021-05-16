using System;
using System.Text;

namespace galaxy.classes
{
	class Moon : BaseClass
	{
		public Moon(string name)
		{
			setName(name);
		}
		public string printMoon()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("------ ").Append(getName()).Append(Environment.NewLine);
			return builder.ToString();
		}
	}
}