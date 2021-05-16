using System;
using System.Collections.Generic;
using System.Text;

namespace galaxy.classes
{
	 abstract class BaseClass
	{
		private string name;
		internal string getName()
		{
			return name;
		}
		protected void setName(string name)
		{
			this.name = name;
		}
	}
}
