using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem161
{
	public class Solution
	{
		public static string GetReversedBitRepresentation(uint number)
		{
			return string.Join(string.Empty, Convert.ToString(number, 2)
				.Reverse());
		}
	}
}
