using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem81
{
	public class Solution
	{
		public static void Test()
		{
		}

		public static string[] GetPossibleLetters(string number, IDictionary<char, string[]> mappings)
		{
			return GetPossibleLetters(number, mappings, 0, new List<string>());
		}

		private static string[] GetPossibleLetters(string number, IDictionary<char, string[]> mappings, int index, IList<string> currentMappings)
		{
			if (index == number.Length)
			{
				return currentMappings
				  .OrderBy(m => m)
				  .ToArray();
			}

			var current = number[index];

			var digitMappings = mappings[current];

			if (currentMappings.Count == 0)
			{
				return GetPossibleLetters(number, mappings, index + 1, digitMappings);
			}

			var result = new List<string>();

			foreach (var mapping in digitMappings)
			{
				var newMap = currentMappings
				  .Select(m => m + mapping);

				result.AddRange(newMap);
			}

			return GetPossibleLetters(number, mappings, index + 1, result);
		}
	}
}
