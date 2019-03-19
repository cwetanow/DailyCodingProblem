using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem118
{
	public class Solution
	{
		public static int[] GetSquaredSortedElements(int[] input)
		{
			return input
				.Select(el => (int)Math.Pow(el, 2))
				.OrderBy(el => el)
				.ToArray();
		}
	}
}
