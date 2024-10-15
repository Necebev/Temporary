using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szia
{
	internal class Program
	{
		static Random R = new Random();
		static void TombFeltoltes(int[] tomb)
		{
			for (int i = 0; i < tomb.Length; i++)
				tomb[i] = R.Next(tomb.Length * 3);
		}

		static int Szambeolvasas(string duma)
		{
			int szam = 0;
			do
			{
				Console.WriteLine(duma);
			} while (!int.TryParse(Console.ReadLine(), out szam) || szam < 1);
			return szam;
		}

		static void Main(string[] args)
		{
			rendezesek Rend = new rendezesek();
			int[] tarolo = new int[Szambeolvasas("Elemszám | ")];
			int[] Rtomb = new int[tarolo.Length];
			TombFeltoltes(tarolo);

			Attoltes(Rtomb, tarolo);
			var start = DateTime.Now; Rend.CseresRendezes(Rtomb); var stop = DateTime.Now;
            Console.WriteLine($"ECS ideje: {stop-start}");
			
			Attoltes(Rtomb, tarolo);
			start = DateTime.Now; Rend.BuborekRendezes(Rtomb); stop = DateTime.Now;
			Console.WriteLine($"Bubi ideje: {stop - start}");
			
			Attoltes(Rtomb, tarolo);
			start = DateTime.Now; Rend.MinMaxRendezes(Rtomb); stop = DateTime.Now;
			Console.WriteLine($"Min rendezés ideje: {stop - start}");

			Attoltes(Rtomb, tarolo);
			start = DateTime.Now; Array.Sort(Rtomb); stop = DateTime.Now;
			Console.WriteLine($"Quick sort ideje: {stop - start}");

			Console.ReadKey();
		}

		static void Attoltes(int[] cel, int[] forras)
		{
			for (int i =0; i<cel.Length; i++)
			{
				cel[i] = forras[i];
			}
		}

		static void Csere_(ref int a, ref int b);
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}

