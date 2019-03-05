using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem12
{
	public class Solution
	{
		public static void Test()
		{
			var n = int.Parse(Console.ReadLine());

			var x = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			var waysToClimb = Climb(0, n, x);

			Console.WriteLine(waysToClimb);
		}

		public static int Climb(int climbedStairs, int n, int[] x)
		{
			if (climbedStairs > n)
			{
				return 0;
			}

			if (climbedStairs == n)
			{
				return 1;
			}

			var result = 0;

			for (int i = 0; i < x.Length; i++)
			{
				var nextClimb = climbedStairs + x[i];

				result += Climb(nextClimb, n, x);
			}

			return result;
		}
	}
}
