using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok_gyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Haromszog haromszog = new Haromszog();
			Haromszog haromszog1 = new Haromszog(3, 4, 5);

			Teglalap teglalap = new Teglalap(3, 5);
			Teglalap teglalap1 = new Teglalap(4, 7);

            Console.WriteLine(haromszog);
			Console.WriteLine(haromszog1);
			Console.WriteLine(teglalap);
			Console.WriteLine(teglalap1);

			try
			{
				haromszog.A = 100;
			}
			catch (ArgumentException ex)
			{
                Console.WriteLine(ex.Message);
            }*/

			Paralelogramma paralelogramma = new Paralelogramma();
            Console.WriteLine(paralelogramma.ToString());

            Console.ReadKey();
		}
	}
}
