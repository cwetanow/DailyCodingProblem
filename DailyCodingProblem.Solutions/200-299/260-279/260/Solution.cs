using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem260
{
	public class Solution
	{
		public const char Greater = '+';
		public const char Lesser = '-';

		public static int[] ReconstructArray(char[] clues)
		{
			var n = clues.Length;

			var firstNumber = clues
				.Count(c => c == Lesser);

			var result = new int[n];

			result[0] = firstNumber;
			var greaterNumber = firstNumber + 1;
			var lesserNumber = 0;

			for (int i = 1; i < n; i++)
			{
				if (clues[i] == Greater)
				{
					result[i] = greaterNumber++;
				}
				else
				{
					result[i] = lesserNumber++;
				}
			}

			return result;
		}
	}
}
