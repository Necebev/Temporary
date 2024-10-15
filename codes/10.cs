using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
	internal class Program
	{
		/* private static int szam = 1; */ //globális változó, minden látja az osztályon belül
		static int[] tomb;

		static void kiir(int[] T, string melyik)
		{
			Console.WriteLine(melyik);
			foreach (int i in T)
			{
				Console.WriteLine(i);
			}
		}

		static int[] TombFeltoltes()
		{
			for (int i = 0; i < tomb.Length; i++)
			{
				tomb[i] = i * 2;
			}
			return tomb;
		}

		
		
		static void Main(string[] args)
		{
			tomb = new int[5];
			var t = TombFeltoltes();
			kiir(tomb, "Tomb");
			kiir(t, "t");
			kiir(tomb, "tomb");
			t[4] = 100;
			#region 1.feladat
			int radius = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(	"\nKerület: " + 2*radius*Math.PI + "cm" +
								"\nTerület: " + radius*radius*Math.PI + "cm" +
								"\nFelszín: " + 4*radius*radius*Math.PI + "cm" +
								"\nTérfogat: " + (4*Math.PI*radius*radius*radius)/3 + "cm");
            Console.WriteLine("");
			#endregion
			#region 2.feladat
			int[] szamok = {Convert.ToInt32(Console.ReadLine()), 
							Convert.ToInt32(Console.ReadLine()), 
							Convert.ToInt32(Console.ReadLine())};
			Array.Sort(szamok);
			Array.Reverse(szamok);
			Console.WriteLine("\nCsökkenő sorrend:");
			foreach (int i in szamok) {
			Console.WriteLine(i);
			}
			Console.WriteLine("");
			#endregion
			#region 3.feladat
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int c = Convert.ToInt32(Console.ReadLine());
			if (a + b > c && a + c > b && b + c > a)
			Console.WriteLine("A háromszög szerkeszthető");
			else
                Console.WriteLine("A háromszög nem szerkeszthető");
			Console.WriteLine("");
			#endregion
			#region 4.feladat
			int number = Convert.ToInt32(Console.ReadLine());
			if (number - -number >= 0) // big viccek mennek itt
				Console.WriteLine("Pozitív");
			else
				Console.WriteLine("Negatív");
			Console.WriteLine("");
			#endregion
			#region 5.feladat
			int szam1 = Convert.ToInt32(Console.ReadLine());
			int szam2 = Convert.ToInt32(Console.ReadLine());
			int osszeg = szam1 + szam2;
			int kulonbseg = szam1 - szam2;
			int szorzat = szam1 * szam2;
			int hanyados = szam1 / szam2;

			Console.WriteLine(
				"\nÖsszeg: " + osszeg +
				"\nKülönbség: " + kulonbseg +
				"\nSzorzat: " + szorzat +
				"\nHányados: " + hanyados);
			Console.WriteLine("");
			#endregion
			#region 6.feladat
			bool user = Convert.ToBoolean(Console.ReadLine());
			if (user)
                Console.WriteLine("IGAZ");
            Console.WriteLine("");
			#endregion
			#region 7.feladat
			int szam_1 = Convert.ToInt32(Console.ReadLine());
			int szam_2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("A két szám számtani közepe: " + (szam1 + szam2) / 2);
            Console.WriteLine("");
			#endregion
			#region 8.feladat
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());
			int z = Convert.ToInt32(Console.ReadLine());
			double atlo_xy = Math.Sqrt(x * x + y * y);
			double atlo_xz = Math.Sqrt(x * x + z * z);
			double atlo_yz = Math.Sqrt(y * y + z * z);
			double testatlo = Math.Sqrt(x * x + y * y + z * z);
			double felszin = 2 * (a * b + a * c + b * c);
			double terfogat = a * b * c;
            Console.WriteLine("");

			#endregion
			#region 9.feladat
			int[,] teglatestek = new int[3, 3];
			for (int i = 0; i < teglatestek.GetLength(0); i++)
			{
                Console.WriteLine(i+1 + ". téglatest 'a' oldala");
				teglatestek[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i+1 + ". téglatest 'b' oldala");
				teglatestek[i, 1] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(i + 1 + ". téglatest 'b' oldala");
				teglatestek[i, 2] = Convert.ToInt32(Console.ReadLine());
			}
			int legkisebb_index = -1;
			int legkisebb_oldalel_osszeg = int.MaxValue;
			for (int i = 0; i < teglatestek.GetLength(0); i++)
			{
				int _osszeg = teglatestek[i, 0] + teglatestek[i, 1] + teglatestek[i, 2];
				if (osszeg < legkisebb_oldalel_osszeg)
				{
					legkisebb_oldalel_osszeg = _osszeg;
					legkisebb_index = 1;
				}
				Console.WriteLine("A(z) " + (i + 1) + ". téglatest oldaléleinek összege: " + _osszeg);
			}
			int _a = teglatestek[legkisebb_index, 0];
			int _b = teglatestek[legkisebb_index, 1];
			int _c = teglatestek[legkisebb_index, 2];
            Console.WriteLine( "A legkisebb oldalél összeggel rendelkező test oldalainak hossza: " + a + ", " + b + ", " + c);
            Console.WriteLine("A legkisebb oldalél összeggel rendelkező test felszíne: " + 2* (a*b + a*c + b*c));
            Console.WriteLine("A legkisebb oldalél összeggel rendelkező test térfogata: " + a*b*c);
			#endregion
			#region 10.feladat
			int hekto = 0;
			int liter = 0;
			int deci = Convert.ToInt32(Console.ReadLine());
			while (deci > 9)
			{
				if (deci / 1000 >= 1)
					deci -= 1000;
				hekto += 1;
				
			}
				
				
			#endregion

			Console.ReadKey();
		}
	}
}


