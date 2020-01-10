namespace DailyCodingProblem.Solutions.Problem332
{
	public class Solution
	{
		public static int GetNumberOfPairs(int m, int n)
		{
			var result = 0;

			for (var i = 1; i < m; i++)
			{
				var xor = i ^ (m - i);
				if ( xor== n)
				{
					result++;
				}
			}

			return result;
		}
	}
}
