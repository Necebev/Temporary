using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class egyenlet
    {
        double E;
        string M1;
        string M2;
        public egyenlet(double a, double b)
        {
            // a*x + b
            E = (-b) / a;
        }

        public egyenlet(double a, double b, double c)
        {
            double Diszkr = b * b - 4 * a * c;
            if (Diszkr < 0)
            {
                M1 = "nincs megoldás"; // nincs megoldas
            }else if (Diszkr == 0)
            {
                M1 = ((-b) / (2 * a)).ToString(); // 1 megoldas
                M2 = "nincs";
            }else
            {
                M1 = (((-b) + Math.Sqrt(Diszkr)) / 2 * a).ToString(); // 2 megoldas
                M2 = (((-b) - Math.Sqrt(Diszkr)) / 2 * a).ToString();
            }
        }

        public double Elso
        {
            get { return E; }
        }

        public string[] Masod
        {
            get { return new string[]{ M1, M2 }; }
            set { }
        }
    }
}
