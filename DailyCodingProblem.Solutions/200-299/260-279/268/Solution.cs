using System;

namespace DailyCodingProblem.Solutions.Problem268
{
	public class Solution
	{
		public static bool IsPowerOf(int number, int poweredNumber)
		{
			return Math.Log(number, poweredNumber) % 1 == 0;
		}
	}
}
