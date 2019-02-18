using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem77
{
	public class Solution
	{
		public static void Test()
		{
		}

		public static IEnumerable<(int start, int end)> MergeOverlappingIntervals(IEnumerable<(int start, int end)> input)
		{
			var result = new List<(int start, int end)>();

			foreach (var (start, end) in input)
			{
				if (!input.Any(el => el.start < start && el.end > end))
				{
					result.Add((start, end));
				}
			}

			return result;
		}
	}
}
