using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unio
{
    internal class Program
    {
        static Random R = new Random();
        static void Main(string[] args)
        {
            int[] h1 = { 1, 2, 3, 4 };
            int[] h2 = { 5, 6, 7, 8 };
            int[] h3 = Unio(h1, h2);
            foreach (int i in h3)
            {
                Console.WriteLine(i);
            }

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
            for (int i = 0; i <= N * 3; i++)
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

        static int[] Unio(int[] A, int[] B)
        {
            List<int> unio = new List<int>();
            for (int i = 0;i < A.Length;i++)
            {
                if (!unio.Contains(A[i]))
                {
                    unio.Add(A[i]);
                }
                for (int j = 0;j < B.Length;j++)
                {
                    if (A[i] != B[j] && !unio.Contains(B[j]))
                    {
                        unio.Add(B[j]);
                    }
                }
            }
            return (unio.ToArray());
        }
    }
}
