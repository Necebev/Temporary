using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatok2
{
    class Program
    {
        static void Feladat11()
        {
            Console.WriteLine("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine()); // szam (integer)
            string szamjegyek = Convert.ToString(szam); // szamjegyek (string)
            int szamjegy_osszeg = 0;

			while (szamjegyek.Length > 1)
            {
				szamjegy_osszeg = 0;
				foreach (char i in szamjegyek)
                {
					szamjegy_osszeg += Convert.ToInt32(i.ToString());
                }
				szamjegyek = szamjegy_osszeg.ToString();
            }

            if (szamjegy_osszeg == 9 && szam % 9 == 0)
            {
                Console.WriteLine("A szám osztható 9-cel!");
            }

            else
            {
                Console.WriteLine("A szám nem osztható 9-cel!");
            }
            
        }

        static void Feladat12()
        {
            Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            string szamjegyek = Convert.ToString(szam);
            Console.WriteLine("A szám " + szamjegyek.Length + " jegyű!");
        }

        static void Feladat13()
        {
            Dictionary<string, string> evszakok = new Dictionary<string, string> {
                { "január",  "Tél"},
                { "február",  "Tél"},
                { "március",  "Tavasz"},
                { "április",  "Tavasz"},
                { "május",  "Tavasz"},
                { "június",  "Nyár"},
                { "július",  "Nyár"},
                { "augusztus",  "Nyár"},
                { "szeptember",  "Ősz"},
                { "október",  "Ősz"},
                { "november",  "Ősz"},
                { "december",  "Tél"}
            };

            Console.WriteLine("Kérem egy hónap nevét: ");
            string honap = Console.ReadLine();
            Console.WriteLine($"A kiválasztott hónap {evszakok[honap]} évszakban van.");
        }

        static void Feladat14()
        {
            Console.WriteLine("Kérem a cég bevételét: ");
            int bevetel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a cég kiadását: ");
            int kiadas = Convert.ToInt32(Console.ReadLine());

            if (bevetel > kiadas)
            {
                Console.WriteLine($"A cég nyereséges ({bevetel - kiadas}).");
            }
            else if (bevetel == kiadas)
            {
                Console.WriteLine($"A cég nullszaldós ({bevetel - kiadas}).");
            }
            else
            {
                Console.WriteLine($"A cég veszteséges ({bevetel - kiadas}).");
            }
        }

        static void Feladat15()
        {
            Dictionary<string, string> nyelvek = new Dictionary<string, string>()
            {
                {"igen","Szia cigány!"},
                {"yes","Hello dickhead!"},
                {"sí","Buenas nachos!"}
            };

            Console.WriteLine("Beszélsz magyarul?\nDo you speak english?\n¿Hablas español?");
            string valasz = Console.ReadLine();

            if (nyelvek.ContainsKey(valasz))
            {
                Console.WriteLine(nyelvek[valasz]);
            }
            else
            {
                Console.WriteLine("♥");
            }
        }

		static void Feladat16() {
            string jelszo = "asda";
            int probalkozasok = 3;
            bool fut = true;
            string input;

            while (fut) {
                if (probalkozasok == 0) {
                    Console.WriteLine("Nincs több próba!");
                    fut = false;
                }
                else
                {
                    Console.WriteLine("Kérem a jelszót:");
                    input = Console.ReadLine();
                    if (input == jelszo) {
                        Console.WriteLine("Helyes jelszó!");
                        fut = false;
                    } else {
                        Console.WriteLine("Rossz jelszó próbáld újra!");
                    }
                    probalkozasok--;
                }
            }
		}

		static void Feladat17() {
			Dictionary<string, string> honapok = new Dictionary<string, string>() {
				{"1","Tél"},
				{"2","Tél"},
				{"3","Tavasz"},
				{"4","Tavasz"},
				{"5","Tavasz"},
				{"6","Nyár"},
				{"7","Nyár"},
				{"8","Nyár"},
				{"9","Ősz"},
				{"10","Ősz"},
				{"11","Ősz"},
				{"12","Tél"}
			};

			Console.WriteLine("Kérem a hónap sorszámát: ");
			string honap = Console.ReadLine();
			Console.WriteLine($"A kiválasztott hónap {honapok[honap]} évszakban van.");
		}

		static void Feladat18() {
			int[] haviK = new int[12];
			for (int i = 0; i < haviK.Length; i++) {
				Console.WriteLine($"Kérem a(z) {i+1}. hónap középhőmérsékletét: ");
				haviK[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine($"Az évi középhőmérséklet: {haviK.Sum() / (double)12}.");
		}

		static void Feladat19() {
			/* 
			   pohár nélkül - 10
			   dupla cukorral + 20
			   habos kávé + 50
			*/

			Dictionary<string, int> kavegep = new Dictionary<string, int> {
				{"kávé", 200},
				{"pohár nélkül", 190},
				{"dupla cukorral", 220},
				{"habos kávé", 250},
			};

			foreach (var kave in kavegep) {
				Console.WriteLine($"{kave.Key}: {kave.Value}");
			}

			Console.WriteLine("Válassz cigó: ");
			string valasztott = Console.ReadLine();
			Console.WriteLine($"Kérek {kavegep[valasztott]} Ft-ot cigger!");
		}

		static void Feladat20() {
			Dictionary<int, int> cimletek = new Dictionary<int, int> {
				{20000,0},
				{10000,0},
				{5000,0},
				{2000,0},
				{1000,0},
				{500,0},
				{200,0},
				{100,0},
				{50,0},
				{20,0},
				{10,0},
				{5,0}
			};

			Dictionary<int, int> cimletek_ki = new Dictionary<int, int>();

			Console.WriteLine("Kérek egy pénzt: ");
			int penz = Convert.ToInt32(Console.ReadLine());

			foreach(var cimlet in cimletek) {
				while(penz - cimlet.Key >= 0) {
					penz -= cimlet.Key;
					if (cimletek_ki.ContainsKey(cimlet.Key))
                    {
						cimletek_ki[cimlet.Key] += 1;
                    }
					else
                    {
						cimletek_ki[cimlet.Key] = 1;
					}
				}
			}

            Console.WriteLine();

			foreach(var anyad in cimletek_ki)
            {
                Console.WriteLine($"{anyad.Key}: {anyad.Value}");
            }
		}

        static void Main(string[] args)
        {
			Feladat11();
			//Feladat12();
			//Feladat13();
			//Feladat14();
			//Feladat15();
			//Feladat16();
			//Feladat17();
			//Feladat18();
			//Feladat19();
			//Feladat20();

            Console.ReadKey();
        }
    }
}
