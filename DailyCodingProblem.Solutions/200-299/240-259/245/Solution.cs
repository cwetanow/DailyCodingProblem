using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem245
{
	public class Solution
	{
		public static int GetMinimumNumberOfJumpsToEnd(List<int> input) =>
			GetMinimumNumberOfJumpsToEnd(input, 0, 0);

		private static int GetMinimumNumberOfJumpsToEnd(List<int> input, int currentIndex, int currentJumps)
		{
			if (currentIndex >= input.Count)
			{
				return int.MaxValue;
			}

			if (currentIndex == input.Count - 1)
			{
				return currentJumps;
			}

			var minJumps = Enumerable.Range(1, input[currentIndex])
				.Select(jump => GetMinimumNumberOfJumpsToEnd(input, currentIndex + jump, currentJumps + 1))
				.ToList();

			if (!minJumps.Any())
			{
				return int.MaxValue;
			}
			return minJumps.Min();
		}
	}
}
