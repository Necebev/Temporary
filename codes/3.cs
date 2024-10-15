using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            haromszog h = new haromszog(2, 3, 4);
            Console.WriteLine(h.HaromszogTerulet);
            Console.ReadKey();
        }
    }
}
