using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proba P = new proba("Hahó!");
            //Console.WriteLine($"{P.ElsoSzoveg} {P.MasodikSzoveg} {P.ElsoSzam}");
            //Console.ReadKey();

            //proba P2 = new proba(12.23);
            //Console.WriteLine($"{P2.ElsoSzoveg} {P2.MasodikSzoveg} {P2.ElsoSzam}");
            //Console.ReadKey();

            //proba P3 = new proba("akármi", 3.14);
            //Console.WriteLine($"{P3.ElsoSzoveg} {P3.MasodikSzoveg} {P3.ElsoSzam}");
            //Console.ReadKey();

            //proba P4 = new proba("a", A: "bbb");
            //Console.WriteLine($"{P4.ElsoSzoveg} {P4.MasodikSzoveg} {P4.ElsoSzam}");
            //Console.ReadKey();

            proba p = new proba("kkk");
            //p.EgeszSzam = 3;
            //Console.WriteLine(p.Negyzet());
            p.MasikSzam = 30;
            Console.WriteLine(p.MasikSzam);

            Console.ReadKey();
        }
    }
}
