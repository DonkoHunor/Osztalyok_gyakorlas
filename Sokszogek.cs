using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Sokszogek
	{
		private List<Sokszog> list = new List<Sokszog> ();

		public Sokszogek()
		{
			for (int i = 0; i < 10; i++)
			{
				list.Add(new Haromszog());
				list.Add(new Teglalap());
				list.Add(new Paralelogramma());
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
			return index;
		}

		public override string ToString()
		{
			string eredmeny="";
			foreach (Sokszog s in list)
			{
				eredmeny += s.ToString();
			}
			return eredmeny;
		}
	}
}
