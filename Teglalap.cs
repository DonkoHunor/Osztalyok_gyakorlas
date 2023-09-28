using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Teglalap : Sokszog
	{
		private double b;
		private static Random rnd = new Random();
		public Teglalap(double a, double b) : base(a)
		{
			this.b = b;
		}

		public Teglalap() : base(rnd.Next(10, 200))
		{
			this.b = rnd.Next(10, 200);
		}

		public double B { get => b; set => b = value; }

		public override double GetKerulet()
		{
			return (this.A + this.b) * 2;
		}

		public override double GetTerulet()
		{
			return this.A * this.b;
		}

		public override string ToString()
		{
			return $"a oldal: {this.A}\n" +
				$"b oldal: {this.b}\n" +
				$"{base.ToString()}\n";
		}
	}
}
