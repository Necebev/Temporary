using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    internal class haromszog
    {
        double A;
        double B;
        double C;

        public haromszog(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }

        public double terulet()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                double S = (A + B + C) / 2;
                return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
            } 
            else
            {
                return -1;
            }
        }

        public double HaromszogTerulet
        {
            get { return terulet();}
        }
    }
}
