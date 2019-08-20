using System.Linq;

namespace DailyCodingProblem.Solutions.Problem273
{
	public class Solution
	{
		public static int? GetFixedPoint(int[] input)
		{
			var fixedPoints = input
				.Where((element, index) => element == index)
				.ToList();

			if (fixedPoints.Any())
			{
				return fixedPoints[0];
			}

			return null;
		}
	}
}
