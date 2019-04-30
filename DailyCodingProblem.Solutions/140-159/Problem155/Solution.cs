using System.Linq;

namespace DailyCodingProblem.Solutions.Problem155
{
	public class Solution
	{
		public static int FindMajorityElement(int[] numbers)
		{
			return numbers
				.GroupBy(n => n)
				.OrderByDescending(g => g.Count())
				.First()
				.Key;
		}
	}
}
