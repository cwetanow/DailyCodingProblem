using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem22
{
	public class Solution
	{
		public static void Test()
		{
			var dictionary = Console.ReadLine()
				.Split(' ')
				.ToHashSet();

			var input = Console.ReadLine();

			var words = GetWordsFromDictionary(input, dictionary);

			Console.WriteLine(string.Join(' ', words));
		}

		public static IEnumerable<string> GetWordsFromDictionary(string input, HashSet<string> dictionary)
		{
			var builder = new StringBuilder();

			var result = new List<string>();

			for (var i = 0; i < input.Length; i++)
			{
				var currentWord = builder.Append(input[i]);
				var word = builder.ToString();

				if (dictionary.Contains(word))
				{
					result.Add(word);

					builder = builder.Clear();
				}
			}

			return result;
		}
	}
}
