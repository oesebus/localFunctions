using System;
using System.Collections.Generic;

namespace localFunctions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Read();

			IEnumerable<string> res = FormatStrings(new string[] { "Je", "suis", "Ismael" }, 0, 2);

			foreach (var item in res)
			{
				Console.Write(item);
			}
			Console.Read();
		}

		public static IEnumerable<string> FormatStrings(string[] strs, int debut, int fin)
		{
			if (fin <= debut)
				throw new ArgumentException($"{nameof(debut)}");

			if (fin > strs.Length - 1)
				throw new ArgumentException($"{nameof(fin)}");

			return getLocal(strs, debut, fin);

			IEnumerable<string> getLocal(string[] array, int start, int end)
			{
				for (int i = debut; i <= fin; i++)
				{
					var res = $"{strs[i]} ";
					yield return res;
				}
			}
		}
	}
}
