using System.Linq;

namespace DailyCodingProblem.Solutions.Problem317
{
	public class Solution
	{
		public static int GetBitwiseAnd(int m, int n)
		{
			if (n < m)
			{
				return GetBitwiseAnd(n, m);
			}

			return Enumerable
				.Range(m, n - m + 1)
				.Aggregate((acc, x) => acc & x);
		}
	}
}

