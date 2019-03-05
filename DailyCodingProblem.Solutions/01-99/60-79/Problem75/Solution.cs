using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem75
{
	public class Solution
	{
		static void Test()
		{
			Console.WriteLine("Hello World!");
		}

		public static int[] GetLongestIncreasingSubsequence(int[] input)
		{
			return GetLongestIncreasingSubsequence(input, 0, new List<int>(), -1);
		}

		private static int[] GetLongestIncreasingSubsequence(int[] input, int currentIndex, List<int> currentSequence, int lastIndexInCurrentSequence)
		{
			if (currentIndex == input.Length)
			{
				return currentSequence.ToArray();
			}

			if (lastIndexInCurrentSequence == -1)
			{
				var copy = currentSequence.Select(x => x).ToList();

				copy.Add(input[currentIndex]);

				var withCurrentElement = GetLongestIncreasingSubsequence(input, currentIndex + 1, copy, lastIndexInCurrentSequence + 1);

				var withoutCurrentElement = GetLongestIncreasingSubsequence(input, currentIndex + 1, currentSequence, lastIndexInCurrentSequence);

				return withCurrentElement.Length > withoutCurrentElement.Length ?
				  withCurrentElement : withoutCurrentElement;
			}
			else
			{
				if (currentSequence[lastIndexInCurrentSequence] < input[currentIndex])
				{
					var copy = currentSequence.Select(x => x).ToList();

					copy.Add(input[currentIndex]);

					var withCurrentElement = GetLongestIncreasingSubsequence(input, currentIndex + 1, copy, lastIndexInCurrentSequence + 1);

					var withoutCurrentElement = GetLongestIncreasingSubsequence(input, currentIndex + 1, currentSequence, lastIndexInCurrentSequence);

					return withCurrentElement.Length > withoutCurrentElement.Length ?
					  withCurrentElement : withoutCurrentElement;
				}

				return GetLongestIncreasingSubsequence(input, currentIndex + 1, currentSequence, lastIndexInCurrentSequence); ;
			}
		}
	}
}
