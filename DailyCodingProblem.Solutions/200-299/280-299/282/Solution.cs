using System.Linq;

namespace DailyCodingProblem.Solutions.Problem282
{
	public class Solution
	{
		public static bool ContainsPythagoreanTriplet(int[] input)
		{
			return input
				.Any(a =>
					input.Any(b =>
						input.Any(c => (a * a + b * b) == (c * c))));
		}
	}
}
