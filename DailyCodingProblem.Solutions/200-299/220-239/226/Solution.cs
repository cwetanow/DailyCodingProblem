using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem226
{
	public class Solution
	{
		public static IEnumerable<char> GetOrderedLetters(IList<string> sortedWords)
		{
			var orderedLetters = new List<char>();

			if (!sortedWords.Any())
			{
				return orderedLetters;
			}

			if (sortedWords.Count == 1)
			{
				return sortedWords.First();
			}

			var pairs = new List<(char before, char after)>();

			for (var index = 1; index < sortedWords.Count; index++)
			{
				var previous = sortedWords[index - 1];
				var current = sortedWords[index];

				var length = Math.Min(previous.Length, current.Length);

				for (int i = 0; i < length; i++)
				{
					var previousLetter = previous[i];
					var currentLetter = current[i];

					if (previousLetter != currentLetter)
					{
						pairs.Add((previousLetter, currentLetter));
						break;
					}
				}
			}

			foreach (var (before, after) in pairs)
			{
				var beforeIndex = orderedLetters.IndexOf(before);
				var afterIndex = orderedLetters.IndexOf(after);

				if (beforeIndex < afterIndex && beforeIndex >= 0 && afterIndex >= 0)
				{
					continue;
				}

				if (beforeIndex < 0 && afterIndex < 0)
				{
					orderedLetters.Add(before);
					orderedLetters.Add(after);
					continue;
				}

				if (beforeIndex < 0)
				{
					orderedLetters.Insert(afterIndex, before);
				}
				else if (afterIndex < 0)
				{
					orderedLetters.Insert(beforeIndex + 1, after);
				}
				else
				{
					orderedLetters.RemoveAt(afterIndex);
					orderedLetters.Insert(beforeIndex, after);
				}
			}

			return orderedLetters;
		}
	}
}
