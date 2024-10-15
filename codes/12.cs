using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atadasok
{
	internal class Program
	{
		static Random R = new Random();

		static void Main(string[] args)
		{
			//int A = 10, B = 20;
			//Console.WriteLine($"Csere előtt\na: {A}, b: {B}");
			//Csere(ref A, ref B);
			//Console.WriteLine($"Meghívás után\na: {A}, b: {B}");
			int[] T = new int[Szambeolvasas("Add meg az elemszámot, ami pozitív egész! ")];
            TombFeltoltes(T); // aktuális paraméter
			Kiir(T);
			Csere(ref T[0], ref T[T.Length-1]);
			MinMaxRendezes(T);
			Kiir(T);
			//Console.WriteLine(T.Length);
			Console.ReadKey();
		}

		static void TombFeltoltes(int[] tomb)
		{
			for (int i = 0; i < tomb.Length; i++)
				tomb[i] = R.Next(tomb.Length*3);

		}	

		static void Kiir(int[] t)
		{
			foreach(int i in t) 
				Console.Write(i + " ");
		}


		static void Csere(ref int a, ref int b) // formális paraméter
		{
			//Console.WriteLine($"Csere előtt\na: {a}, b: {b}");
			int tmp = a;
			a = b;
			b = tmp;
            //Console.WriteLine($"Csere után\na: {a}, b: {b}");

		}

		static void CseresRendezes(int[] t)
		{
            Console.WriteLine("Cserés rendezés");
			for (int i = 0; i< t.Length - 1; i++)
			{
				for (int j = i + 1; j < t.Length; j++)
				{
					if (t[i] > t[j])
					{
						Csere(ref t[i], ref t[j]);
					}
				}
			}
            
		}

		static void BuborekRendezes(int[] t)
		{
            Console.WriteLine("Buborék rendezés");
			for(int i = t.Length - 1; i > 0; i--)
			{
				for(int j = 0; j < i-1; j++)
				{
					if (t[j] > t[j+1]) Csere(ref t[j], ref t[j+1]);
				}
			}
		}

		static void bubi(int[] t)
		{
			int i = t.Length;
			while (i > 1)
			{
				i--;
				for (int j = 0; j < i; j++)
				{
					if (t[j] > t[i + 1]) Csere(ref t[j], ref t[j + 1]);
				}
			}
		}

		static void MinMaxRendezes(int[] t)
		{
			Console.WriteLine("Min-Max rendezés");
			int min = 0;
			for (int i = 0; i < t.Length - 1; i++)
			{
				min = i;
				for (int j = i + 1; j < t.Length; j++)
				{
					if (t[min] > t[j])
						min = j;
				}
				Csere(ref t[i], ref t[min]);
			}
		}
		static int Szambeolvasas(string duma)
		{
            int szam = 0;
			do
			{
				Console.WriteLine(duma);
			}while (!int.TryParse(Console.ReadLine(), out szam) || szam < 1);
			return szam;
		}
	}
}
