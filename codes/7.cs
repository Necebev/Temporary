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