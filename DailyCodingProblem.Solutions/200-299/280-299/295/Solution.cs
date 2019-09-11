using System;

namespace DailyCodingProblem.Solutions.Problem295
{
	public class Solution
	{
		public static int[] GetKthRow(int k)
		{
			var result = new int[k];
			result[0] = 1;

			for (var row = 1; row < k; row++)
			{
				result[row] = 1;
				for (var i = row - 1; i > 0; i--)
				{
					result[i] = result[i] + result[i - 1];
				}
			}

			return result;
		}
	}
}
