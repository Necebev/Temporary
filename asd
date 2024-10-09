using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skchol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // érték
            bool logikai = true; //c# változótípus
            Boolean logikai2 = true; //.net változótípus
            
            char karakter = 'c';
            Char karakter2 = '\t';
            
            string szoveg = "szia";
            String szoveg2 = "asd";

            sbyte bit8szam = -128; //+127
            SByte bit8szam2 = 127;

            short bit16szam = -32768; 
            Int16 bit16szam2 = 32767;

            int bit32szam = -2147483648;
            Int32 bit32szam2 = 2147483647;

            long bit64szam = -9223372036854775808;
            Int64 bit64szam2 = 9223372036854775807;

            byte ubit8 = byte.MinValue;
            Byte ubit16 = byte.MaxValue;

            /* 
            uint = uint32;
            ushort = uint16;
            ulong = uint64;
            */

            float tort_kicsi = float.MaxValue;
            Single tort_kicsi2 = float.MinValue;

            double tort_nagy = double.MaxValue;
            Double tort_nagy2 = double.MinValue;

            decimal tort_megkotesekkel = decimal.MaxValue;
            Decimal tort_megkotesekkel2 = decimal.MinValue; // 16 bites, 28 + 1 jegyű szám

            object ostipus; // minden érték és refernciatípus őse, belőle származtatható minden, ezért helyettesíthet is mindent. De ez nem azt jelenti, hogy "int" helyett "object"-et használhatsz. Mielőtt bármilyen műveletet végzünk vele , konkretizálni kell az object típust.
                            // Az "object"-et gyakran keverik a "dínamic" típussal. Ez azért van, mert a dynamic legtöbbször úgy működik, mint egy típus object. Valójában statikus típus, ami viszont megkerüli a statikus típuselleneőrzést.
                            // A jó és egyben rossz is a "dynamic" típusban, hogy egyszerre támogatja az összes műveletet.      

            // referenia (mutató) típusok:
            int[] t = new int[8];
            foreach ( int i in t )
            {
                Console.WriteLine(i + ';');
            }
            int[] T; // nincs példány | ez jó, de így nem használható, példányosítani kell előbb. ez csak egy deklaráció.
            T = new int[]{3,4,5,6,7};
            int[] z = { 0, 1, 23, 34 };
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using heloka;
using heloka.heloszia;

namespace ip11_elso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nah
            int szam1, szam2, oszto; // két szám változó deklarálása, egész típus
            szam1 = Convert.ToInt32(Console.ReadLine());
            szam2 = Convert.ToInt32(Console.ReadLine());
            int k_oszto = szam1 < szam2 ? szam2 : szam1 /2;
            for (oszto = k_oszto; oszto >= 1; oszto--)
            {
                if (szam1 % oszto == 0 && szam2 % oszto == 0)
                {
                    break;
                }
                if (szam1 == szam2)
                {
                    Console.WriteLine(szam1);
                }
                else if (oszto == 0)
                {
                    Console.WriteLine("Relatív prímek");
                }
                else
                {
                    Console.WriteLine(oszto);
                }
                Console.ReadKey();
            }
        }
    }
    namespace szia
    {
        struct helo
        {
            class osztaly
            {
                struct sz
                {
                    private int valtozo;
                    public sz(int szam)
                    {
                        valtozo = szam;
                    }
                }
            }
        }
    }
}
namespace heloka
{
    namespace heloszia
    {

    }
}

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ip_valtozok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Szám: egész és tört, előjeles egész és előjel nélküli, ilyenkor a fosztóképző az "U"
			 * Két elnevezés az egyik a keretrendszeré (dotNET = .NET) másik a C#-é. Mindkettő nyugodtan használható */
			int a = 1;
			a *= 2;
            Console.WriteLine(a + " " + a.GetType());
			Int32 b = 2;
            Console.WriteLine(b + " " + b.GetType());			
			ulong c = ulong.MaxValue;
			Console.WriteLine(c + " " + c.GetType());
			string szoveg = "k";
			char karakter = Convert.ToChar(szoveg);
            Console.WriteLine(karakter);
			bool logikai;
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace osszetett
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region deklarálás után példányosítás
			int[] tomb; /* ez csak deklaráció, ilyenkor ez a tömb már létezik de mivel nincs példányosítva, nem használható */
			tomb = new int[10]; /* így már van egy 10 elemű, kizárólag 32 bites egész szűmok tárolására alkalmas tömb */
			int index = 0;
			while (index < tomb.Length)
			{
				Console.WriteLine(tomb[index]);
				index++;
			}
			#endregion
			#region deklarálás és példányosítás
			double[] tortek = new double[10];
			int indx = 0;
			do
			{
				Console.WriteLine(tortek[indx]);
				indx++;

			}while (indx < tortek.Length);
			#endregion
			#region elemekkel példányosítás
			// elemekkel példányosítás
			string[] duma = { "a", "b", "c", "d", "e", "f" };
			foreach (var item in duma)
			{
                Console.WriteLine(item);
			}
			#endregion
			//listák
			List<bool> LogLista = new List<bool>();
			LogLista.Add(true); LogLista.Add(false);
			for (int i = 0; i < LogLista.Count; i++) // listánál count, tömbnél length
			{
				Console.WriteLine(LogLista[i]);
			}
			Console.ReadKey();
		}
	}
}

