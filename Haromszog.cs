using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Haromszog : Sokszog
	{
		private double b;
		private double c;
		private static Random rnd = new Random();

		public Haromszog(double a, double b, double c) : base(a)
		{
			this.b = b;
			this.c = c;
			if(!this.Szerkesztheto())
			{
				throw new ArgumentException("A háromszög nem szerkeszthető");
			}
		}

		public Haromszog() : base(VeletlenOldal())
		{
			this.b = VeletlenOldal();
			this.c = VeletlenOldal();

			while (!this.Szerkesztheto())
			{
				base.A = VeletlenOldal();
				this.b = VeletlenOldal();
				this.c = VeletlenOldal();
			}
		}		

		public override double A
		{
			set 
			{
				base.A = value;
				if (!Szerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}

		public double B
		{
			get => b;
			set 
			{
				b = value;
				if (!Szerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}
		public double C
		{
			get => c;
			set
			{
				c = value;
				if (!Szerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}

		private bool Szerkesztheto()
		{
			return this.A + this.b > this.c 
				&& this.A + this.c > this.b 
				&& this.b + this.c > this.A;
		}

		private static int VeletlenOldal()
		{
			return rnd.Next(5, 15);
		}

		public override double GetKerulet()
		{
			return this.A + this.b + this.c;
		}

		public override double GetTerulet()
		{
			double s = this.GetKerulet() / 2;
			return Math.Sqrt(s * (s - this.A) * (s - this.b) * (s - this.c));
		}

		public override string ToString()
		{
			return $"a oldal: {this.A}\n" +
				$"b oldal: {this.b}\n" +
				$"c oldal: {this.c}\n" +
				$"{base.ToString()}\n";
		}
	}
}
