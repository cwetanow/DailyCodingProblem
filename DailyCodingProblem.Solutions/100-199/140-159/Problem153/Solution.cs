using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem153
{
	public class Solution
	{
		// This solution assumes both words exist in the text
		public static int FindSmallestDistanceBetweenWords(string text, string word, string otherWord)
		{
			var splitText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			var smallestDistance = splitText.Count - 1;

			var firstWordIndexes = new List<int>();
			var otherWordIndexes = new List<int>();

			for (var i = 0; i < splitText.Count; i++)
			{
				if (splitText[i] == word)
				{
					firstWordIndexes.Add(i);
				}
				else if (splitText[i] == otherWord)
				{
					otherWordIndexes.Add(i);
				}
			}

			foreach (var firstWordIndex in firstWordIndexes)
			{
				foreach (var otherWordIndex in otherWordIndexes)
				{
					var distance = Math.Abs(firstWordIndex - otherWordIndex) - 1;

					if (smallestDistance > distance)
					{
						smallestDistance = distance;
					}
				}
			}

			return smallestDistance;
		}
	}
}