névtér - osztály v. struktúra
osztály v. str. - mező
		- metódus
			- kontstruktor
			- destruktor
			- eseménykezelő
		- tulajdonság
		- delegált
Egy névtérben lehet másik névtér, vagy osztály, vagy struktúra
Egy osztályban lehet másik osztály, vavgy struktúra, meg a többi, amit felírtunk.
Egy struktúrában mniden lehet, ami egy osztályban kivéve destruktor.

USING directíva névterekt vesz használatba, pl.:
using mysql.data.myqslclient;
fontos! csak az utolsó névteret látja!! Tehát ha a Data névtér is kell akkor:
using mysql.data;

A using directívát nem kötelező használni! (csak kényelmes) ha egy msql parancsváltozót akarok létrehozni, akkor az előző using beállítás esetén így néz ki:
MySqlCommand parancs = new MySqlCommand(...);
ha nincs használatba véve (nincs usingolva) akkor;
MySql.Data.MySqlCommand parancs = new MySql.Data.MySqlCommand(...);

Névtér: Mindent tartalmazhat. Gyűjtőegység, mint Python-ban az importált modulok

Osztály - Class: eredetileg csak adatszerkezet leírására használták, gyakorlatilag a következő történt: az ős programnyelvek némelyike ismerte a rekord szerkezetet. A rekordban azonos név alatt, különböző Típusú változókat tartottak. pl: 'tarolo'- ez volt a rekord neve, azon belül: tarolo.cim - ez egy változó volt.

A struktúra váltotta ki az összetettebb rekordokat. A struktúrának az OOP nyelvekben mindene van, ami egy osztálynak is (kivetél destruktor, az nem minden esetben van). Van egy nagyy hibája, hogy a rekord típustól átörökölte azt, hogy a struktúra mindegy egyede Érték típúsú.

Amikor a struktúrák túl nagyra nőttek (felzabálták a RAM-ot) akkor hozták létre az osztályt, ami mindent tud, amit a struktúra, csakhogy referencia típusú, tehát könnyedén kipucolható a RAM-ból.

Osztályban névtér nem lehet, minden más igen!
Mező - globális, az osztályon belül többnyire mindenhol látható változó, ami lehet érték, vagy referencia típusú.
Tulajdonság - nem paraméterezhető, de input-outputra alkalmas rész. Mivel jól rejthető, ezért az adatok kifele közlésénél elsősorban ezt használjuk

METÓDUSOK:
Konstruktorok - ugyanaz a szerepe, mint Python-ban:
létrehozza az osztálypéldányt. paraméterezhető, a paramétereit általában mezőkben tároljuk.
Függvények - olyan metódusok, melyeknek van visszatérési értéke
void-os függvények (eljárások) - olyan metúdusok, melyeknek nincs visszatérési értéke.
eseménykezelők - olyan metúdusok, melyeknek a utását valamilyen interakció váltja ki. vannak kötelező paramétereik: 
	1. ki (mi) hívta meg az eseménykezelőt, a hívónak milyen tulajdonságai vannak.
	
delegáltak - olyan metódusok, melyeknek paraméterei is metódusok.
destruktor - az a metódus, mely törli a RAM-ból az osztálypéldányt. A c#-nak van beépített destruktora - garbage collector -, ezért az esetek 99%-ában nem kell destruktort írnunk! 🤫🧏‍♂️

