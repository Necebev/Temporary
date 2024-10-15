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
        /* A konstruktor egy met�dus, ami az oszt�ly p�ld�nyos�t�sakor ker�l megh�v�sra.
         * Static oszt�lynak nincs sz�ks�ge konstruktorra, de van neki. Ez egy auto-konstruktor
         * param�terek n�lk�l. A C#-ban annyi kontruktort �runk, amennyire sz�ks�g�nk van! */

        /* A konstruktor onnan ismerhet� meg, hogy se nem void-os, �s nincs visszat�r�si �rt�ke sem,
         * valamint, a neve k�telez�en az oszt�ly neve. */

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
        public proba(string duma, double szam = 0.12, string A = "alap�rtelmezett �rt�k") {
            S = duma;
            F = A;
            D = szam;
        }

        /* Tulajdons�g visszat�r�si �s bemeneti t�pusa is ugyanaz. Arr�l lehet megismerni, 
         * hogy NEM param�terezhet�! (Nincs z�r�jel a neve ut�n). Vagy a SET, vagy a GET parancs haszn�lata 
         * k�telez�. A leggyakrabban mindkett�t haszn�ljuk.*/

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
