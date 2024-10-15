using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class proba
    {
        string S = "0s";
        double D = 0;
        string F = "1f";
        string G = "2g";
        int Egesz;
        /* A konstruktor egy metódus, ami az osztály példányosításakor kerül meghívásra.
         * Static osztálynak nincs szüksége konstruktorra, de van neki. Ez egy auto-konstruktor
         * paraméterek nélkül. A C#-ban annyi kontruktort írunk, amennyire szükségünk van! */

        /* A konstruktor onnan ismerhetõ meg, hogy se nem void-os, és nincs visszatérési értéke sem,
         * valamint, a neve kötelezõen az osztály neve. */

        //public proba(string duma) {
        //    S = duma;
        //}

        public proba(double duma) {
            D = duma;
        }
        public proba(string duma, double szam) {
            S = duma;
            D = szam;
        }
        public proba(string duma, double szam = 0.12, string A = "alapértelmezett érték") {
            S = duma;
            F = A;
            D = szam;
        }

        /* Tulajdonság visszatérési és bemeneti típusa is ugyanaz. Arról lehet megismerni, 
         * hogy NEM paraméterezhetõ! (Nincs zárójel a neve után). Vagy a SET, vagy a GET parancs használata 
         * kötelezõ. A leggyakrabban mindkettõt használjuk.*/

        public string ElsoSzoveg
        {
            get { return S; }
        }

        public string MasodikSzoveg
        {
            get { return F; }
        }

        public double ElsoSzam
        {
            get { return D; }
        }

        public string HarmadikSzoveg {
            get { return G; }
        }

        public int EgeszSzam { get; set; }

        public int MasikSzam {
            set { Egesz = value; }
            get { int A = Egesz * 100; return A; }
        }

        public int Negyzet(){ return EgeszSzam * EgeszSzam; }
    }
}
