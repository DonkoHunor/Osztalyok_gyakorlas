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
			Sokszogek list = new Sokszogek();
			Console.WriteLine(list.ToString());
            Console.WriteLine(list.OsszKerulet());
            Console.WriteLine(list.OsszTerulet());
            Console.WriteLine(list.MaxTerulet());

            Console.ReadKey();
		}
	}
}
