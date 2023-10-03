using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal abstract class Sokszog
	{
		private double a;
		private static Random rnd = new Random();

		public Sokszog(double a)
		{
			this.a = a;
		}

		public virtual double A { get => a; set => a = value; }

		public abstract double GetKerulet();

		public abstract double GetTerulet();

		protected static int VeletlenOldal()
		{
			return rnd.Next(1, 100);
		}

		protected static int VeletlenSzog()
		{
			return rnd.Next(1, 180);
		}

		public override string ToString()
		{
			return $"Kerlet: {this.GetKerulet()} - Terület: {Math.Round(this.GetTerulet(),4)}";
		}
	}
}
