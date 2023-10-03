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

		public Paralelogramma(double a, double b, double alfa) : base(a, b)
		{			
			if (alfa < 0 || alfa >= 180)
			{
				throw new ArgumentException("Rossz szög!", nameof(alfa));
			}
			this.alfa = alfa;
		}

		public Paralelogramma() : base(VeletlenOldal(), VeletlenOldal())
		{
			this.alfa = VeletlenSzog();
		}

		public double Alfa { get => alfa;
			set
			{
				if (value < 0 || value >= 180)
				{
					throw new ArgumentException("Rossz szög!", nameof(value));
				}
				this.alfa = value;
			} }

		public override double GetTerulet()
		{
			return Math.Round(this.A * this.B * Math.Sin(alfa / 180 * Math.PI));
		}

		public override string ToString()
		{
			return $"alfa szög: {this.alfa}°\n" + $"{base.ToString()}";
		}
	}
}
