using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringvergleich
{
	class Program
	{
		
		static void Main(string[] args)
		{
			int ausgabeAB;
			char eingabeA, eingabeB;
			// --> EINGABE
			Console.WriteLine("Bitte geben sie den ersten String ein:");
			eingabeA = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Bitte geben sie den zweiten String ein:");
			eingabeB = Convert.ToChar(Console.ReadLine());
			// --> VERARBEITUNG: (Srings vergleichen)
			ausgabeAB = String.Compare((Convert.ToString(eingabeA)),(Convert.ToString(eingabeB)));
			Console.WriteLine("{0}", ausgabeAB);
			if ((ausgabeAB < 0) == true)
			{
				Console.WriteLine("StringB ist 'kleiner' als StringA!");
			}
			else if ((ausgabeAB == 0) == true)
			{
				Console.WriteLine("Die Strings sind gleich groß!");
			}
			else Console.WriteLine("StringA ist kleiner als StringB!");
			}
	}
}
