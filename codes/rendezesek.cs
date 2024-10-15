using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szia
{
	internal class rendezesek
	{
		void Csere(ref int a, ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}
		public void CseresRendezes(int[] t)
		{
			for (int i = 0; i < t.Length - 1; i++)
			{
				for (int j = i + 1; j < t.Length; j++)
				{
					if (t[i] > t[j])
					{
						Csere(ref t[i], ref t[j]);
					}
				}
			}
		}
		public void BuborekRendezes(int[] t)
		{
			for (int i = t.Length - 1; i > 0; i--)
			{
				for (int j = 0; j < i - 1; j++)
				{
					if (t[j] > t[j + 1]) Csere(ref t[j], ref t[j + 1]);
				}
			}
		}
		public void MinMaxRendezes(int[] t)
		{
			int min = 0;
			for (int i = 0; i < t.Length - 1; i++)
			{
				min = i;
				for (int j = i + 1; j < t.Length; j++)
				{
					if (t[min] > t[j])
						min = j;
				}
				Csere(ref t[i], ref t[min]);
			}
		}
	}
}
