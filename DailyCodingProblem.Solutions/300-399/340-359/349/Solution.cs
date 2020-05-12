using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem349
{
	public static class Solution
	{
		private static readonly IEnumerable<Mapping> Mappings = new List<Mapping>
		{
			new Mapping(1,"b", "f", "p", "v"),
			new Mapping(2,"c", "g", "j", "k", "q", "s", "x", "z"),
			new Mapping(3,"d", "t"),
			new Mapping(4,"l"),
			new Mapping(5,"m", "n"),
			new Mapping(6,"r")
		};

		private static IEnumerable<string> LettersToRemove = new List<string> { "a", "e", "i", "o", "u", "y", "h", "w" };

		public static string Soundex(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return null;
			}

			var firstLetter = input.First();

			return input
					.RemoveConsecutiveConsonantsWithSameSound()
					.RemoveFirstLetter()
					.RemoveVowels()
					.ReplaceConsonants()
					.AppendNumbers()
					.AppendFirstLetter(firstLetter);
		}

		private static string RemoveFirstLetter(this string input) => input.Substring(1);

		private static string AppendFirstLetter(this string input, char firstLetter) => $"{firstLetter}{input}";

		private static string AppendNumbers(this string input)
		{
			var builder = new StringBuilder(input);

			while (builder.Length < 3)
			{
				builder.Append(0);
			}

			return builder.ToString();
		}

		private static string ReplaceConsonants(this string input)
		{
			var builder = new StringBuilder();

			foreach (var letter in input)
			{
				var digit = Mappings.Single(m => m.Letters.Contains(letter.ToString())).Digit;
				builder.Append(digit);
			}

			return builder.ToString();
		}

		private static string RemoveVowels(this string input)
		{
			var builder = new StringBuilder();

			foreach (var letter in input)
			{
				if (!LettersToRemove.Contains(letter.ToString()))
				{
					builder.Append(letter);
				}
			}

			return builder.ToString();
		}

		private static string RemoveConsecutiveConsonantsWithSameSound(this string input)
		{
			var builder = new StringBuilder(input.First().ToString());

			for (var index = 1; index < input.Length; index++)
			{
				if (!Mappings.Any(m =>
					m.Letters.Contains(input[index].ToString()) &&
					m.Letters.Contains(input[index - 1].ToString())))
				{
					builder.Append(input[index]);
				}
			}

			return builder.ToString();
		}

		private class Mapping
		{
			public Mapping(int digit, params string[] letters)
			{
				Digit = digit;
				Letters = letters;
			}

			public ICollection<string> Letters { get; }
			public int Digit { get; }
		}
	}
}
