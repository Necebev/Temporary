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
