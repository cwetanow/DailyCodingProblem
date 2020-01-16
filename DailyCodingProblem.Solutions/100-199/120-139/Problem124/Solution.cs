using System;

namespace DailyCodingProblem.Solutions.Problem124
{
	public class Solution
	{
		// Because the coins are fair, we assume 1/2 probability of tails. So after first round, 1/2 coins are left, after second is 1/2*1/2, etc...
		public static int GetNumberOfRoundsUntillOneCoinLeft(int n) => (int)Math.Floor(Math.Log(n, 2)) + 1; // 2/2=1, log returns to 2
	}
}
