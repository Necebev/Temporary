using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazMuveletekConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("A halmaz elemei: ");
            Console.WriteLine("");
            int[] A = halmazEloallitas();
            Console.WriteLine("");
            Console.WriteLine("B halmaz elemei: ");
            Console.WriteLine("");
            int[] B= halmazEloallitas();
            Console.WriteLine("");
            Console.WriteLine("Részhalmaz: "+ ReszhalmazVizsgalat(A, B));
            Console.WriteLine("");
            Console.WriteLine("Valódi részhalmaz: "+ ValodiReszhalmaz(A, B));
            Console.WriteLine("");
            Console.WriteLine("Metszet: ");
            foreach (int i in Metszet(A, B)) Console.Write(i + " ");
            Console.WriteLine("");
            Console.WriteLine("Különbség: ");
            foreach (int i in Kulonbseg(A, B)) Console.Write(i + " ");
            Console.ReadKey();
        }

        static int[] halmazEloallitas()
        {
            List<int> halmaz = new List<int>();
            Console.WriteLine("Elemszám");
            int qty = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qty; i++)
            {
                halmaz.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return halmaz.ToArray();
        }
        
        static bool ReszhalmazVizsgalat(int[] A, int[] B)
        {
            bool bennevan;
            bool reszhalmaz = true;
            int i = 0;
            while (i < A.Length && reszhalmaz)
            {
                bennevan = false;
                for (int j = 0; j < B.Length-1; j++)
                {
                    if (A[i] == B[j]) bennevan = true;
                }
                reszhalmaz = bennevan;
                i++;
            }
            return reszhalmaz;
        }

        static bool ValodiReszhalmaz(int[] A, int[] B)
        {
            return (ReszhalmazVizsgalat(A, B) && A.Length == B.Length);
                        
        }
 
        static int[] HalmazokUnioja(int[]A, int[]B)
        {
            bool bennevan;
            List<int> Unio = new List<int>();
            int n = A.Length;
            for (int i = 0; i< A.Length; i++)
            {
                Unio.Add(A[i]);
            }

            for (int i = 0; i < B.Length; i++)
            {
                bennevan = false;
                for (int j = 0; j < A.Length; j++)
                {
                    if (Unio[j] == B[i]) bennevan = true;
                }

                if (bennevan == false)
                {
                    Unio.Add(B[i]);
                }
            }
            return Unio.ToArray();
        }   
        
        static int[] Metszet(int[] A, int[] B)
        {
            List<int> metszet = new List<int>();
            bool bennevan;
            for (int i = 0; i < A.Length; i++)
            {
                bennevan = false;
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        bennevan = true;
                    }
                }
                if (bennevan)
                {
                    metszet.Add(A[i]);
                }
            }
            return metszet.ToArray();
        }

        static int[] Kulonbseg(int[] A, int[] B)
        {
            List<int> kulonbseg = new List<int>();
            bool bennevan;
            for (int i = 0; i < A.Length; i++)
            {
                bennevan = false;
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        bennevan = true;
                    }
                }
                if (!bennevan)
                {
                    kulonbseg.Add(A[i]);
                }
            }
            return kulonbseg.ToArray();
        }
    }
}






