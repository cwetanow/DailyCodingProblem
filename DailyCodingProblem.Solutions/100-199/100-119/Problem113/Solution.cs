using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem113
{
	public class Solution
	{
		public static string ReverseWords(string input)
		{
			return string.Join(' ', input
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Reverse()
				.ToArray());
		}
	}
}
