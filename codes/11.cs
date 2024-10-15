using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace osszetett
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region deklarálás után példányosítás
			int[] tomb; /* ez csak deklaráció, ilyenkor ez a tömb már létezik de mivel nincs példányosítva, nem használható */
			tomb = new int[10]; /* így már van egy 10 elemű, kizárólag 32 bites egész szűmok tárolására alkalmas tömb */
			int index = 0;
			while (index < tomb.Length)
			{
				Console.WriteLine(tomb[index]);
				index++;
			}
			#endregion
			#region deklarálás és példányosítás
			double[] tortek = new double[10];
			int indx = 0;
			do
			{
				Console.WriteLine(tortek[indx]);
				indx++;

			}while (indx < tortek.Length);
			#endregion
			#region elemekkel példányosítás
			// elemekkel példányosítás
			string[] duma = { "a", "b", "c", "d", "e", "f" };
			foreach (var item in duma)
			{
                Console.WriteLine(item);
			}
			#endregion
			//listák
			List<bool> LogLista = new List<bool>();
			LogLista.Add(true); LogLista.Add(false);
			for (int i = 0; i < LogLista.Count; i++) // listánál count, tömbnél length
			{
				Console.WriteLine(LogLista[i]);
			}
			Console.ReadKey();
		}
	}
}
