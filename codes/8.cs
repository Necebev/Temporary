using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szia
{
    class Program
    {
        static void feladat1()
        {
            Console.WriteLine("- Feladat 1 -");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nKerület: " + 2 * radius * Math.PI + "cm" +
                                "\nTerület: " + radius * radius * Math.PI + "cm" +
                                "\nFelszín: " + 4 * radius * radius * Math.PI + "cm" +
                                "\nTérfogat: " + (4 * Math.PI * radius * radius * radius) / 3 + "cm");
        }
        static void feladat2()
        {
            Console.WriteLine("- Feladat 2 -");
            int[] szamok = {Convert.ToInt32(Console.ReadLine()),
                            Convert.ToInt32(Console.ReadLine()),
                            Convert.ToInt32(Console.ReadLine())};
            Array.Sort(szamok);
            Array.Reverse(szamok);
            Console.WriteLine("\nCsökkenő sorrend:");
            foreach (int i in szamok)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat3()
        {
            Console.WriteLine("- Feladat 3 -");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("A háromszög szerkeszthető");
            else
                Console.WriteLine("A háromszög nem szerkeszthető");
        }
        static void feladat4()
        {
            Console.WriteLine("- Feladat 4 -");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine("Pozitív");
            else
                Console.WriteLine("Negatív");
        }  
        static void feladat5()
        {
            Console.WriteLine("- Feladat 5 -");
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
        }
        static void feladat6()
        {
            Console.WriteLine("- Feladat 6 -");
            bool user = Convert.ToBoolean(Console.ReadLine());
            if (user)
                Console.WriteLine("IGAZ");
        }
        static void feladat7()
        {
            Console.WriteLine("- Feladat 7 -");
            int szam_1 = Convert.ToInt32(Console.ReadLine());
            int szam_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A két szám számtani közepe: " + (szam_1 + szam_2) / 2);
        }
        static void feladat8()
        {
            Console.WriteLine("- Feladat 8 -");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            double atlo_xy = Math.Sqrt(x * x + y * y);
            double atlo_xz = Math.Sqrt(x * x + z * z);
            double atlo_yz = Math.Sqrt(y * y + z * z);
            double testatlo = Math.Sqrt(x * x + y * y + z * z);
            double felszin = 2 * (x * y + x * z + y * z);
            double terfogat = x * y * z;
        }
        static void feladat9()
        {
            Console.WriteLine("- Feladat 9 -");
            int[,] teglatestek = new int[3, 3];
            for (int i = 0; i < teglatestek.GetLength(0); i++)
            {
                Console.WriteLine(i + 1 + ". téglatest 'a' oldala");
                teglatestek[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i + 1 + ". téglatest 'b' oldala");
                teglatestek[i, 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i + 1 + ". téglatest 'b' oldala");
                teglatestek[i, 2] = Convert.ToInt32(Console.ReadLine());
            }
            int legkisebb_index = -1;
            int legkisebb_oldalel_osszeg = int.MaxValue;
            for (int i = 0; i < teglatestek.GetLength(0); i++)
            {
                int osszeg = teglatestek[i, 0] + teglatestek[i, 1] + teglatestek[i, 2];
                if (osszeg < legkisebb_oldalel_osszeg)
                {
                    legkisebb_oldalel_osszeg = osszeg;
                    legkisebb_index = 1;
                }
                Console.WriteLine("A(z) " + (i + 1) + ". téglatest oldaléleinek összege: " + osszeg);
            }
            int a = teglatestek[legkisebb_index, 0];
            int b = teglatestek[legkisebb_index, 1];
            int c = teglatestek[legkisebb_index, 2];
            Console.WriteLine("A legkisebb oldalél összeggel rendelkező test oldalainak hossza: " + a + ", " + b + ", " + c);
            Console.WriteLine("A legkisebb oldalél összeggel rendelkező test felszíne: " + 2 * (a * b + a * c + b * c));
            Console.WriteLine("A legkisebb oldalél összeggel rendelkező test térfogata: " + a * b * c);
        }
        static void feladat10()
        {
            Console.WriteLine("- Feladat 10-");
            int deci = Convert.ToInt32(Console.ReadLine())


        }
        static void feladat11()
        {
            Console.WriteLine("- Feladat 11 -");
            int numero = Convert.ToInt32(Console.ReadLine());
            string STRING = Convert.ToString(numero);
            int osszeg = 0;


            for (int i = 0; i < STRING.Length; i++)
            {
                int n = Convert.ToInt32(STRING.Substring(i, 1));
                osszeg += n;
            }

            if (osszeg % 9 == 0)
            {
                Console.WriteLine("A szám osztható 9-cel");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 9-cel");
            }
        }
        static void feladat12()
        {
            Console.WriteLine("- Feladat 12 -");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                string String_number = Convert.ToString(number);
                Console.WriteLine("A szám " + String_number.Length + "jegyű");
            }
        }
        static void feladat13()
        {            Console.WriteLine("- Feladat 13 -");
            string month = Console.ReadLine();
            Dictionary<string, string> months = new Dictionary<string, string>()
            {
                { "December", "Tél" },
                { "Január", "Tél" },
                { "Február", "Tél" },
                { "Március", "Tavasz" },
                { "Április", "Tavasz" },
                { "Május", "Tavasz" },
                { "Június", "Nyár" },
                { "Július", "Nyár" },
                { "Augusztus", "Nyár" },
                { "Szeptember", "Ősz" },
                { "Október", "Ősz" },
                { "November", "Ősz" }
            };
            Console.WriteLine(months[month]);
        }
        
  
        static void feladat14()
        {
            Console.WriteLine("- Feladat 14 -");

        }
        static void feladat15()
        {
            Console.WriteLine("- Feladat 15 -");

        }
        static void feladat16()
        {
            Console.WriteLine("- Feladat 16 -");

        }
        static void feladat17()
        {
            Console.WriteLine("- Feladat 17 -");

        }
        static void feladat18()
        {
            Console.WriteLine("- Feladat 18 -");

        }
        static void feladat19()
        {
            Console.WriteLine("- Feladat 19 -");

        }
        static void feladat20()
        {
            Console.WriteLine("- Feladat 20 -");

        }
        static void Main(string[] args)
        {
            feladat10();
            feladat11();
            feladat12();
            feladat13();
            feladat14();
            feladat15();
            feladat16();
            feladat17();
            feladat18();
            feladat19();
            feladat20();
            Console.ReadKey();
        }
    }
}
