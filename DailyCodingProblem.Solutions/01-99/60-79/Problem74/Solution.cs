namespace DailyCodingProblem.Solutions.Problem74
{
	public class Solution
	{
		public static void Test()
		{
		}

		public static int GetXOccurencesCount(int n, int x)
		{
			var count = 0;

			for (int i = 1; i <= n; i++)
			{
				if (x % i == 0 && x / i <= n)
				{
					count++;
				}
			}

			return count;
		}
	}
}
