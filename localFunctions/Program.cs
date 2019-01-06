using System;
using System.Collections.Generic;
using System.Collections;

namespace localFunctions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Read();

			IEnumerable<string> res = FormatStrings(new string[] { "Je", "suis", "Ismael" }, 3, 2);
			// Todo type some logic here ....
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

			return GetLocal(strs, debut, fin);


			IEnumerable<string> GetLocal(string[] array, int start, int end)
			{
				for (int i = start; i <= end; i++)
				{
					var res = $"{array[i]} ";
					yield return res;
				}
			}
		}

		public static bool IsWordPalindrome(string word)
		{

			// Validation logic here in outer function

			if (word is null)
				throw new ArgumentException($" Invalid argument => {nameof(word)}");

			if (word.Length < 2)
				return true;

			return IsPalindrome(0, word.Length - 1);

			// Local function stay focused on character by character comparison (Recursive call)

			bool IsPalindrome(int lo, int hi)
			{
				if (lo >= hi)
				{
					return true;
				}

				if (char.ToUpperInvariant(word[lo]) != char.ToUpperInvariant(word[hi]))
					return false;

				return IsPalindrome(lo + 1, hi + 1);
			}
		}
	}
}
