using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem138
{
	public class Solution
	{
		private static IEnumerable<int> denominations = new List<int> { 25, 10, 5, 1 };

		public static IEnumerable<int> FindMinimumNumberOfCoinsToSumN(int n)
		{
			var result = new List<int>();

			var remaining = n;

			while (remaining > 0)
			{
				var next = denominations
					.Where(d => d <= remaining)
					.Max();

				result.Add(next);
				remaining -= next;
			}

			return result;
		}
	}
}
