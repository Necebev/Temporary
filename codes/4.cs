using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace halmazok
{
    internal class Program
    {
        static Random R = new Random();
        static void Main(string[] args)
        {
            var H = HalmazEloallitas(ElemSzam());
            Array.Sort(H);
            foreach (var x in H)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();
            var H2 = HalmazEloallitas(ElemSzam());
            Array.Sort(H2);
            foreach (var x in H2)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine(ReszhalmazVizsg(H, H2));
            Console.WriteLine(ValodiReszHalm(H,H2));

            Console.ReadKey();
        }

        static int ElemSzam()
        {
            int sz = 0;
            do
            {
                Console.WriteLine("Kérem az elemszámot, pozitív egész legyen!");
            } while (!int.TryParse(Console.ReadLine(), out sz) || sz < 1);
            return sz;
        }

        static int[] HalmazEloallitas(int N)
        {
            List<int> OsszesSzam = new List<int>();
            for (int i = 0; i <= N*3; i++)
            {
                OsszesSzam.Add(i);
            }
            int[] T = new int[N];
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                index = R.Next(OsszesSzam.Count);
                T[i] = OsszesSzam[index];
                OsszesSzam.RemoveAt(index);
            }
            return T;
            
        }

        static bool ValodiReszHalm(int[] A, int[] B)
        {
            return (ReszhalmazVizsg(A, B) && A.Length == B.Length);
        }

        static bool ReszhalmazVizsg(int[] A, int[] B)
        {
            bool reszhalmaz = true;
            bool bennevan;
            int i = 0;
            while (i < A.Length  || reszhalmaz)
            {
                bennevan = false;
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        bennevan = true;
                    }
                }
                reszhalmaz = bennevan;
                i++;
            }
            return reszhalmaz;
        }
    }
}
