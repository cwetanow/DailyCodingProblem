using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem321
{
	public class Solution
	{
		public static int FindSmallestNumberOfStepsToReachOne(int n) => FindSmallestNumberOfStepsToReachOne(n, 0);

		private static int FindSmallestNumberOfStepsToReachOne(int n, int currentSteps)
		{
			if (n < 0)
			{
				return int.MaxValue;
			}

			if (n == 1)
			{
				return currentSteps;
			}

			var items = Enumerable.Range(1, n / 2)
				.Where(number => n % number == 0)
				.Select(number => Math.Max(n / number, number))
				.Distinct()
				.ToList();

			items.Remove(n);
			items.Add(n - 1);

			return items
				.Select(number => FindSmallestNumberOfStepsToReachOne(number, currentSteps + 1))
				.Min();
		}
	}
}
