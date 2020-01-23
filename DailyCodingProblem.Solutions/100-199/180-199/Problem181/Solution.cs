using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem181
{
	public class Solution
	{
		public static IEnumerable<string> SplitToFewestPalindromes(string input)
		{
			var result = new List<string>();

			var currentString = input;

			var currentLength = currentString.Length;

			while (!string.IsNullOrEmpty(currentString))
			{
				var current = currentString.Substring(0, currentLength);

				if (IsPalindrome(current))
				{
					result.Add(current);
					currentString = currentString.Remove(0, currentLength);
					currentLength = currentString.Length;
				}
				else
				{
					currentLength--;
				}
			}

			return result;
		}

		private static bool IsPalindrome(string input)
		{
			for (int i = 0; i <= input.Length / 2; i++)
			{
				if (input[i] != input[input.Length - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}
