using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ip_valtozok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Szám: egész és tört, előjeles egész és előjel nélküli, ilyenkor a fosztóképző az "U"
			 * Két elnevezés az egyik a keretrendszeré (dotNET = .NET) másik a C#-é. Mindkettő nyugodtan használható */
			int a = 1;
			a *= 2;
            Console.WriteLine(a + " " + a.GetType());
			Int32 b = 2;
            Console.WriteLine(b + " " + b.GetType());			
			ulong c = ulong.MaxValue;
			Console.WriteLine(c + " " + c.GetType());
			string szoveg = "k";
			char karakter = Convert.ToChar(szoveg);
            Console.WriteLine(karakter);
			bool logikai;
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}
