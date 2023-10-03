using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Sokszogek
	{
		private List<Sokszog> list = new List<Sokszog>();
		private static Random rnd = new Random();

		public Sokszogek()
		{
			for (int i = 0; i < 10; i++)
			{
				int sokszog = rnd.Next(3);
				switch (sokszog)
				{
					case 0:
						list.Add(new Teglalap());
						break;
					case 1:
						list.Add(new Haromszog());
						break;
					case 2:
						list.Add(new Paralelogramma());
						break;
				}				
			}
		}

		public double OsszKerulet()
		{
			double ossz = 0;
			foreach (Sokszog s in list)
			{
				ossz += s.GetKerulet();
			}
			return ossz;
		}

		public double OsszTerulet()
		{
			double ossz = 0;
			foreach (Sokszog s in list)
			{
				ossz += s.GetTerulet();
			}
			return ossz;
		}

		public int MaxTerulet()
		{
			int index = -1;
			double max = int.MinValue;
			for (int i = 0; i < list.Count(); i++)
			{
				if (list[i].GetTerulet() > max)
				{
					max = list[i].GetTerulet();
					index = i;
				}
			}
			return index + 1;
		}

		public override string ToString()
		{
			var sb = new StringBuilder("Sokszögek:");
			foreach (Sokszog s in list)
			{
				sb.AppendLine(s.ToString());
			}
			return sb.ToString();
		}
	}
}
