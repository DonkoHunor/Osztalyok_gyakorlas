using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Paralelogramma : Teglalap
	{
		private double alfa;
		private static Random rnd = new Random();

		

		public Paralelogramma(double a, double b, double alfa) : base(a, b)
		{
			this.alfa = alfa;
			if (alfa < 0 || alfa > 180)
			{
				throw new ArgumentException("Rossz szög!");
			}
		}

		public Paralelogramma() : base(VeletlenOldal(), VeletlenOldal())
		{
			this.alfa = VeletlenOldal();
			if (alfa < 0 || alfa > 180)
			{
				throw new ArgumentException("Rossz szög!");
			}
		}

		public double Alfa { get => alfa; set => alfa = value; }

		private static int VeletlenOldal()
		{
			return rnd.Next(10, 200);
		}

		public override double GetTerulet()
		{
			return Math.Round(this.A * this.B * Math.Sin(alfa/180*Math.PI),4);
		}

		public override string ToString()
		{
			return $"alfa szög: {this.alfa}" + $"{base.ToString()}\n";
		}
	}
}
